
namespace SerialPortSelectForm
{
    partial class SerialPortSelectForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.combox_PortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combox_Baudrate = new System.Windows.Forms.ComboBox();
            this.combox_DataBits = new System.Windows.Forms.ComboBox();
            this.combox_StopBits = new System.Windows.Forms.ComboBox();
            this.combox_Parity = new System.Windows.Forms.ComboBox();
            this.combox_Handshake = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combox_Encoding = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbox_DataTerminalReady = new System.Windows.Forms.CheckBox();
            this.ckbox_RequestToSend = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combox_PortName
            // 
            this.combox_PortName.FormattingEnabled = true;
            this.combox_PortName.Location = new System.Drawing.Point(90, 15);
            this.combox_PortName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combox_PortName.Name = "combox_PortName";
            this.combox_PortName.Size = new System.Drawing.Size(433, 23);
            this.combox_PortName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baudrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "DataBits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "StopBits";
            // 
            // combox_Baudrate
            // 
            this.combox_Baudrate.FormattingEnabled = true;
            this.combox_Baudrate.Location = new System.Drawing.Point(90, 48);
            this.combox_Baudrate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combox_Baudrate.Name = "combox_Baudrate";
            this.combox_Baudrate.Size = new System.Drawing.Size(176, 23);
            this.combox_Baudrate.TabIndex = 5;
            // 
            // combox_DataBits
            // 
            this.combox_DataBits.FormattingEnabled = true;
            this.combox_DataBits.Location = new System.Drawing.Point(90, 80);
            this.combox_DataBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combox_DataBits.Name = "combox_DataBits";
            this.combox_DataBits.Size = new System.Drawing.Size(176, 23);
            this.combox_DataBits.TabIndex = 6;
            // 
            // combox_StopBits
            // 
            this.combox_StopBits.FormattingEnabled = true;
            this.combox_StopBits.Location = new System.Drawing.Point(90, 112);
            this.combox_StopBits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combox_StopBits.Name = "combox_StopBits";
            this.combox_StopBits.Size = new System.Drawing.Size(176, 23);
            this.combox_StopBits.TabIndex = 7;
            // 
            // combox_Parity
            // 
            this.combox_Parity.FormattingEnabled = true;
            this.combox_Parity.Location = new System.Drawing.Point(90, 145);
            this.combox_Parity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combox_Parity.Name = "combox_Parity";
            this.combox_Parity.Size = new System.Drawing.Size(176, 23);
            this.combox_Parity.TabIndex = 8;
            // 
            // combox_Handshake
            // 
            this.combox_Handshake.FormattingEnabled = true;
            this.combox_Handshake.Location = new System.Drawing.Point(90, 178);
            this.combox_Handshake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combox_Handshake.Name = "combox_Handshake";
            this.combox_Handshake.Size = new System.Drawing.Size(176, 23);
            this.combox_Handshake.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Handshake";
            // 
            // combox_Encoding
            // 
            this.combox_Encoding.FormattingEnabled = true;
            this.combox_Encoding.Location = new System.Drawing.Point(90, 210);
            this.combox_Encoding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combox_Encoding.Name = "combox_Encoding";
            this.combox_Encoding.Size = new System.Drawing.Size(176, 23);
            this.combox_Encoding.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Encoding";
            // 
            // ckbox_DataTerminalReady
            // 
            this.ckbox_DataTerminalReady.AutoSize = true;
            this.ckbox_DataTerminalReady.BackColor = System.Drawing.SystemColors.Control;
            this.ckbox_DataTerminalReady.Location = new System.Drawing.Point(90, 242);
            this.ckbox_DataTerminalReady.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbox_DataTerminalReady.Name = "ckbox_DataTerminalReady";
            this.ckbox_DataTerminalReady.Size = new System.Drawing.Size(47, 19);
            this.ckbox_DataTerminalReady.TabIndex = 14;
            this.ckbox_DataTerminalReady.Text = "DTR";
            this.ckbox_DataTerminalReady.UseVisualStyleBackColor = false;
            // 
            // ckbox_RequestToSend
            // 
            this.ckbox_RequestToSend.AutoSize = true;
            this.ckbox_RequestToSend.Location = new System.Drawing.Point(152, 242);
            this.ckbox_RequestToSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbox_RequestToSend.Name = "ckbox_RequestToSend";
            this.ckbox_RequestToSend.Size = new System.Drawing.Size(45, 19);
            this.ckbox_RequestToSend.TabIndex = 15;
            this.ckbox_RequestToSend.Text = "RTS";
            this.ckbox_RequestToSend.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 244);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Signal";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(342, 244);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(88, 29);
            this.btn_Ok.TabIndex = 17;
            this.btn_Ok.Text = "button1";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(436, 244);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(88, 29);
            this.btn_Cancel.TabIndex = 18;
            this.btn_Cancel.Text = "button2";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // SerialPortSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 285);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ckbox_RequestToSend);
            this.Controls.Add(this.ckbox_DataTerminalReady);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combox_Encoding);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combox_Handshake);
            this.Controls.Add(this.combox_Parity);
            this.Controls.Add(this.combox_StopBits);
            this.Controls.Add(this.combox_DataBits);
            this.Controls.Add(this.combox_Baudrate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combox_PortName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SerialPortSelectForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SerialPortSelectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combox_PortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combox_Baudrate;
        private System.Windows.Forms.ComboBox combox_DataBits;
        private System.Windows.Forms.ComboBox combox_StopBits;
        private System.Windows.Forms.ComboBox combox_Parity;
        private System.Windows.Forms.ComboBox combox_Handshake;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combox_Encoding;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbox_DataTerminalReady;
        private System.Windows.Forms.CheckBox ckbox_RequestToSend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
    }
}

