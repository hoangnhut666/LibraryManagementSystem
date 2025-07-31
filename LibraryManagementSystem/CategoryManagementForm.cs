using BLL_Services.Services;
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
    public partial class CategoryManagementForm : Form
    {
        private CategoryService CategoryService { get; set; }
        public CategoryManagementForm()
        {
            CategoryService = new CategoryService();
            InitializeComponent();
            SetupComponent(dgvCategories);
            LoadCategories();
        }


        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;

            txtDescription.ScrollBars = ScrollBars.Vertical;

            txtSearch.PlaceholderText = "Tìm kiếm theo mã thể loại, tên thể loại...";

            txtDescription.MaxLength = 255; 
            txtDescription.ScrollBars = ScrollBars.Vertical;
        }

        private void LoadCategories()
        {
            try
            {
                var categories = CategoryService.GetCategories();
                dgvCategories.DataSource = categories;
                dgvCategories.Columns["CategoryID"].HeaderText = "Mã thể loại";
                dgvCategories.Columns["Name"].HeaderText = "Tên thể loại";
                dgvCategories.Columns["Description"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi tải danh sách thể loại: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                CategoryID = CategoryService.GenerateCategoryID(),
                Name = txtCategoryName.Text.Trim(),
                Description = txtDescription.Text.Trim()
            };

            try
            {
                if (CategoryService.AddCategory(category) > 0)
                {
                    MessageBox.Show("Thêm thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFields();
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Thêm thể loại thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi thêm thể loại: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category category = new Category
            {
                CategoryID = txtCategoryId.Text.Trim(),
                Name = txtCategoryName.Text.Trim(),
                Description = txtDescription.Text.Trim()
            };

            try
            {
                if (CategoryService.UpdateCategory(category) > 0)
                {
                    MessageBox.Show("Cập nhật thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFields();
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Cập nhật thể loại thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi cập nhật thể loại: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thể loại này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                string categoryId = txtCategoryId.Text.Trim();
                try
                {
                    if (CategoryService.DeleteCategory(categoryId) > 0)
                    {
                        MessageBox.Show("Xóa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputFields();
                        LoadCategories();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thể loại thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Một lỗi xảy ra khi xóa thể loại: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadCategories();
        }

        private void ClearInputFields()
        {
            txtCategoryId.Clear();
            txtCategoryName.Clear();
            txtDescription.Clear();
            txtSearch.Clear();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCategories.Rows.Count)
            {
                var row = dgvCategories.Rows[e.RowIndex];
                txtCategoryId.Text = row.Cells["CategoryID"].Value.ToString();
                txtCategoryName.Text = row.Cells["Name"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            try
            {
                var categories = CategoryService.SearchCategories(searchTerm);
                dgvCategories.DataSource = categories;
                if (categories.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy thể loại nào phù hợp với từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi tìm kiếm thể loại: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
