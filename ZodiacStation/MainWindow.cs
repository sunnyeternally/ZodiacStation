using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ZodiacStation
{
    public partial class MainWindow : MaterialForm
    {
        private List<DroneInfomation> DroneInfomations;
        private MaterialSkinManager materialSkinManager;
        private bool ShowDrone;
        public BindDrone Bind;
        ProcessStartInfo info;
        Process MapBrowser;
        IntPtr MapBrowserHWND;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int ShowScrollBar(IntPtr hWnd, int bar, int show);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MoveWindow(IntPtr hWnd, int x, int y, int nWidth, int nHeight, bool BRePaint);

        internal delegate int WindowEnumProc(IntPtr hwnd, IntPtr lparam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool EnumChildWindows(IntPtr hwnd, WindowEnumProc func, IntPtr lParam);


        public MainWindow()
        {
            InitializeComponent();
            ShowDrone = true;
            DroneInfomations = new List<DroneInfomation>();
            Bind = new BindDrone(this);
            
        }

        ~MainWindow()
        {
            MapBrowser.Kill();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            DroneList_Panel2.Width = 278;
            DroneTable.Width = 250;

            MapBrowser = new Process();
            MapBrowser.StartInfo.FileName = "E:\\My Projects\\GroundStation\\Earth.exe";
            MapBrowser.StartInfo.Arguments = "-parentHWND " + Detail.Handle.ToInt32() + " " + Environment.CommandLine;
            MapBrowser.StartInfo.UseShellExecute = true;
            MapBrowser.StartInfo.CreateNoWindow = true;

            MapBrowser.Start();
            while (MapBrowser.MainWindowHandle == null) {;}
            MapBrowserHWND = MapBrowser.MainWindowHandle;
            

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
                DroneList_Panel2.Width = 278;
                DroneTable.Width = 250;
            }
            else
            {
                this.ShwoDronesBtn.Text = "▶";
                DroneList_Panel2.Width = 28;
                DroneTable.Width = 0;

            }
        }

        private void AddDrone_Click(object sender, EventArgs e)
        {
            Bind.Display();  
        }

        public void AddDroneInformation(DroneInfomation info)
        {
            DroneInfomations.Add(info);
            RedrawDroneTable();
        }

        public void ExclusiveActivate(DroneInfomation info)
        {
            foreach (DroneInfomation item in DroneInfomations)
            {
                if (item != info)
                {
                    item.Losefocus();
                }
            }
        }


        public void SetAddDroneActice(bool active)
        {
            if (active) AddDrone.Enabled = true;
            else AddDrone.Enabled = false;
        }

        private void RedrawDroneTable()
        {
            DroneTable.Controls.Clear();
            DroneTable.RowStyles.Clear();
            DroneTable.RowCount = DroneInfomations.Count + 2;

            

            DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
            for (int i = 0; i < DroneInfomations.Count; i++)
            {
                DroneInfomations[i].Text = i.ToString();
                DroneTable.Controls.Add(DroneInfomations[i], 0, i);
                DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40));
            }
            for (int k = 0; k < DroneTable.RowCount - 2; k++)
            {
                DroneTable.RowStyles[k].Height = 250;
            }
            DroneTable.Controls.Add(AddDrone, 0, DroneTable.RowCount - 2);
            DroneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize, 40));
            DroneTable.Height = DroneList_Panel2.Height;
            if (DroneInfomations.Count * 250 + 40 > DroneList_Panel2.Height) DroneTable.AutoScroll = true;
            else DroneTable.AutoScroll = false;
        }

        private void temp_Click(object sender, EventArgs e)
        {
            MaterialRaisedButton btn = (MaterialRaisedButton)sender;
            //Dro.Remove(btn);
            RedrawDroneTable();


        }
    }
}
