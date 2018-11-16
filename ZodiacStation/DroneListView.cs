using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ZodiacStation
{
    public partial class DroneListView : MaterialListView
    {
        public event EventHandler HScroll;
        public event EventHandler VScroll;
        public event EventHandler Mousewheel;

        const int WM_HSCROLL = 0x0114;
        const int WM_VSCROLL = 0x0115;
        const int WM_MOUSEWHEEL = 0x020A;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HSCROLL)
            {
                OnHScroll(this, new EventArgs());
            }
            else if (m.Msg == WM_VSCROLL)
            {
                OnVScroll(this, new EventArgs());
            }
            else if (m.Msg == WM_MOUSEWHEEL)
            {
                OnMouseWheel(this, new EventArgs());
            }

            base.WndProc(ref m);
        }
        virtual protected void OnHScroll(object sender, EventArgs e)
        {
            if (HScroll != null)
                HScroll(this, e);
        }
        virtual protected void OnVScroll(object sender, EventArgs e)
        {
            if (VScroll != null)
                VScroll(this, e);
        }

        virtual protected void OnMouseWheel(object sender, EventArgs e)
        {
            if (Mousewheel != null)
                Mousewheel(this, e);
        }
    }
}

