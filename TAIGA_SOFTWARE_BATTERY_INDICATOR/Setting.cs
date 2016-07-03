using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace BATTERY_INDICATOR
{
    public static class Setting
    {
        [Serializable]
        private struct SettingData
        {
            public Font font;
            public float x, y;
            public int width, height;
            public bool showIfFull;
        }
        private static string SettingPath => Application.StartupPath + "\\Setting.dat";
        private static BinaryFormatter formatter => new BinaryFormatter();
        /*
         * Icon Color Setting
         * 
         * public int Low,Middle.High
         * public Color Low,Middle,High
         */
        public static void Save()
        {
            using (FileStream fs = new FileStream(SettingPath, FileMode.Create))
            {
                formatter.Serialize(fs, new SettingData()
                {
                    font = IconFont,
                    x = X,
                    y = Y,
                    width = Width,
                    height = Height,
                    showIfFull = ShowIfFull,
                });
            }
        }
        public static void Load()
        {
            if (!File.Exists(SettingPath))
                return;
            try
            {
                using (FileStream fs = new FileStream(SettingPath, FileMode.Open))
                {
                    SettingData dat = (SettingData)formatter.Deserialize(fs);
                    IconFont = dat.font;
                    X = dat.x;
                    Y = dat.y;
                    Width = dat.width;
                    Height = dat.height;
                    ShowIfFull = dat.showIfFull;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        /*
         * FHD optimize
         * 
         * Need to add presets(1440p,2160p...)
         */
        public static Font IconFont = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
        public static float X = -8, Y = 4;
        public static int Width = 32, Height = 32;
        public static bool ShowIfFull = true;
        public static bool AlreadyCall = true;//Don't show if already full
    }
}
