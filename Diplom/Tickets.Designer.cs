
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
            this.tbp_search = new Diplom.Custom_Elements.TextBoxWithPlaceholder();
            this.cb_searchByPriority = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbFirstPage = new System.Windows.Forms.ToolStripButton();
            this.TsbPreviousPage = new System.Windows.Forms.ToolStripButton();
            this.TslTotalPages = new System.Windows.Forms.ToolStripLabel();
            this.TsbNextPage = new System.Windows.Forms.ToolStripButton();
            this.TsbLastPage = new System.Windows.Forms.ToolStripButton();
            this.TslTotalTickets = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbTicketCreate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbTicketDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TstbxCurrentPage = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).BeginInit();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.dgv_tickets.Location = new System.Drawing.Point(0, 32);
            this.dgv_tickets.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_tickets.MultiSelect = false;
            this.dgv_tickets.Name = "dgv_tickets";
            this.dgv_tickets.ReadOnly = true;
            this.dgv_tickets.RowHeadersVisible = false;
            this.dgv_tickets.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_tickets.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_tickets.RowTemplate.Height = 24;
            this.dgv_tickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tickets.Size = new System.Drawing.Size(748, 283);
            this.dgv_tickets.TabIndex = 0;
            this.dgv_tickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tickets_CellContentClick);
            this.dgv_tickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tickets_CellContentClick);
            this.dgv_tickets.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_tickets_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(748, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 366);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 12);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtp_date);
            this.panel3.Controls.Add(this.tbp_search);
            this.panel3.Controls.Add(this.cb_searchByPriority);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 32);
            this.panel3.TabIndex = 3;
            // 
            // dtp_date
            // 
            this.dtp_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_date.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(646, 5);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(98, 24);
            this.dtp_date.TabIndex = 4;
            this.dtp_date.Value = new System.DateTime(2023, 4, 17, 0, 0, 0, 0);
            this.dtp_date.ValueChanged += new System.EventHandler(this.dtp_date_ValueChanged);
            // 
            // tbp_search
            // 
            this.tbp_search.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbp_search.Location = new System.Drawing.Point(165, 2);
            this.tbp_search.Margin = new System.Windows.Forms.Padding(2);
            this.tbp_search.Name = "tbp_search";
            this.tbp_search.PlaceholderColor = System.Drawing.Color.Gray;
            this.tbp_search.PlaceholderText = "Поиск";
            this.tbp_search.Size = new System.Drawing.Size(214, 24);
            this.tbp_search.TabIndex = 3;
            this.tbp_search.TextChanged += new System.EventHandler(this.tbp_search_TextChanged);
            this.tbp_search.Leave += new System.EventHandler(this.Tickets_Load);
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
            this.cb_searchByPriority.Location = new System.Drawing.Point(2, 2);
            this.cb_searchByPriority.Margin = new System.Windows.Forms.Padding(2);
            this.cb_searchByPriority.Name = "cb_searchByPriority";
            this.cb_searchByPriority.Size = new System.Drawing.Size(159, 25);
            this.cb_searchByPriority.TabIndex = 0;
            this.cb_searchByPriority.Text = "Все";
            this.cb_searchByPriority.SelectedValueChanged += new System.EventHandler(this.cb_searchByPriority_SelectedValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.TsbFirstPage,
            this.TsbPreviousPage,
            this.TstbxCurrentPage,
            this.TslTotalPages,
            this.TsbNextPage,
            this.TsbLastPage,
            this.TslTotalTickets,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.TsbTicketCreate,
            this.toolStripSeparator4,
            this.TsbTicketDelete,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 315);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(748, 39);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // TsbFirstPage
            // 
            this.TsbFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbFirstPage.Image = global::Diplom.Properties.Resources.first_32px;
            this.TsbFirstPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbFirstPage.Name = "TsbFirstPage";
            this.TsbFirstPage.Size = new System.Drawing.Size(36, 36);
            this.TsbFirstPage.Text = "toolStripButton1";
            this.TsbFirstPage.ToolTipText = "Первая страница";
            this.TsbFirstPage.Click += new System.EventHandler(this.TsbFirstPage_Click);
            // 
            // TsbPreviousPage
            // 
            this.TsbPreviousPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbPreviousPage.Image = global::Diplom.Properties.Resources.previous_32px;
            this.TsbPreviousPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbPreviousPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPreviousPage.Name = "TsbPreviousPage";
            this.TsbPreviousPage.Size = new System.Drawing.Size(36, 36);
            this.TsbPreviousPage.Text = "toolStripButton2";
            this.TsbPreviousPage.ToolTipText = "Предыдущая страница";
            this.TsbPreviousPage.Click += new System.EventHandler(this.TsbPreviousPage_Click);
            // 
            // TslTotalPages
            // 
            this.TslTotalPages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TslTotalPages.Name = "TslTotalPages";
            this.TslTotalPages.Size = new System.Drawing.Size(14, 36);
            this.TslTotalPages.Text = "#";
            this.TslTotalPages.ToolTipText = "Количество страниц";
            // 
            // TsbNextPage
            // 
            this.TsbNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbNextPage.Image = global::Diplom.Properties.Resources.next_32px;
            this.TsbNextPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNextPage.Name = "TsbNextPage";
            this.TsbNextPage.Size = new System.Drawing.Size(36, 36);
            this.TsbNextPage.Text = "toolStripButton3";
            this.TsbNextPage.ToolTipText = "Следующая страница";
            this.TsbNextPage.Click += new System.EventHandler(this.TsbNextPage_Click);
            // 
            // TsbLastPage
            // 
            this.TsbLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbLastPage.Image = global::Diplom.Properties.Resources.last_32px;
            this.TsbLastPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbLastPage.Name = "TsbLastPage";
            this.TsbLastPage.Size = new System.Drawing.Size(36, 36);
            this.TsbLastPage.Text = "toolStripButton4";
            this.TsbLastPage.ToolTipText = "Последняя страница";
            this.TsbLastPage.Click += new System.EventHandler(this.TsbLastPage_Click);
            // 
            // TslTotalTickets
            // 
            this.TslTotalTickets.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TslTotalTickets.Name = "TslTotalTickets";
            this.TslTotalTickets.Size = new System.Drawing.Size(14, 36);
            this.TslTotalTickets.Text = "#";
            this.TslTotalTickets.ToolTipText = "Количество записей";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // TsbTicketCreate
            // 
            this.TsbTicketCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbTicketCreate.Image = global::Diplom.Properties.Resources.add_32pxNEW;
            this.TsbTicketCreate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbTicketCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbTicketCreate.Name = "TsbTicketCreate";
            this.TsbTicketCreate.Size = new System.Drawing.Size(36, 36);
            this.TsbTicketCreate.Text = "Добавить запрос";
            this.TsbTicketCreate.ToolTipText = "Добавить запись";
            this.TsbTicketCreate.Click += new System.EventHandler(this.TsbTicketCreate_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // TsbTicketDelete
            // 
            this.TsbTicketDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbTicketDelete.Image = global::Diplom.Properties.Resources.circled_x_32px;
            this.TsbTicketDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsbTicketDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbTicketDelete.Name = "TsbTicketDelete";
            this.TsbTicketDelete.Size = new System.Drawing.Size(36, 36);
            this.TsbTicketDelete.Text = "toolStripButton1";
            this.TsbTicketDelete.ToolTipText = "Удалить запись";
            this.TsbTicketDelete.Click += new System.EventHandler(this.TsbTicketDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // TstbxCurrentPage
            // 
            this.TstbxCurrentPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TstbxCurrentPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TstbxCurrentPage.Name = "TstbxCurrentPage";
            this.TstbxCurrentPage.Size = new System.Drawing.Size(25, 39);
            this.TstbxCurrentPage.Text = "#";
            this.TstbxCurrentPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TstbxCurrentPage.ToolTipText = "Текущая страница";
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 366);
            this.Controls.Add(this.dgv_tickets);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tickets)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tickets;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_searchByPriority;
        private Custom_Elements.TextBoxWithPlaceholder tbp_search;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbFirstPage;
        private System.Windows.Forms.ToolStripButton TsbPreviousPage;
        private System.Windows.Forms.ToolStripLabel TslTotalPages;
        private System.Windows.Forms.ToolStripButton TsbNextPage;
        private System.Windows.Forms.ToolStripButton TsbLastPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel TslTotalTickets;
        private System.Windows.Forms.ToolStripButton TsbTicketCreate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton TsbTicketDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox TstbxCurrentPage;
    }
}