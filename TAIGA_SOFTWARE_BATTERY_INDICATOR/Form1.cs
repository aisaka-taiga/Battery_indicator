//#define TEST
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace BATTERY_INDICATOR
{
    public partial class Form1 : Form
    {
#if TEST
        string TestStr = "  6  ";
#endif
        Timer timer = new Timer();
        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
        public Form1()
        {
            Setting.Load();
            InitializeComponent();
            CreateTextIcon();
            this.Visible = false;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            Setting.AlreadyCall = false;
            timer.Interval = 25000;
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();

            if (registryKey.GetValue("TAIGASOFTWARE_BATTERYSTATUS") == null)
            {
                ddToolStripMenuItem.Checked = false;
            }
            else
            {
                ddToolStripMenuItem.Checked = true;
                ddToolStripMenuItem.CheckState = CheckState.Checked;
            }
        }

        void timer_tick(object sender, System.EventArgs e)
        {
            CreateTextIcon();
            GC.Collect();
        }

        float BatteryState => SystemInformation.PowerStatus.BatteryLifePercent * 100;
        string BatteryString
        {
            get
            {
                var str = BatteryState.ToString("R");
                if (str.Length == 3)//100%
                    return str;
                else if (str.Length == 2)//10%~99%
                    return " " + str + " ";
                else//1%~9%
                    return "  " + str + "  ";
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

        private Dictionary<Color, SolidBrush> brushs = new Dictionary<Color, SolidBrush>()
        {
            {Color.White,new SolidBrush(Color.White) },
            {Color.Red,new SolidBrush(Color.Red) },
            {Color.Green,new SolidBrush(Color.Green) },
        };

        public void CreateTextIcon()
        {
#if TEST
            Bitmap bitmapText = new Bitmap(Setting.Width, Setting.Height);
            Graphics g = Graphics.FromImage(bitmapText);

            IntPtr hIcon;

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            g.DrawString(TestStr, Setting.IconFont, brushs[Color.White], Setting.X, Setting.Y);
            hIcon = (bitmapText.GetHicon());
            Icon thisisicon = notifyIcon1.Icon = Icon.FromHandle(hIcon);
            DestroyIcon(thisisicon.Handle);

            g.Dispose();
            bitmapText.Dispose();
#else
            var brushToUse = brushs[Color.White];
            if (BatteryState <= 9)
            {
                brushToUse = brushs[Color.Red];
                Setting.AlreadyCall = false;
            }
            if (BatteryState >= 10)
            {//85
                brushToUse = brushs[Color.White];
            }
            if (BatteryState == 100)
            {
                brushToUse = brushs[Color.Green];
                if (Setting.ShowIfFull)
                {
                    if (!Setting.AlreadyCall)
                    {
                        MessageBox.Show("배터리가 완전히 충전되었습니다.");
                        Setting.AlreadyCall = true;
                    }
                }
            }
            Bitmap bitmapText = new Bitmap(Setting.Width, Setting.Height);
            Graphics g = System.Drawing.Graphics.FromImage(bitmapText);

            IntPtr hIcon;

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            g.DrawString(BatteryString, Setting.IconFont, brushToUse, Setting.X,Setting.Y);
            hIcon = (bitmapText.GetHicon());
            notifyIcon1.Text = "배터리" + BatteryString;
            Icon thisisicon = notifyIcon1.Icon = System.Drawing.Icon.FromHandle(hIcon);
            DestroyIcon(thisisicon.Handle);
            
            g.Dispose();
            bitmapText.Dispose();
#endif
#if DEBUG
            try
            {
                //
            }
            catch (System.Runtime.InteropServices.ExternalException e)
            {
                System.Console.WriteLine(e.Message);
            }
#endif
        }

        private void ddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (registryKey.GetValue("TAIGASOFTWARE_BATTERYSTATUS") == null)
            {
                ddToolStripMenuItem.Checked = true;
                registryKey.SetValue("TAIGASOFTWARE_BATTERYSTATUS", Application.ExecutablePath);
            }
            else if (ddToolStripMenuItem.Checked == true)
            {
                registryKey.DeleteValue("TAIGASOFTWARE_BATTERYSTATUS", false);
                ddToolStripMenuItem.Checked = false;
            }
        }

        private void dd2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Setting.Save();
            Setting.IconFont.Dispose();
            foreach(var brush in brushs)
                brush.Value.Dispose();
            timer.Dispose();
            Application.Exit();
        }

        private void 설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            SettingForm form = new SettingForm();
            form.ShowDialog();
            CreateTextIcon();
            timer.Start();
        }
    }
}