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

        List<WaveData> receiveData = new List<WaveData>();
        List<double> a = new List<double>();
        Series series;
        int indexxx;
        int counttt;
        string SelectName;
        List<string> b = new List<string>();

        private Point mPoint;
        public Wave_Pattern()
        {
            InitializeComponent();

        }
        internal void ReceiveMsg(List<WaveData> wd, int indexx, int Count, string name, string program)
        {
            chart1.Width = 1246 + wd.Count() * 50;
            series = new Series();
            series = chart1.Series[0];
            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 2;
            series.Color = Color.Red;


            textBox2.Text = Count.ToString();
            receiveData = wd;
            SelectName = name;
            indexxx = indexx;
            counttt = Count;

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
                WaveDataShow.Clear();
                a.Clear();
                b.Clear();
            }


            for (int i = 0; i < receiveData.Count; i++)
            {

                b.Add(receiveData[i].datetime.ToString("HH:mm:ss"));
                if (program == "RAF")
                {
                    labelTimeStart.Text = receiveData[0].datetime.ToString("HH:mm:ss");
                    switch (SelectName)
                    {
                        case "Beam_Height_L":
                            a.Add(Convert.ToDouble(receiveData[i].Beam_Height_L[indexxx - 1]));
                            WaveDataShow.Text += (i + 1) + ": " + receiveData[i].datetime.ToString("HH:mm:ss") + "  " + Convert.ToDouble(receiveData[i].Beam_Height_L[indexxx - 1]) + "\n";
                            series.LegendText = "Beam_Height_L";
                            label2.Text = "第" + indexxx + "个Beam_Height_L数据";
                            break;
                        case "Beam_Height_R":
                            a.Add(Convert.ToDouble(receiveData[i].Beam_Height_R[indexxx - 1]));
                            WaveDataShow.Text += (i + 1) + ": " + receiveData[i].datetime.ToString("HH:mm:ss") + "  " + Convert.ToDouble(receiveData[i].Beam_Height_R[indexxx - 1]) + "\n";
                            series.LegendText = "Beam_Height_R";
                            label2.Text = "第" + indexxx + "个Beam_Height_R数据";
                            break;
                        case "Beam_Height_Difference":
                            a.Add(Convert.ToDouble(receiveData[i].Beam_Height_Difference[indexxx - 1]));
                            WaveDataShow.Text += (i + 1) + ": " + receiveData[i].datetime.ToString("HH:mm:ss") + "  " + Convert.ToDouble(receiveData[i].Beam_Height_Difference[indexxx - 1]) + "\n";
                            series.LegendText = "Beam_Height_Difference";
                            label2.Text = "第" + indexxx + "个Beam_Height_Difference数据";
                            break;
                        case "Shield_Flatness":
                            a.Add(Convert.ToDouble(receiveData[i].Shield_Flatness[indexxx - 1]));
                            WaveDataShow.Text += (i + 1) + ": " + receiveData[i].datetime.ToString("HH:mm:ss") + "  " + Convert.ToDouble(receiveData[i].Shield_Flatness[indexxx - 1]) + "\n";
                            series.LegendText = "Shield_Flatness";
                            label2.Text = "第" + indexxx + "个Shield_Flatness数据";
                            break;
                        case "Cross_Shield_TP":
                            a.Add(Convert.ToDouble(receiveData[i].Cross_Shield_TP[indexxx - 1]));
                            WaveDataShow.Text += (i + 1) + ": " + receiveData[i].datetime.ToString("HH:mm:ss") + "  " + Convert.ToDouble(receiveData[i].Cross_Shield_TP[indexxx - 1]) + "\n";
                            series.LegendText = "Cross_Shield_TP";
                            label2.Text = "第" + indexxx + "个Cross_Shield_TP数据";
                            break;
                        case "Wafer_Thickness":
                            a.Add(Convert.ToDouble(receiveData[i].Wafer_Thickness[indexxx - 1]));
                            WaveDataShow.Text += (i + 1) + ": " + receiveData[i].datetime.ToString("HH:mm:ss") + "  " + Convert.ToDouble(receiveData[i].Wafer_Thickness[indexxx - 1]) + "\n";
                            series.LegendText = "Wafer_Thickness";
                            label2.Text = "第" + indexxx + "个Wafer_Thickness数据";
                            break;
                        case "Shield_Cross_Angle":
                            a.Add(Convert.ToDouble(receiveData[i].Shield_Cross_Angle[indexxx - 1]));
                            WaveDataShow.Text += (i + 1) + ": " + receiveData[i].datetime.ToString("HH:mm:ss") + "  " + Convert.ToDouble(receiveData[i].Shield_Cross_Angle[indexxx - 1]) + "\n";
                            series.LegendText = "Shield_Cross_Angle";
                            label2.Text = "第" + indexxx + "个Shield_Cross_Angle数据";
                            break;

                    }
                    if (i == receiveData.Count - 1)
                    {
                        labelTimeEnd.Text = receiveData[i].datetime.ToString("HH:mm:ss");
                    }
                    chart1.Series[0].Points.DataBindXY(b, a);
                    ChartArea chartarea1 = chart1.ChartAreas[0];
                    chartarea1.AxisX.Minimum = 0;
                    chartarea1.AxisY.Minimum = -1d;
                }
                else if (program == "DO")
                {
                    labelTimeStart.Text = receiveData[0].datetime.ToString("HH:mm:ss");
                    switch (SelectName)
                    {
                        case "Beam_Height_L":
                            a.Add(Convert.ToDouble(receiveData[i].Beam_Height_L[indexxx - 1]));
                            WaveDataShow.Text += (i + 1) + ": " + receiveData[i].datetime.ToString("HH:mm:ss") + "  " + Convert.ToDouble(receiveData[i].Beam_Height_L[indexxx - 1]) + "\n";
                            series.LegendText = "Beam_Height_L";
                            label2.Text = "第" + indexxx + "个Beam_Height_L数据";
                            break;
                        case "Beam_Height_R":
                            a.Add(Convert.ToDouble(receiveData[i].Beam_Height_R[indexxx - 1]));
                            WaveDataShow.Text += (i + 1) + ": " + receiveData[i].datetime.ToString("HH:mm:ss") + "  " + Convert.ToDouble(receiveData[i].Beam_Height_R[indexxx - 1]) + "\n";
                            series.LegendText = "Beam_Height_R";
                            label2.Text = "第" + indexxx + "个Beam_Height_R数据";
                            break;
                        case "Beam_Height_Difference":
                            a.Add(Convert.ToDouble(receiveData[i].Beam_Height_Difference[indexxx - 1]));
                            WaveDataShow.Text += (i + 1) + ": " + receiveData[i].datetime.ToString("HH:mm:ss") + "  " + Convert.ToDouble(receiveData[i].Beam_Height_Difference[indexxx - 1]) + "\n";
                            series.LegendText = "Beam_Height_Difference";
                            label2.Text = "第" + indexxx + "个Beam_Height_Difference数据";
                            break;
                        case "Shield_Flatness":
                            a.Add(Convert.ToDouble(receiveData[i].Shield_Flatness[indexxx - 1]));
                            WaveDataShow.Text += (i + 1) + ": " + receiveData[i].datetime.ToString("HH:mm:ss") + "  " + Convert.ToDouble(receiveData[i].Shield_Flatness[indexxx - 1]) + "\n";
                            series.LegendText = "Shield_Plate_Flatness";
                            label2.Text = "第" + indexxx + "个Shield_Plate_Flatness数据";
                            break;
                        case "Cross_Shield_TP":
                            a.Add(Convert.ToDouble(receiveData[i].Cross_Shield_TP[indexxx - 1]));
                            WaveDataShow.Text += (i + 1) + ": " + receiveData[i].datetime.ToString("HH:mm:ss") + "  " + Convert.ToDouble(receiveData[i].Cross_Shield_TP[indexxx - 1]) + "\n";
                            series.LegendText = "Shield_Plate_To_Tower";
                            label2.Text = "第" + indexxx + "个Shield_Plate_To_Tower数据";
                            break;
                        case "Wafer_Thickness":
                            a.Add(Convert.ToDouble(receiveData[i].Wafer_Thickness[indexxx - 1]));
                            WaveDataShow.Text += (i + 1) + ": " + receiveData[i].datetime.ToString("HH:mm:ss") + "  " + Convert.ToDouble(receiveData[i].Wafer_Thickness[indexxx - 1]) + "\n";
                            series.LegendText = "Shield_Blade_TP";
                            label2.Text = "第" + indexxx + "个Shield_Blade_TP数据";
                            break;
                        case "Shield_Cross_Angle":
                            a.Add(Convert.ToDouble(receiveData[i].Shield_Cross_Angle[indexxx - 1]));
                            WaveDataShow.Text += (i + 1) + ": " + receiveData[i].datetime.ToString("HH:mm:ss") + "  " + Convert.ToDouble(receiveData[i].Shield_Cross_Angle[indexxx - 1]) + "\n";
                            series.LegendText = "Angle";
                            label2.Text = "第" + indexxx + "个Shield_Cross_Angle数据";
                            break;
                    }
                    if (i == receiveData.Count - 1)
                    {
                        labelTimeEnd.Text = receiveData[i].datetime.ToString("HH:mm:ss");
                    }
                    chart1.Series[0].Points.DataBindXY(b, a);

                    ChartArea chartarea1 = chart1.ChartAreas[0];
                    chartarea1.AxisX.Minimum = 0;
                    chartarea1.AxisY.Minimum = -1d;
                }
            }
            panel2.HorizontalScroll.Value = panel2.HorizontalScroll.Maximum;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Wave_Pattern_Load(object sender, EventArgs e)
        {
        }

        private void Wave_Pattern_FormClosing(object sender, FormClosingEventArgs e)
        {
            series.LegendText = " ";
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
                WaveDataShow.Clear();
                a.Clear();
                b.Clear();
            }
            this.Hide();
            e.Cancel = true;
        }

        private void Wave_Pattern_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void Wave_Pattern_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //WaveDataShow.SelectionStart = WaveDataShow.Text.Length;
            //WaveDataShow.ScrollToCaret();
        }
    }
}
