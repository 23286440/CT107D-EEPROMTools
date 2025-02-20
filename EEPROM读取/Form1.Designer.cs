namespace EEPROM读取
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox_COMSelect = new System.Windows.Forms.ComboBox();
            this.button_COMScanf = new System.Windows.Forms.Button();
            this.button_COMSwinch = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button_ReadData = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_COMOpenOverTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_ReadDataOverTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button_ReBoot = new System.Windows.Forms.Button();
            this.button_WriteData = new System.Windows.Forms.Button();
            this.textBox_WriteAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_WriteValue = new System.Windows.Forms.TextBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.button_ProgromInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_COMOpenOverTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ReadDataOverTime)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 1000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox_COMSelect
            // 
            this.comboBox_COMSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_COMSelect.FormattingEnabled = true;
            this.comboBox_COMSelect.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox_COMSelect.Location = new System.Drawing.Point(118, 16);
            this.comboBox_COMSelect.Name = "comboBox_COMSelect";
            this.comboBox_COMSelect.Size = new System.Drawing.Size(161, 26);
            this.comboBox_COMSelect.TabIndex = 0;
            // 
            // button_COMScanf
            // 
            this.button_COMScanf.Location = new System.Drawing.Point(12, 12);
            this.button_COMScanf.Name = "button_COMScanf";
            this.button_COMScanf.Size = new System.Drawing.Size(100, 33);
            this.button_COMScanf.TabIndex = 2;
            this.button_COMScanf.Text = "扫描串口";
            this.button_COMScanf.UseVisualStyleBackColor = true;
            this.button_COMScanf.Click += new System.EventHandler(this.button_COMScanf_Click);
            // 
            // button_COMSwinch
            // 
            this.button_COMSwinch.Location = new System.Drawing.Point(12, 51);
            this.button_COMSwinch.Name = "button_COMSwinch";
            this.button_COMSwinch.Size = new System.Drawing.Size(100, 33);
            this.button_COMSwinch.TabIndex = 3;
            this.button_COMSwinch.Text = "打开串口";
            this.button_COMSwinch.UseVisualStyleBackColor = true;
            this.button_COMSwinch.Click += new System.EventHandler(this.button_COMSwinch_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button_ReadData
            // 
            this.button_ReadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ReadData.Location = new System.Drawing.Point(12, 584);
            this.button_ReadData.Name = "button_ReadData";
            this.button_ReadData.Size = new System.Drawing.Size(100, 33);
            this.button_ReadData.TabIndex = 5;
            this.button_ReadData.Text = "读取数据";
            this.button_ReadData.UseVisualStyleBackColor = true;
            this.button_ReadData.Click += new System.EventHandler(this.button_ReadData_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.richTextBox1.Location = new System.Drawing.Point(12, 90);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(745, 488);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "超时：";
            // 
            // numericUpDown_COMOpenOverTime
            // 
            this.numericUpDown_COMOpenOverTime.Location = new System.Drawing.Point(186, 56);
            this.numericUpDown_COMOpenOverTime.Name = "numericUpDown_COMOpenOverTime";
            this.numericUpDown_COMOpenOverTime.Size = new System.Drawing.Size(61, 28);
            this.numericUpDown_COMOpenOverTime.TabIndex = 9;
            this.numericUpDown_COMOpenOverTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "秒";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "秒";
            // 
            // numericUpDown_ReadDataOverTime
            // 
            this.numericUpDown_ReadDataOverTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_ReadDataOverTime.Location = new System.Drawing.Point(186, 589);
            this.numericUpDown_ReadDataOverTime.Name = "numericUpDown_ReadDataOverTime";
            this.numericUpDown_ReadDataOverTime.Size = new System.Drawing.Size(61, 28);
            this.numericUpDown_ReadDataOverTime.TabIndex = 12;
            this.numericUpDown_ReadDataOverTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 591);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "超时：";
            // 
            // button_ReBoot
            // 
            this.button_ReBoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ReBoot.Location = new System.Drawing.Point(648, 12);
            this.button_ReBoot.Name = "button_ReBoot";
            this.button_ReBoot.Size = new System.Drawing.Size(109, 33);
            this.button_ReBoot.TabIndex = 14;
            this.button_ReBoot.Text = "重启单片机";
            this.button_ReBoot.UseVisualStyleBackColor = true;
            this.button_ReBoot.Click += new System.EventHandler(this.button_ReBoot_Click);
            // 
            // button_WriteData
            // 
            this.button_WriteData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_WriteData.Location = new System.Drawing.Point(373, 584);
            this.button_WriteData.Name = "button_WriteData";
            this.button_WriteData.Size = new System.Drawing.Size(100, 33);
            this.button_WriteData.TabIndex = 15;
            this.button_WriteData.Text = "写入数据";
            this.button_WriteData.UseVisualStyleBackColor = true;
            this.button_WriteData.Click += new System.EventHandler(this.button_WriteData_Click);
            // 
            // textBox_WriteAddress
            // 
            this.textBox_WriteAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_WriteAddress.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_WriteAddress.Location = new System.Drawing.Point(547, 588);
            this.textBox_WriteAddress.MaxLength = 2;
            this.textBox_WriteAddress.Name = "textBox_WriteAddress";
            this.textBox_WriteAddress.Size = new System.Drawing.Size(77, 28);
            this.textBox_WriteAddress.TabIndex = 16;
            this.textBox_WriteAddress.Text = "FF";
            this.textBox_WriteAddress.WordWrap = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 591);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "地址：";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 591);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "值：";
            // 
            // textBox_WriteValue
            // 
            this.textBox_WriteValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_WriteValue.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_WriteValue.Location = new System.Drawing.Point(680, 588);
            this.textBox_WriteValue.MaxLength = 2;
            this.textBox_WriteValue.Name = "textBox_WriteValue";
            this.textBox_WriteValue.Size = new System.Drawing.Size(77, 28);
            this.textBox_WriteValue.TabIndex = 19;
            this.textBox_WriteValue.Text = "FF";
            this.textBox_WriteValue.WordWrap = false;
            // 
            // label_Info
            // 
            this.label_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Info.AutoSize = true;
            this.label_Info.Location = new System.Drawing.Point(12, 620);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(431, 18);
            this.label_Info.TabIndex = 20;
            this.label_Info.Text = "配合开发板CT107D使用，使用前请先烧录配套hex文件";
            // 
            // button_ProgromInfo
            // 
            this.button_ProgromInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ProgromInfo.Location = new System.Drawing.Point(648, 51);
            this.button_ProgromInfo.Name = "button_ProgromInfo";
            this.button_ProgromInfo.Size = new System.Drawing.Size(109, 33);
            this.button_ProgromInfo.TabIndex = 21;
            this.button_ProgromInfo.Text = "使用说明";
            this.button_ProgromInfo.UseVisualStyleBackColor = true;
            this.button_ProgromInfo.Click += new System.EventHandler(this.button_ProgromInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 647);
            this.Controls.Add(this.button_ProgromInfo);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.textBox_WriteValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_WriteAddress);
            this.Controls.Add(this.button_WriteData);
            this.Controls.Add(this.button_ReBoot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_ReadDataOverTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_COMOpenOverTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_ReadData);
            this.Controls.Add(this.button_COMSwinch);
            this.Controls.Add(this.button_COMScanf);
            this.Controls.Add(this.comboBox_COMSelect);
            this.Name = "Form1";
            this.Text = "EEPROM读取";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_COMOpenOverTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ReadDataOverTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox_COMSelect;
        private System.Windows.Forms.Button button_COMScanf;
        private System.Windows.Forms.Button button_COMSwinch;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button_ReadData;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_COMOpenOverTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_ReadDataOverTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_ReBoot;
        private System.Windows.Forms.Button button_WriteData;
        private System.Windows.Forms.TextBox textBox_WriteAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_WriteValue;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button button_ProgromInfo;
    }
}

