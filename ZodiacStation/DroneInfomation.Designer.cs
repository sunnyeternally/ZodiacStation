namespace ZodiacStation
{
    partial class DroneInfomation
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
            this.BasicInfo = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // BasicInfo
            // 
            this.BasicInfo.AutoSize = true;
            this.BasicInfo.Depth = 0;
            this.BasicInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.BasicInfo.ForeColor = System.Drawing.Color.White;
            this.BasicInfo.Location = new System.Drawing.Point(3, 0);
            this.BasicInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BasicInfo.Name = "BasicInfo";
            this.BasicInfo.Size = new System.Drawing.Size(72, 19);
            this.BasicInfo.TabIndex = 0;
            this.BasicInfo.Text = "BasicInfo";
            // 
            // DroneInfomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.BasicInfo);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DroneInfomation";
            this.Size = new System.Drawing.Size(250, 250);
            this.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel BasicInfo;
    }
}
