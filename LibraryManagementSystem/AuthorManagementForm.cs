using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Services;
using BLL_Services.Services;
using DTO_Models;

namespace GUI_UI
{
    public partial class AuthorManagementForm : Form
    {
        private AuthorService AuthorService { get; set; }
        public AuthorManagementForm()
        {
            AuthorService = new AuthorService();
            InitializeComponent();
            SetupComponent(dgvAuthors);
            LoadAuthors();
        }


        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;
            dtpDateOfDeath.Checked = false; 
            dtpDateOfBirth.Checked = false;

            // Set the DateTimePicker formats
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfDeath.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = " ";
            dtpDateOfDeath.CustomFormat = " ";

        }


        public void LoadAuthors()
        {
            try
            {
                var authors = AuthorService.GetAuthors();
                dgvAuthors.DataSource = authors;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading authors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAuthors.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvAuthors.Rows[e.RowIndex];
                Author selectedAuthor = (Author)selectedRow.DataBoundItem;
                // Fill the input fields with the selected author's data
                txtAuthorID.Text = selectedAuthor.AuthorID;
                txtFullName.Text = selectedAuthor.FullName;
                if(selectedAuthor.DateOfBirth != null)
                {
                    dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
                    dtpDateOfBirth.Value = selectedAuthor.DateOfBirth ?? DateTime.Now; 
                }
                else
                {
                    dtpDateOfBirth.CustomFormat = " ";
                }
                if (selectedAuthor.DateOfDeath != null)
                {
                    dtpDateOfDeath.CustomFormat = "dd/MM/yyyy";
                    dtpDateOfDeath.Value = selectedAuthor.DateOfDeath ?? DateTime.Now;
                }
                else
                {
                    dtpDateOfDeath.CustomFormat = " ";
                }
                txtBiography.Text = selectedAuthor.Biography;
            }
            else
            {
                ClearInputFields();
            }
        }

        private void ClearInputFields()
        {
            txtFullName.Clear();
            dtpDateOfBirth.CustomFormat = " ";
            dtpDateOfDeath.CustomFormat = " ";
            txtBiography.Clear();
        }
    }
}
