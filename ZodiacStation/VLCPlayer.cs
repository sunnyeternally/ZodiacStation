using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.ExceptionServices;
using System.Security;
using System.IO;
using System.Threading;

namespace ZodiacStation
{

    public partial class VLCPlayer : UserControl
    {
        FFmpegPlayer stream = new FFmpegPlayer();
        Thread streamPlayer;
        public string url;

        public VLCPlayer()
        {
            InitializeComponent();
        }

        ~VLCPlayer()
        {
            stream.Stop();
            streamPlayer.Abort();
        }

        private void VLCPlayer_Load(object sender, EventArgs e)
        {
            //url = "rtsp://127.0.0.1:8554/vlc";
            url = "rtsp://184.72.239.149/vod/mp4://BigBuckBunny_175k.mov";
            streamPlayer = new Thread(DeCode);
            streamPlayer.IsBackground = true;
            streamPlayer.Start();
        }

        public void Pause()
        {
            if(streamPlayer!=null && streamPlayer.IsAlive)
            {
                streamPlayer.Suspend();
            }
        }

        public void Start()
        {
            if (streamPlayer != null && !streamPlayer.IsAlive)
            {
                streamPlayer.Start();
            }
        }

        private unsafe void DeCode()
        {
            try
            {
                Console.WriteLine("DeCoding run...");
                Bitmap oldBmp = null;

                FFmpegPlayer.ShowBitmap show = (bmp) =>
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        Bitmap temp = ResizeImage(bmp, Video.Width, Video.Height);
                        this.Video.Image = temp;
                        if (oldBmp != null)
                        {
                            oldBmp.Dispose();
                        }
                        oldBmp = temp;
                    }));
                    Thread.Sleep(20);
                };
                stream.Start(show, url.Trim());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("DeCoding exit");
                this.Invoke(new MethodInvoker(() =>
                {

                }));
            }
        }



        public static Bitmap ResizeImage(Bitmap bmp, int newW, int newH)
        {
            try
            {
                Bitmap b = new Bitmap(newW, newH);
                Graphics g = Graphics.FromImage(b);

                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                g.DrawImage(bmp, new Rectangle(0, 0, newW, newH), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                g.Dispose();

                return b;
            }
            catch
            {
                return null;
            }
            
        }
    }
}

