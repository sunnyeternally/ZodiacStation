using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZodiacStation
{
    public partial class DroneInfomation : UserControl
    {
        public bool Active;
        public MainWindow Controller;

        public DroneInfomation(MainWindow controller)
        {
            InitializeComponent();
            Controller = controller;
            Height = 250;
            Width = 250;
    }

        private void DroneInfomation_Click(object sender, EventArgs e)
        {
            Active = true;
            Controller.ExclusiveActivate(this);
            this.BackColor = Color.FromArgb(255, 120, 120, 120);
        }

        public void Losefocus()
        {
            Active = false;
            this.BackColor = Color.Transparent;

        }

        private void DroneInfomation_MouseEnter(object sender, EventArgs e)
        {
            if (!Active)
            {
                this.BackColor = Color.FromArgb(255,80,80,80);
            }
        }

        private void DroneInfomation_MouseLeave(object sender, EventArgs e)
        {
            bool inside = false;
            Point p = Control.MousePosition;
            if (p.X > 0 && p.X < 250 && p.Y > 0 && p.Y < 250)
            {
                inside = true;
            }

            if (!Active && !inside)
            {
                this.BackColor = Color.Transparent;
            }
        }
    }
}
