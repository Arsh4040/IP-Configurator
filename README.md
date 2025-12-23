# IP Configurator

A simple Windows tool to quickly switch IP addresses on your Ethernet adapters.  

This app is designed to save time for scenarios like **PLC programming**, where laptops often need to use static IPs that match the machines they connect to.

---

## Features

- Quickly switch between **Static IP** and **DHCP** modes.
- Remembers the **last 5 used IP addresses** for even faster switching.
- Easy-to-use **graphical interface** with network adapter selection.
- Validates IP and subnet mask formats to prevent mistakes.
- Built with **C#** and leverages **PowerShell** for network configuration.

---

## Screenshots

<img width="1298" height="1378" alt="image" src="https://github.com/user-attachments/assets/d24d7bde-0bdc-4609-a3e8-b6b3dd2268f6" />


---

## Requirements

- Windows 10 or later
- .NET Framework (version compatible with WinForms app)
- PowerShell access (used internally to configure network adapters)

---

## Usage

1. Open the app.
2. Select the **Ethernet adapter** you want to configure.
3. Choose between:
   - **Static IP**: Enter an IP address and subnet mask.
   - **DHCP**: Automatically obtain IP settings from the network.
4. Click **Update** to apply the changes.
5. The app remembers your last 5 IP addresses for quick reuse.

---
