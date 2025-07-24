using BLL_Services.Validators;
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
using BLL_Services.Services;

namespace GUI_UI
{
    public partial class ChangePasswordForm : Form
    {
        private ChangePasswordValidator ChangePasswordValidator { get; set; }
        private SecurityService SecurityService { get; set; }

        public ChangePasswordForm()
        {
            ChangePasswordValidator = new ChangePasswordValidator();
            SecurityService = new SecurityService();
            InitializeComponent();
            SetupComponent();
        }


        private void SetupComponent()
        {
            StartPosition = FormStartPosition.CenterScreen;
            txtConfirmNewPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtOldPassword.UseSystemPasswordChar = true;
        }


        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser == null)
            {
                MessageBox.Show("Không có người dùng hiện tại. Vui lòng đăng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = UserSession.CurrentUser.Username ?? string.Empty;

            if (username != txtUserName.Text)
            {
                MessageBox.Show("Tên đăng nhập không khớp với người dùng hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ChangePasswordValidator.IsValidPassword(username, txtOldPassword.Text, txtNewPassword.Text, txtConfirmNewPassword.Text))
            {
                MessageBox.Show(ChangePasswordValidator.ErrorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int result = SecurityService.UpdatePassword(username, txtNewPassword.Text.Trim());
            if (result > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Application.Restart();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShowOldPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtOldPassword.UseSystemPasswordChar = !chkShowOldPassword.Checked;
        }

        private void chkShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = !chkShowNewPassword.Checked;
        }

        private void chkShowConfirmNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmNewPassword.UseSystemPasswordChar = !chkShowConfirmNewPassword.Checked;
        }
    }
}
