using System.IO.Ports;
using System.Text;

namespace SerialPortSelectForm
{
    public class SerialPortParameter
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SerialPortParameter()
        {

        }

        /// <summary>
        /// ポート名 + COM番号
        /// </summary>
        public string PortName { get; set; } = string.Empty;

        /// <summary>
        /// COM番号
        /// </summary>
        public string ComNo { get; set; } = string.Empty;

        public int BaudRate { get; set; } = 0;

        public int DataBits { get; set; } = 0;

        public Parity Parity { get; set; } = Parity.None;

        public StopBits StopBits { get; set; } = StopBits.None;

        public Handshake Handshake { get; set; } = Handshake.None;

        public Encoding Encoding { get; set; } = Encoding.UTF8;

        public bool DTR { get; set; } = false;

        public bool RTS { get; set; } = false;
    }
}
