
namespace Diplom
{
    partial class Tickets
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_tickets = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cb_searchByPriority = new System.Windows.Forms.ComboBox();
            this.btn_ticketCreate = new System.Windows.Forms.Button();
            this.tbp_search = new Diplom.Custom_Elements.TextBoxWithPlaceholder();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_tickets
            // 
            this.dgv_tickets.AllowUserToAddRows = false;
            this.dgv_tickets.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_tickets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tickets.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_tickets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tickets.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_tickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tickets.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_tickets.Location = new System.Drawing.Point(0, 40);
            this.dgv_tickets.Name = "dgv_tickets";
            this.dgv_tickets.ReadOnly = true;
            this.dgv_tickets.RowHeadersVisible = false;
            this.dgv_tickets.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_tickets.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_tickets.RowTemplate.Height = 24;
            this.dgv_tickets.Size = new System.Drawing.Size(997, 345);
            this.dgv_tickets.TabIndex = 0;
            this.dgv_tickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tickets_CellContentClick);
            this.dgv_tickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tickets_CellContentClick);
            this.dgv_tickets.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_tickets_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(997, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 450);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 15);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtp_date);
            this.panel3.Controls.Add(this.tbp_search);
            this.panel3.Controls.Add(this.cb_searchByPriority);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(997, 40);
            this.panel3.TabIndex = 3;
            // 
            // dtp_date
            // 
            this.dtp_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_date.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(862, 6);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(129, 28);
            this.dtp_date.TabIndex = 4;
            this.dtp_date.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            this.dtp_date.ValueChanged += new System.EventHandler(this.dtp_date_ValueChanged);
            // 
            // cb_searchByPriority
            // 
            this.cb_searchByPriority.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_searchByPriority.FormattingEnabled = true;
            this.cb_searchByPriority.Items.AddRange(new object[] {
            "Обычные",
            "Средние",
            "Срочные",
            "Все"});
            this.cb_searchByPriority.Location = new System.Drawing.Point(3, 3);
            this.cb_searchByPriority.Name = "cb_searchByPriority";
            this.cb_searchByPriority.Size = new System.Drawing.Size(211, 29);
            this.cb_searchByPriority.TabIndex = 0;
            this.cb_searchByPriority.Text = "Все";
            this.cb_searchByPriority.SelectedValueChanged += new System.EventHandler(this.cb_searchByPriority_SelectedValueChanged);
            // 
            // btn_ticketCreate
            // 
            this.btn_ticketCreate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_ticketCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ticketCreate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ticketCreate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ticketCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ticketCreate.Image = global::Diplom.Properties.Resources.add_32px_dark;
            this.btn_ticketCreate.Location = new System.Drawing.Point(0, 385);
            this.btn_ticketCreate.Name = "btn_ticketCreate";
            this.btn_ticketCreate.Padding = new System.Windows.Forms.Padding(255, 0, 0, 0);
            this.btn_ticketCreate.Size = new System.Drawing.Size(997, 50);
            this.btn_ticketCreate.TabIndex = 5;
            this.btn_ticketCreate.Text = "Добавить запрос";
            this.btn_ticketCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ticketCreate.UseVisualStyleBackColor = false;
            this.btn_ticketCreate.Click += new System.EventHandler(this.btn_ticketCreate_Click);
            // 
            // tbp_search
            // 
            this.tbp_search.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbp_search.Location = new System.Drawing.Point(220, 3);
            this.tbp_search.Name = "tbp_search";
            this.tbp_search.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbp_search.PlaceholderText = "Поиск по номеру или статусу";
            this.tbp_search.Size = new System.Drawing.Size(284, 28);
            this.tbp_search.TabIndex = 3;
            this.tbp_search.TextChanged += new System.EventHandler(this.tbp_search_TextChanged);
            this.tbp_search.Leave += new System.EventHandler(this.Tickets_Load);
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.dgv_tickets);
            this.Controls.Add(this.btn_ticketCreate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tickets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_searchByPriority;
        private Custom_Elements.TextBoxWithPlaceholder tbp_search;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button btn_ticketCreate;
    }
}