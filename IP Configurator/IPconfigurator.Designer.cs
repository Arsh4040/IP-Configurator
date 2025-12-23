namespace IP_Configurator
{
    partial class IPconfigurator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPconfigurator));
            this.Update_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SubnetMask = new System.Windows.Forms.TextBox();
            this.NetworkAdapters = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IP_Address_Text = new System.Windows.Forms.Label();
            this.Subnet_Mask_Text = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Static_Icon = new System.Windows.Forms.PictureBox();
            this.DHCP_Icon = new System.Windows.Forms.PictureBox();
            this.Static_Text = new System.Windows.Forms.Label();
            this.DHCP_Text = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Static_Button = new System.Windows.Forms.PictureBox();
            this.DHCP_Button = new System.Windows.Forms.PictureBox();
            this.Greyed_Update_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.IPaddress = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Static_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DHCP_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Static_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DHCP_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // Update_Button
            // 
            this.Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update_Button.Location = new System.Drawing.Point(80, 355);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(98, 44);
            this.Update_Button.TabIndex = 0;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-1, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            // 
            // SubnetMask
            // 
            this.SubnetMask.Location = new System.Drawing.Point(144, 285);
            this.SubnetMask.Name = "SubnetMask";
            this.SubnetMask.Size = new System.Drawing.Size(235, 20);
            this.SubnetMask.TabIndex = 5;
            // 
            // NetworkAdapters
            // 
            this.NetworkAdapters.Location = new System.Drawing.Point(144, 228);
            this.NetworkAdapters.Name = "NetworkAdapters";
            this.NetworkAdapters.Size = new System.Drawing.Size(235, 21);
            this.NetworkAdapters.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(28, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Network Adapter";
            // 
            // IP_Address_Text
            // 
            this.IP_Address_Text.AutoSize = true;
            this.IP_Address_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_Address_Text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IP_Address_Text.Location = new System.Drawing.Point(28, 260);
            this.IP_Address_Text.Name = "IP_Address_Text";
            this.IP_Address_Text.Size = new System.Drawing.Size(73, 16);
            this.IP_Address_Text.TabIndex = 15;
            this.IP_Address_Text.Text = "IP Address";
            // 
            // Subnet_Mask_Text
            // 
            this.Subnet_Mask_Text.AutoSize = true;
            this.Subnet_Mask_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subnet_Mask_Text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Subnet_Mask_Text.Location = new System.Drawing.Point(28, 288);
            this.Subnet_Mask_Text.Name = "Subnet_Mask_Text";
            this.Subnet_Mask_Text.Size = new System.Drawing.Size(85, 16);
            this.Subnet_Mask_Text.TabIndex = 16;
            this.Subnet_Mask_Text.Text = "Subnet Mask";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(136, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "IP Configurator";
            // 
            // Static_Icon
            // 
            this.Static_Icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Static_Icon.Image = ((System.Drawing.Image)(resources.GetObject("Static_Icon.Image")));
            this.Static_Icon.Location = new System.Drawing.Point(67, 87);
            this.Static_Icon.Name = "Static_Icon";
            this.Static_Icon.Size = new System.Drawing.Size(80, 74);
            this.Static_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Static_Icon.TabIndex = 19;
            this.Static_Icon.TabStop = false;
            // 
            // DHCP_Icon
            // 
            this.DHCP_Icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DHCP_Icon.Image = ((System.Drawing.Image)(resources.GetObject("DHCP_Icon.Image")));
            this.DHCP_Icon.Location = new System.Drawing.Point(247, 87);
            this.DHCP_Icon.Name = "DHCP_Icon";
            this.DHCP_Icon.Size = new System.Drawing.Size(80, 74);
            this.DHCP_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DHCP_Icon.TabIndex = 20;
            this.DHCP_Icon.TabStop = false;
            // 
            // Static_Text
            // 
            this.Static_Text.AutoSize = true;
            this.Static_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Static_Text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Static_Text.Location = new System.Drawing.Point(87, 173);
            this.Static_Text.Name = "Static_Text";
            this.Static_Text.Size = new System.Drawing.Size(40, 16);
            this.Static_Text.TabIndex = 21;
            this.Static_Text.Text = "Static";
            // 
            // DHCP_Text
            // 
            this.DHCP_Text.AutoSize = true;
            this.DHCP_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DHCP_Text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DHCP_Text.Location = new System.Drawing.Point(265, 173);
            this.DHCP_Text.Name = "DHCP_Text";
            this.DHCP_Text.Size = new System.Drawing.Size(45, 16);
            this.DHCP_Text.TabIndex = 22;
            this.DHCP_Text.Text = "DHCP";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cancel_Button.Location = new System.Drawing.Point(220, 355);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(98, 44);
            this.Cancel_Button.TabIndex = 23;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Static_Button
            // 
            this.Static_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Static_Button.Image = ((System.Drawing.Image)(resources.GetObject("Static_Button.Image")));
            this.Static_Button.Location = new System.Drawing.Point(67, 87);
            this.Static_Button.Name = "Static_Button";
            this.Static_Button.Size = new System.Drawing.Size(80, 74);
            this.Static_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Static_Button.TabIndex = 24;
            this.Static_Button.TabStop = false;
            this.Static_Button.Click += new System.EventHandler(this.Static_Button_Click);
            // 
            // DHCP_Button
            // 
            this.DHCP_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DHCP_Button.Image = ((System.Drawing.Image)(resources.GetObject("DHCP_Button.Image")));
            this.DHCP_Button.Location = new System.Drawing.Point(247, 87);
            this.DHCP_Button.Name = "DHCP_Button";
            this.DHCP_Button.Size = new System.Drawing.Size(80, 74);
            this.DHCP_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DHCP_Button.TabIndex = 25;
            this.DHCP_Button.TabStop = false;
            this.DHCP_Button.Click += new System.EventHandler(this.DHCP_Button_Click);
            // 
            // Greyed_Update_Button
            // 
            this.Greyed_Update_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Greyed_Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greyed_Update_Button.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Greyed_Update_Button.Location = new System.Drawing.Point(80, 355);
            this.Greyed_Update_Button.Name = "Greyed_Update_Button";
            this.Greyed_Update_Button.Size = new System.Drawing.Size(98, 44);
            this.Greyed_Update_Button.TabIndex = 26;
            this.Greyed_Update_Button.Text = "Update";
            this.Greyed_Update_Button.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(98, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fast and easy IP address changer shortcut.";
            // 
            // IPaddress
            // 
            this.IPaddress.Location = new System.Drawing.Point(144, 257);
            this.IPaddress.Name = "IPaddress";
            this.IPaddress.Size = new System.Drawing.Size(235, 21);
            this.IPaddress.TabIndex = 28;
            // 
            // IPconfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(408, 424);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Greyed_Update_Button);
            this.Controls.Add(this.DHCP_Button);
            this.Controls.Add(this.Static_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.DHCP_Text);
            this.Controls.Add(this.Static_Text);
            this.Controls.Add(this.DHCP_Icon);
            this.Controls.Add(this.Static_Icon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Subnet_Mask_Text);
            this.Controls.Add(this.IP_Address_Text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubnetMask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.IPaddress);
            this.Controls.Add(this.NetworkAdapters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IPconfigurator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Configurator";
            ((System.ComponentModel.ISupportInitialize)(this.Static_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DHCP_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Static_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DHCP_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubnetMask;
        private System.Windows.Forms.ComboBox NetworkAdapters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label IP_Address_Text;
        private System.Windows.Forms.Label Subnet_Mask_Text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Static_Icon;
        private System.Windows.Forms.PictureBox DHCP_Icon;
        private System.Windows.Forms.Label Static_Text;
        private System.Windows.Forms.Label DHCP_Text;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.PictureBox Static_Button;
        private System.Windows.Forms.PictureBox DHCP_Button;
        private System.Windows.Forms.Button Greyed_Update_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox IPaddress;
    }
}

