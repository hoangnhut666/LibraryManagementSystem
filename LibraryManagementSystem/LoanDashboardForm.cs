using BLL_Services.Services;
using DTO_Models;
using DTO_Models.ViewModel;
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
    public partial class LoanDashboardForm : Form
    {
        private LoanService LoanService { get; set; }
        private MemberService MemberService { get; set; }
        private BookCopyService BookCopyService { get; set; }
        private BookService BookService { get; set; }
        private User? CurrentUser { get; set; }

        public LoanDashboardForm()
        {
            LoanService = new LoanService();
            MemberService = new MemberService();
            BookCopyService = new BookCopyService();
            BookService = new BookService();
            CurrentUser = UserSession.CurrentUser;
            InitializeComponent();
            SetupComponent(dgvLoans);
            LoadLoans();

            txtUserFullName.Text = CurrentUser?.FullName ?? string.Empty;
        }


        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;

            //Set up status combo box
            cboStatus.DataSource = new List<string> { "Đang mượn", "Đã trả", "Quá hạn", "Thất lạc" };
            cboStatus.SelectedIndex = -1;

            //Set up member combo box
            cboMemberFullName.DataSource = MemberService.GetMembers();
            cboMemberFullName.DisplayMember = "FullName";
            cboMemberFullName.ValueMember = "MemberID";
            cboMemberFullName.SelectedIndex = -1;

            cboCopyId.DataSource = BookCopyService.GetAllBookCopies();
            cboCopyId.DisplayMember = "Barcode";
            cboCopyId.ValueMember = "CopyID";
            cboCopyId.SelectedIndex = -1;

            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.CustomFormat = " ";
            dtpLoanDate.Format = DateTimePickerFormat.Custom;
            dtpLoanDate.CustomFormat = " ";
            dtpReturnDate.Format = DateTimePickerFormat.Custom;
            dtpReturnDate.CustomFormat = " ";

            txtSearch.PlaceholderText = "Tìm với tên bạn đọc, mã mượn, tên sách ...";
        }

        // Load the loan data into the DataGridView
        private void LoadLoans()
        {
            try
            {
                if (CurrentUser?.RoleID == "ROLE002")
                {
                    dgvLoans.DataSource = LoanService.GetLoanViewModelsByCriteria("Username", CurrentUser.Username);
                }
                else
                {
                    List<LoanViewModel> loans = LoanService.GetLoanViewModels();
                    dgvLoans.DataSource = loans;
                }

                SetupComponent(dgvLoans);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading loans: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan()
            {
                LoanID = txtLoanId.Text,
                CopyID = cboCopyId.SelectedValue?.ToString(),
                MemberID = cboMemberFullName.SelectedValue?.ToString(),
                UserID = CurrentUser?.UserID,
                LoanDate = dtpLoanDate.Value,
                DueDate = dtpDueDate.Value,
                ReturnDate = dtpReturnDate.Value,
                Status = cboStatus.Text,
                Notes = txtNotes.Text
            };

            try
            {
                int result = LoanService.AddLoan(loan);
                if (result > 0)
                {
                    MessageBox.Show("Loan added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoans();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to add loan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while adding the loan. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadLoans();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dtpLoanDate_ValueChanged(object sender, EventArgs e)
        {
            dtpLoanDate.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            dtpReturnDate.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDueDate.CustomFormat = "dd/MM/yyyy";
        }

        private void ClearInputFields()
        {
            txtLoanId.Clear();
            cboCopyId.SelectedIndex = -1;
            cboMemberFullName.SelectedIndex = -1;
            dtpLoanDate.CustomFormat = " ";
            dtpDueDate.CustomFormat = " ";
            dtpReturnDate.CustomFormat = " ";
            cboStatus.SelectedIndex = -1;
            txtNotes.Clear();
        }

        private void dgvLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLoans.Rows.Count)
            {
                string? loanId = dgvLoans.Rows[e.RowIndex].Cells["MaMuon"].Value?.ToString();
                var selectedRow = dgvLoans.Rows[e.RowIndex];
                var selectedLoan = LoanService.GetLoansByCriteria("LoanID", loanId).FirstOrDefault();
                txtLoanId.Text = selectedRow.Cells["MaMuon"].Value?.ToString() ?? string.Empty;
                cboCopyId.SelectedValue = selectedRow.Cells["MaBanSao"].Value?.ToString() ?? string.Empty;
                cboMemberFullName.Text = selectedRow.Cells["TenDocGia"].Value?.ToString() ?? string.Empty;
                if (selectedLoan?.LoanDate != null)
                {
                    dtpDueDate.CustomFormat = "dd/MM/yyyy";
                    dtpLoanDate.Value = selectedLoan.LoanDate;
                }
                else
                {
                    dtpLoanDate.CustomFormat = " ";
                }
                if (selectedLoan?.DueDate != null)
                {
                    dtpDueDate.CustomFormat = "dd/MM/yyyy";
                    dtpDueDate.Value = selectedLoan.DueDate;
                }
                else
                {
                    dtpDueDate.CustomFormat = " ";
                }
                if (selectedLoan?.ReturnDate != null)
                {
                    dtpReturnDate.CustomFormat = "dd/MM/yyyy";
                    dtpReturnDate.Value = selectedLoan.ReturnDate.Value;
                }
                else
                {
                    dtpReturnDate.CustomFormat = " ";
                }
                txtTitle.Text = selectedRow.Cells["TenSach"].Value?.ToString() ?? string.Empty;
                txtUserFullName.Text = selectedRow.Cells["TenNhanVien"].Value?.ToString() ?? string.Empty;
                cboStatus.Text = selectedRow.Cells["TrangThai"].Value?.ToString() ?? string.Empty;
                txtNotes.Text = selectedLoan?.Notes ?? string.Empty;
            }
        }

        private void cboCopyId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBook = BookService.GetBooksByCriteria("CopyID", cboCopyId.SelectedValue?.ToString()).FirstOrDefault();
            txtTitle.Text = selectedBook?.Title ?? string.Empty;
        }
    }
}

//public class LoanViewModel
//{
//    public string? MaMuon { get; set; }
//    public string? MaBanSao { get; set; }
//    public string? TenSach { get; set; }
//    public string? TenDocGia { get; set; }
//    public string? TenNhanVien { get; set; }
//    public DateTime NgayMuon { get; set; }
//    public DateTime HanTra { get; set; }
//    public DateTime? NgayTra { get; set; }
//    public string? TrangThai { get; set; }
//}


//    private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
//{
//    if (e.RowIndex >= 0)
//    {
//        var selectedRow = dgvUserList.Rows[e.RowIndex];
//        var selectedUserId = selectedRow.Cells[0].Value?.ToString();

//        if (!string.IsNullOrEmpty(selectedUserId))
//        {
//            var selectedUser = UserService.GetUserById(selectedUserId);
//            txtUserId.Text = selectedUser.UserID;
//            txtUserName.Text = selectedUser.Username;
//            txtFullName.Text = selectedUser.FullName;
//            txtPassword.Text = selectedUser.Password;
//            txtConfirmPassword.Text = selectedUser.Password;
//            txtEmail.Text = selectedUser.Email;
//            cboRole.Text = selectedRow.Cells[2].Value?.ToString();
//            chkIsActive.Checked = selectedUser.IsActive;
//        }
//        else
//        {
//            MessageBox.Show("The selected user ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//        }
//    }
//}