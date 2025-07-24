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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetupComponent();
            timer1.Start();
            InitializeUIBasedOnRole();
            EmbedFormIntoPanel(new BookManagementForm());
        }


        private void SetupComponent()
        {
            // Set the main form properties
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Size = new Size(2400, 1600);
        }

        private void InitializeUIBasedOnRole()
        {
            if (UserSession.CurrentUser == null)
            {
                Application.Exit();
                return;
            }


            switch (UserSession.CurrentUser.RoleID)
            {
                case "ROLE001":
                    SetupAdminUI();
                    break;
                case "ROLE002":
                    SetupLibrarianUI();
                    break;
                default:
                    MessageBox.Show("Unauthorized access", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    break;
            }
        }

        private void SetupAdminUI()
        {
            lblWelcome.Text = UserSession.CurrentUser.FullName != null
                ? $"Xin chào,Quản trị viên {UserSession.CurrentUser.FullName} "
                : "Xin chào!";
        }

        private void SetupLibrarianUI()
        {
            lblWelcome.Text = UserSession.CurrentUser.FullName != null
                ? $"Xin chào,Thủ thư {UserSession.CurrentUser.FullName} "
                : "Xin chào!";
            ToolStripMenuItemUserManagement.Visible = false;
        }

        private void menuItemAuthorManagement_Click(object sender, EventArgs e)
        {
            var authorManagementForm = new AuthorManagementForm();
            EmbedFormIntoPanel(authorManagementForm);
        }

        private void menuItemBookManagement_Click(object sender, EventArgs e)
        {
            var bookManagementForm = new BookManagementForm();
            EmbedFormIntoPanel(bookManagementForm);
        }

        private void menuItemBookCopiesManagement_Click(object sender, EventArgs e)
        {
            var bookCopiesManagementForm = new BookCopiesManagementForm();
            EmbedFormIntoPanel(bookCopiesManagementForm);
        }


        private void EmbedFormIntoPanel(Form form)
        {
            // Dispose the old form if present
            if (panelMainContainer.Controls.Count > 0)
            {
                var oldForm = panelMainContainer.Controls[0] as Form;
                oldForm?.Dispose();
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMainContainer.Controls.Clear();
            panelMainContainer.Controls.Add(form);
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ToolStripMenuItemLoanDashboard_Click(object sender, EventArgs e)
        {
            var loanDashboardForm = new LoanDashboardForm();
            EmbedFormIntoPanel(loanDashboardForm);
        }

        private void ToolStripMenuItemUserManagement_Click(object sender, EventArgs e)
        {
            var userManagementForm = new UserManagementForm();
            EmbedFormIntoPanel(userManagementForm);
        }

        private void ToolStripMenuItemFineManagement_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemSupport_Click(object sender, EventArgs e)
        {
            var supportForm = new SupportForm();
            EmbedFormIntoPanel(supportForm);
        }

        private void ToolStripMenuItemIntroduce_Click(object sender, EventArgs e)
        {
            var introduceForm = new IntroduceForm();
            EmbedFormIntoPanel(introduceForm);
        }

        private void ToolStripMenuItemMemberManagement_Click(object sender, EventArgs e)
        {
            var memberManagementForm = new MemberManagementForm();
            EmbedFormIntoPanel(memberManagementForm);
        }

        private void ToolStripMenuItemChangePassword_Click(object sender, EventArgs e)
        {
            using (var form = new ChangePasswordForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Password changed successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ToolStripMenuItemRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ToolStripMenuItemExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItemLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
