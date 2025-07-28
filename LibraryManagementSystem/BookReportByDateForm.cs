using BLL_Services.Services;
using BLL_Services.Validators;
using DTO_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_UI
{
    public partial class BookReportByDateForm : Form
    {
        private BookService bookService = new BookService();
        public BookReportByDateForm()
        {
            InitializeComponent();
        }
        private void loadAllBooks()
        {
            DateTime fromDate = new DateTime(1900, 1, 1);
            DateTime toDate = DateTime.Now;

            List<BookReport> list = bookService.GetBookReports(fromDate, toDate);

            dgvBookStatistics.DataSource = list;
        }
        private void BookStatisticsOverTimeForm_Load(object sender, EventArgs e)
        {
            dtbStartTime.Format = DateTimePickerFormat.Custom;
            dtbStartTime.CustomFormat = "dd/MM/yyyy";
            dtbEndTime.Format = DateTimePickerFormat.Custom;
            dtbEndTime.CustomFormat = "dd/MM/yyyy";

            loadAllBooks();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtbStartTime.Value;
            DateTime toDate = dtbEndTime.Value;
            string errorMessage;
            if (!BookReportValidator.IsValidDateRange(fromDate, toDate, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<BookReport> list = bookService.GetBookReports(fromDate, toDate);
            dgvBookStatistics.DataSource = list;
            if (list.Count == 0)
            {
                MessageBox.Show("No data available for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dtbStartTime.Value = new DateTime(1900, 1, 1);
            dtbEndTime.Value = DateTime.Now;
            loadAllBooks();
            MessageBox.Show("All records are displayed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
