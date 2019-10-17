namespace Jet_System
{
    partial class Wave_Pattern
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.WaveDataShow = new System.Windows.Forms.RichTextBox();
            this.chart_Beam_Height_L = new System.Windows.Forms.Button();
            this.chart_Beam_Height_R = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chart_Beam_Height_Difference = new System.Windows.Forms.Button();
            this.chart_Shield_Flatness = new System.Windows.Forms.Button();
            this.chart_Cross_Shield_TP = new System.Windows.Forms.Button();
            this.chart_Wafer_Thickness = new System.Windows.Forms.Button();
            this.chart_Shield_Cross_Angle = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTimeEnd = new System.Windows.Forms.Label();
            this.labelTimeStart = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 14);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.MarkerStep = 2;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1247, 406);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(916, 539);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // WaveDataShow
            // 
            this.WaveDataShow.Location = new System.Drawing.Point(6, 41);
            this.WaveDataShow.Name = "WaveDataShow";
            this.WaveDataShow.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.WaveDataShow.Size = new System.Drawing.Size(225, 442);
            this.WaveDataShow.TabIndex = 2;
            this.WaveDataShow.Text = "";
            this.WaveDataShow.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // chart_Beam_Height_L
            // 
            this.chart_Beam_Height_L.Location = new System.Drawing.Point(11, 537);
            this.chart_Beam_Height_L.Name = "chart_Beam_Height_L";
            this.chart_Beam_Height_L.Size = new System.Drawing.Size(122, 23);
            this.chart_Beam_Height_L.TabIndex = 3;
            this.chart_Beam_Height_L.Text = "Beam_Height_L";
            this.chart_Beam_Height_L.UseVisualStyleBackColor = true;
            this.chart_Beam_Height_L.Visible = false;
            this.chart_Beam_Height_L.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart_Beam_Height_R
            // 
            this.chart_Beam_Height_R.Location = new System.Drawing.Point(139, 537);
            this.chart_Beam_Height_R.Name = "chart_Beam_Height_R";
            this.chart_Beam_Height_R.Size = new System.Drawing.Size(122, 23);
            this.chart_Beam_Height_R.TabIndex = 5;
            this.chart_Beam_Height_R.Text = "Beam_Height_R";
            this.chart_Beam_Height_R.UseVisualStyleBackColor = true;
            this.chart_Beam_Height_R.Visible = false;
            this.chart_Beam_Height_R.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1057, 540);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 21);
            this.textBox2.TabIndex = 9;
            this.textBox2.Visible = false;
            // 
            // chart_Beam_Height_Difference
            // 
            this.chart_Beam_Height_Difference.Location = new System.Drawing.Point(267, 537);
            this.chart_Beam_Height_Difference.Name = "chart_Beam_Height_Difference";
            this.chart_Beam_Height_Difference.Size = new System.Drawing.Size(122, 23);
            this.chart_Beam_Height_Difference.TabIndex = 10;
            this.chart_Beam_Height_Difference.Text = "Beam_Height_Difference";
            this.chart_Beam_Height_Difference.UseVisualStyleBackColor = true;
            this.chart_Beam_Height_Difference.Visible = false;
            this.chart_Beam_Height_Difference.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart_Shield_Flatness
            // 
            this.chart_Shield_Flatness.Location = new System.Drawing.Point(395, 537);
            this.chart_Shield_Flatness.Name = "chart_Shield_Flatness";
            this.chart_Shield_Flatness.Size = new System.Drawing.Size(122, 23);
            this.chart_Shield_Flatness.TabIndex = 11;
            this.chart_Shield_Flatness.Text = "Shield_Flatness";
            this.chart_Shield_Flatness.UseVisualStyleBackColor = true;
            this.chart_Shield_Flatness.Visible = false;
            this.chart_Shield_Flatness.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart_Cross_Shield_TP
            // 
            this.chart_Cross_Shield_TP.Location = new System.Drawing.Point(523, 537);
            this.chart_Cross_Shield_TP.Name = "chart_Cross_Shield_TP";
            this.chart_Cross_Shield_TP.Size = new System.Drawing.Size(122, 23);
            this.chart_Cross_Shield_TP.TabIndex = 12;
            this.chart_Cross_Shield_TP.Text = "Cross_Shield_TP";
            this.chart_Cross_Shield_TP.UseVisualStyleBackColor = true;
            this.chart_Cross_Shield_TP.Visible = false;
            this.chart_Cross_Shield_TP.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart_Wafer_Thickness
            // 
            this.chart_Wafer_Thickness.Location = new System.Drawing.Point(651, 537);
            this.chart_Wafer_Thickness.Name = "chart_Wafer_Thickness";
            this.chart_Wafer_Thickness.Size = new System.Drawing.Size(122, 23);
            this.chart_Wafer_Thickness.TabIndex = 13;
            this.chart_Wafer_Thickness.Text = "Wafer_Thickness";
            this.chart_Wafer_Thickness.UseVisualStyleBackColor = true;
            this.chart_Wafer_Thickness.Visible = false;
            this.chart_Wafer_Thickness.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart_Shield_Cross_Angle
            // 
            this.chart_Shield_Cross_Angle.Location = new System.Drawing.Point(779, 537);
            this.chart_Shield_Cross_Angle.Name = "chart_Shield_Cross_Angle";
            this.chart_Shield_Cross_Angle.Size = new System.Drawing.Size(122, 23);
            this.chart_Shield_Cross_Angle.TabIndex = 14;
            this.chart_Shield_Cross_Angle.Text = "Shield_Cross_Angle";
            this.chart_Shield_Cross_Angle.UseVisualStyleBackColor = true;
            this.chart_Shield_Cross_Angle.Visible = false;
            this.chart_Shield_Cross_Angle.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1159, 540);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 21);
            this.textBox3.TabIndex = 15;
            this.textBox3.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(18, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1519, 34);
            this.panel1.TabIndex = 16;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Wave_Pattern_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Wave_Pattern_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(70, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "历史数据";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WaveDataShow);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(1300, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 489);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelTimeEnd);
            this.groupBox2.Controls.Add(this.labelTimeStart);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1282, 489);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "波动图";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(876, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(1092, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "-";
            // 
            // labelTimeEnd
            // 
            this.labelTimeEnd.AutoSize = true;
            this.labelTimeEnd.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTimeEnd.Location = new System.Drawing.Point(1120, 17);
            this.labelTimeEnd.Name = "labelTimeEnd";
            this.labelTimeEnd.Size = new System.Drawing.Size(106, 21);
            this.labelTimeEnd.TabIndex = 21;
            this.labelTimeEnd.Text = "HH:MM:SS";
            // 
            // labelTimeStart
            // 
            this.labelTimeStart.AutoSize = true;
            this.labelTimeStart.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTimeStart.Location = new System.Drawing.Point(980, 17);
            this.labelTimeStart.Name = "labelTimeStart";
            this.labelTimeStart.Size = new System.Drawing.Size(106, 21);
            this.labelTimeStart.TabIndex = 20;
            this.labelTimeStart.Text = "HH:mm:SS";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(6, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1270, 441);
            this.panel2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(107, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "波动图";
            // 
            // Wave_Pattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1549, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.chart_Shield_Cross_Angle);
            this.Controls.Add(this.chart_Wafer_Thickness);
            this.Controls.Add(this.chart_Cross_Shield_TP);
            this.Controls.Add(this.chart_Shield_Flatness);
            this.Controls.Add(this.chart_Beam_Height_Difference);
            this.Controls.Add(this.chart_Beam_Height_L);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.chart_Beam_Height_R);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wave_Pattern";
            this.Text = "Wave_Pattern";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wave_Pattern_FormClosing);
            this.Load += new System.EventHandler(this.Wave_Pattern_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Wave_Pattern_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Wave_Pattern_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox WaveDataShow;
        private System.Windows.Forms.Button chart_Beam_Height_L;
        private System.Windows.Forms.Button chart_Beam_Height_R;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button chart_Beam_Height_Difference;
        private System.Windows.Forms.Button chart_Shield_Flatness;
        private System.Windows.Forms.Button chart_Cross_Shield_TP;
        private System.Windows.Forms.Button chart_Wafer_Thickness;
        private System.Windows.Forms.Button chart_Shield_Cross_Angle;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTimeEnd;
        private System.Windows.Forms.Label labelTimeStart;
        private System.Windows.Forms.Label label3;
    }
}