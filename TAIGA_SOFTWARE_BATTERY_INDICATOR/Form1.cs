using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BATTERY_INDICATOR
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
        public Form1()
        {
            Setting.Load();
            InitializeComponent();
            string ddd = BatteryState.ToString("R");
            CreateTextIcon(ddd);
            this.Visible = false;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.Sizable;
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
            string ddd = BatteryState.ToString("R");
            CreateTextIcon(ddd);
            GC.Collect();
        }

        float BatteryState => SystemInformation.PowerStatus.BatteryLifePercent * 100;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

        private Dictionary<Color, SolidBrush> brushs = new Dictionary<Color, SolidBrush>()
        {
            {Color.White,new SolidBrush(Color.White) },
            {Color.Red,new SolidBrush(Color.Red) },
            {Color.Green,new SolidBrush(Color.Green) },
        };

        public void CreateTextIcon(string str)
        {
            var brushToUse = brushs[Color.White];
            if (BatteryState <= 9)
            {
                brushToUse = brushs[Color.Red];
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
            else
            {
                Setting.AlreadyCall = false;
            }
            Bitmap bitmapText = new Bitmap(Setting.Width, Setting.Height);
            Graphics g = System.Drawing.Graphics.FromImage(bitmapText);

            IntPtr hIcon;

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            g.DrawString(str, Setting.IconFont, brushToUse, Setting.X,Setting.Y);
            hIcon = (bitmapText.GetHicon());
            Icon thisisicon = notifyIcon1.Icon = System.Drawing.Icon.FromHandle(hIcon);
            DestroyIcon(thisisicon.Handle);
            
            g.Dispose();
            bitmapText.Dispose();
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
            SettingForm form = new SettingForm();
            form.ShowDialog();
            CreateTextIcon(BatteryState.ToString("R"));
        }
    }
}