using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Data;
using DTO_Models;

namespace GUI_UI
{
    public partial class FineForm : Form
    {
        public FineForm()
        {
            InitializeComponent();
        }

        FineRepository finerepository = new FineRepository();

        private void LoadFines()
        {
            dgvFines.DataSource = finerepository.GetAllFines();
        }

        private void FineForm_Load(object sender, EventArgs e)
        {
            LoadFines();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                FineDTO fine = new FineDTO
                {
                    FineID = txtFineid.Text,
                    LoanID = txtLoadid.Text,
                    Amount = decimal.Parse(txtamount.Text),

                    IssueDate = DateTime.Parse(cboissuedate.Text),

                    Paid = chkPenaltyPaid.Checked,
                    Reason = txtreason.Text
                };

                if (finerepository.InsertFine(fine))
                {
                    MessageBox.Show("Added successfully");
                    LoadFines();
                }
                else
                {
                    MessageBox.Show("Add failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dgvFines.CurrentRow != null)
            {
                txtFineid.Text = dgvFines.CurrentRow.Cells["FineID"].Value.ToString();
                txtLoadid.Text = dgvFines.CurrentRow.Cells["LoanID"].Value.ToString();
                txtamount.Text = dgvFines.CurrentRow.Cells["Amount"].Value.ToString();
                cboissuedate.Text = dgvFines.CurrentRow.Cells["IssueDate"].Value.ToString();
                txtreason.Text = dgvFines.CurrentRow.Cells["Reason"].Value.ToString();

                bool paid = Convert.ToBoolean(dgvFines.CurrentRow.Cells["Paid"].Value);
                chkPenaltyPaid.Checked = paid;
                chkPenaltyNotPaid.Checked = !paid;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                FineDTO fine = new FineDTO
                {
                    FineID = txtFineid.Text,
                    LoanID = txtLoadid.Text,
                    Amount = decimal.Parse(txtamount.Text),
                    IssueDate = DateTime.Parse(cboissuedate.Text),
                    Paid = chkPenaltyPaid.Checked,
                    Reason = txtreason.Text
                };

                if (finerepository.UpdateFine(fine))
                {
                    MessageBox.Show("Updated successfully");
                    LoadFines();
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvFines.CurrentRow != null)
            {
                string fineID = dgvFines.CurrentRow.Cells["FineID"].Value.ToString();
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (!finerepository.DeleteFine(fineID))
                    {
                        MessageBox.Show("Delete failed");
                    }
                    else
                    {
                        MessageBox.Show("Deleted successfully");
                        LoadFines();
                    }
                }
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            LoadFines();
        }

        private void dgvFines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFines.Rows[e.RowIndex];

                txtFineid.Text = row.Cells["FineID"].Value.ToString();
                txtLoadid.Text = row.Cells["LoanID"].Value.ToString();
                txtamount.Text = row.Cells["Amount"].Value.ToString();

                cboissuedate.Text = Convert.ToDateTime(row.Cells["IssueDate"].Value).ToString("yyyy-MM-dd");

                bool isPaid = Convert.ToBoolean(row.Cells["Paid"].Value);
                chkPenaltyPaid.Checked = isPaid;
                chkPenaltyNotPaid.Checked = !isPaid;

                txtreason.Text = row.Cells["Reason"].Value.ToString();
            }
        }

        private void chkPenaltyPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPenaltyPaid.Checked)
                chkPenaltyNotPaid.Checked = false;
        }

        private void chkPenaltyNotPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPenaltyNotPaid.Checked)
                chkPenaltyPaid.Checked = false;
        }
    }
}
