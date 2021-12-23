using SerialPort_GetDeviceName_for_windows;
using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace SerialPortSelectForm
{
    public partial class SerialPortSelectForm : Form
    {
        /// <summary>
        /// ボーレート
        /// </summary>
        private static readonly int[] BAUD_RATE_ARRAY = new int[]
        {
            110, 300, 600,
            1200, 2400, 4800, 9600,
            14400, 19200, 38400, 57600,
            115200, 230400, 460800, 921600
        };

        /// <summary>
        /// データビット
        /// </summary>
        private static readonly int[] DATA_BITS_ARRAY = new int[]
        {
            5, 6, 7, 8, 9
        };

        /// <summary>
        /// Encoding
        /// </summary>
        private static readonly Encoding[] ENCODING_LIST = new Encoding[]
        {
            Encoding.UTF8, Encoding.ASCII
        };

        /// <summary>
        /// 親フォームに返すクラス変数
        /// </summary>
        public SerialPortParameter ReturnPortPara = new SerialPortParameter();

        public SerialPortSelectForm()
        {
            InitializeComponent();

            this.Text = "シリアルポート選択";
            this.MaximizeBox = this.MinimizeBox = false;

            if(!SerialPortSelectFrom.Properties.Settings.Default.FristPropertys)
            {
                SerialPortSelectFrom.Properties.Settings.Default.FristPropertys = true;
                SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexBaudRate = 6;
                SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexDataBits = 3;
                SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexParity = 0;
                SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexStopBits = 1;
                SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexHandShake = 0;
                SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexEncoding = 0;
                SerialPortSelectFrom.Properties.Settings.Default.DefaultCheckedDTR = true;
                SerialPortSelectFrom.Properties.Settings.Default.DefaultCheckedRTS = true;
                SerialPortSelectFrom.Properties.Settings.Default.Save();
            }
        }

        private void SerialPortSelectForm_Load(object sender, EventArgs e)
        {
            combox_PortName.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_Baudrate.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_DataBits.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_Parity.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_StopBits.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_Handshake.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_Encoding.DropDownStyle = ComboBoxStyle.DropDownList;

            // Device Name
            SerialPortDevice.CheckDevice();
            if(SerialPortDevice.DevicesProperty.Length > 0)
            {
                for(int i = 0; i < SerialPortDevice.DevicesProperty.Length; i++)
                {
                    combox_PortName.Items.Add(SerialPortDevice.DevicesProperty[i].Name);
                }
                combox_PortName.SelectedIndex = 0;
            }

            // BaudRate
            foreach(int br in BAUD_RATE_ARRAY)
            {
                combox_Baudrate.Items.Add(br);
            }
            combox_Baudrate.SelectedIndex = SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexBaudRate;

            // DataBist
            foreach(int bits in DATA_BITS_ARRAY)
            {
                combox_DataBits.Items.Add(bits);
            }
            combox_DataBits.SelectedIndex = SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexDataBits;

            // Parity
            combox_Parity.Items.Add(nameof(Parity.None));
            combox_Parity.Items.Add(nameof(Parity.Odd));
            combox_Parity.Items.Add(nameof(Parity.Even));
            combox_Parity.Items.Add(nameof(Parity.Mark));
            combox_Parity.Items.Add(nameof(Parity.Space));
            combox_Parity.SelectedIndex = SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexParity;

            // StopBits
            combox_StopBits.Items.Add(nameof(StopBits.None));
            combox_StopBits.Items.Add(nameof(StopBits.One));
            combox_StopBits.Items.Add(nameof(StopBits.Two));
            combox_StopBits.Items.Add(nameof(StopBits.OnePointFive));
            combox_StopBits.SelectedIndex = SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexStopBits;

            // HandShake
            combox_Handshake.Items.Add(Handshake.None);
            combox_Handshake.Items.Add(Handshake.XOnXOff);
            combox_Handshake.Items.Add(Handshake.RequestToSend);
            combox_Handshake.Items.Add(Handshake.RequestToSendXOnXOff);
            combox_Handshake.SelectedIndex = SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexHandShake;

            // Encoding
            combox_Encoding.Items.Clear();
            combox_Encoding.Items.Add(nameof(Encoding.UTF8));
            combox_Encoding.Items.Add(nameof(Encoding.ASCII));
            combox_Encoding.SelectedIndex = SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexEncoding;

            ckbox_DataTerminalReady.Checked = SerialPortSelectFrom.Properties.Settings.Default.DefaultCheckedDTR;
            ckbox_RequestToSend.Checked = SerialPortSelectFrom.Properties.Settings.Default.DefaultCheckedRTS;

            btn_Ok.Text = "OK";
            btn_Cancel.Text = "Cancel";
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            ReturnPortPara.PortName = SerialPortDevice.DevicesProperty[combox_PortName.SelectedIndex].Name;
            ReturnPortPara.ComNo = SerialPortDevice.DevicesProperty[combox_PortName.SelectedIndex].ComNo;
            ReturnPortPara.BaudRate = BAUD_RATE_ARRAY[combox_Baudrate.SelectedIndex];
            ReturnPortPara.DataBits = DATA_BITS_ARRAY[combox_DataBits.SelectedIndex];
            ReturnPortPara.StopBits = (StopBits)Enum.ToObject(typeof(StopBits), combox_StopBits.SelectedIndex);
            ReturnPortPara.Parity = (Parity)Enum.ToObject(typeof(Parity), combox_Parity.SelectedIndex);
            ReturnPortPara.Handshake = (Handshake)Enum.ToObject(typeof(Handshake), combox_Handshake.SelectedIndex);
            ReturnPortPara.Encoding = ENCODING_LIST[combox_Encoding.SelectedIndex];
            ReturnPortPara.DTR = ckbox_DataTerminalReady.Checked;
            ReturnPortPara.RTS = ckbox_RequestToSend.Checked;

            SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexBaudRate = combox_Baudrate.SelectedIndex;
            SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexDataBits = combox_DataBits.SelectedIndex;
            SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexParity = combox_Parity.SelectedIndex;
            SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexStopBits = combox_StopBits.SelectedIndex;
            SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexHandShake = combox_Handshake.SelectedIndex;
            SerialPortSelectFrom.Properties.Settings.Default.DefaultIndexEncoding = combox_Encoding.SelectedIndex;
            SerialPortSelectFrom.Properties.Settings.Default.DefaultCheckedDTR = ckbox_DataTerminalReady.Checked;
            SerialPortSelectFrom.Properties.Settings.Default.DefaultCheckedRTS = ckbox_RequestToSend.Checked;
            SerialPortSelectFrom.Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
