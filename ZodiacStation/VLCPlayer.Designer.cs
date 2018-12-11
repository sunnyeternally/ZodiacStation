namespace ZodiacStation
{
    partial class VLCPlayer
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
            this.Video = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Video)).BeginInit();
            this.SuspendLayout();
            // 
            // Video
            // 
            this.Video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Video.Location = new System.Drawing.Point(0, 0);
            this.Video.Margin = new System.Windows.Forms.Padding(0);
            this.Video.Name = "Video";
            this.Video.Size = new System.Drawing.Size(1389, 726);
            this.Video.TabIndex = 0;
            this.Video.TabStop = false;
            // 
            // VLCPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Video);
            this.Name = "VLCPlayer";
            this.Size = new System.Drawing.Size(1389, 726);
            this.Load += new System.EventHandler(this.VLCPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Video)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Video;
    }
}
