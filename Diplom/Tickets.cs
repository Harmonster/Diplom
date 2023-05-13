using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* TODO
 * 1) спрятать колонку ID, добавить колонку послед. нумерации записей
 */

namespace Diplom
{
    public partial class Tickets : Form
    {
        public int currTicketId;
        int paginationSize = 10;
        int totalPages;
        int ticketsCount;
        int currentPage = 1;

        public Tickets()
        {
            InitializeComponent();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            FormLoad();

            if (Classes.AuthorizedUserInfo.UserRole != "Администратор")
            {
                TsbTicketDelete.Visible = false;
                toolStripSeparator5.Visible = false;
            }
        }

        public void FormLoad()
        {
            ticketsCount = Classes.Database.GetTicketsCount();
            totalPages = (int)Math.Ceiling((double)ticketsCount / paginationSize);
            TslTotalTickets.Text = ticketsCount.ToString();
            TslTotalPages.Text = totalPages.ToString();
            TslCurrentPage.Text = "Страница " + currentPage.ToString() + " из";
            Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);
            UpdatePaginationButtons(currentPage);
            DatagridviewSettings();
        }

        public void FormLoad(int size, int offset)
        {
            ticketsCount = Classes.Database.GetTicketsCount();
            totalPages = (int)Math.Ceiling((double)ticketsCount / paginationSize);
            TslTotalTickets.Text = ticketsCount.ToString();
            TslTotalPages.Text = totalPages.ToString();
            TslCurrentPage.Text = "Страница " + currentPage.ToString() + " из";
            Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", size, offset);
            UpdatePaginationButtons(currentPage);
            DatagridviewSettings();
        }


        private void cb_searchByPriority_SelectedValueChanged(object sender, EventArgs e)
        {
            string currValue = (string)cb_searchByPriority.SelectedItem;
            switch (currValue)
            {
                case "Обычные":
                    Classes.Database.GetTicketList(dgv_tickets, "GetTicketsByPriority", "Обычный");
                    break;
                case "Средние":
                    Classes.Database.GetTicketList(dgv_tickets, "GetTicketsByPriority", "Средний");
                    break;
                case "Срочные":
                    Classes.Database.GetTicketList(dgv_tickets, "GetTicketsByPriority", "Срочный");
                    break;
                case "Без приоритета":
                    Classes.Database.GetTicketList(dgv_tickets, "GetTicketsByPriority", "Не указано");
                    break;
                case "Все":
                    Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);
                    break;
            }
        }

        private void tbp_search_TextChanged(object sender, EventArgs e)
        {
            Classes.Database.Search(dgv_tickets, "GetTicketsByLike", tbp_search.Text);
            DatagridviewSettings();
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            Classes.Database.SearchDate(dgv_tickets, dtp_date);
        }

        private void dgv_tickets_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TicketDetails f = new TicketDetails(this, currTicketId, paginationSize, (currentPage - 1) * paginationSize);
            f.ShowDialog();
        }

        private void dgv_tickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_tickets.Rows[e.RowIndex];
                currTicketId = (int)row.Cells[0].Value;
            }
        }

        private void TsbNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                TslCurrentPage.Text = "Страница " + currentPage.ToString() + " из";
                Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);
            }
            else if (currentPage == totalPages)
            {
                currentPage = 1;
                TslCurrentPage.Text = "Страница " + currentPage.ToString() + " из";
                Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);
            }

            DatagridviewSettings();
            UpdatePaginationButtons(currentPage);
        }

        private void TsbLastPage_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            TslCurrentPage.Text = "Страница " + currentPage.ToString() + " из";
            Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);

            DatagridviewSettings();
            UpdatePaginationButtons(currentPage);
        }

        private void TsbPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                TslCurrentPage.Text = "Страница " + currentPage.ToString() + " из";
                Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);
            }
            else if (currentPage == 1)
            {
                currentPage = 1;
                TslCurrentPage.Text = "Страница " + currentPage.ToString() + " из";
                Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);
            }

            DatagridviewSettings();
            UpdatePaginationButtons(currentPage);
        }

        private void TsbFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            TslCurrentPage.Text = "Страница " + currentPage.ToString() + " из";
            Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);
            DatagridviewSettings();
            UpdatePaginationButtons(currentPage);
        }

        private void TsbTicketCreate_Click(object sender, EventArgs e)
        {
            CreateTicket f = new CreateTicket(this, paginationSize, (currentPage - 1) * paginationSize);
            f.ShowDialog();
        }

        private void TsbTicketDelete_Click(object sender, EventArgs e)
        {
            Classes.Database.DeleteTicketById(currTicketId);
            FormLoad();
        }

        private void BtnSearchReset_Click(object sender, EventArgs e)
        {
            FormLoad(paginationSize, (currentPage - 1) * paginationSize);
        }

        private void UpdatePaginationButtons(int currentPage)
        {
            if (currentPage == 1) 
            {
                TsbFirstPage.Enabled = false;
                TsbPreviousPage.Enabled = false;
                TsbNextPage.Enabled = true;
                TsbLastPage.Enabled = true;
            }
            else if (currentPage == totalPages)
            {
                TsbFirstPage.Enabled = true;
                TsbPreviousPage.Enabled = true;
                TsbNextPage.Enabled = false;
                TsbLastPage.Enabled = false;
            }
            else if ((currentPage != 1) && (currentPage != totalPages))
            {
                TsbFirstPage.Enabled = true;
                TsbPreviousPage.Enabled = true;
                TsbNextPage.Enabled = true;
                TsbLastPage.Enabled = true;
            }
        }

        private void DatagridviewSettings()
        {
            dgv_tickets.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_tickets.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_tickets.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_tickets.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_tickets.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_tickets.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_tickets.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}


