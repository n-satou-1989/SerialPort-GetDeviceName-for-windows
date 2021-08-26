using System.Collections.Generic;
using System.Management;

namespace SerialPort_GetDeviceName_for_windows
{
    /// <summary>
    /// Get the name and COM port number of the connected device.
    /// </summary>
    public static class SerialPortDevice
    {
        public static DeviceProperties[] DevicesProperty
        {
            get; private set;
        }

        public static void CheckDevice()
        {
            List<string> deviceName = new List<string>();
            List<string> comNumber = new List<string>();
            DevicesProperty = new DeviceProperties[0];

            using(ManagementObjectCollection managementObjectCollection = new ManagementClass("Win32_PnPEntity").GetInstances())
            {
                foreach(ManagementObject managementObject in managementObjectCollection)
                {
                    var namePropertyValue = managementObject.GetPropertyValue("Name");
                    if(namePropertyValue != null)
                    {
                        string name = namePropertyValue.ToString();
                        if(System.Text.RegularExpressions.Regex.IsMatch(name, "(COM[1-9][0-9]?[0-9]?)"))
                        {
                            deviceName.Add(managementObject.GetPropertyValue("Caption").ToString());
                            comNumber.Add(name.Substring(name.IndexOf("(COM") + 1).Replace(")", ""));
                        }
                    }
                }
            }

            if(comNumber.Count == 0)
            {
                return; // not device
            }

            // Sort by ascending order
            for(int i = 0; i < comNumber.Count; i++)
            {
                for(int x = i + 1; x < comNumber.Count; x++)
                {
                    int a = int.Parse(comNumber[i].Substring(3));
                    int b = int.Parse(comNumber[x].Substring(3));
                    if(a > b)
                    {
                        string name = deviceName[x];
                        deviceName.RemoveAt(x);
                        string com = comNumber[x];
                        comNumber.RemoveAt(x);

                        deviceName.Insert(i, name);
                        comNumber.Insert(i, com);
                    }
                }
            }
            DevicesProperty = new DeviceProperties[comNumber.Count];
            for(int i = 0; i < comNumber.Count; i++)
            {
                DevicesProperty[i] = new DeviceProperties(deviceName[i], comNumber[i]);
            }
        }
    }
}
