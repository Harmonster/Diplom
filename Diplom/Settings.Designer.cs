
namespace Diplom
{
    partial class Settings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pl_background = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_settingsSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSmtpAddress = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblSmtpServer = new System.Windows.Forms.Label();
            this.LblSmtpAddress = new System.Windows.Forms.Label();
            this.TxtSmtpServer = new System.Windows.Forms.TextBox();
            this.LblSmtpPassword = new System.Windows.Forms.Label();
            this.TxtSmtpPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pl_background.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pl_background);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 368);
            this.panel1.TabIndex = 0;
            // 
            // pl_background
            // 
            this.pl_background.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pl_background.Controls.Add(this.panel4);
            this.pl_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_background.Location = new System.Drawing.Point(0, 28);
            this.pl_background.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pl_background.Name = "pl_background";
            this.pl_background.Size = new System.Drawing.Size(338, 298);
            this.pl_background.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_close);
            this.panel3.Controls.Add(this.btn_settingsSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 326);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 42);
            this.panel3.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(176, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(162, 42);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Закрыть";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_settingsSave
            // 
            this.btn_settingsSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_settingsSave.Location = new System.Drawing.Point(0, 0);
            this.btn_settingsSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_settingsSave.Name = "btn_settingsSave";
            this.btn_settingsSave.Size = new System.Drawing.Size(176, 42);
            this.btn_settingsSave.TabIndex = 0;
            this.btn_settingsSave.Text = "Сохранить";
            this.btn_settingsSave.UseVisualStyleBackColor = true;
            this.btn_settingsSave.Click += new System.EventHandler(this.btn_settingsSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 28);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки программы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Данные SMTP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtSmtpAddress
            // 
            this.TxtSmtpAddress.Location = new System.Drawing.Point(54, 55);
            this.TxtSmtpAddress.Name = "TxtSmtpAddress";
            this.TxtSmtpAddress.Size = new System.Drawing.Size(160, 20);
            this.TxtSmtpAddress.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LblSmtpPassword);
            this.panel4.Controls.Add(this.TxtSmtpPassword);
            this.panel4.Controls.Add(this.LblSmtpServer);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.LblSmtpAddress);
            this.panel4.Controls.Add(this.TxtSmtpAddress);
            this.panel4.Controls.Add(this.TxtSmtpServer);
            this.panel4.Location = new System.Drawing.Point(12, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 117);
            this.panel4.TabIndex = 2;
            // 
            // LblSmtpServer
            // 
            this.LblSmtpServer.AutoSize = true;
            this.LblSmtpServer.Location = new System.Drawing.Point(4, 30);
            this.LblSmtpServer.Name = "LblSmtpServer";
            this.LblSmtpServer.Size = new System.Drawing.Size(44, 13);
            this.LblSmtpServer.TabIndex = 2;
            this.LblSmtpServer.Text = "Сервер";
            // 
            // LblSmtpAddress
            // 
            this.LblSmtpAddress.AutoSize = true;
            this.LblSmtpAddress.Location = new System.Drawing.Point(4, 58);
            this.LblSmtpAddress.Name = "LblSmtpAddress";
            this.LblSmtpAddress.Size = new System.Drawing.Size(38, 13);
            this.LblSmtpAddress.TabIndex = 4;
            this.LblSmtpAddress.Text = "Адрес";
            // 
            // TxtSmtpServer
            // 
            this.TxtSmtpServer.Location = new System.Drawing.Point(54, 27);
            this.TxtSmtpServer.Name = "TxtSmtpServer";
            this.TxtSmtpServer.Size = new System.Drawing.Size(160, 20);
            this.TxtSmtpServer.TabIndex = 3;
            // 
            // LblSmtpPassword
            // 
            this.LblSmtpPassword.AutoSize = true;
            this.LblSmtpPassword.Location = new System.Drawing.Point(4, 87);
            this.LblSmtpPassword.Name = "LblSmtpPassword";
            this.LblSmtpPassword.Size = new System.Drawing.Size(45, 13);
            this.LblSmtpPassword.TabIndex = 6;
            this.LblSmtpPassword.Text = "Пароль";
            // 
            // TxtSmtpPassword
            // 
            this.TxtSmtpPassword.Location = new System.Drawing.Point(54, 84);
            this.TxtSmtpPassword.Name = "TxtSmtpPassword";
            this.TxtSmtpPassword.Size = new System.Drawing.Size(160, 20);
            this.TxtSmtpPassword.TabIndex = 5;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 368);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.pl_background.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pl_background;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_settingsSave;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblSmtpServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSmtpAddress;
        private System.Windows.Forms.Label LblSmtpPassword;
        private System.Windows.Forms.TextBox TxtSmtpPassword;
        private System.Windows.Forms.Label LblSmtpAddress;
        private System.Windows.Forms.TextBox TxtSmtpServer;
    }
}