
namespace Diplom
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl_background = new System.Windows.Forms.Panel();
            this.pl_workplace = new System.Windows.Forms.Panel();
            this.pl_leftMenu = new System.Windows.Forms.Panel();
            this.pl_menu_report = new System.Windows.Forms.Panel();
            this.pl_menu_reportHighlight = new System.Windows.Forms.Panel();
            this.btn_reports = new System.Windows.Forms.Button();
            this.pl_menu_staff = new System.Windows.Forms.Panel();
            this.pl_menu_staffHighlight = new System.Windows.Forms.Panel();
            this.btn_staff = new System.Windows.Forms.Button();
            this.pl_menu_tickets = new System.Windows.Forms.Panel();
            this.pl_menu_ticketsHighlight = new System.Windows.Forms.Panel();
            this.btn_tickets = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.pl_menu_spacer = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pl_header = new System.Windows.Forms.Panel();
            this.pl_currUser = new System.Windows.Forms.Panel();
            this.lb_currUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pl_menu_header = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pl_background.SuspendLayout();
            this.pl_leftMenu.SuspendLayout();
            this.pl_menu_report.SuspendLayout();
            this.pl_menu_staff.SuspendLayout();
            this.pl_menu_tickets.SuspendLayout();
            this.pl_header.SuspendLayout();
            this.pl_currUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pl_menu_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_background
            // 
            this.pl_background.Controls.Add(this.pl_workplace);
            this.pl_background.Controls.Add(this.pl_leftMenu);
            this.pl_background.Controls.Add(this.pl_header);
            this.pl_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_background.Location = new System.Drawing.Point(0, 0);
            this.pl_background.Name = "pl_background";
            this.pl_background.Size = new System.Drawing.Size(953, 513);
            this.pl_background.TabIndex = 0;
            // 
            // pl_workplace
            // 
            this.pl_workplace.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pl_workplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pl_workplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_workplace.Location = new System.Drawing.Point(135, 42);
            this.pl_workplace.Name = "pl_workplace";
            this.pl_workplace.Size = new System.Drawing.Size(818, 471);
            this.pl_workplace.TabIndex = 2;
            // 
            // pl_leftMenu
            // 
            this.pl_leftMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pl_leftMenu.Controls.Add(this.pl_menu_report);
            this.pl_leftMenu.Controls.Add(this.pl_menu_staff);
            this.pl_leftMenu.Controls.Add(this.pl_menu_tickets);
            this.pl_leftMenu.Controls.Add(this.btn_settings);
            this.pl_leftMenu.Controls.Add(this.pl_menu_spacer);
            this.pl_leftMenu.Controls.Add(this.btn_logout);
            this.pl_leftMenu.Controls.Add(this.panel1);
            this.pl_leftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_leftMenu.Location = new System.Drawing.Point(0, 42);
            this.pl_leftMenu.Name = "pl_leftMenu";
            this.pl_leftMenu.Size = new System.Drawing.Size(135, 471);
            this.pl_leftMenu.TabIndex = 1;
            // 
            // pl_menu_report
            // 
            this.pl_menu_report.Controls.Add(this.pl_menu_reportHighlight);
            this.pl_menu_report.Controls.Add(this.btn_reports);
            this.pl_menu_report.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_menu_report.Location = new System.Drawing.Point(0, 105);
            this.pl_menu_report.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pl_menu_report.Name = "pl_menu_report";
            this.pl_menu_report.Size = new System.Drawing.Size(135, 45);
            this.pl_menu_report.TabIndex = 3;
            // 
            // pl_menu_reportHighlight
            // 
            this.pl_menu_reportHighlight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pl_menu_reportHighlight.Location = new System.Drawing.Point(124, 0);
            this.pl_menu_reportHighlight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pl_menu_reportHighlight.Name = "pl_menu_reportHighlight";
            this.pl_menu_reportHighlight.Size = new System.Drawing.Size(11, 45);
            this.pl_menu_reportHighlight.TabIndex = 0;
            // 
            // btn_reports
            // 
            this.btn_reports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reports.FlatAppearance.BorderSize = 0;
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_reports.Image = global::Diplom.Properties.Resources.report_32px_dark;
            this.btn_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reports.Location = new System.Drawing.Point(0, 0);
            this.btn_reports.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.btn_reports.Size = new System.Drawing.Size(135, 45);
            this.btn_reports.TabIndex = 2;
            this.btn_reports.Text = "Отчёт";
            this.btn_reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reports.UseVisualStyleBackColor = true;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // pl_menu_staff
            // 
            this.pl_menu_staff.Controls.Add(this.pl_menu_staffHighlight);
            this.pl_menu_staff.Controls.Add(this.btn_staff);
            this.pl_menu_staff.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_menu_staff.Location = new System.Drawing.Point(0, 60);
            this.pl_menu_staff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pl_menu_staff.Name = "pl_menu_staff";
            this.pl_menu_staff.Size = new System.Drawing.Size(135, 45);
            this.pl_menu_staff.TabIndex = 3;
            // 
            // pl_menu_staffHighlight
            // 
            this.pl_menu_staffHighlight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pl_menu_staffHighlight.Location = new System.Drawing.Point(124, 0);
            this.pl_menu_staffHighlight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pl_menu_staffHighlight.Name = "pl_menu_staffHighlight";
            this.pl_menu_staffHighlight.Size = new System.Drawing.Size(11, 45);
            this.pl_menu_staffHighlight.TabIndex = 2;
            // 
            // btn_staff
            // 
            this.btn_staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_staff.FlatAppearance.BorderSize = 0;
            this.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_staff.Image = global::Diplom.Properties.Resources.staff_32px_dark;
            this.btn_staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_staff.Location = new System.Drawing.Point(0, 0);
            this.btn_staff.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Size = new System.Drawing.Size(135, 45);
            this.btn_staff.TabIndex = 1;
            this.btn_staff.Text = "Сотрудники";
            this.btn_staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_staff.UseVisualStyleBackColor = true;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // pl_menu_tickets
            // 
            this.pl_menu_tickets.Controls.Add(this.pl_menu_ticketsHighlight);
            this.pl_menu_tickets.Controls.Add(this.btn_tickets);
            this.pl_menu_tickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_menu_tickets.Location = new System.Drawing.Point(0, 15);
            this.pl_menu_tickets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pl_menu_tickets.Name = "pl_menu_tickets";
            this.pl_menu_tickets.Size = new System.Drawing.Size(135, 45);
            this.pl_menu_tickets.TabIndex = 0;
            // 
            // pl_menu_ticketsHighlight
            // 
            this.pl_menu_ticketsHighlight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pl_menu_ticketsHighlight.Location = new System.Drawing.Point(124, 0);
            this.pl_menu_ticketsHighlight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pl_menu_ticketsHighlight.Name = "pl_menu_ticketsHighlight";
            this.pl_menu_ticketsHighlight.Size = new System.Drawing.Size(11, 45);
            this.pl_menu_ticketsHighlight.TabIndex = 1;
            // 
            // btn_tickets
            // 
            this.btn_tickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_tickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_tickets.FlatAppearance.BorderSize = 0;
            this.btn_tickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tickets.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_tickets.Image = global::Diplom.Properties.Resources.tickets_32px;
            this.btn_tickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tickets.Location = new System.Drawing.Point(0, 0);
            this.btn_tickets.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btn_tickets.Name = "btn_tickets";
            this.btn_tickets.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.btn_tickets.Size = new System.Drawing.Size(135, 45);
            this.btn_tickets.TabIndex = 0;
            this.btn_tickets.Text = "Заявки";
            this.btn_tickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tickets.UseVisualStyleBackColor = true;
            this.btn_tickets.Click += new System.EventHandler(this.btn_tickets_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_settings.Enabled = false;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_settings.Image = global::Diplom.Properties.Resources.settings_32px_dark;
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(0, 369);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(135, 45);
            this.btn_settings.TabIndex = 3;
            this.btn_settings.Text = "Настройки";
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Visible = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // pl_menu_spacer
            // 
            this.pl_menu_spacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_menu_spacer.Location = new System.Drawing.Point(0, 0);
            this.pl_menu_spacer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pl_menu_spacer.Name = "pl_menu_spacer";
            this.pl_menu_spacer.Size = new System.Drawing.Size(135, 15);
            this.pl_menu_spacer.TabIndex = 5;
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_logout.Image = global::Diplom.Properties.Resources.logout_32px_dark;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 414);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(135, 45);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Выход";
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 12);
            this.panel1.TabIndex = 4;
            // 
            // pl_header
            // 
            this.pl_header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pl_header.Controls.Add(this.pl_currUser);
            this.pl_header.Controls.Add(this.pictureBox1);
            this.pl_header.Controls.Add(this.pl_menu_header);
            this.pl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_header.Location = new System.Drawing.Point(0, 0);
            this.pl_header.Name = "pl_header";
            this.pl_header.Size = new System.Drawing.Size(953, 42);
            this.pl_header.TabIndex = 0;
            // 
            // pl_currUser
            // 
            this.pl_currUser.Controls.Add(this.lb_currUser);
            this.pl_currUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_currUser.Location = new System.Drawing.Point(161, 0);
            this.pl_currUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pl_currUser.Name = "pl_currUser";
            this.pl_currUser.Size = new System.Drawing.Size(233, 42);
            this.pl_currUser.TabIndex = 2;
            // 
            // lb_currUser
            // 
            this.lb_currUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_currUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_currUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_currUser.Location = new System.Drawing.Point(0, 0);
            this.lb_currUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_currUser.Name = "lb_currUser";
            this.lb_currUser.Size = new System.Drawing.Size(233, 42);
            this.lb_currUser.TabIndex = 1;
            this.lb_currUser.Text = "%";
            this.lb_currUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Diplom.Properties.Resources.user_32px_dark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(135, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 42);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pl_menu_header
            // 
            this.pl_menu_header.Controls.Add(this.pictureBox2);
            this.pl_menu_header.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_menu_header.Location = new System.Drawing.Point(0, 0);
            this.pl_menu_header.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pl_menu_header.Name = "pl_menu_header";
            this.pl_menu_header.Size = new System.Drawing.Size(135, 42);
            this.pl_menu_header.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Diplom.Properties.Resources.menu_32px_dark;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 513);
            this.Controls.Add(this.pl_background);
            this.Name = "Main";
            this.Text = "Система заявок ККРИТ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.pl_background.ResumeLayout(false);
            this.pl_leftMenu.ResumeLayout(false);
            this.pl_menu_report.ResumeLayout(false);
            this.pl_menu_staff.ResumeLayout(false);
            this.pl_menu_tickets.ResumeLayout(false);
            this.pl_header.ResumeLayout(false);
            this.pl_currUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pl_menu_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_background;
        private System.Windows.Forms.Panel pl_workplace;
        private System.Windows.Forms.Panel pl_leftMenu;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_staff;
        private System.Windows.Forms.Button btn_tickets;
        private System.Windows.Forms.Panel pl_header;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Panel pl_currUser;
        private System.Windows.Forms.Label lb_currUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pl_menu_report;
        private System.Windows.Forms.Panel pl_menu_reportHighlight;
        private System.Windows.Forms.Panel pl_menu_staff;
        private System.Windows.Forms.Panel pl_menu_staffHighlight;
        private System.Windows.Forms.Panel pl_menu_tickets;
        private System.Windows.Forms.Panel pl_menu_ticketsHighlight;
        private System.Windows.Forms.Panel pl_menu_spacer;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pl_menu_header;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

