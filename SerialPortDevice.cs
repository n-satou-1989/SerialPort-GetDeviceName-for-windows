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

            DevicesProperty = ConvertDevicesProperty(deviceName, comNumber);
        }

        private static DeviceProperties[] ConvertDevicesProperty(List<string> deviceName, List<string> comNumber)
        {
            DeviceProperties[] deviceProperties = new DeviceProperties[0];

            if(deviceName != null && comNumber != null)
            {
                for(int x = 0; x < comNumber.Count; x++)
                {
                    for(int y = x + 1; y < comNumber.Count; y++)
                    {
                        int a = int.Parse(comNumber[x].Substring(3));
                        int b = int.Parse(comNumber[y].Substring(3));
                        if(a > b)
                        {
                            string name = deviceName[y];
                            deviceName.RemoveAt(y);
                            string com = comNumber[y];
                            comNumber.RemoveAt(y);

                            deviceName.Insert(x, name);
                            comNumber.Insert(x, com);
                        }
                    }
                }

                if(comNumber.Count > 0)
                {
                    deviceProperties = new DeviceProperties[comNumber.Count];
                    for(int i = 0; i < comNumber.Count; i++)
                    {
                        deviceProperties[i] = new DeviceProperties(deviceName[i], comNumber[i]);
                    }
                }
            }
            
            return deviceProperties;
        }
    }
}
