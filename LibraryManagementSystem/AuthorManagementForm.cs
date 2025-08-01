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
            txtBiography.MaxLength = 1000;
            txtSearch.PlaceholderText = "Nhập id hoặc tên tác giả cần tìm";

            
        }


        public void LoadAuthors()
        {
            try
            {
                var authors = AuthorService.GetAuthors();
                dgvAuthors.DataSource = authors;
                dgvAuthors.Columns["AuthorID"].HeaderText = "Mã tác giả";
                dgvAuthors.Columns["FullName"].HeaderText = "Tên tác giả";
                dgvAuthors.Columns["Biography"].HeaderText = "Tiểu sử";
                dgvAuthors.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
                dgvAuthors.Columns["DateOfDeath"].HeaderText = "Ngày mất";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi tải danh sách tác giả: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtAuthorID.Clear();
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
                    MessageBox.Show("Thêm tác giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAuthors();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm tác giả thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi thêm tác giả: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Cập nhật tác giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAuthors();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Cập nhật tác giả thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi cập nhật tác giả: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string authorId = txtAuthorID.Text.Trim();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Delete the author from the database
                    if (AuthorService.DeleteAuthor(authorId) > 0)
                    {
                        MessageBox.Show("Xóa tác giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAuthors();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Xóa tác giả thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Một lỗi xảy ra khi xóa tác giả. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Một lỗi xảy ra khi tìm kiếm tác giả. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
