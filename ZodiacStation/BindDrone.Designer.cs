namespace ZodiacStation
{
    partial class BindDrone
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
            this.Opacity = 0.9;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Bind = new MaterialSkin.Controls.MaterialFlatButton();
            this.Cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 520);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 64);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 456);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.Bind);
            this.panel4.Location = new System.Drawing.Point(55, 363);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 40);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.Cancel);
            this.panel5.Location = new System.Drawing.Point(325, 363);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(140, 40);
            this.panel5.TabIndex = 1;
            // 
            // Bind
            // 
            this.Bind.AutoSize = true;
            this.Bind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bind.Depth = 0;
            this.Bind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bind.Icon = null;
            this.Bind.Location = new System.Drawing.Point(0, 0);
            this.Bind.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Bind.MouseState = MaterialSkin.MouseState.HOVER;
            this.Bind.Name = "Bind";
            this.Bind.Primary = false;
            this.Bind.Size = new System.Drawing.Size(140, 40);
            this.Bind.TabIndex = 0;
            this.Bind.Text = "Bind";
            this.Bind.UseVisualStyleBackColor = true;
            this.Bind.Click += new System.EventHandler(this.Bind_Click);
            // 
            // Cancel
            // 
            this.Cancel.AutoSize = true;
            this.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancel.Depth = 0;
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel.Icon = null;
            this.Cancel.Location = new System.Drawing.Point(0, 0);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cancel.Name = "Cancel";
            this.Cancel.Primary = false;
            this.Cancel.Size = new System.Drawing.Size(140, 40);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // BindDrone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 520);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BindDrone";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BindDrone";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialFlatButton Cancel;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialFlatButton Bind;
    }
}