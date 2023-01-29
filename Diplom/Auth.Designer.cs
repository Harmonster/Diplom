
namespace Diplom
{
    partial class Auth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl_header = new System.Windows.Forms.Panel();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.tbp_password = new Diplom.Custom_Elements.TextBoxWithPlaceholder();
            this.tbp_login = new Diplom.Custom_Elements.TextBoxWithPlaceholder();
            this.pl_workplace = new System.Windows.Forms.Panel();
            this.lb_title = new System.Windows.Forms.Label();
            this.pl_footer = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.pl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.pl_workplace.SuspendLayout();
            this.pl_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_header
            // 
            this.pl_header.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pl_header.Controls.Add(this.pb_logo);
            this.pl_header.Controls.Add(this.tbp_password);
            this.pl_header.Controls.Add(this.tbp_login);
            this.pl_header.Controls.Add(this.pl_workplace);
            this.pl_header.Controls.Add(this.pl_footer);
            this.pl_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_header.Location = new System.Drawing.Point(0, 0);
            this.pl_header.Name = "pl_header";
            this.pl_header.Size = new System.Drawing.Size(288, 353);
            this.pl_header.TabIndex = 1;
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::Diplom.Properties.Resources.Logos;
            this.pb_logo.Location = new System.Drawing.Point(55, 38);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(179, 171);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 8;
            this.pb_logo.TabStop = false;
            // 
            // tbp_password
            // 
            this.tbp_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbp_password.Location = new System.Drawing.Point(26, 271);
            this.tbp_password.Name = "tbp_password";
            this.tbp_password.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbp_password.PlaceholderText = "Пароль";
            this.tbp_password.Size = new System.Drawing.Size(228, 30);
            this.tbp_password.TabIndex = 7;
            // 
            // tbp_login
            // 
            this.tbp_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbp_login.Location = new System.Drawing.Point(26, 226);
            this.tbp_login.Name = "tbp_login";
            this.tbp_login.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbp_login.PlaceholderText = "Эл. почта";
            this.tbp_login.Size = new System.Drawing.Size(228, 30);
            this.tbp_login.TabIndex = 6;
            // 
            // pl_workplace
            // 
            this.pl_workplace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pl_workplace.Controls.Add(this.lb_title);
            this.pl_workplace.Dock = System.Windows.Forms.DockStyle.Top;
            this.pl_workplace.Location = new System.Drawing.Point(0, 0);
            this.pl_workplace.Name = "pl_workplace";
            this.pl_workplace.Size = new System.Drawing.Size(288, 32);
            this.pl_workplace.TabIndex = 1;
            // 
            // lb_title
            // 
            this.lb_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_title.Location = new System.Drawing.Point(0, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(288, 32);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Вход в систему";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pl_footer
            // 
            this.pl_footer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pl_footer.Controls.Add(this.btn_exit);
            this.pl_footer.Controls.Add(this.btn_login);
            this.pl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_footer.Location = new System.Drawing.Point(0, 315);
            this.pl_footer.Name = "pl_footer";
            this.pl_footer.Size = new System.Drawing.Size(288, 38);
            this.pl_footer.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(144, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(144, 38);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Закрыть";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_login.Location = new System.Drawing.Point(0, 0);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(144, 38);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Вход";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 353);
            this.Controls.Add(this.pl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Auth";
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Auth_FormClosing);
            this.Load += new System.EventHandler(this.Auth_Load);
            this.pl_header.ResumeLayout(false);
            this.pl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.pl_workplace.ResumeLayout(false);
            this.pl_footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_header;
        private System.Windows.Forms.Panel pl_workplace;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Panel pl_footer;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private Custom_Elements.TextBoxWithPlaceholder tbp_password;
        private Custom_Elements.TextBoxWithPlaceholder tbp_login;
        private System.Windows.Forms.PictureBox pb_logo;
    }
}