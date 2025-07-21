using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Services;
using BLL_Services.Services;
using BLL_Services.Validators;
using DAL_Data;
using DTO_Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DBUTIL_Utilities;
using Microsoft.Data.SqlClient;

namespace GUI_UI
{

    public partial class MembersManagementForm : Form
    {
        public static class ImageToByteConverter
        {
            public static byte[] ConvertImageToByte(Image image)
            {
                using (var ms = new System.IO.MemoryStream())
                {
                    using (var temp = new Bitmap(image)) // copy ảnh sang bitmap mới
                    {
                        temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // luôn lưu dưới dạng PNG
                        return ms.ToArray();
                    }
                }
            }

        }
        private MemberService MemberService { get; set; }
        private MemberValidator MemberValidator { get; set; }
        private MemberRepository MemberRepository { get; set; }
        public MembersManagementForm()
        {
            InitializeComponent();
            SetupComponent(dgvMembers);
            LoadMembers();
        }
        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;
            // Set the TextBox properties
            txtSearch.PlaceholderText = "Enter MemberID to search";
        }
        private void LoadMembers()
        {
            MemberService = new MemberService();
            MemberValidator = new MemberValidator();
            dgvMembers.DataSource = MemberService.GetMembers();
            dgvMembers.Columns["Photo"].Visible = false; // Hide the Photo column
        }
        private void ClearInputFields()
        {
            txtMemberID.Clear();
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            chkStatus.Checked = false;
            dtpDateOfBirth.Value = DateTime.Now;
            dtpJoinDate.Value = DateTime.Now;
            picMemberPhoto.Image = null; // Clear the picture box
        }
        private void MembersManagementForm_Load(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Member newMember = new Member
                {
                    MemberID = string.IsNullOrEmpty(txtMemberID.Text.Trim()) ? MemberService.GenerateMemberID() : txtMemberID.Text.Trim(),
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Status = chkStatus.Checked ? "Hoạt động" : "Không hoạt động",
                    DateOfBirth = dtpDateOfBirth.Value,
                    JoinDate = dtpJoinDate.Value,
                    Photo = picMemberPhoto.Image != null ? ImageToByteConverter.ConvertImageToByte(picMemberPhoto.Image) : null
                };

                // Áp dụng kiểm tra hợp lệ
                MemberValidator validator = new MemberValidator();

                if (validator.IsvaliMember(newMember))
                {
                    MemberService.AddMember(newMember);
                    LoadMembers();
                    ClearInputFields();
                    MessageBox.Show("Added member successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(validator.ErrorMessage ?? "Invalid data!", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding member: {ex.Message}", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMembers.Rows.Count)
            {
                DataGridViewRow row = dgvMembers.Rows[e.RowIndex];
                txtMemberID.Text = row.Cells["MemberID"].Value?.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
                chkStatus.Checked = row.Cells["Status"].Value?.ToString() == "Hoạt động";
                dtpDateOfBirth.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                dtpJoinDate.Value = Convert.ToDateTime(row.Cells["JoinDate"].Value);

                var photoValue = row.Cells["Photo"].Value;
                if (photoValue != DBNull.Value && photoValue != null)
                {
                    byte[] photoData = (byte[])photoValue;
                    if (photoData.Length > 0)
                    {
                        using (var ms = new System.IO.MemoryStream(photoData))
                        {
                            picMemberPhoto.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        picMemberPhoto.Image = null;
                    }
                }
                else
                {
                    picMemberPhoto.Image = null; // Clear the picture box if no photo
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picMemberPhoto.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Không thể tải ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemberID.Text.Trim()))
            {
                MessageBox.Show("Please select member to delete.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string memberId = txtMemberID.Text.Trim();
                var confirmResult = MessageBox.Show($"Are you sure delete {memberId}?", "Ok", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    MemberRepository = new MemberRepository();
                    int result = MemberRepository.Delete(memberId);
                    if (result > 0)
                    {
                        MessageBox.Show("Complete!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMembers();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("No member found to delete or deletion failed.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errol: {ex.Message}", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMemberID.Text.Trim()))
                {
                    MessageBox.Show("Please select a member to update.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Member updatedMember = new Member
                {
                    MemberID = txtMemberID.Text.Trim(),
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Status = chkStatus.Checked ? "Hoạt động" : "Không hoạt động",
                    DateOfBirth = dtpDateOfBirth.Value,
                    JoinDate = dtpJoinDate.Value,
                    Photo = picMemberPhoto.Image != null ? ImageToByteConverter.ConvertImageToByte(picMemberPhoto.Image) : null
                };
                // Áp dụng kiểm tra hợp lệ
                MemberValidator validator = new MemberValidator();
                MemberRepository = new MemberRepository();
                if (validator.IsvaliMember(updatedMember))
                {
                    int result = MemberRepository.Update(updatedMember);
                    if (result > 0)
                    {
                        MessageBox.Show("Membership updated successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadMembers();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("No member found to update or update failed.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(validator.ErrorMessage ?? "Invalid data!", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating member: {ex.Message}", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();
                if (string.IsNullOrEmpty(searchTerm))
                {
                    MessageBox.Show("Please enter a search term.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                List<Member> searchResults = MemberService.SearchMembers(searchTerm);
                if (searchResults.Count > 0)
                {
                    dgvMembers.DataSource = searchResults;
                }
                else
                {
                    MessageBox.Show("No members found matching the search criteria.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMembers(); // Reload all members if no results found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching members: {ex.Message}", "Errol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
