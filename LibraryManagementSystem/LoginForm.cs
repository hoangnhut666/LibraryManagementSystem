using BLL_Services.Services;
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

namespace GUI_UI
{
    public partial class LoginForm : Form
    {
        private SecurityService SecurityService { get; set; }
        private UserService UserService { get; set; }
        private LoginValidator LoginValidator { get; set; }
        private Dictionary<string, int> failedAttempts = new Dictionary<string, int>();
        public LoginForm()
        {
            SecurityService = new SecurityService();
            UserService = new UserService();
            LoginValidator = new LoginValidator();
            InitializeComponent();
            SetupComponent();
        }


        private void SetupComponent()
        {
            StartPosition = FormStartPosition.CenterScreen;
            txtPassword.UseSystemPasswordChar = true;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!LoginValidator.Validate(username, password))
            {
                MessageBox.Show(LoginValidator.ErrorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string? storedHash = SecurityService.GetStoredHashedPasswordWithUsername(username);

            if (storedHash == null)
            {
                MessageBox.Show("Tên đăng nhập không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!SecurityService.VerifyPassword(password, storedHash))
            {
                if (username == "helperadmin")
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (failedAttempts.ContainsKey(username))
                {
                    failedAttempts[username]++;
                }
                else
                {
                    failedAttempts[username] = 1;
                }

                if (failedAttempts[username] >= 3)
                {

                    SecurityService.LockAccountByUsername(username);
                    MessageBox.Show("Tài khoản của bạn đã bị khóa do quá nhiều lần đăng nhập không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show($"Tên đăng nhập hoặc mật khẩu không đúng. Số lần thử còn lại: {3 - failedAttempts[username]}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserSession.CurrentUser = UserService.GetUserByUsername(username);
            this.DialogResult = DialogResult.OK;
            this.Close();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
