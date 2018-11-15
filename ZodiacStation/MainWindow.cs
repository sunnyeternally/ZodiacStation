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

namespace ZodiacStation
{
    public partial class MainWindow : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private bool ShowDrone;

        public MainWindow()
        {
            InitializeComponent();
            ShowDrone = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);



            ListViewItem[] lvs = new ListViewItem[3];
            lvs[0] = new ListViewItem(new string[] { "行1列1", "行1列2", "" });
            lvs[1] = new ListViewItem(new string[] { "行2列1", "行2列2", "" });
            lvs[2] = new ListViewItem(new string[] { "行3列1", "行3列2", "" });
            this.DroneList.Items.AddRange(lvs);

            MaterialFlatButton btn;
            btn = new MaterialFlatButton();
            btn.Text = "...";
            this.DroneList.Controls.Add(btn);
            btn.Size = new Size(this.DroneList.Items[0].SubItems[2].Bounds.Width,
            this.DroneList.Items[0].SubItems[2].Bounds.Height);

        }

        private void ShwoDronesBtn_Click(object sender, EventArgs e)
        {
            ShowDrone = !ShowDrone;
            if (ShowDrone)
            {
                this.ShwoDronesBtn.Text = "◀";
                Drone_panel.Width = 278;
            }
            else
            {
                this.ShwoDronesBtn.Text = "▶";
                Drone_panel.Width = 28;
            }
        }
    }
}
