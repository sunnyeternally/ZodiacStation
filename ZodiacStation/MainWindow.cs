using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;

namespace ZodiacStation
{
    public partial class MainWindow : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private bool ShowDrone;
        MaterialFlatButton materialFlatButton1;


        public MainWindow()
        {
            InitializeComponent();
            ShowDrone = true;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int ShowScrollBar(IntPtr hWnd, int bar, int show);


        private void MainWindow_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            materialFlatButton1 = new MaterialFlatButton();
            materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialFlatButton1.Depth = 0;
            materialFlatButton1.Icon = null;
            materialFlatButton1.Margin = new System.Windows.Forms.Padding(0);
            materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFlatButton1.Name = "materialFlatButton1";
            materialFlatButton1.Primary = false;
            materialFlatButton1.Size = new System.Drawing.Size(250, 37);
            materialFlatButton1.TabIndex = 2;
            materialFlatButton1.Text = "+";
            materialFlatButton1.UseVisualStyleBackColor = true;

            //materialFlatButton1.Location = new System.Drawing.Point(DroneList.Items[3].Position.X, DroneList.Items[3].Position.Y);

        }

        private void DroneTable_Paint(object sender, PaintEventArgs e)
        {
            Control _Control = (Control)sender;
            ShowScrollBar(_Control.Handle, 0, 0);
        }


        private void ShwoDronesBtn_Click(object sender, EventArgs e)
        {
            ShowDrone = !ShowDrone;
            if (ShowDrone)
            {
                this.ShwoDronesBtn.Text = "◀";
                DronePanel.Width = 278;
                DroneTable.Width = 250;
            }
            else
            {
                this.ShwoDronesBtn.Text = "▶";
                DronePanel.Width = 28;
                DroneTable.Width = 0;
            }
        }

        private void AddDrone_Click(object sender, EventArgs e)
        {

            DroneTable.RowCount++;
            //设置高度
            //DroneTable.Height = DroneTable.RowCount * 40;
            // 行高
            int height = (DroneTable.RowCount - 2) * 200 + 40;
            if (height > DroneList_Panel2.Height) height = DroneList_Panel2.Height;
            DroneTable.Height = height;

            MaterialRaisedButton temp = new MaterialRaisedButton();
            // 
            // temp
            // 
            temp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            temp.Depth = 0;
            temp.Dock = System.Windows.Forms.DockStyle.Fill;
            temp.Icon = null;
            temp.Location = new System.Drawing.Point(0, 0);
            temp.Margin = new System.Windows.Forms.Padding(0);
            temp.MouseState = MaterialSkin.MouseState.HOVER;
            temp.Name = "temp";
            temp.Primary = false;
            temp.Size = new System.Drawing.Size(278, 64);
            temp.TabIndex = 2;
            temp.Text = "-";
            temp.UseVisualStyleBackColor = true;
            temp.Click += new System.EventHandler(this.temp_Click);
            

            //MaterialLabel temp = new MaterialLabel();
            temp.Text = (DroneTable.RowCount - 1).ToString();
            DroneTable.Controls.Add(temp, 0, DroneTable.RowCount - 1);
            DroneTable.Controls.Add(AddDrone, 0, DroneTable.RowCount);
            DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));

            for(int k=2; k< DroneTable.RowCount;k++)
            {
                DroneTable.RowStyles[k].Height = 200;
            }
            DroneTable.RowStyles[DroneTable.RowCount].Height = 40;
            DroneTable.RowStyles[1].Height = 0;
            DroneTable.RowStyles[0].Height = 0;




        }

        private void temp_Click(object sender, EventArgs e)
        {
            MaterialRaisedButton btn = (MaterialRaisedButton)sender;
           
            DroneTable.Controls.Remove(btn);
            DroneTable.
            DroneTable.RowCount--;


            int height = (DroneTable.RowCount - 2) * 200 + 40;
            if (height > DroneList_Panel2.Height) height = DroneList_Panel2.Height;
            DroneTable.Height = height;

        }
    }
}
