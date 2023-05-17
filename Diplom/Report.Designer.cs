
namespace Diplom
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_export = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_report = new System.Windows.Forms.DataGridView();
            this.pl_tooltips = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rb_mode_excel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).BeginInit();
            this.pl_tooltips.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(589, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 366);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 12);
            this.panel2.TabIndex = 1;
            // 
            // btn_export
            // 
            this.btn_export.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_export.Location = new System.Drawing.Point(0, 319);
            this.btn_export.Margin = new System.Windows.Forms.Padding(2);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(589, 35);
            this.btn_export.TabIndex = 2;
            this.btn_export.Text = "Экспорт";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.dgv_report);
            this.panel3.Controls.Add(this.pl_tooltips);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(589, 319);
            this.panel3.TabIndex = 3;
            // 
            // dgv_report
            // 
            this.dgv_report.AllowUserToAddRows = false;
            this.dgv_report.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_report.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_report.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_report.Location = new System.Drawing.Point(146, 0);
            this.dgv_report.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.ReadOnly = true;
            this.dgv_report.RowHeadersVisible = false;
            this.dgv_report.RowHeadersWidth = 51;
            this.dgv_report.RowTemplate.Height = 24;
            this.dgv_report.Size = new System.Drawing.Size(443, 319);
            this.dgv_report.TabIndex = 1;
            // 
            // pl_tooltips
            // 
            this.pl_tooltips.Controls.Add(this.comboBox1);
            this.pl_tooltips.Controls.Add(this.rb_mode_excel);
            this.pl_tooltips.Controls.Add(this.label1);
            this.pl_tooltips.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_tooltips.Location = new System.Drawing.Point(0, 0);
            this.pl_tooltips.Margin = new System.Windows.Forms.Padding(2);
            this.pl_tooltips.Name = "pl_tooltips";
            this.pl_tooltips.Size = new System.Drawing.Size(146, 319);
            this.pl_tooltips.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Выполненные запросы",
            "Незакрытые срочные запросы",
            "Запросы на доработке"});
            this.comboBox1.Location = new System.Drawing.Point(0, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // rb_mode_excel
            // 
            this.rb_mode_excel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_mode_excel.Location = new System.Drawing.Point(4, 294);
            this.rb_mode_excel.Margin = new System.Windows.Forms.Padding(2);
            this.rb_mode_excel.Name = "rb_mode_excel";
            this.rb_mode_excel.Size = new System.Drawing.Size(71, 20);
            this.rb_mode_excel.TabIndex = 3;
            this.rb_mode_excel.TabStop = true;
            this.rb_mode_excel.Text = "Excel";
            this.rb_mode_excel.UseVisualStyleBackColor = true;
            this.rb_mode_excel.Visible = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите данные на экспорт";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).EndInit();
            this.pl_tooltips.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_report;
        private System.Windows.Forms.Panel pl_tooltips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_mode_excel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}