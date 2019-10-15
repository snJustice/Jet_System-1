using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Jet_System.Utils;
using System.Windows.Forms.DataVisualization.Charting;

namespace Jet_System
{

    public partial class Wave_Pattern : Form
    {
        public event EventHandler UpdateData;

        List<WaveData> data = new List<WaveData>();
        List<double> a = new List<double>();
        Series series;
        int indexxx;
        int counttt;
        string Name;
        List<string> b = new List<string>();
        public Wave_Pattern()
        {
            InitializeComponent();

        


        }
        internal  void ReceiveMsg(List<WaveData> wd, int indexx, int Count, string name)
        {
            series = new Series();
            series = chart1.Series[0];
            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 2;
            series.Color = Color.Red;
           

            textBox2.Text = Count.ToString();
            data = wd;
            Name = name;
            indexxx = indexx;
            counttt = Count;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
                richTextBox1.Clear();
                a.Clear();
                b.Clear();
            }


            for (int i = 0; i < data.Count; i++)
            {
                b.Add(data[i].datetime.ToString("HH:mm:ss"));
                switch (Name)
                {
                    


                    case "Beam_Height_L":
                        a.Add(Convert.ToDouble(data[i].Beam_Height_L[indexxx]));
                        richTextBox1.Text += Convert.ToDouble(data[i].Beam_Height_L[indexxx]) + "\n";
                        series.LegendText = "Beam_Height_L";
                        textBox1.Text = a.Count.ToString();
                        break;
                    case "Beam_Height_R":
                        a.Add(Convert.ToDouble(data[i].Beam_Height_R[indexxx]));
                        richTextBox1.Text += Convert.ToDouble(data[i].Beam_Height_R[indexxx]) + "\n";
                        textBox1.Text = a.Count.ToString();
                        series.LegendText = "Beam_Height_R";
                        break;
                    case "Beam_Height_Difference":
                        a.Add(Convert.ToDouble(data[i].Beam_Height_Difference[indexxx]));
                        richTextBox1.Text += Convert.ToDouble(data[i].Beam_Height_Difference[indexxx]) + "\n";
                        textBox1.Text = a.Count.ToString();
                        series.LegendText = "Beam_Height_Difference";
                        break;
                    case "Shield_Flatness":
                        a.Add(Convert.ToDouble(data[i].Shield_Flatness[indexxx]));
                        richTextBox1.Text += Convert.ToDouble(data[i].Shield_Flatness[indexxx]) + "\n";
                        textBox1.Text = a.Count.ToString();
                        series.LegendText = "Shield_Flatness";
                        break;
                    case "Cross_Shield_TP":
                        a.Add(Convert.ToDouble(data[i].Cross_Shield_TP[indexxx]));
                        richTextBox1.Text += Convert.ToDouble(data[i].Cross_Shield_TP[indexxx]) + "\n";
                        textBox1.Text = a.Count.ToString();
                        series.LegendText = "Cross_Shield_TP";
                        break;
                    case "Wafer_Thickness":
                        a.Add(Convert.ToDouble(data[i].Wafer_Thickness[indexxx]));
                        richTextBox1.Text += Convert.ToDouble(data[i].Wafer_Thickness[indexxx]) + "\n";
                        textBox1.Text = a.Count.ToString();
                        series.LegendText = "Wafer_Thickness";
                        break;
                    case "Shield_Cross_Angle":
                        a.Add(Convert.ToDouble(data[i].Shield_Cross_Angle[indexxx]));
                        richTextBox1.Text += Convert.ToDouble(data[i].Shield_Cross_Angle[indexxx]) + "\n";
                        textBox1.Text = a.Count.ToString();
                        series.LegendText = "Shield_Cross_Angle";
                        break;


                }
                chart1.Series[0].Points.DataBindXY(b, a);
                ChartArea chartarea1 = chart1.ChartAreas[0];
                chartarea1.AxisX.Minimum = 0;
                chartarea1.AxisY.Minimum = 0d;
            }

            }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string btn_name = btn.Text;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
                richTextBox1.Clear();
                a.Clear();
                b.Clear();
            }


            for (int i = 0; i < data.Count; i++)
            {
                b.Add(data[i].datetime.ToString("yyyy-MM-dd"));
                switch (btn_name)
                {

                    case "Beam_Height_L":
                        a.Add(Convert.ToDouble(data[i].Beam_Height_L[indexxx]));
                        richTextBox1.Text += Convert.ToDouble(data[i].Beam_Height_L[indexxx]) + "\n";
                        textBox1.Text = a.Count.ToString();
                        break;
                    case "Beam_Height_R":
                        a.Add(Convert.ToDouble(data[i].Beam_Height_R[indexxx]));
                        richTextBox1.Text += Convert.ToDouble(data[i].Beam_Height_R[indexxx]) + "\n";
                        textBox1.Text = a.Count.ToString();
                        break;
                    case "Beam_Height_Difference":
                        a.Add(Convert.ToDouble(data[i].Beam_Height_Difference[indexxx]));
                        richTextBox1.Text += Convert.ToDouble(data[i].Beam_Height_Difference[indexxx]) + "\n";
                        textBox1.Text = a.Count.ToString();
                        break;
                    case "Shield_Flatness":
                        a.Add(Convert.ToDouble(data[i].Shield_Flatness[indexxx]));
                        richTextBox1.Text += Convert.ToDouble(data[i].Shield_Flatness[indexxx]) + "\n";
                        textBox1.Text = a.Count.ToString();
                        break;
                    case "Cross_Shield_TP":
                        a.Add(Convert.ToDouble(data[i].Cross_Shield_TP[indexxx]));
                        richTextBox1.Text += Convert.ToDouble(data[i].Cross_Shield_TP[indexxx]) + "\n";
                        textBox1.Text = a.Count.ToString();
                        break;
                    case "Wafer_Thickness":
                        a.Add(Convert.ToDouble(data[i].Wafer_Thickness[indexxx]));
                        richTextBox1.Text += Convert.ToDouble(data[i].Wafer_Thickness[indexxx]) + "\n";
                        textBox1.Text = a.Count.ToString();
                        break;
                    case "Shield_Cross_Angle":
                        a.Add(Convert.ToDouble(data[i].Shield_Cross_Angle[indexxx]));
                        richTextBox1.Text += Convert.ToDouble(data[i].Shield_Cross_Angle[indexxx]) + "\n";
                        textBox1.Text = a.Count.ToString();
                        break;
                }
                chart1.Series[0].Points.DataBindXY(b, a);
                ChartArea chartarea1 = chart1.ChartAreas[0];
                chartarea1.AxisX.Minimum = 0;
                chartarea1.AxisY.Minimum = 0d;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void Wave_Pattern_Load(object sender, EventArgs e)
        {     
        }

        private void Wave_Pattern_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; 
        }
    }
}
