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

        private static DeviceProperties[] ConvertDevicesProperty(List<string> deviceName, List<string> comNo)
        {
            DeviceProperties[] deviceProperties = new DeviceProperties[0];

            if(deviceName != null && comNo != null)
            {
                for(int i = 0; i < comNo.Count; i++)
                {
                    for(int x = i + 1; x < comNo.Count; x++)
                    {
                        int a = int.Parse(comNo[i].Substring(3));
                        int b = int.Parse(comNo[x].Substring(3));
                        if(a > b)
                        {
                            string name = deviceName[x];
                            deviceName.RemoveAt(x);
                            string com = comNo[x];
                            comNo.RemoveAt(x);

                            deviceName.Insert(i, name);
                            com.Insert(i, com);
                        }
                    }
                }

                if(comNo.Count > 0)
                {
                    deviceProperties = new DeviceProperties[comNo.Count];
                    for(int i = 0; i < comNo.Count; i++)
                    {
                        deviceProperties[i] = new DeviceProperties(deviceName[i], comNo[i]);
                    }
                }
            }
            
            return deviceProperties;
        }
    }
}
