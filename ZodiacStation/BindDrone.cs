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
    public partial class BindDrone : MaterialForm
    {
        public MainWindow Controller;

        public BindDrone(MainWindow controller)
        {
            InitializeComponent();
            Controller = controller;
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
            Controller.SetAddDroneActice(true);
        }

        public void Display()
        {
            this.Show();
            Controller.SetAddDroneActice(false);
        }

        private void Bind_Click(object sender, EventArgs e)
        {
            DroneInfomation info = new DroneInfomation(Controller);
            Controller.AddDroneInformation(info);
            Controller.SetAddDroneActice(true);
            Hide();
        }
    }

}
