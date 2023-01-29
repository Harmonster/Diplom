
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_export = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_report = new System.Windows.Forms.DataGridView();
            this.pl_tooltips = new System.Windows.Forms.Panel();
            this.rb_mode_excel = new System.Windows.Forms.RadioButton();
            this.btn_reportByStatus = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(785, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 450);
            this.panel1.TabIndex = 0;
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
            // btn_export
            // 
            this.btn_export.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_export.Location = new System.Drawing.Point(0, 392);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(785, 43);
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
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 392);
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
            this.dgv_report.Location = new System.Drawing.Point(194, 0);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.ReadOnly = true;
            this.dgv_report.RowHeadersVisible = false;
            this.dgv_report.RowHeadersWidth = 51;
            this.dgv_report.RowTemplate.Height = 24;
            this.dgv_report.Size = new System.Drawing.Size(591, 392);
            this.dgv_report.TabIndex = 1;
            // 
            // pl_tooltips
            // 
            this.pl_tooltips.Controls.Add(this.rb_mode_excel);
            this.pl_tooltips.Controls.Add(this.btn_reportByStatus);
            this.pl_tooltips.Controls.Add(this.label1);
            this.pl_tooltips.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_tooltips.Location = new System.Drawing.Point(0, 0);
            this.pl_tooltips.Name = "pl_tooltips";
            this.pl_tooltips.Size = new System.Drawing.Size(194, 392);
            this.pl_tooltips.TabIndex = 0;
            // 
            // rb_mode_excel
            // 
            this.rb_mode_excel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_mode_excel.Location = new System.Drawing.Point(5, 361);
            this.rb_mode_excel.Name = "rb_mode_excel";
            this.rb_mode_excel.Size = new System.Drawing.Size(95, 25);
            this.rb_mode_excel.TabIndex = 3;
            this.rb_mode_excel.TabStop = true;
            this.rb_mode_excel.Text = "Excel";
            this.rb_mode_excel.UseVisualStyleBackColor = true;
            // 
            // btn_reportByStatus
            // 
            this.btn_reportByStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reportByStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_reportByStatus.Location = new System.Drawing.Point(0, 87);
            this.btn_reportByStatus.Name = "btn_reportByStatus";
            this.btn_reportByStatus.Size = new System.Drawing.Size(194, 66);
            this.btn_reportByStatus.TabIndex = 1;
            this.btn_reportByStatus.Text = "Выполненные запросы";
            this.btn_reportByStatus.UseVisualStyleBackColor = true;
            this.btn_reportByStatus.Click += new System.EventHandler(this.btn_reportByStatus_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите данные на экспорт";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Button btn_reportByStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_mode_excel;
    }
}