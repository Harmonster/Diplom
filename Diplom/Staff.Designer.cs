
namespace Diplom
{
    partial class Staff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pl_background = new System.Windows.Forms.Panel();
            this.dgv_details = new System.Windows.Forms.DataGridView();
            this.pl_spacer = new System.Windows.Forms.Panel();
            this.pl_staffInfo = new System.Windows.Forms.Panel();
            this.mtb_phone = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lb_phone = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.cb_staff = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pl_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
            this.pl_staffInfo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_background
            // 
            this.pl_background.Controls.Add(this.dgv_details);
            this.pl_background.Controls.Add(this.pl_spacer);
            this.pl_background.Controls.Add(this.pl_staffInfo);
            this.pl_background.Controls.Add(this.panel2);
            this.pl_background.Controls.Add(this.panel1);
            this.pl_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_background.Location = new System.Drawing.Point(0, 0);
            this.pl_background.Name = "pl_background";
            this.pl_background.Size = new System.Drawing.Size(800, 450);
            this.pl_background.TabIndex = 0;
            // 
            // dgv_details
            // 
            this.dgv_details.AllowUserToAddRows = false;
            this.dgv_details.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_details.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_details.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_details.Location = new System.Drawing.Point(372, 0);
            this.dgv_details.Name = "dgv_details";
            this.dgv_details.ReadOnly = true;
            this.dgv_details.RowHeadersVisible = false;
            this.dgv_details.RowHeadersWidth = 51;
            this.dgv_details.RowTemplate.Height = 24;
            this.dgv_details.Size = new System.Drawing.Size(413, 435);
            this.dgv_details.TabIndex = 3;
            // 
            // pl_spacer
            // 
            this.pl_spacer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pl_spacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_spacer.Location = new System.Drawing.Point(350, 0);
            this.pl_spacer.Name = "pl_spacer";
            this.pl_spacer.Size = new System.Drawing.Size(22, 435);
            this.pl_spacer.TabIndex = 5;
            // 
            // pl_staffInfo
            // 
            this.pl_staffInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pl_staffInfo.Controls.Add(this.btn_delete);
            this.pl_staffInfo.Controls.Add(this.mtb_phone);
            this.pl_staffInfo.Controls.Add(this.panel4);
            this.pl_staffInfo.Controls.Add(this.lb_phone);
            this.pl_staffInfo.Controls.Add(this.tb_email);
            this.pl_staffInfo.Controls.Add(this.lb_email);
            this.pl_staffInfo.Controls.Add(this.tb_name);
            this.pl_staffInfo.Controls.Add(this.lb_name);
            this.pl_staffInfo.Controls.Add(this.cb_staff);
            this.pl_staffInfo.Controls.Add(this.panel3);
            this.pl_staffInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_staffInfo.Location = new System.Drawing.Point(0, 0);
            this.pl_staffInfo.Name = "pl_staffInfo";
            this.pl_staffInfo.Size = new System.Drawing.Size(350, 435);
            this.pl_staffInfo.TabIndex = 4;
            // 
            // mtb_phone
            // 
            this.mtb_phone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtb_phone.Location = new System.Drawing.Point(37, 263);
            this.mtb_phone.Mask = "#(###)#######";
            this.mtb_phone.Name = "mtb_phone";
            this.mtb_phone.Size = new System.Drawing.Size(271, 28);
            this.mtb_phone.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_create);
            this.panel4.Controls.Add(this.btn_update);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 55);
            this.panel4.TabIndex = 8;
            // 
            // btn_create
            // 
            this.btn_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_create.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_create.Location = new System.Drawing.Point(175, 0);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(175, 55);
            this.btn_create.TabIndex = 9;
            this.btn_create.Text = "Создать";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_update
            // 
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_update.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_update.Location = new System.Drawing.Point(0, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(175, 55);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Изменить";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_phone.Location = new System.Drawing.Point(33, 239);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(154, 21);
            this.lb_phone.TabIndex = 6;
            this.lb_phone.Text = "Мобильный номер";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_email.Location = new System.Drawing.Point(37, 199);
            this.tb_email.MaxLength = 45;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(271, 28);
            this.tb_email.TabIndex = 5;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_email.Location = new System.Drawing.Point(33, 175);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(136, 21);
            this.lb_email.TabIndex = 4;
            this.lb_email.Text = "Адрес эл. почты";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.Location = new System.Drawing.Point(37, 135);
            this.tb_name.MaxLength = 45;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(271, 28);
            this.tb_name.TabIndex = 3;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_name.Location = new System.Drawing.Point(33, 111);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(46, 21);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "ФИО";
            // 
            // cb_staff
            // 
            this.cb_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_staff.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_staff.FormattingEnabled = true;
            this.cb_staff.Location = new System.Drawing.Point(37, 70);
            this.cb_staff.Name = "cb_staff";
            this.cb_staff.Size = new System.Drawing.Size(271, 29);
            this.cb_staff.TabIndex = 0;
            this.cb_staff.SelectedIndexChanged += new System.EventHandler(this.cb_staff_SelectedIndexChanged);
            this.cb_staff.SelectionChangeCommitted += new System.EventHandler(this.cb_staff_SelectionChangeCommitted);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 55);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 15);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(785, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delete.Location = new System.Drawing.Point(86, 325);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(177, 49);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pl_background);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.pl_background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
            this.pl_staffInfo.ResumeLayout(false);
            this.pl_staffInfo.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_background;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_details;
        private System.Windows.Forms.Panel pl_spacer;
        private System.Windows.Forms.Panel pl_staffInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.ComboBox cb_staff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox mtb_phone;
        private System.Windows.Forms.Button btn_delete;
    }
}