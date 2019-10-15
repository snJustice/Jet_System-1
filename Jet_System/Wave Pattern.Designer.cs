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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chart_Beam_Height_L = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chart_Beam_Height_R = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chart_Beam_Height_Difference = new System.Windows.Forms.Button();
            this.chart_Shield_Flatness = new System.Windows.Forms.Button();
            this.chart_Cross_Shield_TP = new System.Windows.Forms.Button();
            this.chart_Wafer_Thickness = new System.Windows.Forms.Button();
            this.chart_Shield_Cross_Angle = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1155, 437);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1310, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 21);
            this.textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1310, 103);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(237, 346);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // chart_Beam_Height_L
            // 
            this.chart_Beam_Height_L.Location = new System.Drawing.Point(1173, 30);
            this.chart_Beam_Height_L.Name = "chart_Beam_Height_L";
            this.chart_Beam_Height_L.Size = new System.Drawing.Size(122, 23);
            this.chart_Beam_Height_L.TabIndex = 3;
            this.chart_Beam_Height_L.Text = "Beam_Height_L";
            this.chart_Beam_Height_L.UseVisualStyleBackColor = true;
            this.chart_Beam_Height_L.Visible = false;
            this.chart_Beam_Height_L.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1463, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart_Beam_Height_R
            // 
            this.chart_Beam_Height_R.Location = new System.Drawing.Point(1173, 91);
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
            this.textBox2.Location = new System.Drawing.Point(1310, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 21);
            this.textBox2.TabIndex = 9;
            // 
            // chart_Beam_Height_Difference
            // 
            this.chart_Beam_Height_Difference.Location = new System.Drawing.Point(1173, 152);
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
            this.chart_Shield_Flatness.Location = new System.Drawing.Point(1173, 213);
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
            this.chart_Cross_Shield_TP.Location = new System.Drawing.Point(1173, 274);
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
            this.chart_Wafer_Thickness.Location = new System.Drawing.Point(1173, 335);
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
            this.chart_Shield_Cross_Angle.Location = new System.Drawing.Point(1173, 396);
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
            this.textBox3.Location = new System.Drawing.Point(1310, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 21);
            this.textBox3.TabIndex = 15;
            // 
            // Wave_Pattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1549, 471);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart_Shield_Cross_Angle);
            this.Controls.Add(this.chart_Wafer_Thickness);
            this.Controls.Add(this.chart_Cross_Shield_TP);
            this.Controls.Add(this.chart_Shield_Flatness);
            this.Controls.Add(this.chart_Beam_Height_Difference);
            this.Controls.Add(this.chart_Beam_Height_L);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.chart_Beam_Height_R);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Wave_Pattern";
            this.Text = "Wave_Pattern";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wave_Pattern_FormClosing);
            this.Load += new System.EventHandler(this.Wave_Pattern_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button chart_Beam_Height_L;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button chart_Beam_Height_R;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button chart_Beam_Height_Difference;
        private System.Windows.Forms.Button chart_Shield_Flatness;
        private System.Windows.Forms.Button chart_Cross_Shield_TP;
        private System.Windows.Forms.Button chart_Wafer_Thickness;
        private System.Windows.Forms.Button chart_Shield_Cross_Angle;
        private System.Windows.Forms.TextBox textBox3;
    }
}