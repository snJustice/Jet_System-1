namespace Jet_System.CustomerUserControl
{
    partial class CustomerLight
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
            this.led = new LEDLib.LEDControl();
            this.lblNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // led
            // 
            this.led.LEDCenterColor = System.Drawing.Color.LightYellow;
            this.led.LEDCircleColor = System.Drawing.Color.Gray;
            this.led.LEDClickEnable = true;
            this.led.LEDSurroundColor = System.Drawing.Color.Yellow;
            this.led.LEDSwitch = true;
            this.led.Location = new System.Drawing.Point(7, 3);
            this.led.Name = "led";
            this.led.Size = new System.Drawing.Size(20, 20);
            this.led.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 26);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(11, 12);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "1";
            // 
            // CustomerLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.led);
            this.Name = "CustomerLight";
            this.Size = new System.Drawing.Size(42, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LEDLib.LEDControl led;
        private System.Windows.Forms.Label lblNumber;
    }
}
