using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Main : Form
    {
        private Form activeForm;

        public Main()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pl_workplace.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            var f = new Settings();
            f.ShowDialog(this);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lb_currUser.Text = Classes.AuthorizedUserInfo.UserName;
            OpenChildForm(new Tickets(), sender);

            if (Classes.AuthorizedUserInfo.UserRole != "Администратор")
            {
                pl_menu_operators.Hide();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_tickets_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tickets(), sender);
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff(), sender);
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Report(), sender);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Classes.AuthorizedUserInfo.UserName = string.Empty;
            Auth authForm = new Auth();
            this.Hide();
            authForm.Show();
        }

        private void btn_operators_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Operators(), sender);
        }
    }
}
