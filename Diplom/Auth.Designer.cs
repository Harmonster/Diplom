
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.LblRestore = new System.Windows.Forms.LinkLabel();
            this.CbPasswordShow = new System.Windows.Forms.CheckBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblLogin = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.PnlMain.SuspendLayout();
            this.PnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PnlHeader.Controls.Add(this.LblRestore);
            this.PnlHeader.Controls.Add(this.CbPasswordShow);
            this.PnlHeader.Controls.Add(this.LblPassword);
            this.PnlHeader.Controls.Add(this.LblLogin);
            this.PnlHeader.Controls.Add(this.TxtPassword);
            this.PnlHeader.Controls.Add(this.TxtLogin);
            this.PnlHeader.Controls.Add(this.PbLogo);
            this.PnlHeader.Controls.Add(this.PnlMain);
            this.PnlHeader.Controls.Add(this.PnlFooter);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(216, 358);
            this.PnlHeader.TabIndex = 1;
            // 
            // LblRestore
            // 
            this.LblRestore.AutoSize = true;
            this.LblRestore.Location = new System.Drawing.Point(65, 265);
            this.LblRestore.Name = "LblRestore";
            this.LblRestore.Size = new System.Drawing.Size(91, 13);
            this.LblRestore.TabIndex = 13;
            this.LblRestore.TabStop = true;
            this.LblRestore.Text = "Забыли пароль?";
            this.LblRestore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblRestore_LinkClicked);
            // 
            // CbPasswordShow
            // 
            this.CbPasswordShow.AutoSize = true;
            this.CbPasswordShow.Location = new System.Drawing.Point(32, 290);
            this.CbPasswordShow.Name = "CbPasswordShow";
            this.CbPasswordShow.Size = new System.Drawing.Size(114, 17);
            this.CbPasswordShow.TabIndex = 12;
            this.CbPasswordShow.Text = "Показать пароль";
            this.CbPasswordShow.UseVisualStyleBackColor = true;
            this.CbPasswordShow.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPassword.Location = new System.Drawing.Point(29, 219);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(57, 16);
            this.LblPassword.TabIndex = 11;
            this.LblPassword.Text = "Пароль";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.BackColor = System.Drawing.Color.Transparent;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLogin.Location = new System.Drawing.Point(26, 172);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(47, 16);
            this.LblLogin.TabIndex = 11;
            this.LblLogin.Text = "Логин";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPassword.Location = new System.Drawing.Point(29, 236);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(159, 26);
            this.TxtPassword.TabIndex = 10;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtLogin
            // 
            this.TxtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtLogin.Location = new System.Drawing.Point(29, 188);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(159, 26);
            this.TxtLogin.TabIndex = 9;
            this.TxtLogin.Validating += new System.ComponentModel.CancelEventHandler(this.tb_login_Validating);
            // 
            // PbLogo
            // 
            this.PbLogo.Image = global::Diplom.Properties.Resources.Logos;
            this.PbLogo.Location = new System.Drawing.Point(41, 31);
            this.PbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(134, 139);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 8;
            this.PbLogo.TabStop = false;
            // 
            // PnlMain
            // 
            this.PnlMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnlMain.Controls.Add(this.LblTitle);
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(216, 26);
            this.PnlMain.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(216, 26);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Вход в систему";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlFooter
            // 
            this.PnlFooter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PnlFooter.Controls.Add(this.BtnExit);
            this.PnlFooter.Controls.Add(this.BtnLogin);
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.Location = new System.Drawing.Point(0, 327);
            this.PnlFooter.Margin = new System.Windows.Forms.Padding(2);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(216, 31);
            this.PnlFooter.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.Location = new System.Drawing.Point(108, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(108, 31);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Закрыть";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLogin.Location = new System.Drawing.Point(0, 0);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(108, 31);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Вход";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 358);
            this.Controls.Add(this.PnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Auth";
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Auth_FormClosing);
            this.Load += new System.EventHandler(this.Auth_Load);
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.PnlMain.ResumeLayout(false);
            this.PnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel PnlFooter;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.CheckBox CbPasswordShow;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.LinkLabel LblRestore;
    }
}