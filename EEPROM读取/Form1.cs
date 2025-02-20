using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEPROM读取
{
    public partial class Form1 : Form
    {
        string[] ports;

        private void ClearTempData()
        {
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
        }
        private void COMRefresh()
        {
            try
            {
                ports = System.IO.Ports.SerialPort.GetPortNames();
            }
            catch (Exception)
            {
                timer1.Enabled = false;
                throw;
            }

            try
            {
                foreach (var item in comboBox_COMSelect.Items)
                {
                    if (!ports.Contains(item.ToString()))
                    {
                        comboBox_COMSelect.Items.Remove(item);
                    }
                }
                foreach (var item in ports)
                {
                    if (!comboBox_COMSelect.Items.Contains(item))
                    {
                        comboBox_COMSelect.Items.Add(item);
                    }
                }
            }
            catch (System.InvalidOperationException) { }

            if (comboBox_COMSelect.SelectedItem == null && comboBox_COMSelect.Items.Count > 0)
            {
                comboBox_COMSelect.SelectedIndex = 0;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            COMRefresh();
        }

        private void button_COMScanf_Click(object sender, EventArgs e)
        {
            COMRefresh();
        }

        private void button_COMSwinch_Click(object sender, EventArgs e)
        {
            if (button_COMSwinch.Text == "打开串口")
            {
                if (comboBox_COMSelect.SelectedItem == null)
                {
                    return;
                }

                try
                {
                    serialPort1.PortName = comboBox_COMSelect.SelectedItem.ToString();
                    serialPort1.Open();

                    ClearTempData();
                    serialPort1.Write("CMDC\0\0\0\0\0\0".ToCharArray(), 0, 10);
                    serialPort1.ReadTimeout = (int)numericUpDown_COMOpenOverTime.Value * 1000;
                    if (!serialPort1.ReadTo("CommandEnd").Contains("EEPROM Program V1"))
                    {
                        throw new Exception("通讯失败。");
                    }

                    button_COMSwinch.Text = "关闭串口";
                    comboBox_COMSelect.Enabled = false;
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"串口打开失败:{ex.Message}", "串口打开失败");
                    serialPort1.Close();
                    button_COMSwinch.Text = "打开串口";
                    timer1.Enabled = true;
                    timer2.Enabled = false;
                    comboBox_COMSelect.Enabled = true;
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception) { }
                finally
                {
                    button_COMSwinch.Text = "打开串口";
                    timer1.Enabled = true;
                    timer2.Enabled = false;
                    comboBox_COMSelect.Enabled = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                button_COMSwinch_Click(sender, e);
                return;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Debug.WriteLine("DataReceived");
        }

        private void button_ReadData_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.AppendText("\t 0  1  2  3  4  5  6  7  8  9  A  B  C  D  E  F\n");
            richTextBox1.SelectionColor = Color.Black;

            if (!serialPort1.IsOpen)
            {
                button_COMSwinch_Click(sender, e);
            }
            if (!serialPort1.IsOpen)
            {
                return;
            }
            ClearTempData();
            serialPort1.Write("CMDR\0\0\0\0\0\0".ToCharArray(), 0, 10);
            serialPort1.ReadTimeout = (int)numericUpDown_ReadDataOverTime.Value * 1000;
            string data = null;
            try
            {
                data = serialPort1.ReadTo("CommandEnd");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"读取失败:{ex.Message}", "读取失败");
            }
            if (data == null)
            {
                return;
            }
            string[] datas = data.Split(' ');
            for (int i = 0; i < datas.Length - 1;)
            {
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.AppendText($"{i:X}H \t");
                richTextBox1.SelectionColor = Color.Black;
                for (int j = i + 16; (i < j) && (i < datas.Length - 1); i++)
                {
                    richTextBox1.AppendText($"{datas[i].Split(':')[1]} ");
                }
                richTextBox1.AppendText("\n");
            }
            label_Info.Text = "读取数据完毕";
        }

        private void button_ReBoot_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                return;
            }
            byte[] data = new byte[10];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = 0xF8;
            }
            serialPort1.Write(data, 0, 10);
        }

        private void button_WriteData_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                return;
            }
            byte[] data = new byte[10];
            data[0] = (byte)'C';
            data[1] = (byte)'M';
            data[2] = (byte)'D';
            data[3] = (byte)'W';
            try
            {
                data[4] = Convert.ToByte(textBox_WriteAddress.Text, 16);
                data[5] = Convert.ToByte(textBox_WriteValue.Text, 16);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"转换出现错误：{ex.Message}", "转换错误");
                return;
            }
            data[6] = (byte)(data[0] ^ data[1] ^ data[2] ^ data[3] ^ data[4] ^ data[5]);
            Debug.WriteLine(data[6].ToString());
            serialPort1.Write(data, 0, 10);

            serialPort1.ReadTimeout = (int)numericUpDown_ReadDataOverTime.Value * 1000;
            ClearTempData();
            string recdata;
            try
            {
                recdata = serialPort1.ReadTo("CommandEnd");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"读取失败:{ex.Message}", "读取失败");
                return;
            }


            if (recdata.Contains("WriteDone"))
            {
                label_Info.Text = $"向地址{data[4]:X}写入数据{data[5]:X}成功";
                return;
            }
            else if (recdata.Contains("WriteCheckError"))
            {
                MessageBox.Show("写入失败：校验错误", "写入失败");
            }
            else
            {
                MessageBox.Show($"未知错误{recdata}", "写入失败");
            }
        }

        private void button_ProgromInfo_Click(object sender, EventArgs e)
        {
            Form form = new 使用说明();
            form.ShowDialog();
        }
    }
}
