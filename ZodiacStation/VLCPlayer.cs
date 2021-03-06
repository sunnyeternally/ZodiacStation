﻿using System;
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
    using libvlc_media_t = System.IntPtr;
    using libvlc_media_player_t = System.IntPtr;
    using libvlc_instance_t = System.IntPtr;


    public partial class VLCPlayer : UserControl
    {
        public VLCPlayer()
        {
            InitializeComponent();
        }

        private void VLCPlayer_Load(object sender, EventArgs e)
        {
            VLC vlc = new VLC();
            string url = "rtsp://47.110.156.106:8554 /vlc";
            //string url = "udp://@:1234";
            vlc.playUrl(url, this.Video.Handle);
        }
    }

        public partial class VLC
    {

        internal struct PointerToArrayOfPointerHelper
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
            public IntPtr[] pointers;
        }

        private static string pluginPath = System.Environment.CurrentDirectory + "\\plugins\\";
        private static string plugin_arg = "--plugin-path=" + pluginPath;
        private static string[] arguments = { "-I", "dummy", "--ignore-config", "--video-title", plugin_arg };//, program_arg };  

        public struct libvlc_media_stats_t
        {
            public int i_read_bytes;
            public float f_input_bitrate;

            public int i_demux_read_bytes;
            public float f_demux_bitrate;
            public int i_demux_corrupted;
            public int i_demux_discontinuity;

            public int i_decoded_video;
            public int i_decoded_audio;

            public int i_displayed_pictures;
            public int i_lost_pictures;

            public int i_played_abuffers;
            public int i_lost_abuffers;

            public int i_sent_packets;
            public int i_sent_bytes;
            public float f_send_bitrate;
        }
        private libvlc_instance_t lit;
        private libvlc_media_player_t lmpt;
        public bool playUrl(string url, IntPtr handle)
        {
            lit = Create_Media_Instance();
            lmpt = Create_MediaPlayer(lit, handle);
            return NetWork_Media_Play(lit, lmpt, url);
        }
        public bool playLocalVideo(string path, IntPtr handle)
        {
            lit = Create_Media_Instance();
            lmpt = Create_MediaPlayer(lit, handle);
            return Local_Media_Play(lit, lmpt, path);
        }
        public bool release()
        {
            try
            {
                MediaPlayer_Stop(lmpt);
                Release_Media_Instance(lit);
                Release_MediaPlayer(lmpt);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool IsPlaying()
        {
            return MediaPlayer_IsPlaying(lmpt);
        }
        public void Stop()
        {
            MediaPlayer_Stop(lmpt);
        }
        private libvlc_instance_t Create_Media_Instance()
        {
            libvlc_instance_t libvlc_instance = IntPtr.Zero;
            IntPtr argvPtr = IntPtr.Zero;

            try
            {
                if (arguments.Length == 0 ||
                    arguments == null)
                {
                    return IntPtr.Zero;
                }

                argvPtr = StrToIntPtr(arguments);
                if (argvPtr == null || argvPtr == IntPtr.Zero)
                {
                    return IntPtr.Zero;
                }

                libvlc_instance = SafeNativeMethods.libvlc_new(arguments.Length, argvPtr);
                if (libvlc_instance == null || libvlc_instance == IntPtr.Zero)
                {
                    return IntPtr.Zero;
                }

                return libvlc_instance;
            }
            catch
            {
                return IntPtr.Zero;
            }
        }
        
        private void Release_Media_Instance(libvlc_instance_t libvlc_instance)
        {
            try
            {
                if (libvlc_instance != IntPtr.Zero ||
                    libvlc_instance != null)
                {
                    SafeNativeMethods.libvlc_release(libvlc_instance);
                }

                libvlc_instance = IntPtr.Zero;
            }
            catch (Exception)
            {
                libvlc_instance = IntPtr.Zero;
            }
        }

        private libvlc_media_player_t Create_MediaPlayer(libvlc_instance_t libvlc_instance, IntPtr handle)
        {
            libvlc_media_player_t libvlc_media_player = IntPtr.Zero;

            try
            {
                if (libvlc_instance == IntPtr.Zero ||
                    libvlc_instance == null ||
                    handle == IntPtr.Zero ||
                    handle == null)
                {
                    return IntPtr.Zero;
                }

                libvlc_media_player = SafeNativeMethods.libvlc_media_player_new(libvlc_instance);
                if (libvlc_media_player == null || libvlc_media_player == IntPtr.Zero)
                {
                    return IntPtr.Zero;
                }

                SafeNativeMethods.libvlc_media_player_set_hwnd(libvlc_media_player, (int)handle);

                return libvlc_media_player;
            }
            catch
            {
                SafeNativeMethods.libvlc_media_player_release(libvlc_media_player);

                return IntPtr.Zero;
            }
        }

        private void Release_MediaPlayer(libvlc_media_player_t libvlc_media_player)
        {
            try
            {
                if (libvlc_media_player != IntPtr.Zero ||
                    libvlc_media_player != null)
                {
                    if (SafeNativeMethods.libvlc_media_player_is_playing(libvlc_media_player))
                    {
                        SafeNativeMethods.libvlc_media_player_stop(libvlc_media_player);
                    }

                    SafeNativeMethods.libvlc_media_player_release(libvlc_media_player);
                }

                libvlc_media_player = IntPtr.Zero;
            }
            catch (Exception)
            {
                libvlc_media_player = IntPtr.Zero;
            }
        }

        private bool NetWork_Media_Play(libvlc_instance_t libvlc_instance, libvlc_media_player_t libvlc_media_player, string url)
        {
            IntPtr pMrl = IntPtr.Zero;
            libvlc_media_t libvlc_media = IntPtr.Zero;

            try
            {
                if (url == null ||
                    libvlc_instance == IntPtr.Zero ||
                    libvlc_instance == null ||
                    libvlc_media_player == IntPtr.Zero ||
                    libvlc_media_player == null)
                {
                    return false;
                }

                pMrl = StrToIntPtr(url);
                if (pMrl == null || pMrl == IntPtr.Zero)
                {
                    return false;
                }

                libvlc_media = SafeNativeMethods.libvlc_media_new_location(libvlc_instance, pMrl);

                if (libvlc_media == null || libvlc_media == IntPtr.Zero)
                {
                    return false;
                }

                SafeNativeMethods.libvlc_media_player_set_media(libvlc_media_player, libvlc_media);

                SafeNativeMethods.libvlc_media_release(libvlc_media);
                libvlc_media = IntPtr.Zero;

                if (0 != SafeNativeMethods.libvlc_media_player_play(libvlc_media_player))
                {
                    return false;
                }

                Thread.Sleep(500);

                return true;
            }
            catch (Exception)
            {
                if (libvlc_media != IntPtr.Zero)
                {
                    SafeNativeMethods.libvlc_media_release(libvlc_media);
                }
                libvlc_media = IntPtr.Zero;

                return false;
            }
        }
        
        private bool Local_Media_Play(libvlc_instance_t libvlc_instance, libvlc_media_player_t libvlc_media_player, string url)
        {
            IntPtr pMrl = IntPtr.Zero;
            libvlc_media_t libvlc_media = IntPtr.Zero;

            try
            {
                if (url == null ||
                    libvlc_instance == IntPtr.Zero ||
                    libvlc_instance == null ||
                    libvlc_media_player == IntPtr.Zero ||
                    libvlc_media_player == null)
                {
                    return false;
                }

                pMrl = StrToIntPtr(url);
                if (pMrl == null || pMrl == IntPtr.Zero)
                {
                    return false;
                }

                libvlc_media = SafeNativeMethods.libvlc_media_new_path(libvlc_instance, pMrl);

                if (libvlc_media == null || libvlc_media == IntPtr.Zero)
                {
                    return false;
                }

                SafeNativeMethods.libvlc_media_player_set_media(libvlc_media_player, libvlc_media);

                SafeNativeMethods.libvlc_media_release(libvlc_media);
                libvlc_media = IntPtr.Zero;

                if (0 != SafeNativeMethods.libvlc_media_player_play(libvlc_media_player))
                {
                    return false;
                }

                Thread.Sleep(500);

                return true;
            }
            catch (Exception)
            {
                if (libvlc_media != IntPtr.Zero)
                {
                    SafeNativeMethods.libvlc_media_release(libvlc_media);
                }
                libvlc_media = IntPtr.Zero;

                return false;
            }
        }

        private bool MediaPlayer_Pause(libvlc_media_player_t libvlc_media_player)
        {
            try
            {
                if (libvlc_media_player == IntPtr.Zero ||
                    libvlc_media_player == null)
                {
                    return false;
                }

                if (SafeNativeMethods.libvlc_media_player_can_pause(libvlc_media_player))
                {
                    SafeNativeMethods.libvlc_media_player_pause(libvlc_media_player);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        private bool MediaPlayer_Stop(libvlc_media_player_t libvlc_media_player)
        {
            try
            {
                if (libvlc_media_player == IntPtr.Zero ||
                    libvlc_media_player == null)
                {
                    return false;
                }

                SafeNativeMethods.libvlc_media_player_stop(libvlc_media_player);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool MediaPlayer_IsPlaying(libvlc_media_player_t libvlc_media_player)
        {
            try
            {
                if (libvlc_media_player == IntPtr.Zero ||
                    libvlc_media_player == null)
                {
                    return false;
                }

                return SafeNativeMethods.libvlc_media_player_is_playing(libvlc_media_player);
            }
            catch (Exception)
            {
                return false;
            }
        }


        private bool TakeSnapShot(libvlc_media_player_t libvlc_media_player, string path, string name)
        {
            try
            {
                string snap_shot_path = null;

                if (libvlc_media_player == IntPtr.Zero ||
                    libvlc_media_player == null)
                {
                    return false;
                }

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                snap_shot_path = path + "\\" + name;

                if (0 == SafeNativeMethods.libvlc_video_take_snapshot(libvlc_media_player, 0, snap_shot_path.ToCharArray(), 0, 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        private bool GetMedia(libvlc_media_player_t libvlc_media_player)
        {
            libvlc_media_t media = IntPtr.Zero;

            try
            {
                if (libvlc_media_player == IntPtr.Zero ||
                    libvlc_media_player == null)
                {
                    return false;
                }

                media = SafeNativeMethods.libvlc_media_player_get_media(libvlc_media_player);
                if (media == IntPtr.Zero || media == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        private int GetDisplayedPictures(libvlc_media_player_t libvlc_media_player)
        {
            libvlc_media_t media = IntPtr.Zero;
            libvlc_media_stats_t media_stats = new libvlc_media_stats_t();
            try
            {
                if (libvlc_media_player == IntPtr.Zero ||
                    libvlc_media_player == null)
                {
                    return 0;
                }

                media = SafeNativeMethods.libvlc_media_player_get_media(libvlc_media_player);
                if (media == IntPtr.Zero || media == null)
                {
                    return 0;
                }

                if (1 == SafeNativeMethods.libvlc_media_get_stats(media, ref media_stats))
                {
                    return media_stats.i_displayed_pictures;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        
        private bool SetFullScreen(libvlc_media_player_t libvlc_media_player, int isFullScreen)
        {
            try
            {
                if (libvlc_media_player == IntPtr.Zero ||
                    libvlc_media_player == null)
                {
                    return false;
                }

                SafeNativeMethods.libvlc_set_fullscreen(libvlc_media_player, isFullScreen);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        private static IntPtr StrToIntPtr(string[] args)
        {
            try
            {
                IntPtr ip_args = IntPtr.Zero;

                PointerToArrayOfPointerHelper argv = new PointerToArrayOfPointerHelper();
                argv.pointers = new IntPtr[11];

                for (int i = 0; i < args.Length; i++)
                {
                    argv.pointers[i] = Marshal.StringToHGlobalAnsi(args[i]);
                }

                int size = Marshal.SizeOf(typeof(PointerToArrayOfPointerHelper));
                ip_args = Marshal.AllocHGlobal(size);
                Marshal.StructureToPtr(argv, ip_args, false);

                return ip_args;
            }
            catch (Exception)
            {
                return IntPtr.Zero;
            }
        }
        
        private static IntPtr StrToIntPtr(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    return IntPtr.Zero;
                }

                IntPtr pMrl = IntPtr.Zero;
                byte[] bytes = Encoding.UTF8.GetBytes(url);

                pMrl = Marshal.AllocHGlobal(bytes.Length + 1);
                Marshal.Copy(bytes, 0, pMrl, bytes.Length);
                Marshal.WriteByte(pMrl, bytes.Length, 0);

                return pMrl;
            }
            catch (Exception)
            {
                return IntPtr.Zero;
            }
        }

        [SuppressUnmanagedCodeSecurity]
        internal static class SafeNativeMethods
        {
            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern libvlc_instance_t libvlc_new(int argc, IntPtr argv);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern void libvlc_release(libvlc_instance_t libvlc_instance);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern String libvlc_get_version();

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern libvlc_media_t libvlc_media_new_location(libvlc_instance_t libvlc_instance, IntPtr path);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern libvlc_media_t libvlc_media_new_path(libvlc_instance_t libvlc_instance, IntPtr path);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern void libvlc_media_release(libvlc_media_t libvlc_media_inst);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern libvlc_media_player_t libvlc_media_player_new(libvlc_instance_t libvlc_instance);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern libvlc_media_player_t libvlc_media_player_new_from_media(libvlc_media_t libvlc_media);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern void libvlc_media_player_release(libvlc_media_player_t libvlc_mediaplayer);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern void libvlc_media_player_set_media(libvlc_media_player_t libvlc_media_player, libvlc_media_t libvlc_media);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern void libvlc_media_player_set_hwnd(libvlc_media_player_t libvlc_mediaplayer, Int32 drawable);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern int libvlc_media_player_play(libvlc_media_player_t libvlc_mediaplayer);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern void libvlc_media_player_pause(libvlc_media_player_t libvlc_mediaplayer);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern void libvlc_media_player_stop(libvlc_media_player_t libvlc_mediaplayer);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern void libvlc_media_parse(libvlc_media_t libvlc_media);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern Int64 libvlc_media_get_duration(libvlc_media_t libvlc_media);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern Int64 libvlc_media_player_get_time(libvlc_media_player_t libvlc_mediaplayer);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern void libvlc_media_player_set_time(libvlc_media_player_t libvlc_mediaplayer, Int64 time);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern int libvlc_audio_get_volume(libvlc_media_player_t libvlc_media_player);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern void libvlc_audio_set_volume(libvlc_media_player_t libvlc_media_player, int volume);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern void libvlc_set_fullscreen(libvlc_media_player_t libvlc_media_player, int isFullScreen);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern int libvlc_get_fullscreen(libvlc_media_player_t libvlc_media_player);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern void libvlc_toggle_fullscreen(libvlc_media_player_t libvlc_media_player);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern bool libvlc_media_player_is_playing(libvlc_media_player_t libvlc_media_player);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern bool libvlc_media_player_is_seekable(libvlc_media_player_t libvlc_media_player);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern bool libvlc_media_player_can_pause(libvlc_media_player_t libvlc_media_player);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern int libvlc_media_player_will_play(libvlc_media_player_t libvlc_media_player);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern int libvlc_video_take_snapshot(libvlc_media_player_t libvlc_media_player, int num, char[] filepath, int i_width, int i_height);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern libvlc_media_t libvlc_media_player_get_media(libvlc_media_player_t libvlc_media_player);

            [DllImport("libvlc", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
            internal static extern int libvlc_media_get_stats(libvlc_media_t libvlc_media, ref libvlc_media_stats_t lib_vlc_media_stats);
        }
    }
}

