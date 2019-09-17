namespace Jet_System.CustomerUserControl
{
    partial class UserControlSetMaxAndMin
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSetMax = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetMin = new System.Windows.Forms.Button();
            this.txtOffer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetOffer = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetRate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetMax
            // 
            this.btnSetMax.Location = new System.Drawing.Point(77, 60);
            this.btnSetMax.Name = "btnSetMax";
            this.btnSetMax.Size = new System.Drawing.Size(75, 23);
            this.btnSetMax.TabIndex = 0;
            this.btnSetMax.Text = "设定";
            this.btnSetMax.UseVisualStyleBackColor = true;
            this.btnSetMax.Click += new System.EventHandler(this.btnSetMax_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "最大";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(61, 22);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 21);
            this.txtMax.TabIndex = 2;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(61, 103);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 21);
            this.txtMin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "最小";
            // 
            // btnSetMin
            // 
            this.btnSetMin.Location = new System.Drawing.Point(77, 141);
            this.btnSetMin.Name = "btnSetMin";
            this.btnSetMin.Size = new System.Drawing.Size(75, 23);
            this.btnSetMin.TabIndex = 3;
            this.btnSetMin.Text = "设定";
            this.btnSetMin.UseVisualStyleBackColor = true;
            this.btnSetMin.Click += new System.EventHandler(this.btnSetMin_Click);
            // 
            // txtOffer
            // 
            this.txtOffer.Location = new System.Drawing.Point(61, 175);
            this.txtOffer.Name = "txtOffer";
            this.txtOffer.Size = new System.Drawing.Size(100, 21);
            this.txtOffer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "偏移";
            // 
            // btnSetOffer
            // 
            this.btnSetOffer.Location = new System.Drawing.Point(77, 213);
            this.btnSetOffer.Name = "btnSetOffer";
            this.btnSetOffer.Size = new System.Drawing.Size(75, 23);
            this.btnSetOffer.TabIndex = 6;
            this.btnSetOffer.Text = "设定";
            this.btnSetOffer.UseVisualStyleBackColor = true;
            this.btnSetOffer.Click += new System.EventHandler(this.btnSetOffer_Click);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(61, 254);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 21);
            this.txtRate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "比例系数";
            // 
            // btnSetRate
            // 
            this.btnSetRate.Location = new System.Drawing.Point(77, 281);
            this.btnSetRate.Name = "btnSetRate";
            this.btnSetRate.Size = new System.Drawing.Size(75, 23);
            this.btnSetRate.TabIndex = 11;
            this.btnSetRate.Text = "设定";
            this.btnSetRate.UseVisualStyleBackColor = true;
            this.btnSetRate.Click += new System.EventHandler(this.btnSetRate_Click);
            // 
            // UserControlSetMaxAndMin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSetRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtOffer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSetOffer);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSetMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetMax);
            this.Name = "UserControlSetMaxAndMin";
            this.Size = new System.Drawing.Size(164, 320);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetMin;
        private System.Windows.Forms.TextBox txtOffer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetOffer;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetRate;
    }
}
