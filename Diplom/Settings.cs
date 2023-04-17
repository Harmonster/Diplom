using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salaros.Configuration;

namespace Diplom
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void cb_colorTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_colorTheme.SelectedItem.ToString() == "Светлая")
            {
                Classes.ApplicationSettings.cfg.SetValue("Appereance", "ColorTheme", "0");
            }
            else if (cb_colorTheme.SelectedItem.ToString() == "Тёмная")
            {
                Classes.ApplicationSettings.cfg.SetValue("Appereance", "ColorTheme", "1");
            }
        }

        private void btn_settingsSave_Click(object sender, EventArgs e)
        {
            Classes.ApplicationSettings.cfg.Save();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
