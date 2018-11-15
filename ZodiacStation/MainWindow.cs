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



            
        }

        private void ShwoDronesBtn_Click(object sender, EventArgs e)
        {
            ShowDrone = !ShowDrone;
            if (ShowDrone)
            {
                this.ShwoDronesBtn.Text = "◀";
                DronePanel.Width = 278;
            }
            else
            {
                this.ShwoDronesBtn.Text = "▶";
                DronePanel.Width = 28;
            }
        }
    }
}
