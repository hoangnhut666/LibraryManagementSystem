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
using DTO_Models.ViewModel;

namespace GUI_UI
{
    public partial class FineManagementForm : Form
    {
        private FineService FineService { get; set; }
        private LoanService LoanService { get; set; }
        private MemberService MemberService { get; set; }

        public FineManagementForm()
        {
            FineService = new FineService();
            LoanService = new LoanService();
            MemberService = new MemberService();
            InitializeComponent();
            SetupComponent(dgvFineList);
            LoadFineViewModels();
        }


        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;

            // Set the DateTimePicker formats
            dtpIssueDate.Format = DateTimePickerFormat.Custom;
            dtpIssueDate.CustomFormat = " ";

            cboLoanID.DataSource = LoanService.GetAllLoans();
            cboLoanID.DisplayMember = "LoanID";
            cboLoanID.ValueMember = "LoanID";
            cboLoanID.SelectedIndex = -1;

            txtReason.ScrollBars = ScrollBars.Vertical;
            txtSearch.PlaceholderText = "Tìm kiếm với mã phiếu mượn, tên thành viên, mã phạt";
        }


        private void LoadFineViewModels()
        {
            try
            {
                var fineViewModels = FineService.GetFineViewModels();
                dgvFineList.DataSource = fineViewModels;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading fines", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Fine fine = new Fine
            {
                FineID = FineService.GenerateFineID(),
                LoanID = cboLoanID.Text.Trim(),
                Amount = decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) ? amount : null,
                IssueDate = dtpIssueDate.Value,
                Reason = txtReason.Text.Trim(),
                Paid = chkPaid.Checked
            };

            try
            {
                if (FineService.AddFine(fine) > 0)
                {
                    MessageBox.Show("Thêm khoản phạt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFields();
                    LoadFineViewModels();
                }
                else
                {
                    MessageBox.Show("Thêm khoản phạt không thành công. Vui lòng kiểm tra dữ liệu đầu vào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi đã xảy ra khi thêm khoản phạt: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Fine newFine = new Fine
            {
                FineID = txtFineID.Text.Trim(),
                LoanID = cboLoanID.Text.Trim(),
                Amount = decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) ? amount : null,
                IssueDate = dtpIssueDate.Value,
                Reason = txtReason.Text.Trim(),
                Paid = chkPaid.Checked
            };
            try
            {
                Fine? fine = FineService.GetFineById(txtFineID.Text.Trim());
                if (fine?.Paid == true)
                {
                    MessageBox.Show("Không thể sửa khoản phạt đã được thanh toán.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (FineService.UpdateFine(newFine) > 0)
                {
                    MessageBox.Show("Cập nhật khoản phạt thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputFields();
                    LoadFineViewModels();
                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật khoản phạt ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi đã xảy ra khi cập nhật khoản phạt {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string fineId = txtFineID.Text.Trim();
            if (string.IsNullOrEmpty(fineId))
            {
                MessageBox.Show("Xin chọn khoản phạt để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoản phạt này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Fine? fine = FineService.GetFineById(fineId);
                    if (fine?.Paid == true)
                    {
                        MessageBox.Show("Không thể xóa khoản phạt đã được thanh toán.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (FineService.DeleteFine(fineId) > 0)
                    {
                        MessageBox.Show("Xóa khoản phạt thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputFields();
                        LoadFineViewModels();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khoản phạt không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Một lỗi đã xảy ra khi xóa khoản phạt. {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadFineViewModels();
        }

        private void dgvFineList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvFineList.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvFineList.Rows[e.RowIndex];
                string? selectedFineId = selectedRow.Cells["MaPhieuPhat"].Value?.ToString();
                var selectedFine = FineService.GetFineById(selectedFineId);
                cboLoanID.Text = selectedFine?.LoanID;
                txtFineID.Text = selectedRow.Cells["MaPhieuPhat"].Value?.ToString() ?? string.Empty;
                txtMemberName.Text = selectedRow.Cells["TenThanhVien"].Value?.ToString() ?? string.Empty;
                txtAmount.Text = selectedFine?.Amount?.ToString("F2");
                if (selectedFine?.IssueDate != null)
                {
                    dtpIssueDate.CustomFormat = "dd/MM/yyyy";
                    dtpIssueDate.Value = selectedFine.IssueDate.Value;
                }
                else
                {
                    dtpIssueDate.CustomFormat = " ";
                }
                txtReason.Text = selectedFine?.Reason ?? string.Empty;
                chkPaid.Checked = selectedFine?.Paid ?? false;
            }
        }

        private void dtpIssueDate_ValueChanged(object sender, EventArgs e)
        {
            dtpIssueDate.CustomFormat = "dd/MM/yyyy";
        }

        private void ClearInputFields()
        {
            txtFineID.Clear();
            cboLoanID.SelectedIndex = -1;
            txtMemberName.Clear();
            txtAmount.Clear();
            dtpIssueDate.CustomFormat = " ";
            txtReason.Clear();
            chkPaid.Checked = false;
            txtSearch.Clear();
        }

        private void cboLoanID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoanID.SelectedItem is Loan selectedLoan)
            {
                var member = MemberService.GetMemberById(selectedLoan.MemberID);
                txtMemberName.Text = member?.FullName ?? string.Empty;
                txtFineID.Clear();
                txtAmount.Clear();
                dtpIssueDate.CustomFormat = " ";
                txtReason.Clear();
                chkPaid.Checked = false;
            }
            else
            {
                txtMemberName.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm) || searchTerm == "Tìm kiếm với mã phiếu mượn, tên thành viên, mã phạt")
            {
                MessageBox.Show("Xin hãy nhập từ khóa tìm kiếm hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var searchResults = FineService.SearchFineBySearchTerm(searchTerm);
                if (searchResults.Count > 0)
                {
                    dgvFineList.DataSource = searchResults;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khoản phạt nào phù hợp với tiêu chí tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFineViewModels();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi đã xảy ra khi tìm kiếm khoản phạt {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
