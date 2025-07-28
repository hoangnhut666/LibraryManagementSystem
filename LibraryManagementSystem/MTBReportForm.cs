using BLL_Services.Services;
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
    public partial class MTBReportForm : Form
    {
        public MTBReportForm()
        {
            InitializeComponent();
            loadComboBox();
        }
        private void loadComboBox()
        {
            // Add items to the combo box
            cboReportType.Items.Add("Sách mượn nhiều nhất");
            cboReportType.Items.Add("Người mượn hàng đầu");
            cboReportType.Items.Add("Tình trạng tồn kho sách");
            // Set the default selected item
            if (cboReportType.Items.Count > 0)
            {
                cboReportType.SelectedIndex = 0;
            }
        }
        private void cboReportType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void baform_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Get the selected report type from the combo box
            string selectedReportType = cboReportType.SelectedItem.ToString();
            // Create an instance of the ReportService
            BookService bookService = new BookService();
            // Call the appropriate method based on the selected report type
            switch (selectedReportType)
            {
                case "Sách mượn nhiều nhất":
                    dgvReport.DataSource =  bookService.GetTopBorrowedBooks();
                    break;
                case "Người mượn hàng đầu":
                    dgvReport.DataSource = bookService.GetTopReaders();
                    break;
                case "Tình trạng tồn kho sách":
                    dgvReport.DataSource = bookService.GetBookInventoryStatus();
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn loại báo cáo hợp lệ.");
                    break;
            }
        }
    }
}
