
namespace Diplom
{
    partial class RestorePassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestorePassword));
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.TxtPasswordRepeat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicPasswordHelp = new System.Windows.Forms.PictureBox();
            this.PnlRecovery = new System.Windows.Forms.Panel();
            this.LblRecoveryMode = new System.Windows.Forms.Label();
            this.CbRecoveryMode = new System.Windows.Forms.ComboBox();
            this.CbPasswordShow = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.ErrEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.TmrEmail = new System.Windows.Forms.Timer(this.components);
            this.successOk = new System.Windows.Forms.ErrorProvider(this.components);
            this.TmrSecret = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPasswordHelp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.successOk)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtLogin
            // 
            this.TxtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtLogin.Location = new System.Drawing.Point(33, 35);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(186, 22);
            this.TxtLogin.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(30, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 16);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Логин";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPassword.Location = new System.Drawing.Point(33, 251);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(186, 22);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(30, 232);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Новый пароль";
            // 
            // TxtPasswordRepeat
            // 
            this.TxtPasswordRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPasswordRepeat.Location = new System.Drawing.Point(33, 277);
            this.TxtPasswordRepeat.Name = "TxtPasswordRepeat";
            this.TxtPasswordRepeat.Size = new System.Drawing.Size(186, 22);
            this.TxtPasswordRepeat.TabIndex = 1;
            this.TxtPasswordRepeat.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.PicPasswordHelp);
            this.panel1.Controls.Add(this.PnlRecovery);
            this.panel1.Controls.Add(this.LblRecoveryMode);
            this.panel1.Controls.Add(this.CbRecoveryMode);
            this.panel1.Controls.Add(this.CbPasswordShow);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.TxtLogin);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.TxtPasswordRepeat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 389);
            this.panel1.TabIndex = 3;
            // 
            // PicPasswordHelp
            // 
            this.PicPasswordHelp.Image = global::Diplom.Properties.Resources.question_mark_16px;
            this.PicPasswordHelp.Location = new System.Drawing.Point(204, 234);
            this.PicPasswordHelp.Name = "PicPasswordHelp";
            this.PicPasswordHelp.Size = new System.Drawing.Size(15, 16);
            this.PicPasswordHelp.TabIndex = 18;
            this.PicPasswordHelp.TabStop = false;
            this.PicPasswordHelp.MouseHover += new System.EventHandler(this.PicPasswordHelp_MouseHover);
            // 
            // PnlRecovery
            // 
            this.PnlRecovery.Location = new System.Drawing.Point(33, 108);
            this.PnlRecovery.Name = "PnlRecovery";
            this.PnlRecovery.Size = new System.Drawing.Size(216, 120);
            this.PnlRecovery.TabIndex = 17;
            // 
            // LblRecoveryMode
            // 
            this.LblRecoveryMode.AutoSize = true;
            this.LblRecoveryMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblRecoveryMode.Location = new System.Drawing.Point(30, 60);
            this.LblRecoveryMode.Name = "LblRecoveryMode";
            this.LblRecoveryMode.Size = new System.Drawing.Size(167, 16);
            this.LblRecoveryMode.TabIndex = 16;
            this.LblRecoveryMode.Text = "Способ восстановления";
            // 
            // CbRecoveryMode
            // 
            this.CbRecoveryMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRecoveryMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbRecoveryMode.FormattingEnabled = true;
            this.CbRecoveryMode.Items.AddRange(new object[] {
            "Секретное слово",
            "Код подтверждения"});
            this.CbRecoveryMode.Location = new System.Drawing.Point(33, 79);
            this.CbRecoveryMode.Name = "CbRecoveryMode";
            this.CbRecoveryMode.Size = new System.Drawing.Size(186, 23);
            this.CbRecoveryMode.TabIndex = 15;
            this.CbRecoveryMode.SelectedIndexChanged += new System.EventHandler(this.CbRecoveryMode_SelectedIndexChanged);
            // 
            // CbPasswordShow
            // 
            this.CbPasswordShow.AutoSize = true;
            this.CbPasswordShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbPasswordShow.Location = new System.Drawing.Point(33, 305);
            this.CbPasswordShow.Name = "CbPasswordShow";
            this.CbPasswordShow.Size = new System.Drawing.Size(90, 20);
            this.CbPasswordShow.TabIndex = 13;
            this.CbPasswordShow.Text = "Показать";
            this.CbPasswordShow.UseVisualStyleBackColor = true;
            this.CbPasswordShow.CheckedChanged += new System.EventHandler(this.CbPasswordShow_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.BtnReset);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 49);
            this.panel2.TabIndex = 4;
            // 
            // BtnClose
            // 
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClose.Location = new System.Drawing.Point(136, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(134, 49);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "Закрыть";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnReset.Location = new System.Drawing.Point(0, 0);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(136, 49);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "Сбросить";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // ErrEmail
            // 
            this.ErrEmail.ContainerControl = this;
            // 
            // TmrEmail
            // 
            this.TmrEmail.Interval = 1000;
            this.TmrEmail.Tick += new System.EventHandler(this.TmrEmail_Tick);
            // 
            // successOk
            // 
            this.successOk.ContainerControl = this;
            this.successOk.Icon = ((System.Drawing.Icon)(resources.GetObject("successOk.Icon")));
            // 
            // TmrSecret
            // 
            this.TmrSecret.Interval = 1000;
            this.TmrSecret.Tick += new System.EventHandler(this.TmrSecret_Tick);
            // 
            // RestorePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 389);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RestorePassword";
            this.Text = "Сброс пароля";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RestorePassword_FormClosing);
            this.Load += new System.EventHandler(this.RestorePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPasswordHelp)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.successOk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox TxtPasswordRepeat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.CheckBox CbPasswordShow;
        private System.Windows.Forms.ErrorProvider ErrEmail;
        private System.Windows.Forms.ComboBox CbRecoveryMode;
        private System.Windows.Forms.Panel PnlRecovery;
        private System.Windows.Forms.Label LblRecoveryMode;
        private System.Windows.Forms.Timer TmrEmail;
        private System.Windows.Forms.PictureBox PicPasswordHelp;
        private System.Windows.Forms.ErrorProvider successOk;
        private System.Windows.Forms.Timer TmrSecret;
    }
}