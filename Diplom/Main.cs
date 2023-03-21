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
            lb_currUser.Text = AuthorizedUserInfo.UserName;
            OpenChildForm(new Tickets(), sender);
            
            //if (AuthorizedUserInfo.UserRole == "Администратор")
            //{
            //    pl_menu_operators.Show();
            //    this.Text += " РЕЖИМ АДМИНИСТРАТОРА";
            //}
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_tickets_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Tickets(), sender);
            pl_menu_ticketsHighlight.BackColor = Classes.ColorPalette.hightlightOn;
            pl_menu_staffHighlight.BackColor = Classes.ColorPalette.hightlightOff;
            pl_menu_reportHighlight.BackColor = Classes.ColorPalette.hightlightOff;
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff(), sender);
            pl_menu_ticketsHighlight.BackColor = Classes.ColorPalette.hightlightOff;
            pl_menu_staffHighlight.BackColor = Classes.ColorPalette.hightlightOn;
            pl_menu_reportHighlight.BackColor = Classes.ColorPalette.hightlightOff;
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Report(), sender);
            pl_menu_ticketsHighlight.BackColor = Classes.ColorPalette.hightlightOff;
            pl_menu_staffHighlight.BackColor = Classes.ColorPalette.hightlightOff;
            pl_menu_reportHighlight.BackColor = Classes.ColorPalette.hightlightOn;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            AuthorizedUserInfo.UserName = string.Empty;
            Auth authForm = new Auth();
            this.Hide();
            authForm.Show();
        }
    }
}
