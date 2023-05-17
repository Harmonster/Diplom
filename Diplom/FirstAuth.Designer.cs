
namespace Diplom
{
    partial class FirstAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstAuth));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChbPassword = new System.Windows.Forms.CheckBox();
            this.ChbSecrets = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblWarning = new System.Windows.Forms.Label();
            this.BtnSend = new System.Windows.Forms.Button();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblSecret = new System.Windows.Forms.Label();
            this.TxtSecret = new System.Windows.Forms.TextBox();
            this.TxtPasswordRepeat = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.ChbPassword);
            this.panel1.Controls.Add(this.ChbSecrets);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LblWarning);
            this.panel1.Controls.Add(this.BtnSend);
            this.panel1.Controls.Add(this.LblPassword);
            this.panel1.Controls.Add(this.LblSecret);
            this.panel1.Controls.Add(this.TxtSecret);
            this.panel1.Controls.Add(this.TxtPasswordRepeat);
            this.panel1.Controls.Add(this.TxtPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 376);
            this.panel1.TabIndex = 0;
            // 
            // ChbPassword
            // 
            this.ChbPassword.AutoSize = true;
            this.ChbPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChbPassword.Location = new System.Drawing.Point(74, 274);
            this.ChbPassword.Name = "ChbPassword";
            this.ChbPassword.Size = new System.Drawing.Size(81, 20);
            this.ChbPassword.TabIndex = 10;
            this.ChbPassword.Text = "Показать";
            this.ChbPassword.UseVisualStyleBackColor = true;
            this.ChbPassword.CheckedChanged += new System.EventHandler(this.ChbPassword_CheckedChanged);
            // 
            // ChbSecrets
            // 
            this.ChbSecrets.AutoSize = true;
            this.ChbSecrets.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChbSecrets.Location = new System.Drawing.Point(74, 145);
            this.ChbSecrets.Name = "ChbSecrets";
            this.ChbSecrets.Size = new System.Drawing.Size(81, 20);
            this.ChbSecrets.TabIndex = 9;
            this.ChbSecrets.Text = "Показать";
            this.ChbSecrets.UseVisualStyleBackColor = true;
            this.ChbSecrets.CheckedChanged += new System.EventHandler(this.СhbSecret_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(98, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "и сохранить данные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Вам необходимо указать секретное слово и пароль";
            // 
            // LblWarning
            // 
            this.LblWarning.BackColor = System.Drawing.SystemColors.Control;
            this.LblWarning.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblWarning.ForeColor = System.Drawing.Color.Red;
            this.LblWarning.Location = new System.Drawing.Point(12, 9);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.Size = new System.Drawing.Size(324, 23);
            this.LblWarning.TabIndex = 6;
            this.LblWarning.Text = "Система зарегистрировала что это ваш первый вход";
            // 
            // BtnSend
            // 
            this.BtnSend.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSend.Location = new System.Drawing.Point(114, 327);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(111, 37);
            this.BtnSend.TabIndex = 5;
            this.BtnSend.Text = "Сохранить";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPassword.Location = new System.Drawing.Point(71, 197);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(92, 16);
            this.LblPassword.TabIndex = 4;
            this.LblPassword.Text = "Новый пароль";
            // 
            // LblSecret
            // 
            this.LblSecret.AutoSize = true;
            this.LblSecret.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSecret.Location = new System.Drawing.Point(71, 97);
            this.LblSecret.Name = "LblSecret";
            this.LblSecret.Size = new System.Drawing.Size(108, 16);
            this.LblSecret.TabIndex = 3;
            this.LblSecret.Text = "Секретное слово";
            // 
            // TxtSecret
            // 
            this.TxtSecret.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtSecret.Location = new System.Drawing.Point(74, 116);
            this.TxtSecret.MaxLength = 50;
            this.TxtSecret.Name = "TxtSecret";
            this.TxtSecret.Size = new System.Drawing.Size(189, 23);
            this.TxtSecret.TabIndex = 0;
            this.TxtSecret.UseSystemPasswordChar = true;
            // 
            // TxtPasswordRepeat
            // 
            this.TxtPasswordRepeat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPasswordRepeat.Location = new System.Drawing.Point(74, 245);
            this.TxtPasswordRepeat.MaxLength = 50;
            this.TxtPasswordRepeat.Name = "TxtPasswordRepeat";
            this.TxtPasswordRepeat.Size = new System.Drawing.Size(189, 23);
            this.TxtPasswordRepeat.TabIndex = 2;
            this.TxtPasswordRepeat.UseSystemPasswordChar = true;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPassword.Location = new System.Drawing.Point(74, 216);
            this.TxtPassword.MaxLength = 50;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(189, 23);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // FirstAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 376);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstAuth";
            this.Text = "Первый вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FirstAuth_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblSecret;
        private System.Windows.Forms.TextBox TxtSecret;
        private System.Windows.Forms.TextBox TxtPasswordRepeat;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblWarning;
        private System.Windows.Forms.CheckBox ChbPassword;
        private System.Windows.Forms.CheckBox ChbSecrets;
    }
}