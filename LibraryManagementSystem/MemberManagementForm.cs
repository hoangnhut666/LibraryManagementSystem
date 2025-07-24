using BLL_Services.Services;
using DAL_Data;
using DTO_Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class MemberManagementForm : Form
    {
        private MemberService MemberService { get; set; }
        public MemberManagementForm()
        {
            MemberService = new MemberService();
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
            txtSearch.PlaceholderText = "Tìm thành viên theo id, tên, email, số điện thoại";

            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.CustomFormat = " ";

            dtpJoinDate.Format = DateTimePickerFormat.Custom;
            dtpJoinDate.CustomFormat = " ";
        }

        private void LoadMembers()
        {
            dgvMembers.DataSource = MemberService.GetMembers();
            dgvMembers.Columns["Photo"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Member member = new Member
            {
                MemberID = MemberService.GenerateMemberID(),
                FullName = txtFullName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                DateOfBirth = dtpDateOfBirth.Value,
                JoinDate = dtpJoinDate.Value,
                Status = chkStatus.Checked ? "Hoạt động" : "Không hoạt động",
                Photo = picMemberPhoto.Image != null ? ImageToByteArray(picMemberPhoto.Image) : null
            };

            try
            {
                if (MemberService.AddMember(member) > 0)
                {
                    MessageBox.Show("Member added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMembers();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to add member. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Member member = new Member
            {
                MemberID = txtMemberID.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                DateOfBirth = dtpDateOfBirth.Value,
                JoinDate = dtpJoinDate.Value,
                Status = chkStatus.Checked ? "Hoạt động" : "Không hoạt động",
                Photo = picMemberPhoto.Image != null ? ImageToByteArray(picMemberPhoto.Image) : null
            };

            try
            {
                if (MemberService.UpdateMember(member) > 0)
                {
                    MessageBox.Show("Member updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMembers();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to update member. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    int result = MemberService.DeleteMember(memberId);
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
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadMembers();
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
            picMemberPhoto.Image = null;
            dtpJoinDate.CustomFormat = " ";
            dtpDateOfBirth.CustomFormat = " ";
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMembers.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvMembers.Rows[e.RowIndex];
                Member selectedMember = (Member)selectedRow.DataBoundItem;
                txtMemberID.Text = selectedMember.MemberID;
                txtFullName.Text = selectedMember.FullName;
                txtEmail.Text = selectedMember.Email;
                txtPhone.Text = selectedMember.Phone;
                txtAddress.Text = selectedMember.Address;
                dtpDateOfBirth.Value = selectedMember.DateOfBirth ?? DateTime.Now;
                dtpJoinDate.Value = selectedMember.JoinDate;
                chkStatus.Checked = selectedMember.Status == "Hoạt động";
                picMemberPhoto.Image = selectedMember.Photo != null ? Image.FromStream(new System.IO.MemoryStream(selectedMember.Photo)) : null;
            }
        }

        private void btnSelectCoverImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;"; ;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picMemberPhoto.Image = Image.FromFile(openFileDialog.FileName);
                    picMemberPhoto.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            dtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpJoinDate_ValueChanged(object sender, EventArgs e)
        {
            dtpJoinDate.CustomFormat = "dd/MM/yyyy";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            try
            {
                var members = MemberService.SearchMembers(searchTerm);
                if (members.Count > 0)
                {
                    dgvMembers.DataSource = members;
                    dgvMembers.Columns["Photo"].Visible = false; 
                }
                else
                {
                    MessageBox.Show("No members found matching the search criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMembers(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
