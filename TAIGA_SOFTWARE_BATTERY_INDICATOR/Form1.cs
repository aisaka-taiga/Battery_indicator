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

namespace BATTERY_INDICATOR
{
    public partial class Form1 : Form
    {
        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
        public Form1()
        {
            InitializeComponent();
            string ddd = NextValue().ToString("R");
            CreateTextIcon(ddd);
            this.Visible = false;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;


            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 30000;
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
        int Textsize_modi = 10;
        void timer_tick(object sender, System.EventArgs e)
        {
            string ddd = NextValue().ToString("R");
            CreateTextIcon(ddd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(ddd);
        }
        float NextValue()
        {
            System.Windows.Forms.PowerStatus ps = System.Windows.Forms.SystemInformation.PowerStatus;
            return ps.BatteryLifePercent * 100;
        }
        public void CreateTextIcon(string str)
        {
            //105
            Font fontToUse = new Font("Microsoft Sans Serif", Textsize_modi, FontStyle.Regular, GraphicsUnit.Pixel);
            Brush brushToUse = new SolidBrush(Color.White);
            if (NextValue() <= 9)
            {
                fontToUse = new Font("Microsoft Sans Serif", 88);
                brushToUse = new SolidBrush(Color.Red);
            }
            if (NextValue() >= 10)
            {//85
                fontToUse = new Font("Microsoft Sans Serif", 85);
                brushToUse = new SolidBrush(Color.White);
            }
            if (NextValue() == 100)
            {
                fontToUse = new Font("Microsoft Sans Serif", 57);
                brushToUse = new SolidBrush(Color.Green);
                // MessageBox.Show("배터리가 완전히 충전되었습니다.");
            }
            Bitmap bitmapText = new Bitmap(128, 128);
            Graphics g = System.Drawing.Graphics.FromImage(bitmapText);

            IntPtr hIcon;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            g.DrawString(str, fontToUse, brushToUse, -10, 15);
            hIcon = (bitmapText.GetHicon());
            notifyIcon1.Icon = System.Drawing.Icon.FromHandle(hIcon);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (registryKey.GetValue("TAIGASOFTWARE_BATTERYSTATUS") == null)
            {
                ddToolStripMenuItem.Checked = true;
                registryKey.SetValue("TAIGASOFTWARE_BATTERYSTATUS", Application.ExecutablePath.ToString());
            }
            if (registryKey.GetValue("TAIGASOFTWARE_BATTERYSTATUS") == null)
            {
                registryKey.DeleteValue("TAIGASOFTWARE_BATTERYSTATUS", false);
            }
        }
    }
}
