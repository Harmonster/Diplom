using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salaros.Configuration;

namespace Diplom.Classes
{
    public class ApplicationSettings
    {
        private static string AppSettingsPath = Application.StartupPath + @"\settings.ini";
        public static ConfigParser cfg = new ConfigParser(AppSettingsPath);
        public static int themeColorValue;

        public static void LoadSettings()
        {
            themeColorValue = Convert.ToInt32(cfg.GetValue("Appereance", "ColorTheme"));
        }
    }
}
