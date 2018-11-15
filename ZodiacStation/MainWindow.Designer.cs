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
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("111");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("222");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("333");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("444");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("555");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("666");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("777");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("888");
            this.DronePanel = new System.Windows.Forms.Panel();
            this.DroneList_Panel2 = new System.Windows.Forms.Panel();
            this.DroneList_Panel3 = new System.Windows.Forms.Panel();
            this.ShwoDronesBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.DroneList = new MaterialSkin.Controls.MaterialListView();
            this.Drone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Drone_Spacer = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.DronePanel.SuspendLayout();
            this.DroneList_Panel2.SuspendLayout();
            this.DroneList_Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DronePanel
            // 
            this.DronePanel.BackColor = System.Drawing.Color.Transparent;
            this.DronePanel.Controls.Add(this.DroneList_Panel2);
            this.DronePanel.Controls.Add(this.Drone_Spacer);
            this.DronePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DronePanel.Location = new System.Drawing.Point(0, 0);
            this.DronePanel.Margin = new System.Windows.Forms.Padding(0);
            this.DronePanel.Name = "DronePanel";
            this.DronePanel.Size = new System.Drawing.Size(278, 1080);
            this.DronePanel.TabIndex = 0;
            // 
            // DroneList_Panel2
            // 
            this.DroneList_Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DroneList_Panel2.Controls.Add(this.materialFlatButton1);
            this.DroneList_Panel2.Controls.Add(this.DroneList_Panel3);
            this.DroneList_Panel2.Controls.Add(this.DroneList);
            this.DroneList_Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DroneList_Panel2.Location = new System.Drawing.Point(0, 64);
            this.DroneList_Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.DroneList_Panel2.Name = "DroneList_Panel2";
            this.DroneList_Panel2.Size = new System.Drawing.Size(278, 1016);
            this.DroneList_Panel2.TabIndex = 1;
            // 
            // DroneList_Panel3
            // 
            this.DroneList_Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.DroneList_Panel3.Controls.Add(this.ShwoDronesBtn);
            this.DroneList_Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.DroneList_Panel3.Location = new System.Drawing.Point(250, 0);
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
            this.ShwoDronesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
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
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24});
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
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(0, 419);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(250, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "+";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.DronePanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Zodiac Station";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.DronePanel.ResumeLayout(false);
            this.DroneList_Panel2.ResumeLayout(false);
            this.DroneList_Panel3.ResumeLayout(false);
            this.DroneList_Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DronePanel;
        private System.Windows.Forms.Panel DroneList_Panel2;
        private System.Windows.Forms.Panel Drone_Spacer;
        private MaterialListView DroneList;
        private MaterialFlatButton ShwoDronesBtn;
        private System.Windows.Forms.Panel DroneList_Panel3;
        private System.Windows.Forms.ColumnHeader Drone;
        private MaterialFlatButton materialFlatButton1;
    }
}

