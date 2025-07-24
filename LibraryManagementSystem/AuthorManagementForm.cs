using BLL_Services;
using BLL_Services.Services;
using BLL_Services.Validators;
using DAL_Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            // Set the TextBox properties
            txtBiography.Multiline = true;
            txtBiography.ScrollBars = ScrollBars.Vertical;
            txtSearch.PlaceholderText = "Nhập id hoặc tên tác giả cần tìm";
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
                if (selectedAuthor.DateOfBirth != null)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the new author from the input fields
            Author author = new Author
            {
                AuthorID = AuthorService.GenerateAuthorID(),
                FullName = txtFullName.Text.Trim(),
                Biography = txtBiography.Text.Trim(),
                DateOfBirth = dtpDateOfBirth.Checked ? dtpDateOfBirth.Value : (DateTime?)null,
                DateOfDeath = dtpDateOfDeath.Checked ? dtpDateOfDeath.Value : (DateTime?)null
            };

            // Add the author to the database
            try
            {
                int result = AuthorService.AddAuthor(author);
                if (result > 0)
                {
                    MessageBox.Show("Author added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAuthors();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to add author. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the author: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the selected author from the input fields
            Author author = new Author
            {
                AuthorID = txtAuthorID.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Biography = txtBiography.Text.Trim(),
                DateOfBirth = dtpDateOfBirth.Checked ? dtpDateOfBirth.Value : (DateTime?)null,
                DateOfDeath = dtpDateOfDeath.Checked ? dtpDateOfDeath.Value : (DateTime?)null
            };


            // Update the author in the database
            try
            {
                int result = AuthorService.UpdateAuthor(author);
                if (result > 0)
                {
                    MessageBox.Show("Author updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAuthors();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to update author. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the author: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string authorId = txtAuthorID.Text.Trim();
                DialogResult result = MessageBox.Show("Are you sure you want to delete this author?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Delete the author from the database
                    if (AuthorService.DeleteAuthor(authorId) > 0)
                    {
                        MessageBox.Show("Author deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAuthors();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete author. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while deleting the author. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadAuthors();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();
                dgvAuthors.DataSource = AuthorService.SearchAuthors(searchTerm);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while searching for authors. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpDateOfDeath_ValueChanged(object sender, EventArgs e)
        {
            dtpDateOfDeath.CustomFormat = "dd/MM/yyyy";
        }
    }
}
