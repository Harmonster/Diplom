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

        private void GetSettings()
        {
            TxtSmtpServer.Text = Properties.Settings.Default.SmtpServer;
            TxtSmtpAddress.Text = Properties.Settings.Default.SmtpEmail;
            TxtSmtpPassword.Text = Properties.Settings.Default.SmtpPassword;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.SmtpServer = TxtSmtpServer.Text;
            Properties.Settings.Default.SmtpEmail = TxtSmtpAddress.Text;
            Properties.Settings.Default.SmtpPassword = TxtSmtpPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void btn_settingsSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены что хотите изменить настройки?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SaveSettings();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            GetSettings();
        }
    }
}
