using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZodiacStation.Properties;

namespace ZodiacStation
{
    public partial class Splash : Form
    {
        /// <summary> 
        /// 启动画面本身 
        /// </summary> 
        static Splash instance;
        /// <summary> 
        /// 显示的图片 
        /// </summary> 
        Bitmap bitmap;
        public static Splash Instance
        {
            get
            {
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        public Splash()
        {
            InitializeComponent();
            // 设置窗体的类型 
            const string showInfo = "启动画面：我们正在努力的加载程序，请稍后...";
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            ShowInTaskbar = false;
            //bitmap = new Bitmap((Bitmap)Resources.ResourceManager.GetObject("Splash"));
            //ClientSize = bitmap.Size;
            using (Font font = new Font("Consoles", 10))
            {
                //using (Graphics g = Graphics.FromImage(bitmap))
                //{
                    //g.DrawString(showInfo, font, Brushes.White, 130, 100);
                //}
            }
            BackgroundImage = bitmap;
        }

        public static void ShowSplashScreen()
        {
            instance = new Splash();
            instance.Show();
        }

    }
}
