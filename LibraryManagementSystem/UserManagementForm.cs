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
        public UserManagementForm()
        {
            UserService = new UserService();
            RoleService = new RoleService();
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
                MessageBox.Show($"An error occurred while loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("No users found matching the search criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("The selected user ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User() { 
                UserID = UserService.GenerateUserID(),
                Username = txtUserName.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                RoleID = cboRole.SelectedValue?.ToString(),
                IsActive = chkIsActive.Checked
            };

            //Add user to the database
            try
            {
                if (UserService.AddUser(user) > 0)
                {
                    MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserViewModels();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to add user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Get user details from input fields
            User user = new User()
            {
                UserID = txtUserId.Text.Trim(),
                Username = txtUserName.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                RoleID = cboRole.SelectedValue?.ToString(),
                IsActive = chkIsActive.Checked
            };

            //Update user in the database
            try
            {
                if (UserService.UpdateUser(user) > 0)
                {
                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUserViewModels();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to update user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string userId = txtUserId.Text.Trim();
                try
                {
                    if (UserService.DeleteUser(userId) > 0)
                    {
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUserViewModels();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while deleting the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

