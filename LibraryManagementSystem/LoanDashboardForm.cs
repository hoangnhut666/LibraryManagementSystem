using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Services.Services;
using DTO_Models.ViewModel;

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
    }
}
