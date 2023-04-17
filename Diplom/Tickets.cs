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
 * 1) Удаление записи администратором
 * 2) Восстановление пароля
 * 3) Добавить секретное слово для сотрудников
 * 4) Проверить и пофиксить поля ввода
 * 5) Настроить отображение таблицы
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
        }

        public void FormLoad()
        {
            ticketsCount = Classes.Database.GetTicketsCount();
            totalPages = (int)Math.Ceiling((double)ticketsCount / paginationSize);
            TslTotalTickets.Text = ticketsCount.ToString();
            TslTotalPages.Text = totalPages.ToString();
            TstbxCurrentPage.Text = currentPage.ToString();
            Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);
        }

        public void FormLoad(int size, int offset)
        {
            ticketsCount = Classes.Database.GetTicketsCount();
            totalPages = (int)Math.Ceiling((double)ticketsCount / paginationSize);
            TslTotalTickets.Text = ticketsCount.ToString();
            TslTotalPages.Text = totalPages.ToString();
            TstbxCurrentPage.Text = currentPage.ToString();
            Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", size, offset);
        }


        private void cb_searchByPriority_SelectedValueChanged(object sender, EventArgs e)
        {
            string currValue = (string)cb_searchByPriority.SelectedItem;

            switch (currValue)
            {
                case "Обычные":
                    Classes.Database.GetTicketList(dgv_tickets, "GetTicketsByPriorityOffset", paginationSize, (currentPage - 1) * paginationSize);
                    break;
                
            }
        }

        private void tbp_search_TextChanged(object sender, EventArgs e)
        {
            Classes.Database.Search(dgv_tickets, "GetTicketsByLike", tbp_search.Text);
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {

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
                TstbxCurrentPage.Text = currentPage.ToString();
                Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);
            }
            else if (currentPage == totalPages)
            {
                currentPage = 1;
                TstbxCurrentPage.Text = currentPage.ToString();
                Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);
            }
        }

        private void TsbLastPage_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            TstbxCurrentPage.Text = currentPage.ToString();
            Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);
        }

        private void TsbPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                TstbxCurrentPage.Text = currentPage.ToString();
                Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);
            }
            else if (currentPage == 1)
            {
                currentPage = 1;
                TstbxCurrentPage.Text = currentPage.ToString();
                Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);
            }
        }

        private void TsbFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            TstbxCurrentPage.Text = currentPage.ToString();
            Classes.Database.GetTicketList(dgv_tickets, "GetTicketListOffset", paginationSize, (currentPage - 1) * paginationSize);
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
    }
}
