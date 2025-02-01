using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UART_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string cadena = "0000 0000 0000 0000";
        string RxData = "0000 0000 0000 0000";
        double x;
        int On_SetPoint = 0;


        private void Form1_Load(object sender, EventArgs e)

        {

            try
            {
                cmbBxPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                cmbBxPort.SelectedIndex = 1;
                cmboxBaudRate.SelectedIndex = 1;
                //sp.PortName = "COM4";
                sp.BaudRate = 115200;
                sp.ReadTimeout = 2000;
                sp.WriteTimeout = 2000;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            tm.Tick += tm_Tick;
            tm.Interval = 50;
            
            //tm.Start();

            chart1.Series.Add("Salida");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].Color = Color.Green;
            chart1.Series[0].BorderWidth = 2;

            chart1.Series.Add("Set Point");
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[1].Color = Color.Red;
            chart1.Series[0].BorderWidth = 2;
        }

        private void cmbBxPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttnConnect_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                try { 
                sp.PortName = cmbBxPort.Text;
                sp.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //txtBxInput.Text = sp.ReadLine();
            //tm.Enabled = true;
            bttnConnect.BackColor = Color.LightGreen;
        }

        private void bttnDisconnect_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
                sp.Close();
            //txtBxInput.Clear();
            tm.Enabled = false;
            bttnConnect.BackColor = Color.Transparent;
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
                sp.Open();
            
            var RxData = sp.ReadLine();
            txtBxInput.Text = RxData;
            Thread.Sleep(50);

            chart1.Series[0].Points.AddXY(x, RxData);
            chart1.Series[1].Points.AddXY(x, On_SetPoint);
           
            if (chart1.Series[0].Points.Count>100)
                chart1.Series[0].Points.RemoveAt(0);

            chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = x;

            chart1.ChartAreas[0].AxisY.Maximum = 120;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            chart1.ChartAreas[0].AxisY.Interval = 20;
            chart1.ChartAreas[0].AxisX.RoundAxisValues();
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.0";

            x += 0.1;
    
            //var subCadena = cadena.Split(',');
            //Invoke((MethodInvoker)(() => DisplayData(subCadena[0], subCadena[1])));


            //sp.Close();
        }
        private void DisplayData(string temperatura, string humedad)
        {
            //txtBxTemp.Text = temperatura;
            //aGauge1.Value = float.Parse(temperatura) / 10;
            //txtBxHum.Text = humedad;
            //aGauge1.Value = float.Parse(humedad) / 10;
        }

        private void txtBxOutput_TextChanged(object sender, EventArgs e)
        {
        }

        private void bttnUpDate_Click(object sender, EventArgs e)
        {
            //char character = cadena[0];
            string str1, str2, str3, str4;
            int num;
            //string str = "Hello";
            //char[] chars = { 'a', ' ', 's', 't', 'r', 'i', 'n', 'g' };
            //char[] characters = cadena.ToCharArray();

            
            num = (int)(numUpDownSetPoint.Value * 10);
            str1 = num.ToString();
            if (num < 100) { str1 = string.Concat("00", str1); }
            else if (num < 1000) { str1 = string.Concat("0", str1); }

            num = (int)(numericUpDownKp.Value * 100);
            str2 = num.ToString();
            if (num < 100) { str2 = string.Concat("00", str2);}
            else if (num < 1000) { str2 = string.Concat("0", str2);}

            num = (int)(numericUpDownKi.Value * 100);
            str3 = num.ToString();
            if (num < 100) { str3 = string.Concat("00", str3);}
            else if (num < 1000) { str3 = string.Concat("0", str3);}

            num = (int)(numericUpDownKd.Value * 100);
            str4 = num.ToString();
            if (num < 100) { str4 = string.Concat("00", str4);}
            else if (num < 1000) { str4 = string.Concat("0", str4);}

            cadena = string.Concat( str1, str2, str3, str4);
            txtBxOutput.Text = cadena;

            if (!sp.IsOpen)
                sp.Open();
            sp.WriteLine(cadena);
            Thread.Sleep(100);

            On_SetPoint = (int)numUpDownSetPoint.Value;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bttnOFF_Click(object sender, EventArgs e)
        {
            cadena = "0000000000000000";
            txtBxOutput.Text = cadena;
            if (!sp.IsOpen)
                sp.Open();
            sp.WriteLine(cadena);
            Thread.Sleep(100);
        }

        private void txtBxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnStart_Click(object sender, EventArgs e)
        {
            if (tm.Enabled)
            {
                tm.Stop();
                bttnStart.Text = "Start";
            }

            else
            {
                tm.Start();
                bttnStart.Text = "Stop";
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void numUpDownSetPoint_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
