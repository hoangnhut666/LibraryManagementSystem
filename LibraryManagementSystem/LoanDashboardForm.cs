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
            txtTitle.Text = string.Empty;
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
            cboMemberID.DataSource = MemberService.GetMembers();
            cboMemberID.DisplayMember = "MemberID";
            cboMemberID.ValueMember = "MemberID";
            cboMemberID.SelectedIndex = -1;

            cboCopyId.DataSource = BookCopyService.GetAllBookCopies();
            cboCopyId.DisplayMember = "CopyID";
            cboCopyId.ValueMember = "CopyID";
            cboCopyId.SelectedIndex = -1;

            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.CustomFormat = " ";
            dtpLoanDate.Format = DateTimePickerFormat.Custom;
            dtpLoanDate.CustomFormat = " ";
            dtpReturnDate.Format = DateTimePickerFormat.Custom;
            dtpReturnDate.CustomFormat = " ";

            txtSearch.PlaceholderText = "Tìm với tên bạn đọc, mã mượn, tên sách ...";
            txtNotes.ScrollBars = ScrollBars.Vertical;

            txtNotes.MaxLength = 255;
        }

        // Load the loan data into the DataGridView
        private void LoadLoans()
        {
            try
            {
                if (CurrentUser?.RoleID == "ROLE002")
                {
                    dgvLoans.DataSource = LoanService.GetLoanViewModelsByCriteria("UserID", CurrentUser.UserID);
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
                MessageBox.Show($"Một lỗi xảy ra khi tải dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan()
            {
                LoanID = LoanService.GenerateNewLoanID(),
                CopyID = cboCopyId.Text,
                MemberID = cboMemberID.SelectedValue?.ToString(),
                UserID = CurrentUser?.UserID,
                LoanDate = dtpLoanDate.CustomFormat == " " ? default(DateTime) : dtpLoanDate.Value,
                DueDate = dtpDueDate.CustomFormat == " " ? default(DateTime) : dtpDueDate.Value,
                ReturnDate = dtpReturnDate.CustomFormat == " " ? default(DateTime) : dtpReturnDate.Value,
                Status = cboStatus.Text,
                Notes = txtNotes.Text
            };


            try
            {
                int result = LoanService.AddLoan(loan);
                if (result > 0)
                {
                    MessageBox.Show("Thêm phiếu mượn thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoans();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm phiếu mượn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi thêm phiếu mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Loan loan = new Loan()
            {
                LoanID = txtLoanId.Text,
                CopyID = cboCopyId.SelectedValue?.ToString(),
                MemberID = cboMemberID.SelectedValue?.ToString(),
                UserID = CurrentUser?.UserID,
                LoanDate = dtpLoanDate.CustomFormat == " " ? default(DateTime) : dtpLoanDate.Value,
                DueDate = dtpDueDate.CustomFormat == " " ? default(DateTime) : dtpDueDate.Value,
                ReturnDate = dtpReturnDate.CustomFormat == " " ? default(DateTime) : dtpReturnDate.Value,
                Status = cboStatus.Text,
                Notes = txtNotes.Text
            };

            try
            {
                int result = LoanService.UpdateLoan(loan);
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật phiếu mượn thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoans();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Cập nhật phiếu mượn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi cập nhật phiếu mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var loanId = txtLoanId.Text;
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu mượn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
            {
                return; 
            }
            try
            {
                int result = LoanService.DeleteLoan(loanId);
                if (result > 0)
                {
                    MessageBox.Show("Xóa phiếu mượn thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoans();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Xóa phiếu mượn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi xóa phiếu mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadLoans();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                List<LoanViewModel> searchResults = LoanService.SearchLoansBySearchTerm(searchTerm);
                if (searchResults.Count > 0)
                {
                    dgvLoans.DataSource = searchResults;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu mượn nào khớp với tiêu chí tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoans();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi tìm kiếm phiếu mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            cboMemberID.SelectedIndex = -1;
            dtpLoanDate.CustomFormat = " ";
            dtpDueDate.CustomFormat = " ";
            dtpReturnDate.CustomFormat = " ";
            cboStatus.SelectedIndex = -1;
            txtNotes.Clear();
            txtTitle.Clear();
            txtUserFullName.Clear();
            txtSearch.Clear();
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
                cboMemberID.Text = selectedRow.Cells["MaThanhVien"].Value?.ToString() ?? string.Empty;
                if (selectedLoan?.LoanDate != null)
                {
                    dtpLoanDate.CustomFormat = "dd/MM/yyyy";
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
            if (cboCopyId.SelectedItem is BookCopy selectedBookCopy)
            {
                var book = BookService.GetBooksByCriteria("BookID", selectedBookCopy.BookID).FirstOrDefault();
                txtTitle.Text = book?.Title ?? string.Empty;
            }
            else
            {
                txtTitle.Clear();
            }
        }

        private void cboMemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMemberID.SelectedItem is Member selectedMember)
            {
                txtMemberName.Text = selectedMember.FullName ?? string.Empty;
            }
            else
            {
                txtMemberName.Clear();
            }
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStatus.SelectedItem != null)
            {
                if (cboStatus.Text == "Đang mượn")
                {
                    txtDislayReturnDate.Visible = true;
                }
                else
                {
                    txtDislayReturnDate.Visible = false;
                }
            }
        }
    }
}