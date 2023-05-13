
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pl_background = new System.Windows.Forms.Panel();
            this.dgv_details = new System.Windows.Forms.DataGridView();
            this.pl_spacer = new System.Windows.Forms.Panel();
            this.pl_staffInfo = new System.Windows.Forms.Panel();
            this.TxtPatron = new System.Windows.Forms.TextBox();
            this.LblPatron = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.LblPhone = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.LblSurname = new System.Windows.Forms.Label();
            this.CbStaff = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.pl_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).BeginInit();
            this.pl_staffInfo.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrEmail)).BeginInit();
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
            this.pl_background.Margin = new System.Windows.Forms.Padding(2);
            this.pl_background.Name = "pl_background";
            this.pl_background.Size = new System.Drawing.Size(603, 405);
            this.pl_background.TabIndex = 0;
            // 
            // dgv_details
            // 
            this.dgv_details.AllowUserToAddRows = false;
            this.dgv_details.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_details.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_details.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_details.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_details.Location = new System.Drawing.Point(278, 0);
            this.dgv_details.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_details.Name = "dgv_details";
            this.dgv_details.ReadOnly = true;
            this.dgv_details.RowHeadersVisible = false;
            this.dgv_details.RowHeadersWidth = 51;
            this.dgv_details.RowTemplate.Height = 24;
            this.dgv_details.Size = new System.Drawing.Size(314, 393);
            this.dgv_details.TabIndex = 3;
            // 
            // pl_spacer
            // 
            this.pl_spacer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pl_spacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_spacer.Location = new System.Drawing.Point(262, 0);
            this.pl_spacer.Margin = new System.Windows.Forms.Padding(2);
            this.pl_spacer.Name = "pl_spacer";
            this.pl_spacer.Size = new System.Drawing.Size(16, 393);
            this.pl_spacer.TabIndex = 5;
            // 
            // pl_staffInfo
            // 
            this.pl_staffInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pl_staffInfo.Controls.Add(this.TxtPatron);
            this.pl_staffInfo.Controls.Add(this.LblPatron);
            this.pl_staffInfo.Controls.Add(this.TxtName);
            this.pl_staffInfo.Controls.Add(this.LblName);
            this.pl_staffInfo.Controls.Add(this.BtnDelete);
            this.pl_staffInfo.Controls.Add(this.TxtPhone);
            this.pl_staffInfo.Controls.Add(this.panel4);
            this.pl_staffInfo.Controls.Add(this.LblPhone);
            this.pl_staffInfo.Controls.Add(this.TxtEmail);
            this.pl_staffInfo.Controls.Add(this.LblEmail);
            this.pl_staffInfo.Controls.Add(this.TxtSurname);
            this.pl_staffInfo.Controls.Add(this.LblSurname);
            this.pl_staffInfo.Controls.Add(this.CbStaff);
            this.pl_staffInfo.Controls.Add(this.panel3);
            this.pl_staffInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_staffInfo.Location = new System.Drawing.Point(0, 0);
            this.pl_staffInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pl_staffInfo.Name = "pl_staffInfo";
            this.pl_staffInfo.Size = new System.Drawing.Size(262, 393);
            this.pl_staffInfo.TabIndex = 4;
            // 
            // TxtPatron
            // 
            this.TxtPatron.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPatron.Location = new System.Drawing.Point(28, 162);
            this.TxtPatron.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPatron.MaxLength = 50;
            this.TxtPatron.Name = "TxtPatron";
            this.TxtPatron.Size = new System.Drawing.Size(204, 21);
            this.TxtPatron.TabIndex = 14;
            // 
            // LblPatron
            // 
            this.LblPatron.AutoSize = true;
            this.LblPatron.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPatron.Location = new System.Drawing.Point(25, 145);
            this.LblPatron.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPatron.Name = "LblPatron";
            this.LblPatron.Size = new System.Drawing.Size(63, 15);
            this.LblPatron.TabIndex = 13;
            this.LblPatron.Text = "Отчество";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtName.Location = new System.Drawing.Point(28, 122);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtName.MaxLength = 50;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(204, 21);
            this.TxtName.TabIndex = 12;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblName.Location = new System.Drawing.Point(25, 105);
            this.LblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(32, 15);
            this.LblName.TabIndex = 11;
            this.LblName.Text = "Имя";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDelete.Location = new System.Drawing.Point(64, 284);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(133, 40);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPhone.Location = new System.Drawing.Point(28, 242);
            this.TxtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPhone.Mask = "##(###)#######";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(204, 21);
            this.TxtPhone.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnCreate);
            this.panel4.Controls.Add(this.BtnUpdate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 348);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 45);
            this.panel4.TabIndex = 8;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCreate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCreate.Location = new System.Drawing.Point(131, 0);
            this.BtnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(131, 45);
            this.BtnCreate.TabIndex = 9;
            this.BtnCreate.Text = "Создать";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnUpdate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnUpdate.Location = new System.Drawing.Point(0, 0);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(131, 45);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Изменить";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPhone.Location = new System.Drawing.Point(25, 225);
            this.LblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(116, 15);
            this.LblPhone.TabIndex = 6;
            this.LblPhone.Text = "Мобильный номер";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtEmail.Location = new System.Drawing.Point(28, 202);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmail.MaxLength = 45;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(204, 21);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblEmail.Location = new System.Drawing.Point(25, 185);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(99, 15);
            this.LblEmail.TabIndex = 4;
            this.LblEmail.Text = "Адрес эл. почты";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtSurname.Location = new System.Drawing.Point(28, 82);
            this.TxtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSurname.MaxLength = 50;
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(204, 21);
            this.TxtSurname.TabIndex = 3;
            // 
            // LblSurname
            // 
            this.LblSurname.AutoSize = true;
            this.LblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSurname.Location = new System.Drawing.Point(25, 63);
            this.LblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(62, 15);
            this.LblSurname.TabIndex = 2;
            this.LblSurname.Text = "Фамилия";
            // 
            // CbStaff
            // 
            this.CbStaff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbStaff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbStaff.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbStaff.FormattingEnabled = true;
            this.CbStaff.Location = new System.Drawing.Point(28, 27);
            this.CbStaff.Margin = new System.Windows.Forms.Padding(2);
            this.CbStaff.Name = "CbStaff";
            this.CbStaff.Size = new System.Drawing.Size(204, 25);
            this.CbStaff.TabIndex = 0;
            this.CbStaff.SelectedIndexChanged += new System.EventHandler(this.CbStaff_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 23);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 393);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 12);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(592, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 405);
            this.panel1.TabIndex = 0;
            // 
            // ErrEmail
            // 
            this.ErrEmail.ContainerControl = this;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 405);
            this.Controls.Add(this.pl_background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.pl_background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_details)).EndInit();
            this.pl_staffInfo.ResumeLayout(false);
            this.pl_staffInfo.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrEmail)).EndInit();
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
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label LblSurname;
        private System.Windows.Forms.ComboBox CbStaff;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtPatron;
        private System.Windows.Forms.Label LblPatron;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.ErrorProvider ErrEmail;
    }
}