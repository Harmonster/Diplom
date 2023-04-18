using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Pdfa;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Diplom
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgv_report);
        }

        private void ExportToPdf(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf|*.pdf)";
                sfd.FileName = "Отчёт " + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";
                bool errorMsg = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (Exception ex)
                        {
                            errorMsg = true;
                            MessageBox.Show("Невозможно сохранить файл на диск.", "Ошибка", MessageBoxButtons.OKCancel);
                        }
                    }
                    if (!errorMsg)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                            pdfTable.DefaultCell.Padding = 2;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach(DataGridViewColumn col in dgv.Columns)
                            {
                                PdfPCell pdfCell = new PdfPCell(new Phrase(col.HeaderText));
                                pdfTable.AddCell(pdfCell);
                            }
                            foreach(DataGridViewRow row in dgv.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream fstream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document doc = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                doc.Open();
                                doc.Add(pdfTable);
                                doc.Close();
                                fstream.Close();
                            }

                            MessageBox.Show("Данные успешно сохранены.", "Успех", MessageBoxButtons.OKCancel);
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                }
            }
        }

        private void ExportToExcel(DataGridView dgv)
        {
            if (dgv_report.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv_report.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgv_report.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_report.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_report.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgv_report.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            rb_mode_excel.Checked = true;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string currValue = (string)comboBox1.SelectedItem;
            switch (currValue)
            {
                case "Выполненные запросы":
                    Classes.Database.GetTicketList(dgv_report, "GetCompletedTickets");
                    break;
                case "Незакрытые срочные запросы":
                    Classes.Database.GetTicketList(dgv_report, "GetTicketsListFinishedHighPriority");
                    break;
                case "Запросы на доработке":
                    Classes.Database.GetTicketList(dgv_report, "GetTicketsListUnfinished");
                    break;
            }
        }
    }
}
