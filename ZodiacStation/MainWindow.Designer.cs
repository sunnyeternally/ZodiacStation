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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Detail_Panel = new System.Windows.Forms.Panel();
            this.Ground = new System.Windows.Forms.Panel();
            this.MainViewPanel = new System.Windows.Forms.Panel();
            this.DetailControl_Panel = new System.Windows.Forms.Panel();
            this.Detail = new System.Windows.Forms.Panel();
            this.DetailButton_Panel = new System.Windows.Forms.Panel();
            this.RT_Panel = new System.Windows.Forms.Panel();
            this.CamIcon = new System.Windows.Forms.Label();
            this.RTControl = new MaterialSkin.Controls.MaterialFlatButton();
            this.ThreeD_Panel = new System.Windows.Forms.Panel();
            this.ThreeDIcon = new System.Windows.Forms.Label();
            this.ThreeDControl = new MaterialSkin.Controls.MaterialFlatButton();
            this.DroneList_Panel2 = new System.Windows.Forms.Panel();
            this.DroneTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddDrone = new MaterialSkin.Controls.MaterialFlatButton();
            this.DroneList_Panel3 = new System.Windows.Forms.Panel();
            this.ShwoDronesBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton7 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Interval = new System.Windows.Forms.Panel();
            this.Detail_Panel.SuspendLayout();
            this.Ground.SuspendLayout();
            this.MainViewPanel.SuspendLayout();
            this.DetailControl_Panel.SuspendLayout();
            this.RT_Panel.SuspendLayout();
            this.ThreeD_Panel.SuspendLayout();
            this.DroneList_Panel2.SuspendLayout();
            this.DroneTable.SuspendLayout();
            this.DroneList_Panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Menu_Panel.SuspendLayout();
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
            this.Ground.Controls.Add(this.MainViewPanel);
            this.Ground.Controls.Add(this.DroneList_Panel2);
            this.Ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ground.Location = new System.Drawing.Point(0, 0);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1920, 1016);
            this.Ground.TabIndex = 2;
            // 
            // MainViewPanel
            // 
            this.MainViewPanel.Controls.Add(this.DetailControl_Panel);
            this.MainViewPanel.Controls.Add(this.DetailButton_Panel);
            this.MainViewPanel.Controls.Add(this.RT_Panel);
            this.MainViewPanel.Controls.Add(this.ThreeD_Panel);
            this.MainViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainViewPanel.Location = new System.Drawing.Point(28, 0);
            this.MainViewPanel.Name = "MainViewPanel";
            this.MainViewPanel.Size = new System.Drawing.Size(1892, 1016);
            this.MainViewPanel.TabIndex = 3;
            // 
            // DetailControl_Panel
            // 
            this.DetailControl_Panel.Controls.Add(this.Detail);
            this.DetailControl_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailControl_Panel.Location = new System.Drawing.Point(0, 0);
            this.DetailControl_Panel.Name = "DetailControl_Panel";
            this.DetailControl_Panel.Size = new System.Drawing.Size(1836, 1016);
            this.DetailControl_Panel.TabIndex = 4;
            // 
            // Detail
            // 
            this.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Detail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Detail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Detail.Location = new System.Drawing.Point(0, 0);
            this.Detail.Margin = new System.Windows.Forms.Padding(0);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(1836, 1016);
            this.Detail.TabIndex = 0;
            this.Detail.Resize += new System.EventHandler(this.Detail_Resize);
            // 
            // DetailButton_Panel
            // 
            this.DetailButton_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DetailButton_Panel.Location = new System.Drawing.Point(1836, 0);
            this.DetailButton_Panel.Name = "DetailButton_Panel";
            this.DetailButton_Panel.Size = new System.Drawing.Size(0, 1016);
            this.DetailButton_Panel.TabIndex = 3;
            // 
            // RT_Panel
            // 
            this.RT_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.RT_Panel.Controls.Add(this.CamIcon);
            this.RT_Panel.Controls.Add(this.RTControl);
            this.RT_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RT_Panel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RT_Panel.Location = new System.Drawing.Point(1836, 0);
            this.RT_Panel.Name = "RT_Panel";
            this.RT_Panel.Size = new System.Drawing.Size(28, 1016);
            this.RT_Panel.TabIndex = 2;
            // 
            // CamIcon
            // 
            this.CamIcon.BackColor = System.Drawing.Color.Transparent;
            this.CamIcon.Image = global::ZodiacStation.Properties.Resources.CamIcon;
            this.CamIcon.Location = new System.Drawing.Point(0, 495);
            this.CamIcon.Name = "CamIcon";
            this.CamIcon.Size = new System.Drawing.Size(28, 28);
            this.CamIcon.TabIndex = 1;
            this.CamIcon.Click += new System.EventHandler(this.CamIcon_Click);
            // 
            // RTControl
            // 
            this.RTControl.AutoSize = true;
            this.RTControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RTControl.Depth = 0;
            this.RTControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTControl.Icon = null;
            this.RTControl.Location = new System.Drawing.Point(0, 0);
            this.RTControl.Margin = new System.Windows.Forms.Padding(0);
            this.RTControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.RTControl.Name = "RTControl";
            this.RTControl.Primary = false;
            this.RTControl.Size = new System.Drawing.Size(28, 1016);
            this.RTControl.TabIndex = 0;
            this.RTControl.UseVisualStyleBackColor = true;
            this.RTControl.Click += new System.EventHandler(this.RTControl_Click);
            // 
            // ThreeD_Panel
            // 
            this.ThreeD_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ThreeD_Panel.Controls.Add(this.ThreeDIcon);
            this.ThreeD_Panel.Controls.Add(this.ThreeDControl);
            this.ThreeD_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ThreeD_Panel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ThreeD_Panel.Location = new System.Drawing.Point(1864, 0);
            this.ThreeD_Panel.Name = "ThreeD_Panel";
            this.ThreeD_Panel.Size = new System.Drawing.Size(28, 1016);
            this.ThreeD_Panel.TabIndex = 1;
            // 
            // ThreeDIcon
            // 
            this.ThreeDIcon.BackColor = System.Drawing.Color.Transparent;
            this.ThreeDIcon.Image = ((System.Drawing.Image)(resources.GetObject("ThreeDIcon.Image")));
            this.ThreeDIcon.Location = new System.Drawing.Point(0, 495);
            this.ThreeDIcon.Name = "ThreeDIcon";
            this.ThreeDIcon.Size = new System.Drawing.Size(28, 28);
            this.ThreeDIcon.TabIndex = 2;
            this.ThreeDIcon.Click += new System.EventHandler(this.ThreeDIcon_Click);
            // 
            // ThreeDControl
            // 
            this.ThreeDControl.AutoSize = true;
            this.ThreeDControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ThreeDControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ThreeDControl.Depth = 0;
            this.ThreeDControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeDControl.Font = new System.Drawing.Font("华文细黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ThreeDControl.Icon = null;
            this.ThreeDControl.Location = new System.Drawing.Point(0, 0);
            this.ThreeDControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ThreeDControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThreeDControl.Name = "ThreeDControl";
            this.ThreeDControl.Primary = false;
            this.ThreeDControl.Size = new System.Drawing.Size(28, 1016);
            this.ThreeDControl.TabIndex = 0;
            this.ThreeDControl.UseVisualStyleBackColor = false;
            this.ThreeDControl.Click += new System.EventHandler(this.ThreeDControl_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.Menu_Panel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 40);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 40);
            this.panel3.TabIndex = 0;
            // 
            // Menu_Panel
            // 
            this.Menu_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Menu_Panel.Controls.Add(this.materialFlatButton7);
            this.Menu_Panel.Controls.Add(this.panel8);
            this.Menu_Panel.Controls.Add(this.materialFlatButton6);
            this.Menu_Panel.Controls.Add(this.panel7);
            this.Menu_Panel.Controls.Add(this.materialFlatButton5);
            this.Menu_Panel.Controls.Add(this.panel6);
            this.Menu_Panel.Controls.Add(this.materialFlatButton4);
            this.Menu_Panel.Controls.Add(this.panel5);
            this.Menu_Panel.Controls.Add(this.materialFlatButton3);
            this.Menu_Panel.Controls.Add(this.panel4);
            this.Menu_Panel.Controls.Add(this.materialFlatButton2);
            this.Menu_Panel.Controls.Add(this.Interval);
            this.Menu_Panel.Controls.Add(this.materialFlatButton1);
            this.Menu_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu_Panel.Location = new System.Drawing.Point(278, 0);
            this.Menu_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.Size = new System.Drawing.Size(1642, 40);
            this.Menu_Panel.TabIndex = 1;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoEllipsis = true;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialFlatButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(120, 40);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "TAKE OFF";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoEllipsis = true;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialFlatButton2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(125, 0);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(120, 40);
            this.materialFlatButton2.TabIndex = 2;
            this.materialFlatButton2.Text = "LAND";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(245, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 40);
            this.panel4.TabIndex = 2;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoEllipsis = true;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialFlatButton3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(250, 0);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(0);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(120, 40);
            this.materialFlatButton3.TabIndex = 3;
            this.materialFlatButton3.Text = "PLAN";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(370, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 40);
            this.panel5.TabIndex = 3;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoEllipsis = true;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialFlatButton4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(375, 0);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(0);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(120, 40);
            this.materialFlatButton4.TabIndex = 4;
            this.materialFlatButton4.Text = "MISSION";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(495, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 40);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(620, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 40);
            this.panel7.TabIndex = 5;
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoEllipsis = true;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialFlatButton5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton5.Icon = null;
            this.materialFlatButton5.Location = new System.Drawing.Point(500, 0);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(0);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(120, 40);
            this.materialFlatButton5.TabIndex = 6;
            this.materialFlatButton5.Text = "INSPECT";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(745, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 40);
            this.panel8.TabIndex = 7;
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoEllipsis = true;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialFlatButton6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton6.Icon = null;
            this.materialFlatButton6.Location = new System.Drawing.Point(625, 0);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(0);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(120, 40);
            this.materialFlatButton6.TabIndex = 8;
            this.materialFlatButton6.Text = "SETTINGS";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton7
            // 
            this.materialFlatButton7.AutoEllipsis = true;
            this.materialFlatButton7.Depth = 0;
            this.materialFlatButton7.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialFlatButton7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton7.Icon = null;
            this.materialFlatButton7.Location = new System.Drawing.Point(750, 0);
            this.materialFlatButton7.Margin = new System.Windows.Forms.Padding(0);
            this.materialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton7.Name = "materialFlatButton7";
            this.materialFlatButton7.Primary = false;
            this.materialFlatButton7.Size = new System.Drawing.Size(120, 40);
            this.materialFlatButton7.TabIndex = 10;
            this.materialFlatButton7.Text = "ADD ITEM";
            this.materialFlatButton7.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(1151, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(769, 40);
            this.panel9.TabIndex = 2;
            // 
            // Interval
            // 
            this.Interval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Interval.Dock = System.Windows.Forms.DockStyle.Left;
            this.Interval.Location = new System.Drawing.Point(120, 0);
            this.Interval.Margin = new System.Windows.Forms.Padding(0);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(5, 40);
            this.Interval.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel2);
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
            this.MainViewPanel.ResumeLayout(false);
            this.DetailControl_Panel.ResumeLayout(false);
            this.RT_Panel.ResumeLayout(false);
            this.RT_Panel.PerformLayout();
            this.ThreeD_Panel.ResumeLayout(false);
            this.ThreeD_Panel.PerformLayout();
            this.DroneList_Panel2.ResumeLayout(false);
            this.DroneTable.ResumeLayout(false);
            this.DroneTable.PerformLayout();
            this.DroneList_Panel3.ResumeLayout(false);
            this.DroneList_Panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Menu_Panel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel MainViewPanel;
        private System.Windows.Forms.Panel RT_Panel;
        private System.Windows.Forms.Panel ThreeD_Panel;
        private System.Windows.Forms.Panel DetailButton_Panel;
        private System.Windows.Forms.Panel DetailControl_Panel;
        private MaterialFlatButton ThreeDControl;
        private System.Windows.Forms.Label CamIcon;
        private System.Windows.Forms.Label ThreeDIcon;
        private MaterialFlatButton RTControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Menu_Panel;
        private System.Windows.Forms.Panel panel3;
        private MaterialFlatButton materialFlatButton1;
        private MaterialFlatButton materialFlatButton7;
        private System.Windows.Forms.Panel panel8;
        private MaterialFlatButton materialFlatButton6;
        private System.Windows.Forms.Panel panel7;
        private MaterialFlatButton materialFlatButton5;
        private System.Windows.Forms.Panel panel6;
        private MaterialFlatButton materialFlatButton4;
        private System.Windows.Forms.Panel panel5;
        private MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.Panel panel4;
        private MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel Interval;
    }
}

