using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NoUsbExecution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey key;

            // Looking for the "SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies" value. If it doesn't exist, we catch the exception and try to create it.
            try
            {
                key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies");

                if (Convert.ToInt16(key.GetValue("WriteProtect", null)) == 1)
                {
                    readonlybtn.BackColor = Color.Green;
                }
                else
                {
                    fullaccessbtn.BackColor = Color.Green;
                }
            }
            catch (NullReferenceException)
            {

                key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control", true);
                key.CreateSubKey("StorageDevicePolicies");
                key.Close();
            }

            catch (Exception) { }

            // Trying to access the value of the "SYSTEM\CurrentControlSet\Services\UsbStor". If it doesn't exist, we create it. 
            try
            {
                key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\UsbStor");

                if (Convert.ToInt16(key.GetValue("Start", null)) == 4)
                {
                    disabledbtn.BackColor = Color.Green;
                    return;
                }
            }

            catch (NullReferenceException)
            {
                key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services", true);
                key.CreateSubKey("USBSTOR");

                key.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\UsbStor", true);

                key.SetValue("Type", 1, RegistryValueKind.DWord);
                key.SetValue("Start", 3, RegistryValueKind.DWord);
                key.SetValue("ImagePath", "system32\\drivers\\usbstor.sys", RegistryValueKind.ExpandString);
                key.SetValue("ErrorControl", 1, RegistryValueKind.DWord);
                key.SetValue("DisplayName", "Usb Mass Storage Driver", RegistryValueKind.String);
                key.Close();
            }

            catch (Exception) { }

            void UsbEnableWriteProtect()
            {
                key = Registry.LocalMachine.OpenSubKey

     ("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", true);

                if (key == null)

                {

                    Registry.LocalMachine.CreateSubKey

        ("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", RegistryKeyPermissionCheck.ReadWriteSubTree);

                    key = Registry.LocalMachine.OpenSubKey

         ("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", true);

                    key.SetValue("WriteProtect", 1, RegistryValueKind.DWord);
                }
                else if (key.GetValue("WriteProtect") != (object)(1))

                {

                    key.SetValue("WriteProtect", 1, RegistryValueKind.DWord);

                }
            }

            void UsbDisableWriteProtect()
            {
                key = Registry.LocalMachine.OpenSubKey

          ("SYSTEM\\CurrentControlSet\\Control\\StorageDevicePolicies", true);

                if (key != null)

                {

                    key.SetValue("WriteProtect", 0, RegistryValueKind.DWord);

                }

                key.Close();
            }

            void UsbDisableAllStorageDevices()
            {
                key = Registry.LocalMachine.OpenSubKey

                ("SYSTEM\\CurrentControlSet\\Services\\UsbStor", true);

                if (key != null)

                {

                    key.SetValue("Start", 4, RegistryValueKind.DWord);

                }

                key.Close();
            }

            void UsbEnableAllStorageDevices()
            {
                key = Registry.LocalMachine.OpenSubKey

                ("SYSTEM\\CurrentControlSet\\Services\\UsbStor", true);

                if (key != null)

                {

                    key.SetValue("Start", 3, RegistryValueKind.DWord);

                }

                key.Close();
            }
        }
    }
}