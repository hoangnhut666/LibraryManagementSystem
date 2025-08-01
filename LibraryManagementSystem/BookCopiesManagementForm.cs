using BLL_Services.Services;
using DTO_Models;
using DTO_Models.ViewModel;
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
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Không tìm thấy bản sao sách nào khớp với từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookCopies();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi tìm kiếm bản sao sách: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrWhiteSpace(bookCopy.CopyID) || string.IsNullOrWhiteSpace(bookCopy.Barcode) || string.IsNullOrEmpty(bookCopy.Status))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin bản sao sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int result = BookCopyService.AddBookCopy(bookCopy);
                if (result > 0)
                {
                    MessageBox.Show("Thêm bản sao sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookCopies();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm bản sao sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi thêm bản sao sách: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrWhiteSpace(newBookCopy.CopyID) || string.IsNullOrWhiteSpace(newBookCopy.Barcode) || string.IsNullOrEmpty(newBookCopy.Status))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin bản sao sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (BookCopyService.UpdateBookCopy(newBookCopy) > 0)
                {
                    MessageBox.Show("Cập nhật bản sao sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookCopies();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Cập nhật bản sao sách thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi cập nhật bản sao sách: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Vui lòng chọn một bản sao sách để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bản sao sách này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Delete the book copy from the database
                    if (BookCopyService.DeleteBookCopy(copyId) > 0)
                    {
                        MessageBox.Show("Xóa bản sao sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookCopies();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Xóa bản sao sách thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi xảy ra khi xóa bản sao sách: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    txtPurchasePrice.Text = (selectedBookCopy.PurchasePrice ?? 0).ToString("N0");
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

