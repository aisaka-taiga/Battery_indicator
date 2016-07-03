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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            currentFont.Text = Setting.IconFont?.Name ?? "";
            currentFontSizeTB.Text = Setting.IconFont?.Size.ToString() ?? "";
            xOffset.Value = (decimal)Setting.X;
            yOffset.Value = (decimal)Setting.Y;
            widthNum.Value = Setting.Width;
            heightNum.Value = Setting.Height;
            showIfFullCB.Checked = Setting.ShowIfFull;
        }

        private void changeFontBtn_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.Font = Setting.IconFont;
            dialog.FontMustExist = true;
            dialog.ShowDialog();
            Setting.IconFont = dialog.Font;
            currentFont.Text = dialog.Font.Name;
            currentFontSizeTB.Text = dialog.Font.Size.ToString();
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            Setting.X = (float)xOffset.Value;
            Setting.Y = (float)yOffset.Value;
        }

        private void ResolutionValueChanged(object sender,EventArgs e)
        {
            Setting.Width = (int)widthNum.Value;
            Setting.Height = (int)heightNum.Value;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showIfFullCB_CheckedChanged(object sender, EventArgs e)
        {
            Setting.ShowIfFull = showIfFullCB.Checked;
        }

    }
}
