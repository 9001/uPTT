using CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace uPTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*public enum HookType : int
        {
            WH_JOURNALRECORD = 0,
            WH_JOURNALPLAYBACK = 1,
            WH_KEYBOARD = 2,
            WH_GETMESSAGE = 3,
            WH_CALLWNDPROC = 4,
            WH_CBT = 5,
            WH_SYSMSGFILTER = 6,
            WH_MOUSE = 7,
            WH_HARDWARE = 8,
            WH_DEBUG = 9,
            WH_SHELL = 10,
            WH_FOREGROUNDIDLE = 11,
            WH_CALLWNDPROCRET = 12,
            WH_KEYBOARD_LL = 13,
            WH_MOUSE_LL = 14
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(HookType code, HookProc func, IntPtr hInstance, int threadID);

        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        delegate int HookProc(int code, IntPtr wParam, IntPtr lParam);
        private HookProc cbDelegate = null;

        int cbFunction(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code < 0)
                return CallNextHookEx(IntPtr.Zero, code, wParam, lParam);

            Keys key = (Keys)wParam.ToInt32();
            this.Text = key.ToString();

            return CallNextHookEx(IntPtr.Zero, code, wParam, lParam);
        }*/

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        Keys pttkey;
        bool inptt;
        bool muted;
        bool feedback;
        System.Media.SoundPlayer on, off;

        void Form1_Load(object sender, EventArgs e)
        {
            pttkey = Keys.None;
            inptt = false;
            muted = true;
            feedback = false;

            try
            {
                string[] config = File.ReadAllLines("uptt.ini", Encoding.UTF8);
                pttkey = (Keys)(Convert.ToInt32(config[0]));
                _key.Text = config[1];
                Boolean.TryParse(config[2], out feedback);
                feedbackCheckBox.Checked = feedback;
            }
            catch (Exception ex)
            {
                _key.Text = "NOT SET";
                pttkey = Keys.None;
            }
            try
            {
                if (!File.Exists("uptt-on.wav"))
                    using (var fso = new FileStream("uptt-on.wav", FileMode.Create))
                    using (var strm = System.Reflection.Assembly.
                    GetExecutingAssembly().GetManifestResourceStream(
                    "uPTT.uptt-on.wav"))
                        strm.CopyTo(fso);

                if (!File.Exists("uptt-off.wav"))
                    using (var fso = new FileStream("uptt-off.wav", FileMode.Create))
                    using (var strm = System.Reflection.Assembly.
                    GetExecutingAssembly().GetManifestResourceStream(
                    "uPTT.uptt-off.wav"))
                        strm.CopyTo(fso);
            }
            catch (Exception ex)
            {

            }

            //RegisterHotKey(this.Handle, 0, 0, (int)Keys.XButton1);

            //cbDelegate = new HookProc(this.cbFunction);
            //SetWindowsHookEx(HookType.WH_KEYBOARD, this.cbDelegate, IntPtr.Zero, AppDomain.GetCurrentThreadId());

            on = off = null;
            if (File.Exists("uptt-on.wav"))
                on = new System.Media.SoundPlayer("uptt-on.wav");
            if (File.Exists("uptt-off.wav"))
                off = new System.Media.SoundPlayer("uptt-off.wav");

            Timer t = new Timer();
            t.Tick += pttcheck;
            t.Interval = 10;
            t.Start();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x0312)
            {
                this.Text = DateTime.UtcNow.Ticks.ToString();
            }
        }

        void pttcheck(object sender, EventArgs e)
        {
            if (inptt || pttkey == Keys.None)
                return;
            inptt = true;

            int gaks = GetAsyncKeyState(pttkey);

            if (gaks < 0)
                SetMute(false);
            else
                SetMute(true);

            inptt = false;
        }

        void SetMute(bool newstate)
        {
            if (muted == newstate)
                return;
            muted = newstate;
            MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
            var device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eCapture, ERole.eMultimedia);
            device.AudioEndpointVolume.Mute = muted;
            var au = muted ? off : on;
            if (au != null && feedback)
                au.Play();
        }

        List<Keys> getkeys()
        {
            var ret = new List<Keys>();
            var keys = Enum.GetValues(typeof(Keys)).Cast<Keys>();
            foreach (var key in keys)
                if (GetAsyncKeyState(key) < 0)
                    ret.Add(key);
            return ret;
        }

        private void saveConfig()
        {
            File.WriteAllText("uptt.ini", (int)pttkey + "\r\n" + _key.Text + "\r\n" + (bool)feedback, Encoding.UTF8);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //UnregisterHotKey(this.Handle, 0);
            saveConfig();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                if (FormWindowState.Minimized == this.WindowState)
                {
                    Hide();
                    notifyIcon.Visible = true;
                    this.ShowInTaskbar = false; 
                }
                else if (FormWindowState.Normal == this.WindowState)
                {
                    Show();
                    this.WindowState = FormWindowState.Normal;
                    notifyIcon.Visible = false;
                    this.ShowInTaskbar = true;
                }
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
            this.ShowInTaskbar = true;
        }

        private void feedbackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            feedback = feedbackCheckBox.Checked;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveConfig();
            System.Windows.Forms.Application.Exit();
        }

        void _pick_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            var badkeys = getkeys();
            //this.Text = badkeys.Count.ToString();
            Timer t1 = new Timer();
            Timer t2 = new Timer();
            t1.Interval = 200;
            t2.Interval = 10;

            t1.Tick += (oa, ob) =>
            {
                t1.Stop();
                badkeys = getkeys();
                form.Show();
                t2.Start();
            };

            t2.Tick += (oa, ob) =>
            {
                t2.Stop();
                var keys = getkeys();
                foreach (var key in badkeys)
                    if (keys.Contains(key))
                        keys.Remove(key);

                if (keys.Count > 0)
                {
                    if (keys.Count > 1)
                    {
                        MessageBox.Show("too many keys pressed, aborting");
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                    }
                    _key.Text = keys[0].ToString();
                    pttkey = keys[0];
                    form.Hide();
                    this.Show();
                    return;
                }
                t2.Start();
            };

            t1.Start();
        }

    }
}