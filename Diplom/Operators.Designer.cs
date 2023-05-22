
namespace Diplom
{
    partial class Operators
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operators));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.LbSearch = new System.Windows.Forms.Label();
            this.LbRole = new System.Windows.Forms.Label();
            this.CbRole = new System.Windows.Forms.ComboBox();
            this.LbPatron = new System.Windows.Forms.Label();
            this.TxtPatron = new System.Windows.Forms.TextBox();
            this.LbName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LbSurname = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.LbEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.CbSearchOperators = new System.Windows.Forms.ComboBox();
            this.dgv_solutions = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_solutions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.dgv_solutions);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnUpdate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnCreate);
            this.panel1.Controls.Add(this.LbSearch);
            this.panel1.Controls.Add(this.LbRole);
            this.panel1.Controls.Add(this.CbRole);
            this.panel1.Controls.Add(this.LbPatron);
            this.panel1.Controls.Add(this.TxtPatron);
            this.panel1.Controls.Add(this.LbName);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.LbSurname);
            this.panel1.Controls.Add(this.TxtSurname);
            this.panel1.Controls.Add(this.LbEmail);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.CbSearchOperators);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 469);
            this.panel1.TabIndex = 0;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(114, 348);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(94, 38);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "Очистить";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(15, 348);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(94, 38);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(114, 392);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(94, 38);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "Изменить";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 43);
            this.panel2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(184, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 14;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(15, 392);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(94, 38);
            this.BtnCreate.TabIndex = 12;
            this.BtnCreate.Text = "Создать";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // LbSearch
            // 
            this.LbSearch.AutoSize = true;
            this.LbSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbSearch.Location = new System.Drawing.Point(12, 46);
            this.LbSearch.Name = "LbSearch";
            this.LbSearch.Size = new System.Drawing.Size(42, 16);
            this.LbSearch.TabIndex = 11;
            this.LbSearch.Text = "Поиск";
            // 
            // LbRole
            // 
            this.LbRole.AutoSize = true;
            this.LbRole.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbRole.Location = new System.Drawing.Point(12, 136);
            this.LbRole.Name = "LbRole";
            this.LbRole.Size = new System.Drawing.Size(36, 16);
            this.LbRole.TabIndex = 10;
            this.LbRole.Text = "Роль";
            // 
            // CbRole
            // 
            this.CbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRole.FormattingEnabled = true;
            this.CbRole.Items.AddRange(new object[] {
            "Оператор",
            "Администратор"});
            this.CbRole.Location = new System.Drawing.Point(15, 157);
            this.CbRole.Name = "CbRole";
            this.CbRole.Size = new System.Drawing.Size(193, 21);
            this.CbRole.TabIndex = 9;
            // 
            // LbPatron
            // 
            this.LbPatron.AutoSize = true;
            this.LbPatron.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbPatron.Location = new System.Drawing.Point(15, 275);
            this.LbPatron.Name = "LbPatron";
            this.LbPatron.Size = new System.Drawing.Size(63, 16);
            this.LbPatron.TabIndex = 8;
            this.LbPatron.Text = "Отчество";
            // 
            // TxtPatron
            // 
            this.TxtPatron.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPatron.Location = new System.Drawing.Point(15, 294);
            this.TxtPatron.MaxLength = 50;
            this.TxtPatron.Name = "TxtPatron";
            this.TxtPatron.Size = new System.Drawing.Size(193, 23);
            this.TxtPatron.TabIndex = 7;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbName.Location = new System.Drawing.Point(15, 230);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(31, 16);
            this.LbName.TabIndex = 6;
            this.LbName.Text = "Имя";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtName.Location = new System.Drawing.Point(15, 249);
            this.TxtName.MaxLength = 50;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(193, 23);
            this.TxtName.TabIndex = 5;
            // 
            // LbSurname
            // 
            this.LbSurname.AutoSize = true;
            this.LbSurname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbSurname.Location = new System.Drawing.Point(12, 185);
            this.LbSurname.Name = "LbSurname";
            this.LbSurname.Size = new System.Drawing.Size(61, 16);
            this.LbSurname.TabIndex = 4;
            this.LbSurname.Text = "Фамилия";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtSurname.Location = new System.Drawing.Point(15, 204);
            this.TxtSurname.MaxLength = 50;
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(193, 23);
            this.TxtSurname.TabIndex = 3;
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbEmail.Location = new System.Drawing.Point(12, 91);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(104, 16);
            this.LbEmail.TabIndex = 2;
            this.LbEmail.Text = "Адрес эл. почты";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtEmail.Location = new System.Drawing.Point(15, 110);
            this.TxtEmail.MaxLength = 45;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(193, 23);
            this.TxtEmail.TabIndex = 1;
            // 
            // CbSearchOperators
            // 
            this.CbSearchOperators.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbSearchOperators.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbSearchOperators.FormattingEnabled = true;
            this.CbSearchOperators.Location = new System.Drawing.Point(15, 65);
            this.CbSearchOperators.Name = "CbSearchOperators";
            this.CbSearchOperators.Size = new System.Drawing.Size(193, 21);
            this.CbSearchOperators.TabIndex = 0;
            this.CbSearchOperators.SelectedIndexChanged += new System.EventHandler(this.CbSearchOperators_SelectedIndexChanged);
            // 
            // dgv_solutions
            // 
            this.dgv_solutions.AllowUserToAddRows = false;
            this.dgv_solutions.AllowUserToDeleteRows = false;
            this.dgv_solutions.AllowUserToOrderColumns = true;
            this.dgv_solutions.BackgroundColor = System.Drawing.Color.White;
            this.dgv_solutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_solutions.Location = new System.Drawing.Point(227, 65);
            this.dgv_solutions.Name = "dgv_solutions";
            this.dgv_solutions.ReadOnly = true;
            this.dgv_solutions.RowHeadersVisible = false;
            this.dgv_solutions.Size = new System.Drawing.Size(554, 365);
            this.dgv_solutions.TabIndex = 17;
            this.dgv_solutions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_solutions_CellFormatting);
            // 
            // Operators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 469);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Operators";
            this.Text = "Operators";
            this.Load += new System.EventHandler(this.Operators_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_solutions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbSearch;
        private System.Windows.Forms.Label LbRole;
        private System.Windows.Forms.ComboBox CbRole;
        private System.Windows.Forms.Label LbPatron;
        private System.Windows.Forms.TextBox TxtPatron;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LbSurname;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.ComboBox CbSearchOperators;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.DataGridView dgv_solutions;
    }
}