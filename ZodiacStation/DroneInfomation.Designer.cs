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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DroneInfomation));
            this.Background = new System.Windows.Forms.PictureBox();
            this.RDSSLastecho = new System.Windows.Forms.Label();
            this.BasicInfo = new System.Windows.Forms.Label();
            this.Ping = new System.Windows.Forms.Label();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.DroneName = new System.Windows.Forms.Label();
            this.materialLabel2 = new System.Windows.Forms.Label();
            this.Lastecho = new System.Windows.Forms.Label();
            this.materialLabel3 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.materialLabel4 = new System.Windows.Forms.Label();
            this.Altitude = new System.Windows.Forms.Label();
            this.materialLabel5 = new System.Windows.Forms.Label();
            this.Latitude = new System.Windows.Forms.Label();
            this.materialLabel6 = new System.Windows.Forms.Label();
            this.Longitude = new System.Windows.Forms.Label();
            this.materialLabel7 = new System.Windows.Forms.Label();
            this.materialLabel8 = new System.Windows.Forms.Label();
            this.materialLabel9 = new System.Windows.Forms.Label();
            this.materialLabel10 = new System.Windows.Forms.Label();
            this.materialLabel11 = new System.Windows.Forms.Label();
            this.materialLabel13 = new System.Windows.Forms.Label();
            this.materialLabel12 = new System.Windows.Forms.Label();
            this.GPS_Light_Green = new System.Windows.Forms.Label();
            this.BD_Light_Green = new System.Windows.Forms.Label();
            this.LTE_Light_Green = new System.Windows.Forms.Label();
            this.RDSS_Light_Green = new System.Windows.Forms.Label();
            this.GPS_Light_Red = new System.Windows.Forms.Label();
            this.BD_Light_Red = new System.Windows.Forms.Label();
            this.LTE_Light_Red = new System.Windows.Forms.Label();
            this.RDSS_Light_Red = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.GPS_Light_Green);
            this.Background.Controls.Add(this.BD_Light_Green);
            this.Background.Controls.Add(this.LTE_Light_Green);
            this.Background.Controls.Add(this.RDSS_Light_Green);
            this.Background.Controls.Add(this.RDSSLastecho);
            this.Background.Controls.Add(this.BasicInfo);
            this.Background.Controls.Add(this.Ping);
            this.Background.Controls.Add(this.materialLabel1);
            this.Background.Controls.Add(this.DroneName);
            this.Background.Controls.Add(this.materialLabel2);
            this.Background.Controls.Add(this.Lastecho);
            this.Background.Controls.Add(this.materialLabel3);
            this.Background.Controls.Add(this.Status);
            this.Background.Controls.Add(this.materialLabel4);
            this.Background.Controls.Add(this.Altitude);
            this.Background.Controls.Add(this.materialLabel5);
            this.Background.Controls.Add(this.Latitude);
            this.Background.Controls.Add(this.materialLabel6);
            this.Background.Controls.Add(this.Longitude);
            this.Background.Controls.Add(this.materialLabel7);
            this.Background.Controls.Add(this.materialLabel8);
            this.Background.Controls.Add(this.materialLabel9);
            this.Background.Controls.Add(this.materialLabel10);
            this.Background.Controls.Add(this.materialLabel11);
            this.Background.Controls.Add(this.materialLabel13);
            this.Background.Controls.Add(this.materialLabel12);
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(250, 250);
            this.Background.TabIndex = 26;
            this.Background.TabStop = false;
            this.Background.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.Background.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.Background.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // RDSSLastecho
            // 
            this.RDSSLastecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RDSSLastecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RDSSLastecho.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.RDSSLastecho.Location = new System.Drawing.Point(205, 221);
            this.RDSSLastecho.Name = "RDSSLastecho";
            this.RDSSLastecho.Size = new System.Drawing.Size(32, 18);
            this.RDSSLastecho.TabIndex = 25;
            this.RDSSLastecho.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.RDSSLastecho.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.RDSSLastecho.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // BasicInfo
            // 
            this.BasicInfo.AutoSize = true;
            this.BasicInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BasicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BasicInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BasicInfo.Location = new System.Drawing.Point(14, 9);
            this.BasicInfo.Name = "BasicInfo";
            this.BasicInfo.Size = new System.Drawing.Size(127, 18);
            this.BasicInfo.TabIndex = 0;
            this.BasicInfo.Text = "Drone Information";
            this.BasicInfo.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.BasicInfo.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.BasicInfo.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // Ping
            // 
            this.Ping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ping.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Ping.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Ping.Location = new System.Drawing.Point(176, 199);
            this.Ping.Name = "Ping";
            this.Ping.Size = new System.Drawing.Size(61, 18);
            this.Ping.TabIndex = 24;
            this.Ping.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.Ping.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.Ping.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel1.Location = new System.Drawing.Point(14, 40);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(52, 18);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Name:";
            this.materialLabel1.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.materialLabel1.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.materialLabel1.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // DroneName
            // 
            this.DroneName.AutoSize = true;
            this.DroneName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DroneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DroneName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DroneName.Location = new System.Drawing.Point(64, 40);
            this.DroneName.Name = "DroneName";
            this.DroneName.Size = new System.Drawing.Size(89, 18);
            this.DroneName.TabIndex = 23;
            this.DroneName.Text = "DroneName";
            this.DroneName.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.DroneName.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.DroneName.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel2.Location = new System.Drawing.Point(14, 62);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(119, 18);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Current Position:";
            this.materialLabel2.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.materialLabel2.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.materialLabel2.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // Lastecho
            // 
            this.Lastecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lastecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lastecho.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lastecho.Location = new System.Drawing.Point(91, 172);
            this.Lastecho.Name = "Lastecho";
            this.Lastecho.Size = new System.Drawing.Size(61, 18);
            this.Lastecho.TabIndex = 22;
            this.Lastecho.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.Lastecho.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.Lastecho.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel3.Location = new System.Drawing.Point(14, 84);
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(33, 18);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Lon";
            this.materialLabel3.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.materialLabel3.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.materialLabel3.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Status.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Status.Location = new System.Drawing.Point(76, 150);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(30, 18);
            this.Status.TabIndex = 21;
            this.Status.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.Status.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.Status.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel4.Location = new System.Drawing.Point(14, 106);
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(28, 18);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Lat";
            this.materialLabel4.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.materialLabel4.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.materialLabel4.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // Altitude
            // 
            this.Altitude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Altitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Altitude.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Altitude.Location = new System.Drawing.Point(45, 128);
            this.Altitude.Name = "Altitude";
            this.Altitude.Size = new System.Drawing.Size(90, 18);
            this.Altitude.TabIndex = 20;
            this.Altitude.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.Altitude.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.Altitude.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel5.Location = new System.Drawing.Point(14, 128);
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(24, 18);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Alt";
            this.materialLabel5.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.materialLabel5.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.materialLabel5.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // Latitude
            // 
            this.Latitude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Latitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Latitude.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Latitude.Location = new System.Drawing.Point(45, 106);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(68, 18);
            this.Latitude.TabIndex = 19;
            this.Latitude.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.Latitude.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.Latitude.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel6.Location = new System.Drawing.Point(14, 150);
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(54, 18);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "Status:";
            this.materialLabel6.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.materialLabel6.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.materialLabel6.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // Longitude
            // 
            this.Longitude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Longitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Longitude.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Longitude.Location = new System.Drawing.Point(45, 84);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(68, 18);
            this.Longitude.TabIndex = 18;
            this.Longitude.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.Longitude.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.Longitude.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel7.Location = new System.Drawing.Point(14, 172);
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(79, 18);
            this.materialLabel7.TabIndex = 7;
            this.materialLabel7.Text = "Last Echo:";
            this.materialLabel7.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.materialLabel7.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.materialLabel7.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel8.Location = new System.Drawing.Point(43, 197);
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(35, 18);
            this.materialLabel8.TabIndex = 8;
            this.materialLabel8.Text = "LTE";
            this.materialLabel8.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.materialLabel8.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.materialLabel8.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel9.Location = new System.Drawing.Point(43, 221);
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(50, 18);
            this.materialLabel9.TabIndex = 9;
            this.materialLabel9.Text = "RDSS";
            this.materialLabel9.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.materialLabel9.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.materialLabel9.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel10.Location = new System.Drawing.Point(129, 199);
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(37, 18);
            this.materialLabel10.TabIndex = 10;
            this.materialLabel10.Text = "Ping";
            this.materialLabel10.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.materialLabel10.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.materialLabel10.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel11.Location = new System.Drawing.Point(129, 221);
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(75, 18);
            this.materialLabel11.TabIndex = 11;
            this.materialLabel11.Text = "Last Echo";
            this.materialLabel11.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.materialLabel11.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.materialLabel11.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel13.Location = new System.Drawing.Point(205, 81);
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(29, 18);
            this.materialLabel13.TabIndex = 13;
            this.materialLabel13.Text = "BD";
            this.materialLabel13.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.materialLabel13.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.materialLabel13.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel12.Location = new System.Drawing.Point(205, 57);
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(40, 18);
            this.materialLabel12.TabIndex = 12;
            this.materialLabel12.Text = "GPS";
            this.materialLabel12.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.materialLabel12.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.materialLabel12.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // GPS_Light_Green
            // 
            this.GPS_Light_Green.BackColor = System.Drawing.Color.Transparent;
            this.GPS_Light_Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GPS_Light_Green.ForeColor = System.Drawing.Color.Transparent;
            this.GPS_Light_Green.Image = ((System.Drawing.Image)(resources.GetObject("GPS_Light_Green.Image")));
            this.GPS_Light_Green.Location = new System.Drawing.Point(172, 50);
            this.GPS_Light_Green.Name = "GPS_Light_Green";
            this.GPS_Light_Green.Size = new System.Drawing.Size(37, 32);
            this.GPS_Light_Green.TabIndex = 14;
            this.GPS_Light_Green.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.GPS_Light_Green.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.GPS_Light_Green.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // BD_Light_Green
            // 
            this.BD_Light_Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BD_Light_Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BD_Light_Green.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BD_Light_Green.Image = ((System.Drawing.Image)(resources.GetObject("BD_Light_Green.Image")));
            this.BD_Light_Green.Location = new System.Drawing.Point(172, 74);
            this.BD_Light_Green.Name = "BD_Light_Green";
            this.BD_Light_Green.Size = new System.Drawing.Size(37, 32);
            this.BD_Light_Green.TabIndex = 15;
            this.BD_Light_Green.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.BD_Light_Green.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.BD_Light_Green.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // LTE_Light_Green
            // 
            this.LTE_Light_Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LTE_Light_Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LTE_Light_Green.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LTE_Light_Green.Image = ((System.Drawing.Image)(resources.GetObject("LTE_Light_Green.Image")));
            this.LTE_Light_Green.Location = new System.Drawing.Point(8, 189);
            this.LTE_Light_Green.Name = "LTE_Light_Green";
            this.LTE_Light_Green.Size = new System.Drawing.Size(37, 32);
            this.LTE_Light_Green.TabIndex = 16;
            this.LTE_Light_Green.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.LTE_Light_Green.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.LTE_Light_Green.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // RDSS_Light_Green
            // 
            this.RDSS_Light_Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RDSS_Light_Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RDSS_Light_Green.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RDSS_Light_Green.Image = ((System.Drawing.Image)(resources.GetObject("RDSS_Light_Green.Image")));
            this.RDSS_Light_Green.Location = new System.Drawing.Point(8, 213);
            this.RDSS_Light_Green.Name = "RDSS_Light_Green";
            this.RDSS_Light_Green.Size = new System.Drawing.Size(37, 32);
            this.RDSS_Light_Green.TabIndex = 17;
            this.RDSS_Light_Green.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.RDSS_Light_Green.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.RDSS_Light_Green.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            // 
            // GPS_Light_Red
            // 
            this.GPS_Light_Red.BackColor = System.Drawing.Color.Transparent;
            this.GPS_Light_Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GPS_Light_Red.ForeColor = System.Drawing.Color.Transparent;
            this.GPS_Light_Red.Image = ((System.Drawing.Image)(resources.GetObject("GPS_Light_Red.Image")));
            this.GPS_Light_Red.Location = new System.Drawing.Point(176, 50);
            this.GPS_Light_Red.Name = "GPS_Light_Red";
            this.GPS_Light_Red.Size = new System.Drawing.Size(37, 32);
            this.GPS_Light_Red.TabIndex = 27;
            // 
            // BD_Light_Red
            // 
            this.BD_Light_Red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BD_Light_Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BD_Light_Red.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BD_Light_Red.Image = ((System.Drawing.Image)(resources.GetObject("BD_Light_Red.Image")));
            this.BD_Light_Red.Location = new System.Drawing.Point(176, 74);
            this.BD_Light_Red.Name = "BD_Light_Red";
            this.BD_Light_Red.Size = new System.Drawing.Size(37, 32);
            this.BD_Light_Red.TabIndex = 28;
            // 
            // LTE_Light_Red
            // 
            this.LTE_Light_Red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LTE_Light_Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LTE_Light_Red.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LTE_Light_Red.Image = ((System.Drawing.Image)(resources.GetObject("LTE_Light_Red.Image")));
            this.LTE_Light_Red.Location = new System.Drawing.Point(12, 189);
            this.LTE_Light_Red.Name = "LTE_Light_Red";
            this.LTE_Light_Red.Size = new System.Drawing.Size(37, 32);
            this.LTE_Light_Red.TabIndex = 29;
            // 
            // RDSS_Light_Red
            // 
            this.RDSS_Light_Red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RDSS_Light_Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RDSS_Light_Red.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RDSS_Light_Red.Image = ((System.Drawing.Image)(resources.GetObject("RDSS_Light_Red.Image")));
            this.RDSS_Light_Red.Location = new System.Drawing.Point(12, 213);
            this.RDSS_Light_Red.Name = "RDSS_Light_Red";
            this.RDSS_Light_Red.Size = new System.Drawing.Size(37, 32);
            this.RDSS_Light_Red.TabIndex = 30;
            // 
            // DroneInfomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Background);
            this.Controls.Add(this.GPS_Light_Red);
            this.Controls.Add(this.BD_Light_Red);
            this.Controls.Add(this.LTE_Light_Red);
            this.Controls.Add(this.RDSS_Light_Red);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DroneInfomation";
            this.Size = new System.Drawing.Size(250, 250);
            this.Click += new System.EventHandler(this.DroneInfomation_Click);
            this.MouseEnter += new System.EventHandler(this.DroneInfomation_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DroneInfomation_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BasicInfo;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.Label materialLabel2;
        private System.Windows.Forms.Label materialLabel3;
        private System.Windows.Forms.Label materialLabel4;
        private System.Windows.Forms.Label materialLabel5;
        private System.Windows.Forms.Label materialLabel6;
        private System.Windows.Forms.Label materialLabel7;
        private System.Windows.Forms.Label materialLabel8;
        private System.Windows.Forms.Label materialLabel9;
        private System.Windows.Forms.Label materialLabel10;
        private System.Windows.Forms.Label materialLabel11;
        private System.Windows.Forms.Label materialLabel12;
        private System.Windows.Forms.Label materialLabel13;
        private System.Windows.Forms.Label GPS_Light_Green;
        private System.Windows.Forms.Label BD_Light_Green;
        private System.Windows.Forms.Label LTE_Light_Green;
        private System.Windows.Forms.Label RDSS_Light_Green;
        private System.Windows.Forms.Label Longitude;
        private System.Windows.Forms.Label Latitude;
        private System.Windows.Forms.Label Altitude;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label Lastecho;
        private System.Windows.Forms.Label DroneName;
        private System.Windows.Forms.Label Ping;
        private System.Windows.Forms.Label RDSSLastecho;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Label GPS_Light_Red;
        private System.Windows.Forms.Label BD_Light_Red;
        private System.Windows.Forms.Label LTE_Light_Red;
        private System.Windows.Forms.Label RDSS_Light_Red;
    }
}
