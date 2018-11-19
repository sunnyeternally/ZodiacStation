using MaterialSkin;
using MaterialSkin.Controls;


namespace ZodiacStation
{
    partial class MainWindow
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Detail_Panel = new System.Windows.Forms.Panel();
            this.Ground = new System.Windows.Forms.Panel();
            this.DroneList_Panel2 = new System.Windows.Forms.Panel();
            this.DroneTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddDrone = new MaterialSkin.Controls.MaterialFlatButton();
            this.DroneList_Panel3 = new System.Windows.Forms.Panel();
            this.ShwoDronesBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.Detail = new System.Windows.Forms.Panel();
            this.Detail_Panel.SuspendLayout();
            this.Ground.SuspendLayout();
            this.DroneList_Panel2.SuspendLayout();
            this.DroneTable.SuspendLayout();
            this.DroneList_Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(145, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // Detail_Panel
            // 
            this.Detail_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Detail_Panel.Controls.Add(this.Ground);
            this.Detail_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Detail_Panel.Location = new System.Drawing.Point(0, 64);
            this.Detail_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Detail_Panel.Name = "Detail_Panel";
            this.Detail_Panel.Size = new System.Drawing.Size(1920, 1016);
            this.Detail_Panel.TabIndex = 1;
            // 
            // Ground
            // 
            this.Ground.Controls.Add(this.Detail);
            this.Ground.Controls.Add(this.DroneList_Panel2);
            this.Ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ground.Location = new System.Drawing.Point(0, 0);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1920, 1016);
            this.Ground.TabIndex = 2;
            // 
            // DroneList_Panel2
            // 
            this.DroneList_Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DroneList_Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DroneList_Panel2.Controls.Add(this.DroneTable);
            this.DroneList_Panel2.Controls.Add(this.DroneList_Panel3);
            this.DroneList_Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.DroneList_Panel2.Location = new System.Drawing.Point(0, 0);
            this.DroneList_Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.DroneList_Panel2.Name = "DroneList_Panel2";
            this.DroneList_Panel2.Size = new System.Drawing.Size(28, 1016);
            this.DroneList_Panel2.TabIndex = 1;
            // 
            // DroneTable
            // 
            this.DroneTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DroneTable.ColumnCount = 1;
            this.DroneTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DroneTable.Controls.Add(this.AddDrone, 0, 0);
            this.DroneTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.DroneTable.ForeColor = System.Drawing.Color.Transparent;
            this.DroneTable.Location = new System.Drawing.Point(0, 0);
            this.DroneTable.Margin = new System.Windows.Forms.Padding(0);
            this.DroneTable.Name = "DroneTable";
            this.DroneTable.RowCount = 2;
            this.DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 874F));
            this.DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DroneTable.Size = new System.Drawing.Size(0, 80);
            this.DroneTable.TabIndex = 2;
            this.DroneTable.Paint += new System.Windows.Forms.PaintEventHandler(this.DroneTable_Paint);
            // 
            // AddDrone
            // 
            this.AddDrone.AutoSize = true;
            this.AddDrone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddDrone.BackColor = System.Drawing.Color.White;
            this.AddDrone.Depth = 0;
            this.AddDrone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddDrone.Font = new System.Drawing.Font("苹方 常规", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddDrone.ForeColor = System.Drawing.Color.Transparent;
            this.AddDrone.Icon = null;
            this.AddDrone.Location = new System.Drawing.Point(0, 0);
            this.AddDrone.Margin = new System.Windows.Forms.Padding(0);
            this.AddDrone.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddDrone.Name = "AddDrone";
            this.AddDrone.Primary = false;
            this.AddDrone.Size = new System.Drawing.Size(1, 40);
            this.AddDrone.TabIndex = 0;
            this.AddDrone.Text = "＋";
            this.AddDrone.UseVisualStyleBackColor = false;
            this.AddDrone.Click += new System.EventHandler(this.AddDrone_Click);
            // 
            // DroneList_Panel3
            // 
            this.DroneList_Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.DroneList_Panel3.Controls.Add(this.ShwoDronesBtn);
            this.DroneList_Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.DroneList_Panel3.Location = new System.Drawing.Point(0, 0);
            this.DroneList_Panel3.Name = "DroneList_Panel3";
            this.DroneList_Panel3.Size = new System.Drawing.Size(28, 1016);
            this.DroneList_Panel3.TabIndex = 1;
            // 
            // ShwoDronesBtn
            // 
            this.ShwoDronesBtn.AutoSize = true;
            this.ShwoDronesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShwoDronesBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShwoDronesBtn.Depth = 0;
            this.ShwoDronesBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShwoDronesBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ShwoDronesBtn.Icon = null;
            this.ShwoDronesBtn.Location = new System.Drawing.Point(0, 0);
            this.ShwoDronesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ShwoDronesBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShwoDronesBtn.Name = "ShwoDronesBtn";
            this.ShwoDronesBtn.Primary = false;
            this.ShwoDronesBtn.Size = new System.Drawing.Size(28, 1016);
            this.ShwoDronesBtn.TabIndex = 1;
            this.ShwoDronesBtn.Text = "◀";
            this.ShwoDronesBtn.UseVisualStyleBackColor = false;
            this.ShwoDronesBtn.Click += new System.EventHandler(this.ShwoDronesBtn_Click);
            // 
            // Detail
            // 
            this.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Detail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Detail.Location = new System.Drawing.Point(28, 0);
            this.Detail.Margin = new System.Windows.Forms.Padding(0);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(1892, 1016);
            this.Detail.TabIndex = 0;
            this.Detail.Resize += new System.EventHandler(this.Detail_Resize);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Detail_Panel);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Zodiac Station";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Detail_Panel.ResumeLayout(false);
            this.Ground.ResumeLayout(false);
            this.DroneList_Panel2.ResumeLayout(false);
            this.DroneTable.ResumeLayout(false);
            this.DroneTable.PerformLayout();
            this.DroneList_Panel3.ResumeLayout(false);
            this.DroneList_Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Detail_Panel;
        private System.Windows.Forms.Panel Ground;
        private System.Windows.Forms.Panel DroneList_Panel2;
        private System.Windows.Forms.TableLayoutPanel DroneTable;
        private MaterialFlatButton AddDrone;
        private System.Windows.Forms.Panel DroneList_Panel3;
        private MaterialFlatButton ShwoDronesBtn;
        private System.Windows.Forms.Panel Detail;
    }
}

