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
using DTO_Models.ViewModel;

namespace GUI_UI
{
    public partial class BookCopiesManagementForm : Form
    {
        private BookCopyService BookCopyService { get; set; }
        private BookService BookService { get; set; }

        public BookCopiesManagementForm()
        {
            BookCopyService = new BookCopyService();
            BookService = new BookService();
            InitializeComponent();
            SetupComponent(dgvBookCopies);
            LoadBookCopies();
        }


        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set up PictureBox
            pictureBoxCoverImage.SizeMode = PictureBoxSizeMode.Zoom;

            //Set up the form properties
            StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(2300, 1400);

            //Set up comboBox for book status
            cboStatus.DataSource = new List<string> { "Có sẵn", "Đang cho mượn", "Thất lạc", "Hư hỏng", "Đang sửa chữa" };
            cboStatus.SelectedIndex = -1;

            //Set up comboBox for bookId

            //Get a list that contain bookId of all books
            cboBookId.DataSource = BookService.GetBooks();
            cboBookId.DisplayMember = "BookID";
            cboBookId.ValueMember = "BookID";
            cboBookId.SelectedIndex = -1;


            dtpPurchaseDate.Format = DateTimePickerFormat.Custom;
            dtpPurchaseDate.CustomFormat = " ";

            txtSearch.PlaceholderText = "Tìm sách theo id, tên sách, tác giả, thể loại";
        }



        private void LoadBookCopies()
        {
            List<BookCopyViewModel>? bookCopyViewModels = BookCopyService.GetBookCopiesViewModels();
            dgvBookCopies.DataSource = bookCopyViewModels;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var searchResults = BookCopyService.SearchBookCopies(searchTerm);
                if (searchResults != null && searchResults.Count > 0)
                {
                    dgvBookCopies.DataSource = searchResults;
                }
                else
                {
                    MessageBox.Show("No book copies found matching the search term.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookCopies();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for book copies: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookCopy bookCopy = new BookCopy()
            {
                CopyID = BookCopyService.GenerateCopyID(),
                BookID = cboBookId.SelectedValue?.ToString(),
                Barcode = txtBarcode.Text.Trim(),
                Status = cboStatus.SelectedItem?.ToString() ?? string.Empty,
                ConditionNotes = txtConditionNotes.Text.Trim(),
                PurchaseDate = dtpPurchaseDate.Value,
                PurchasePrice = decimal.TryParse(txtPurchasePrice.Text.Trim(), out decimal price) ? price : (decimal?)null
            };

            try
            {
                int result = BookCopyService.AddBookCopy(bookCopy);
                if (result > 0)
                {
                    MessageBox.Show("Book copy added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookCopies();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to add book copy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the book copy: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BookCopy newBookCopy = new BookCopy()
            {
                CopyID = txtCopyID.Text.Trim(),
                BookID = cboBookId.SelectedValue?.ToString(),
                Barcode = txtBarcode.Text.Trim(),
                Status = cboStatus.SelectedItem?.ToString() ?? string.Empty,
                ConditionNotes = txtConditionNotes.Text.Trim(),
                PurchaseDate = dtpPurchaseDate.Value,
                PurchasePrice = decimal.TryParse(txtPurchasePrice.Text.Trim(), out decimal price) ? price : (decimal?)null
            };

            //Update bookcopy to database
            try
            {
                if (BookCopyService.UpdateBookCopy(newBookCopy) > 0)
                {
                    MessageBox.Show("Book copy updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookCopies();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to update book copy. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Using try catch to handle any exceptions that may occur during deletion
            try
            {
                string copyId = txtCopyID.Text.Trim();
                if (string.IsNullOrEmpty(copyId))
                {
                    MessageBox.Show("Please select a book copy to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure you want to delete this book copy?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Delete the book copy from the database
                    if (BookCopyService.DeleteBookCopy(copyId) > 0)
                    {
                        MessageBox.Show("Book copy deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookCopies();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete book copy. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the book copy: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void dgvBookCopies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedBookCopyId = dgvBookCopies.Rows[e.RowIndex].Cells[0].Value.ToString();
                var selectedBookCopy = BookCopyService.GetAllBookCopies().FirstOrDefault(bc => bc.CopyID == selectedBookCopyId);
                Book? selectedBook = BookService.GetBooks().FirstOrDefault(b => b.BookID == selectedBookCopy?.BookID);
                if (selectedBookCopy != null)
                {
                    txtCopyID.Text = selectedBookCopy.CopyID;
                    txtTitle.Text = dgvBookCopies.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cboBookId.SelectedValue = selectedBookCopy.BookID;
                    txtBarcode.Text = selectedBookCopy.Barcode;
                    cboStatus.SelectedItem = selectedBookCopy.Status;
                    txtConditionNotes.Text = selectedBookCopy.ConditionNotes;
                    dtpPurchaseDate.Value = selectedBookCopy.PurchaseDate ?? DateTime.Now;
                    txtPurchasePrice.Text = (selectedBookCopy.PurchasePrice ?? 0).ToString();
                    pictureBoxCoverImage.Image = selectedBook.CoverImage != null ? Image.FromStream(new System.IO.MemoryStream(selectedBook.CoverImage)) : null;
                }
            }
        }


        private void ClearInputFields()
        {
            txtCopyID.Clear();
            txtTitle.Clear();
            cboBookId.SelectedIndex = -1;
            txtBarcode.Clear();
            cboStatus.SelectedIndex = -1;
            txtConditionNotes.Clear();
            dtpPurchaseDate.Value = DateTime.Now;
            txtPurchasePrice.Clear();
            dtpPurchaseDate.CustomFormat = " ";
            pictureBoxCoverImage.Image = null;
            txtSearch.Clear();
        }

        private void dtpPurchaseDate_ValueChanged(object sender, EventArgs e)
        {
            dtpPurchaseDate.CustomFormat = "dd/MM/yyyy";
        }

        private void cboBookId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBookId = cboBookId.SelectedValue?.ToString();
            Book? selectedBook = BookService.GetBooks().FirstOrDefault(b => b.BookID == selectedBookId);
            pictureBoxCoverImage.Image = selectedBook?.CoverImage == null ? null : Image.FromStream(new System.IO.MemoryStream(selectedBook.CoverImage));
            txtTitle.Text = selectedBook?.Title ?? string.Empty;
        }

    }
}

