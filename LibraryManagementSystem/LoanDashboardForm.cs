using BLL_Services.Services;
using DTO_Models;
using DTO_Models.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_UI
{
    public partial class LoanDashboardForm : Form
    {
        private LoanService LoanService { get; set; }

        public LoanDashboardForm()
        {
            LoanService = new LoanService();
            InitializeComponent();
            SetupComponent(dgvLoans);
            LoadLoans();
        }


        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;

            //Set up status combo box
            cboStatus.DataSource = new List<string> { "Đang mượn", "Đã trả", "Quá hạn", "Thất lạc" };
            cboStatus.SelectedIndex = -1; 

            //Set up member combo box
        }

        // Load the loan data into the DataGridView
        private void LoadLoans()
        {
            try
            {
                List<LoanViewModel> loans = LoanService.GetLoanViewModels();
                dgvLoans.DataSource = loans;
                SetupComponent(dgvLoans);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading loans: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan()
            {
                LoanID = txtLoanId.Text,
                CopyID = txtCopyId.Text,
               

            };
        }

        //public string? LoanID { get; set; }
        //public string? CopyID { get; set; }
        //public string? MemberID { get; set; }
        //public DateTime LoanDate { get; set; }
        //public DateTime DueDate { get; set; }
        //public DateTime? ReturnDate { get; set; }
        //public string? Status { get; set; }
        //public string? Notes { get; set; }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
