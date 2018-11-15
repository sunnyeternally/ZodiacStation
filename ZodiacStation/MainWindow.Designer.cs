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
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("111");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("222");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("333");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("444");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("555");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("666");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("777");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("888");
            this.Drone_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ShwoDronesBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.DroneList = new MaterialSkin.Controls.MaterialListView();
            this.Drone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Drone_Spacer = new System.Windows.Forms.Panel();
            this.Drone_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Drone_panel
            // 
            this.Drone_panel.BackColor = System.Drawing.Color.Transparent;
            this.Drone_panel.Controls.Add(this.panel1);
            this.Drone_panel.Controls.Add(this.Drone_Spacer);
            this.Drone_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Drone_panel.Location = new System.Drawing.Point(0, 0);
            this.Drone_panel.Margin = new System.Windows.Forms.Padding(0);
            this.Drone_panel.Name = "Drone_panel";
            this.Drone_panel.Size = new System.Drawing.Size(278, 1080);
            this.Drone_panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DroneList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 1016);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.ShwoDronesBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 1016);
            this.panel2.TabIndex = 1;
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
            // DroneList
            // 
            this.DroneList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DroneList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Drone});
            this.DroneList.Depth = 0;
            this.DroneList.Dock = System.Windows.Forms.DockStyle.Left;
            this.DroneList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.DroneList.FullRowSelect = true;
            this.DroneList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DroneList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
            this.DroneList.Location = new System.Drawing.Point(0, 0);
            this.DroneList.Margin = new System.Windows.Forms.Padding(0);
            this.DroneList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DroneList.MouseState = MaterialSkin.MouseState.OUT;
            this.DroneList.Name = "DroneList";
            this.DroneList.OwnerDraw = true;
            this.DroneList.Size = new System.Drawing.Size(250, 1016);
            this.DroneList.TabIndex = 0;
            this.DroneList.UseCompatibleStateImageBehavior = false;
            this.DroneList.View = System.Windows.Forms.View.Details;
            // 
            // Drone
            // 
            this.Drone.Text = "Drone";
            this.Drone.Width = 250;
            // 
            // Drone_Spacer
            // 
            this.Drone_Spacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Drone_Spacer.Location = new System.Drawing.Point(0, 0);
            this.Drone_Spacer.Margin = new System.Windows.Forms.Padding(0);
            this.Drone_Spacer.Name = "Drone_Spacer";
            this.Drone_Spacer.Size = new System.Drawing.Size(278, 64);
            this.Drone_Spacer.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Drone_panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Zodiac Station";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Drone_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Drone_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Drone_Spacer;
        private MaterialListView DroneList;
        private MaterialFlatButton ShwoDronesBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader Drone;
    }
}

