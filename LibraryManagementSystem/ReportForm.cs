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
    public partial class ReportForm : Form
    {
        private ReportService ReportService { get; set; }
        public ReportForm()
        {
            ReportService = new ReportService();
            InitializeComponent();
            SetupComponent(dgvReport);

        }


        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            List<string> criteria = new List<string>
            {
                "Top 10 sách có lượt mượn cao nhất",
                "Top 10 mọt sách",
                "Tất cả sách đang được mượn",
                "Tất cả sách quá hạn",
                "Tất cả sách thất lạc"
            };

            cboFilter.DataSource = criteria;
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCriteria = cboFilter.SelectedItem.ToString();
            switch (selectedCriteria)
            {
                case "Top 10 sách có lượt mượn cao nhất":
                    dgvReport.DataSource = ReportService.GetTopBorrowedBooks();
                    break;
                case "Top 10 mọt sách":
                    dgvReport.DataSource = ReportService.GetTopReaders();
                    break;
                case "Tất cả sách đang được mượn":
                    dgvReport.DataSource = ReportService.GetBookReportViewModelByCriteria("Status","Đang mượn");
                    break;
                case "Tất cả sách quá hạn":
                    dgvReport.DataSource = ReportService.GetBookReportViewModelByCriteria("Status", "Quá hạn");
                    break;
                case "Tất cả sách thất lạc":
                    dgvReport.DataSource = ReportService.GetBookReportViewModelByCriteria("Status", "Thất lạc");
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn một tiêu chí hợp lệ.");
                    break;
            }
        }
    }
}
