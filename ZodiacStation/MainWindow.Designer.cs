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
            this.RTViewPanel = new System.Windows.Forms.Panel();
            this.RTDisplay_Panel = new System.Windows.Forms.Panel();
            this.RTSpacer_Panel1 = new System.Windows.Forms.Panel();
            this.RTSpacer_Panel2 = new System.Windows.Forms.Panel();
            this.ThreeD_Panel = new System.Windows.Forms.Panel();
            this.Detail = new System.Windows.Forms.Panel();
            this.DetailButton_Panel = new System.Windows.Forms.Panel();
            this.TabControl_Panel = new System.Windows.Forms.Panel();
            this.ThreeDControl_Panel = new System.Windows.Forms.Panel();
            this.ThreeDIcon = new System.Windows.Forms.Label();
            this.ThreeDControl = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel17 = new System.Windows.Forms.Panel();
            this.RTViewControl_Panel = new System.Windows.Forms.Panel();
            this.CamIcon = new System.Windows.Forms.Label();
            this.RTControl = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel18 = new System.Windows.Forms.Panel();
            this.BrowserControl_Panel = new System.Windows.Forms.Panel();
            this.BrowserIcon = new System.Windows.Forms.Label();
            this.BrowserControl = new MaterialSkin.Controls.MaterialFlatButton();
            this.DroneList_Panel2 = new System.Windows.Forms.Panel();
            this.DroneTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddDrone = new MaterialSkin.Controls.MaterialFlatButton();
            this.DroneList_Panel3 = new System.Windows.Forms.Panel();
            this.ShwoDronesBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.materialFlatButton7 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Interval = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Detail_Panel.SuspendLayout();
            this.Ground.SuspendLayout();
            this.MainViewPanel.SuspendLayout();
            this.DetailControl_Panel.SuspendLayout();
            this.RTViewPanel.SuspendLayout();
            this.TabControl_Panel.SuspendLayout();
            this.ThreeDControl_Panel.SuspendLayout();
            this.RTViewControl_Panel.SuspendLayout();
            this.BrowserControl_Panel.SuspendLayout();
            this.DroneList_Panel2.SuspendLayout();
            this.DroneTable.SuspendLayout();
            this.DroneList_Panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Menu_Panel.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Interval.SuspendLayout();
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
            this.MainViewPanel.Controls.Add(this.TabControl_Panel);
            this.MainViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainViewPanel.Location = new System.Drawing.Point(28, 0);
            this.MainViewPanel.Name = "MainViewPanel";
            this.MainViewPanel.Size = new System.Drawing.Size(1892, 1016);
            this.MainViewPanel.TabIndex = 3;
            // 
            // DetailControl_Panel
            // 
            this.DetailControl_Panel.Controls.Add(this.RTViewPanel);
            this.DetailControl_Panel.Controls.Add(this.ThreeD_Panel);
            this.DetailControl_Panel.Controls.Add(this.Detail);
            this.DetailControl_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailControl_Panel.Location = new System.Drawing.Point(0, 0);
            this.DetailControl_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.DetailControl_Panel.Name = "DetailControl_Panel";
            this.DetailControl_Panel.Size = new System.Drawing.Size(1852, 1016);
            this.DetailControl_Panel.TabIndex = 4;
            // 
            // RTViewPanel
            // 
            this.RTViewPanel.Controls.Add(this.RTDisplay_Panel);
            this.RTViewPanel.Controls.Add(this.RTSpacer_Panel1);
            this.RTViewPanel.Controls.Add(this.RTSpacer_Panel2);
            this.RTViewPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RTViewPanel.Location = new System.Drawing.Point(0, 0);
            this.RTViewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.RTViewPanel.Name = "RTViewPanel";
            this.RTViewPanel.Size = new System.Drawing.Size(0, 1016);
            this.RTViewPanel.TabIndex = 1;
            // 
            // RTDisplay_Panel
            // 
            this.RTDisplay_Panel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RTDisplay_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTDisplay_Panel.Location = new System.Drawing.Point(0, 84);
            this.RTDisplay_Panel.Name = "RTDisplay_Panel";
            this.RTDisplay_Panel.Size = new System.Drawing.Size(0, 832);
            this.RTDisplay_Panel.TabIndex = 2;
            // 
            // RTSpacer_Panel1
            // 
            this.RTSpacer_Panel1.BackColor = System.Drawing.Color.Black;
            this.RTSpacer_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.RTSpacer_Panel1.Location = new System.Drawing.Point(0, 0);
            this.RTSpacer_Panel1.Name = "RTSpacer_Panel1";
            this.RTSpacer_Panel1.Size = new System.Drawing.Size(20, 84);
            this.RTSpacer_Panel1.TabIndex = 0;
            // 
            // RTSpacer_Panel2
            // 
            this.RTSpacer_Panel2.BackColor = System.Drawing.Color.Black;
            this.RTSpacer_Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RTSpacer_Panel2.Location = new System.Drawing.Point(0, 916);
            this.RTSpacer_Panel2.Name = "RTSpacer_Panel2";
            this.RTSpacer_Panel2.Size = new System.Drawing.Size(20, 100);
            this.RTSpacer_Panel2.TabIndex = 1;
            // 
            // ThreeD_Panel
            // 
            this.ThreeD_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ThreeD_Panel.Location = new System.Drawing.Point(0, 0);
            this.ThreeD_Panel.Name = "ThreeD_Panel";
            this.ThreeD_Panel.Size = new System.Drawing.Size(0, 1016);
            this.ThreeD_Panel.TabIndex = 2;
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
            this.Detail.Size = new System.Drawing.Size(1852, 1016);
            this.Detail.TabIndex = 0;
            this.Detail.Resize += new System.EventHandler(this.Detail_Resize);
            // 
            // DetailButton_Panel
            // 
            this.DetailButton_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DetailButton_Panel.Location = new System.Drawing.Point(1852, 0);
            this.DetailButton_Panel.Name = "DetailButton_Panel";
            this.DetailButton_Panel.Size = new System.Drawing.Size(0, 1016);
            this.DetailButton_Panel.TabIndex = 3;
            // 
            // TabControl_Panel
            // 
            this.TabControl_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TabControl_Panel.Controls.Add(this.ThreeDControl_Panel);
            this.TabControl_Panel.Controls.Add(this.panel17);
            this.TabControl_Panel.Controls.Add(this.RTViewControl_Panel);
            this.TabControl_Panel.Controls.Add(this.panel18);
            this.TabControl_Panel.Controls.Add(this.BrowserControl_Panel);
            this.TabControl_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TabControl_Panel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TabControl_Panel.Location = new System.Drawing.Point(1852, 0);
            this.TabControl_Panel.Name = "TabControl_Panel";
            this.TabControl_Panel.Size = new System.Drawing.Size(40, 1016);
            this.TabControl_Panel.TabIndex = 1;
            // 
            // ThreeDControl_Panel
            // 
            this.ThreeDControl_Panel.Controls.Add(this.ThreeDIcon);
            this.ThreeDControl_Panel.Controls.Add(this.ThreeDControl);
            this.ThreeDControl_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeDControl_Panel.Location = new System.Drawing.Point(0, 684);
            this.ThreeDControl_Panel.Name = "ThreeDControl_Panel";
            this.ThreeDControl_Panel.Size = new System.Drawing.Size(40, 332);
            this.ThreeDControl_Panel.TabIndex = 7;
            // 
            // ThreeDIcon
            // 
            this.ThreeDIcon.BackColor = System.Drawing.Color.Transparent;
            this.ThreeDIcon.Image = ((System.Drawing.Image)(resources.GetObject("ThreeDIcon.Image")));
            this.ThreeDIcon.Location = new System.Drawing.Point(6, 144);
            this.ThreeDIcon.Name = "ThreeDIcon";
            this.ThreeDIcon.Size = new System.Drawing.Size(28, 28);
            this.ThreeDIcon.TabIndex = 2;
            this.ThreeDIcon.Click += new System.EventHandler(this.ThreeDIcon_Click);
            // 
            // ThreeDControl
            // 
            this.ThreeDControl.AutoSize = true;
            this.ThreeDControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ThreeDControl.BackColor = System.Drawing.Color.Transparent;
            this.ThreeDControl.Depth = 0;
            this.ThreeDControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeDControl.Font = new System.Drawing.Font("华文细黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ThreeDControl.Icon = null;
            this.ThreeDControl.Location = new System.Drawing.Point(0, 0);
            this.ThreeDControl.Margin = new System.Windows.Forms.Padding(0);
            this.ThreeDControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThreeDControl.Name = "ThreeDControl";
            this.ThreeDControl.Primary = false;
            this.ThreeDControl.Size = new System.Drawing.Size(40, 332);
            this.ThreeDControl.TabIndex = 0;
            this.ThreeDControl.UseVisualStyleBackColor = false;
            this.ThreeDControl.Click += new System.EventHandler(this.ThreeDControl_Click);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Gray;
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 674);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(40, 10);
            this.panel17.TabIndex = 6;
            // 
            // RTViewControl_Panel
            // 
            this.RTViewControl_Panel.Controls.Add(this.CamIcon);
            this.RTViewControl_Panel.Controls.Add(this.RTControl);
            this.RTViewControl_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RTViewControl_Panel.Location = new System.Drawing.Point(0, 342);
            this.RTViewControl_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.RTViewControl_Panel.Name = "RTViewControl_Panel";
            this.RTViewControl_Panel.Size = new System.Drawing.Size(40, 332);
            this.RTViewControl_Panel.TabIndex = 5;
            // 
            // CamIcon
            // 
            this.CamIcon.BackColor = System.Drawing.Color.Transparent;
            this.CamIcon.Image = global::ZodiacStation.Properties.Resources.CamIcon;
            this.CamIcon.Location = new System.Drawing.Point(5, 159);
            this.CamIcon.Name = "CamIcon";
            this.CamIcon.Size = new System.Drawing.Size(28, 28);
            this.CamIcon.TabIndex = 1;
            this.CamIcon.Click += new System.EventHandler(this.CamIcon_Click);
            // 
            // RTControl
            // 
            this.RTControl.AutoSize = true;
            this.RTControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RTControl.BackColor = System.Drawing.Color.Transparent;
            this.RTControl.Depth = 0;
            this.RTControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTControl.Icon = null;
            this.RTControl.Location = new System.Drawing.Point(0, 0);
            this.RTControl.Margin = new System.Windows.Forms.Padding(0);
            this.RTControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.RTControl.Name = "RTControl";
            this.RTControl.Primary = false;
            this.RTControl.Size = new System.Drawing.Size(40, 332);
            this.RTControl.TabIndex = 0;
            this.RTControl.UseVisualStyleBackColor = false;
            this.RTControl.Click += new System.EventHandler(this.RTControl_Click);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Gray;
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 332);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(40, 10);
            this.panel18.TabIndex = 4;
            // 
            // BrowserControl_Panel
            // 
            this.BrowserControl_Panel.BackColor = System.Drawing.Color.DimGray;
            this.BrowserControl_Panel.Controls.Add(this.BrowserIcon);
            this.BrowserControl_Panel.Controls.Add(this.BrowserControl);
            this.BrowserControl_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BrowserControl_Panel.Location = new System.Drawing.Point(0, 0);
            this.BrowserControl_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.BrowserControl_Panel.Name = "BrowserControl_Panel";
            this.BrowserControl_Panel.Size = new System.Drawing.Size(40, 332);
            this.BrowserControl_Panel.TabIndex = 3;
            // 
            // BrowserIcon
            // 
            this.BrowserIcon.BackColor = System.Drawing.Color.Transparent;
            this.BrowserIcon.Image = ((System.Drawing.Image)(resources.GetObject("BrowserIcon.Image")));
            this.BrowserIcon.Location = new System.Drawing.Point(7, 163);
            this.BrowserIcon.Name = "BrowserIcon";
            this.BrowserIcon.Size = new System.Drawing.Size(28, 28);
            this.BrowserIcon.TabIndex = 2;
            this.BrowserIcon.Click += new System.EventHandler(this.BrowserControl_Click);
            // 
            // BrowserControl
            // 
            this.BrowserControl.AutoSize = true;
            this.BrowserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowserControl.BackColor = System.Drawing.Color.Transparent;
            this.BrowserControl.Depth = 0;
            this.BrowserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserControl.Icon = null;
            this.BrowserControl.Location = new System.Drawing.Point(0, 0);
            this.BrowserControl.Margin = new System.Windows.Forms.Padding(0);
            this.BrowserControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.BrowserControl.Name = "BrowserControl";
            this.BrowserControl.Primary = false;
            this.BrowserControl.Size = new System.Drawing.Size(40, 332);
            this.BrowserControl.TabIndex = 1;
            this.BrowserControl.UseVisualStyleBackColor = false;
            this.BrowserControl.Click += new System.EventHandler(this.BrowserControl_Click);
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
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(1145, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(775, 40);
            this.panel9.TabIndex = 2;
            // 
            // Menu_Panel
            // 
            this.Menu_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Menu_Panel.Controls.Add(this.panel16);
            this.Menu_Panel.Controls.Add(this.panel15);
            this.Menu_Panel.Controls.Add(this.panel14);
            this.Menu_Panel.Controls.Add(this.panel13);
            this.Menu_Panel.Controls.Add(this.panel12);
            this.Menu_Panel.Controls.Add(this.panel11);
            this.Menu_Panel.Controls.Add(this.panel10);
            this.Menu_Panel.Controls.Add(this.panel8);
            this.Menu_Panel.Controls.Add(this.panel7);
            this.Menu_Panel.Controls.Add(this.panel6);
            this.Menu_Panel.Controls.Add(this.panel5);
            this.Menu_Panel.Controls.Add(this.panel4);
            this.Menu_Panel.Controls.Add(this.Interval);
            this.Menu_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu_Panel.Location = new System.Drawing.Point(278, 0);
            this.Menu_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.Size = new System.Drawing.Size(1642, 40);
            this.Menu_Panel.TabIndex = 1;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel16.Controls.Add(this.materialFlatButton7);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(750, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(120, 40);
            this.panel16.TabIndex = 14;
            // 
            // materialFlatButton7
            // 
            this.materialFlatButton7.AutoSize = true;
            this.materialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton7.Depth = 0;
            this.materialFlatButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialFlatButton7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton7.Icon = null;
            this.materialFlatButton7.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton7.Margin = new System.Windows.Forms.Padding(0);
            this.materialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton7.Name = "materialFlatButton7";
            this.materialFlatButton7.Primary = false;
            this.materialFlatButton7.Size = new System.Drawing.Size(120, 40);
            this.materialFlatButton7.TabIndex = 10;
            this.materialFlatButton7.Text = "ADD ITEM";
            this.materialFlatButton7.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(745, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(5, 40);
            this.panel15.TabIndex = 13;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel14.Controls.Add(this.materialFlatButton6);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(625, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(120, 40);
            this.panel14.TabIndex = 12;
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialFlatButton6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton6.Icon = null;
            this.materialFlatButton6.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(0);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(120, 40);
            this.materialFlatButton6.TabIndex = 8;
            this.materialFlatButton6.Text = "SETTINGS";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(620, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(5, 40);
            this.panel13.TabIndex = 11;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel12.Controls.Add(this.materialFlatButton5);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(500, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(120, 40);
            this.panel12.TabIndex = 10;
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialFlatButton5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton5.Icon = null;
            this.materialFlatButton5.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(0);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(120, 40);
            this.materialFlatButton5.TabIndex = 6;
            this.materialFlatButton5.Text = "INSPECT";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(495, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 40);
            this.panel11.TabIndex = 9;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel10.Controls.Add(this.materialFlatButton4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(375, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(120, 40);
            this.panel10.TabIndex = 8;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialFlatButton4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(0);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(120, 40);
            this.materialFlatButton4.TabIndex = 4;
            this.materialFlatButton4.Text = "MISSION";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(370, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 40);
            this.panel8.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel7.Controls.Add(this.materialFlatButton3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(250, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(120, 40);
            this.panel7.TabIndex = 5;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialFlatButton3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(0);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(120, 40);
            this.materialFlatButton3.TabIndex = 3;
            this.materialFlatButton3.Text = "PLAN";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(245, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 40);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel5.Controls.Add(this.materialFlatButton2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(125, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 40);
            this.panel5.TabIndex = 3;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialFlatButton2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(0, 0);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(120, 40);
            this.materialFlatButton2.TabIndex = 2;
            this.materialFlatButton2.Text = "LAND";
            this.materialFlatButton2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(120, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 40);
            this.panel4.TabIndex = 2;
            // 
            // Interval
            // 
            this.Interval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Interval.Controls.Add(this.materialFlatButton1);
            this.Interval.Dock = System.Windows.Forms.DockStyle.Left;
            this.Interval.Location = new System.Drawing.Point(0, 0);
            this.Interval.Margin = new System.Windows.Forms.Padding(0);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(120, 40);
            this.Interval.TabIndex = 1;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 40);
            this.panel3.TabIndex = 0;
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
            this.RTViewPanel.ResumeLayout(false);
            this.TabControl_Panel.ResumeLayout(false);
            this.ThreeDControl_Panel.ResumeLayout(false);
            this.ThreeDControl_Panel.PerformLayout();
            this.RTViewControl_Panel.ResumeLayout(false);
            this.RTViewControl_Panel.PerformLayout();
            this.BrowserControl_Panel.ResumeLayout(false);
            this.BrowserControl_Panel.PerformLayout();
            this.DroneList_Panel2.ResumeLayout(false);
            this.DroneTable.ResumeLayout(false);
            this.DroneTable.PerformLayout();
            this.DroneList_Panel3.ResumeLayout(false);
            this.DroneList_Panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Menu_Panel.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.Interval.ResumeLayout(false);
            this.Interval.PerformLayout();
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
        private System.Windows.Forms.Panel TabControl_Panel;
        private System.Windows.Forms.Panel DetailButton_Panel;
        private System.Windows.Forms.Panel DetailControl_Panel;
        private MaterialFlatButton ThreeDControl;
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
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel RTViewPanel;
        private MaterialFlatButton BrowserControl;
        private System.Windows.Forms.Panel BrowserControl_Panel;
        private System.Windows.Forms.Label BrowserIcon;
        private System.Windows.Forms.Label CamIcon;
        private System.Windows.Forms.Panel ThreeDControl_Panel;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel RTViewControl_Panel;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel ThreeD_Panel;
        private System.Windows.Forms.Panel RTDisplay_Panel;
        private System.Windows.Forms.Panel RTSpacer_Panel2;
        private System.Windows.Forms.Panel RTSpacer_Panel1;
    }
}

