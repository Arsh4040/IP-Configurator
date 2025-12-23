using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Net;
using System.Net.Sockets;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IP_Configurator
{
    public partial class IPconfigurator : Form
    {
        // Variable decleration
        private bool isDHCP = false;
        private bool isStatic = true;
        private List<string> ipHistory = new List<string>();

        // Initializes the form and populates network adapter list
        public IPconfigurator()
        {
            InitializeComponent();
            PopulateNetworkAdapters();
            LoadHistory();
            PopulateIPaddressHistory();

            // Set default IP address and subnet mask
            IPaddress.Text = "192.168.0.1";
            SubnetMask.Text = "255.255.255.0";

            // Set deafult button visibilities
            Static_Button.Visible = false;
            DHCP_Button.Visible = true;
            Greyed_Update_Button.Visible = false;
            DHCP_Text.ForeColor = Color.LightSlateGray;

            // Load last used IP address if available
            if (ipHistory.Any())
            {IPaddress.Text = ipHistory[0];}

            // Select IP Address field by default
            this.ActiveControl = IPaddress;

            NetworkAdapters.DropDownStyle = ComboBoxStyle.DropDownList;

            IPaddress.TextChanged += IP_Updated;
            SubnetMask.TextChanged += IP_Updated;

        }


        // Fetches network adapter names using PowerShell and adds them to the ComboBox
        private void PopulateNetworkAdapters()
        {
            NetworkAdapters.Items.Clear();

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = "Get-NetAdapter | Select-Object -ExpandProperty Name",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                using (StreamReader reader = process.StandardOutput)
                {
                    string output = reader.ReadToEnd();
                    string[] adapterNames = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string name in adapterNames)
                    {
                        NetworkAdapters.Items.Add(name.Trim());
                    }

                    // Select the first adapter by default
                    if (NetworkAdapters.Items.Count > 0)
                        NetworkAdapters.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get network adapters: " + ex.Message);
            }
        }


        // Converts a subnet mask (e.g., 255.255.255.0) to prefix length (e.g., 24).
        private int SubnetMaskToPrefixLength(string subnetMask)
        {
            try
            {
                // Split mask into bytes and parse to integers
                var bytes = subnetMask.Split('.').Select(byte.Parse).ToArray();
                int prefixLength = 0;

                // Count the number of 1's in binary representation of each byte
                foreach (byte b in bytes)
                {
                    string bits = Convert.ToString(b, 2);
                    prefixLength += bits.Count(c => c == '1');
                }

                return prefixLength;
            }
            catch
            {
                // Return -1 if conversion fails (invalid input)
                return -1;
            }
        }


        // Retrieve IP address history from settings
        private void LoadHistory()
        {
            var saved = Properties.Settings.Default.IpHistory;
            ipHistory = saved?.Cast<string>().ToList() ?? new List<string>();
        }


        // Populate IP address history combobox
        private void PopulateIPaddressHistory()
        {
            IPaddress.Items.Clear();
            IPaddress.Items.AddRange(ipHistory.ToArray());
        }


        // Static button click
        private void Static_Button_Click(object sender, EventArgs e)
        {
            isDHCP = false;
            isStatic = true;

            IPaddress.Enabled = true;
            SubnetMask.Enabled = true;

            Static_Button.Visible = false;
            DHCP_Button.Visible = true;
            Greyed_Update_Button.Visible = !IsValidIpFormat(IPaddress.Text) && !IsValidIpFormat(SubnetMask.Text);
            DHCP_Text.ForeColor = Color.LightSlateGray;
            Static_Text.ForeColor = Color.White;
            IP_Address_Text.ForeColor = Color.White;
            Subnet_Mask_Text.ForeColor = Color.White;

            this.ActiveControl = IPaddress;
            IPaddress.SelectionStart = IPaddress.Text.Length;
            IPaddress.SelectionLength = 0;

        }


        // DHCP button click
        private void DHCP_Button_Click(object sender, EventArgs e)
        {
            isDHCP = true;
            isStatic = false;

            IPaddress.Enabled = false;
            SubnetMask.Enabled = false;

            Static_Button.Visible = true;
            DHCP_Button.Visible = false;
            Greyed_Update_Button.Visible = false;
            DHCP_Text.ForeColor = Color.White;
            Static_Text.ForeColor = Color.LightSlateGray;
            IP_Address_Text.ForeColor = Color.LightSlateGray;
            Subnet_Mask_Text.ForeColor = Color.LightSlateGray;
        }


        // Cancel button click
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        // IP Address or Subnet Mask changed
        private void IP_Updated(object sender, EventArgs e)
        {
            bool invalidInput = !IsValidIpFormat(IPaddress.Text) || !IsValidIpFormat(SubnetMask.Text);
            Greyed_Update_Button.Visible = invalidInput;
        }


        // Check if the IP Address or Subnet Mask has valid format
        private bool IsValidIpFormat(string ipString)
        {
            var parts = ipString.Split('.');
            if (parts.Length != 4) return false;

            foreach (var part in parts)
            {
                if (!int.TryParse(part, out int num)) return false;
                if (num < 0 || num > 255) return false;
            }

            return true;
        }


        // Update button click
        private async void Update_Button_Click(object sender, EventArgs e)
        {
            UpdateHistory(IPaddress.Text);
            var ProgressBar = new Progress();
            ProgressBar.Show(this);  // Show as modal but non-blocking

            try
            {
                await Task.Run(() =>
                {
                    if (isDHCP)
                        Set_DHCP();
                    else if (isStatic)
                        Set_Static_IP();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ProgressBar.Close();
            }
        }


        // Assign a static IP to selected network adapter
        private void Set_Static_IP()
        {
            string adapterName = NetworkAdapters.SelectedItem.ToString();
            string ipAddress = IPaddress.Text.Trim();
            string subnetMask = SubnetMask.Text.Trim();
            int prefixLength = SubnetMaskToPrefixLength(subnetMask);

            string script = $@"
            Remove-NetIPAddress -InterfaceAlias '{adapterName}' -AddressFamily IPv4 -Confirm:$false
            New-NetIPAddress -InterfaceAlias '{adapterName}' -IPAddress '{ipAddress}' -PrefixLength {prefixLength} -AddressFamily IPv4
            ".Trim();

            using (Runspace runspace = RunspaceFactory.CreateRunspace())
            {
                runspace.Open();
                using (Pipeline pipeline = runspace.CreatePipeline())
                {
                    pipeline.Commands.AddScript(script);

                    try
                    {
                        Collection<PSObject> results = pipeline.Invoke();

                        // Check for PowerShell errors
                        if (pipeline.Error != null && pipeline.Error.Count > 0)
                        {
                            StringBuilder errorOutput = new StringBuilder();
                            foreach (var err in pipeline.Error.ReadToEnd())
                            {
                                errorOutput.AppendLine(err.ToString());
                            }

                            MessageBox.Show("PowerShell errors:\n\n" + errorOutput.ToString(), "PowerShell Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        StringBuilder output = new StringBuilder();
                        foreach (PSObject obj in results)
                        {
                            output.AppendLine(obj.ToString());
                        }

                        this.DialogResult = DialogResult.Cancel;
                        this.Close();


                        //MessageBox.Show("IP configuration updated successfully:\n\n" + output.ToString(), "Success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error running PowerShell script:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        // Assign DHCP to selected network adapter
        private void Set_DHCP()
        {
            string adapterName = NetworkAdapters.SelectedItem.ToString();

            string script = $@"
            Set-NetIPInterface -InterfaceAlias ""{adapterName}"" -Dhcp Enabled
            Set-DnsClientServerAddress -InterfaceAlias ""{adapterName}"" -ResetServerAddresses
            Start-Sleep -Seconds 2
            Restart-NetAdapter -Name ""{adapterName}"" -Confirm:$false
            Start-Sleep -Seconds 2
            ".Trim();

            using (Runspace runspace = RunspaceFactory.CreateRunspace())
            {
                runspace.Open();
                using (Pipeline pipeline = runspace.CreatePipeline())
                {
                    pipeline.Commands.AddScript(script);

                    try
                    {
                        Collection<PSObject> results = pipeline.Invoke();

                        if (pipeline.Error != null && pipeline.Error.Count > 0)
                        {
                            StringBuilder errorOutput = new StringBuilder();
                            foreach (var err in pipeline.Error.ReadToEnd())
                            {
                                errorOutput.AppendLine(err.ToString());
                            }

                            MessageBox.Show("PowerShell errors:\n\n" + errorOutput.ToString(), "PowerShell Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        StringBuilder output = new StringBuilder();
                        foreach (PSObject obj in results)
                        {
                            output.AppendLine(obj.ToString());
                        }

                        this.DialogResult = DialogResult.Cancel;
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error running PowerShell script:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        // Update last 5 used IP addresses history
        private void UpdateHistory(string newIp)
        {
            ipHistory.Remove(newIp);        // Avoid duplicates
            ipHistory.Insert(0, newIp);     // Add to top
            if (ipHistory.Count > 5)
                ipHistory.RemoveAt(5);      // Keep max 5

            var collection = new System.Collections.Specialized.StringCollection();
            collection.AddRange(ipHistory.ToArray());
            Properties.Settings.Default.IpHistory = collection;
            Properties.Settings.Default.Save();

            PopulateIPaddressHistory(); // Refresh UI
        }

    }

}