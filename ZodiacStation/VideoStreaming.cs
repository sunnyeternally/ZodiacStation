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
using FFmpeg.AutoGen;
using FFmpeg.AutoGen.Example;
using System.Drawing;
using System.Drawing.Imaging;

namespace ZodiacStation
{
    public unsafe partial class VideoStreaming : MaterialForm
    {

        public VideoStreaming()
        {
            InitializeComponent();
            Console.WriteLine("Current directory: " + Environment.CurrentDirectory);
            Console.WriteLine("Runnung in {0}-bit mode.", Environment.Is64BitProcess ? "64" : "32");

            Console.WriteLine($"FFmpeg version info: {ffmpeg.av_version_info()}");

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var url = "http://www.quirksmode.org/html5/videos/big_buck_bunny.mp4";
            using (var vsd = new VideoStreamDecoder(url))
            {
                Console.WriteLine($"codec name: {vsd.CodecName}");

                var info = vsd.GetContextInfo();
                info.ToList().ForEach(x => Console.WriteLine($"{x.Key} = {x.Value}"));

                var sourceSize = vsd.FrameSize;
                var sourcePixelFormat = vsd.PixelFormat;
                var destinationSize = sourceSize;
                var destinationPixelFormat = AVPixelFormat.AV_PIX_FMT_BGR24;
                using (var vfc = new VideoFrameConverter(sourceSize, sourcePixelFormat, destinationSize, destinationPixelFormat))
                {
                    var frameNumber = 0;
                    while (vsd.TryDecodeNextFrame(out var frame))
                    {
                        var convertedFrame = vfc.Convert(frame);

                        using (var bitmap = new Bitmap(convertedFrame.width, convertedFrame.height, convertedFrame.linesize[0], PixelFormat.Format24bppRgb, (IntPtr)convertedFrame.data[0]))
                            label1.Image = bitmap;

                        Console.WriteLine($"frame: {frameNumber}");
                        frameNumber++;
                    }
                }
            }
        }
    }
}
