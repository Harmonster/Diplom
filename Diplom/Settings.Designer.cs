
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
            this.cb_colorTheme = new System.Windows.Forms.ComboBox();
            this.lb_theme = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_settingsSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pl_background.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pl_background);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 453);
            this.panel1.TabIndex = 0;
            // 
            // pl_background
            // 
            this.pl_background.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pl_background.Controls.Add(this.cb_colorTheme);
            this.pl_background.Controls.Add(this.lb_theme);
            this.pl_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_background.Location = new System.Drawing.Point(0, 35);
            this.pl_background.Name = "pl_background";
            this.pl_background.Size = new System.Drawing.Size(451, 366);
            this.pl_background.TabIndex = 2;
            // 
            // cb_colorTheme
            // 
            this.cb_colorTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_colorTheme.FormattingEnabled = true;
            this.cb_colorTheme.Items.AddRange(new object[] {
            "Светлая",
            "Тёмная"});
            this.cb_colorTheme.Location = new System.Drawing.Point(234, 30);
            this.cb_colorTheme.Name = "cb_colorTheme";
            this.cb_colorTheme.Size = new System.Drawing.Size(171, 24);
            this.cb_colorTheme.TabIndex = 1;
            this.cb_colorTheme.SelectedIndexChanged += new System.EventHandler(this.cb_colorTheme_SelectedIndexChanged);
            // 
            // lb_theme
            // 
            this.lb_theme.AutoSize = true;
            this.lb_theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_theme.Location = new System.Drawing.Point(46, 29);
            this.lb_theme.Name = "lb_theme";
            this.lb_theme.Size = new System.Drawing.Size(156, 25);
            this.lb_theme.TabIndex = 0;
            this.lb_theme.Text = "Цветовая тема";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_close);
            this.panel3.Controls.Add(this.btn_settingsSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 52);
            this.panel3.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(234, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(217, 52);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Закрыть";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_settingsSave
            // 
            this.btn_settingsSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_settingsSave.Location = new System.Drawing.Point(0, 0);
            this.btn_settingsSave.Name = "btn_settingsSave";
            this.btn_settingsSave.Size = new System.Drawing.Size(234, 52);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 35);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки программы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 453);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.panel1.ResumeLayout(false);
            this.pl_background.ResumeLayout(false);
            this.pl_background.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cb_colorTheme;
        private System.Windows.Forms.Label lb_theme;
    }
}