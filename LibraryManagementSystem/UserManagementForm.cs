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
using DTO_Models;

namespace GUI_UI
{
    public partial class UserManagementForm : Form
    {
        private UserService UserService { get; set; }
        private RoleService RoleService { get; set; }
        private SecurityService SecurityHelper { get; set; }
        public UserManagementForm()
        {
            UserService = new UserService();
            RoleService = new RoleService();
            SecurityHelper = new SecurityService();
            InitializeComponent();
            SetupComponent(dgvUserList);
            LoadUserViewModels();
        }


        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;

            txtConfirmPassword.UseSystemPasswordChar = true;
            txtPassword.UseSystemPasswordChar = true;

            // Set up ComboBox for roles
            cboRole.DataSource = RoleService.GetAllRoles();
            cboRole.DisplayMember = "RoleName";
            cboRole.ValueMember = "RoleID";
            cboRole.SelectedIndex = -1; 

            txtSearch.PlaceholderText = "Tìm kiếm theo mã người dùng, tên, email, vai trò, tên đăng nhập";
        }

        private void LoadUserViewModels()
        {
            try
            {
                var userViewModels = UserService.GetUserViewModels();
                dgvUserList.DataSource = userViewModels;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải danh sách người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            try
            {
                var searchResults = UserService.SearchUsers(searchTerm);
                dgvUserList.DataSource = searchResults;
                if (searchResults.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy người dùng phù hợp với tiêu chí tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tìm kiếm người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvUserList.Rows[e.RowIndex];
                var selectedUserId = selectedRow.Cells[0].Value?.ToString();

                if (!string.IsNullOrEmpty(selectedUserId))
                {
                    var selectedUser = UserService.GetUserById(selectedUserId);
                    txtUserId.Text = selectedUser.UserID;
                    txtUserName.Text = selectedUser.Username;
                    txtFullName.Text = selectedUser.FullName;
                    txtPassword.Text = selectedUser.Password;
                    txtConfirmPassword.Text = selectedUser.Password;
                    txtEmail.Text = selectedUser.Email;
                    cboRole.Text = selectedRow.Cells[2].Value?.ToString();
                    chkIsActive.Checked = selectedUser.IsActive;
                }
                else
                {
                    MessageBox.Show("ID người dùng được chọn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void chkShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowConfirmPassword.Checked)
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User()
            {
                UserID = UserService.GenerateUserID(),
                Username = txtUserName.Text.Trim(),
                Password = SecurityService.HashPassword(txtPassword.Text.Trim()),
                Email = txtEmail.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                RoleID = cboRole.SelectedValue?.ToString(),
                IsActive = chkIsActive.Checked
            };

            try
            {
                if (UserService.AddUser(user) > 0)
                {
                    MessageBox.Show("Thêm người dùng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserViewModels();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi thêm người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User()
            {
                UserID = txtUserId.Text.Trim(),
                Username = txtUserName.Text.Trim(),
                Password = SecurityService.HashPassword(txtPassword.Text.Trim()),
                Email = txtEmail.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                RoleID = cboRole.SelectedValue?.ToString(),
                IsActive = chkIsActive.Checked
            };

            try
            {
                if (UserService.UpdateUser(user) > 0)
                {
                    MessageBox.Show("Cập nhật người dùng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserViewModels();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Cập nhật người dùng thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi cập nhật người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string userId = txtUserId.Text.Trim();
                try
                {
                    if (UserService.DeleteUser(userId) > 0)
                    {
                        MessageBox.Show("Xóa người dùng thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUserViewModels();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Xóa người dùng thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi khi xóa người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadUserViewModels();
        }

        private void ClearInputFields()
        {
            txtUserId.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtEmail.Clear();
            txtFullName.Clear();
            cboRole.SelectedIndex = -1;
            chkIsActive.Checked = false;
            chkShowPassword.Checked = false;
            chkShowConfirmPassword.Checked = false;
            txtSearch.Clear();
        }

    }
}

