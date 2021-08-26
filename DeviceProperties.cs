using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPort_GetDeviceName_for_windows
{
    public class DeviceProperties
    {
        public DeviceProperties() { }

        public DeviceProperties(string name, string com)
        {
            Name = name;
            ComNo = com;
        }

        public string Name { get; set; }

        public string ComNo { get; set; }
    }
}
