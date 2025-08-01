using BLL_Services;
using BLL_Services.Services;
using DAL_Data;
using DTO_Models;
using DTO_Models.ViewModel;
using Microsoft.VisualBasic.Devices;
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
    public partial class BookManagementForm : Form
    {
        private BookService BookService { get; set; }
        private PublisherService PublisherService { get; set; }
        private CategoryService CategoryService { get; set; }
        private AuthorService AuthorService { get; set; }
        private BookAuthorsService BookAuthorsService { get; set; }
        public BookManagementForm()
        {
            BookService = new BookService();
            PublisherService = new PublisherService();
            CategoryService = new CategoryService();
            AuthorService = new AuthorService();
            BookAuthorsService = new BookAuthorsService();

            InitializeComponent();
            SetupComponent(dgvBooks);
            LoadBooks();
            LoadBookAuthors();
        }


        private void SetupComponent(DataGridView dataGridView)
        {
            // Set the DataGridView properties
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;

            //Set up PictureBox
            pictureBoxCoverImage.SizeMode = PictureBoxSizeMode.Zoom;

            //Set up Combobox
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "CategoryID";
            cboCategory.DataSource = CategoryService.GetCategories();
            cboCategory.SelectedIndex = -1;

            cboPublisherName.DisplayMember = "Name";
            cboPublisherName.ValueMember = "PublisherID";
            cboPublisherName.DataSource = PublisherService.GetPublishers();
            cboPublisherName.SelectedIndex = -1;


            cboAuthorNameBookAuthorTab.DisplayMember = "FullName";
            cboAuthorNameBookAuthorTab.ValueMember = "AuthorID";
            cboAuthorNameBookAuthorTab.DataSource = AuthorService.GetAuthors();
            cboAuthorNameBookAuthorTab.SelectedIndex = -1;

            cboTitleBookAuthor.DisplayMember = "Title";
            cboTitleBookAuthor.ValueMember = "BookID";
            cboTitleBookAuthor.DataSource = BookService.GetBooks();
            cboTitleBookAuthor.SelectedIndex = -1;

            cboShelfLocation.DataSource = new List<string>
            {
                "A1", "A2", "A3", "A4", "A5",
                "B1", "B2", "B3", "B4", "B5",
                "C1", "C2", "C3", "C4", "C5",
                "D1", "D2", "D3", "D4", "D5",
                "E1", "E2", "E3", "E4", "E5"
            };
            cboShelfLocation.SelectedIndex = -1;


            // Set the TextBox properties
            txtDescription.Multiline = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtSearch.PlaceholderText = "Tìm sách theo id, tên sách, tác giả, thể loại";

            txtDescription.MaxLength = 255; 
        }

        //Load all books from the database
        private void LoadBooks()
        {
            try
            {
                var books = BookService.GetBooks();
                dgvBooks.DataSource = books;
                dgvBooks.Columns["ISBN"].Visible = false;
                dgvBooks.Columns["PublicationYear"].Visible = false;
                dgvBooks.Columns["PublisherID"].Visible = false;
                dgvBooks.Columns["CategoryID"].Visible = false;
                dgvBooks.Columns["ShelfLocation"].Visible = false;
                dgvBooks.Columns["NumberOfPages"].Visible = false;
                dgvBooks.Columns["Language"].Visible = false;
                dgvBooks.Columns["Description"].Visible = false;
                dgvBooks.Columns["CoverImage"].Visible = false;
                dgvBooks.Columns["BookID"].HeaderText = "MaAnBan";
                dgvBooks.Columns["Title"].HeaderText = "TieuDe";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi đã xảy ra trong quá trình tải sách: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Load all book authors from the database
        private void LoadBookAuthors()
        {
            try
            {
                var bookAuthors = BookAuthorsService.GetBookAuthorViewModels();
                dgvBookAuthor.DataSource = bookAuthors;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi đã xảy ra trong quá trình tải tác giả sách: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int publicationYear;
            int numberOfPages;

            Book newBook = new Book
            {
                BookID = BookService.GenerateBookID(),
                ISBN = txtISBN.Text,
                Title = txtTitle.Text,
                PublisherID = cboPublisherName.SelectedValue != null ? cboPublisherName.SelectedValue.ToString() : null,
                PublicationYear = int.TryParse(txtPublicationYear.Text, out publicationYear) ? publicationYear : (int?)null,
                CategoryID = cboCategory.SelectedValue != null ? cboCategory.SelectedValue.ToString() : null,
                ShelfLocation = cboShelfLocation.SelectedItem != null ? cboShelfLocation.SelectedItem.ToString() : null,
                NumberOfPages = int.TryParse(txtNumberOfPages.Text, out numberOfPages) ? numberOfPages : (int?)null,
                Language = txtLanguage.Text,
                Description = txtDescription.Text,
                CoverImage = pictureBoxCoverImage.Image != null ? ImageToByteArray(pictureBoxCoverImage.Image) : null
            };

            var existingBook = BookService.GetBooksByCriteria("ISBN", newBook.ISBN);
            if (existingBook.Count > 0)
            {
                MessageBox.Show("Ấn bản với mã ISBN này đã tồn tại. Vui lòng nhập mã ISBN khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            try
            {
                if (BookService.AddBook(newBook) > 0)
                {
                    MessageBox.Show("Thêm sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks();
                    ClearBookInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm sách thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi đã xảy ra trong quá trình thêm sách: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int publicationYear;
            int numberOfPages;

            Book newBook = new Book
            {
                BookID = txtBookId.Text.Trim(),
                ISBN = txtISBN.Text,
                Title = txtTitle.Text,
                PublisherID = cboPublisherName.SelectedValue != null ? cboPublisherName.SelectedValue.ToString() : null,
                PublicationYear = int.TryParse(txtPublicationYear.Text, out publicationYear) ? publicationYear : (int?)null,
                CategoryID = cboCategory.SelectedValue != null ? cboCategory.SelectedValue.ToString() : null,
                ShelfLocation = cboShelfLocation.SelectedItem != null ? cboShelfLocation.SelectedItem.ToString() : null,
                NumberOfPages = int.TryParse(txtNumberOfPages.Text, out numberOfPages) ? numberOfPages : (int?)null,
                Language = txtLanguage.Text,
                Description = txtDescription.Text,
                CoverImage = pictureBoxCoverImage.Image != null ? ImageToByteArray(pictureBoxCoverImage.Image) : null
            };

            //Update the book in the database
            try
            {
                if (BookService.UpdateBook(newBook) > 0)
                {
                    MessageBox.Show("Cập nhật sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks();
                    ClearBookInputFields();
                }
                else
                {
                    MessageBox.Show("Cập nhật sách thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi đã xảy ra trong quá trình cập nhật sách: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Using try catch to handle any exceptions that may occur during deletion
            try
            {
                string bookId = txtBookId.Text.Trim();
                if (string.IsNullOrEmpty(bookId))
                {
                    MessageBox.Show("Vui lòng chọn một cuốn sách để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa cuốn sách này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Delete the book from the database
                    if (BookService.DeleteBook(bookId) > 0)
                    {
                        MessageBox.Show("Xóa sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBooks();
                        ClearBookInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Xóa sách thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi đã xảy ra trong quá trình xóa sách: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearBookInputFields();
            LoadBooks();
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
                var searchResults = BookService.SearchBooks(searchTerm);
                if (searchResults != null && searchResults.Count > 0)
                {
                    dgvBooks.DataSource = searchResults;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sách nào phù hợp với từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi đã xảy ra trong quá trình tìm kiếm sách: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if a row is selected
            if (e.RowIndex >= 0 && e.RowIndex < dgvBooks.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvBooks.Rows[e.RowIndex];
                Book selectedBook = (Book)selectedRow.DataBoundItem;

                txtBookId.Text = selectedBook.BookID;
                txtISBN.Text = selectedBook.ISBN;
                txtTitle.Text = selectedBook.Title;
                cboPublisherName.SelectedValue = selectedBook.PublisherID;
                txtPublicationYear.Text = selectedBook.PublicationYear.HasValue ? selectedBook.PublicationYear.Value.ToString() : string.Empty;
                cboCategory.SelectedValue = selectedBook.CategoryID;
                cboShelfLocation.Text = selectedBook.ShelfLocation;
                txtNumberOfPages.Text = selectedBook.NumberOfPages.HasValue ? selectedBook.NumberOfPages.Value.ToString() : string.Empty;
                txtLanguage.Text = selectedBook.Language;
                txtDescription.Text = selectedBook.Description;
                pictureBoxCoverImage.Image = selectedBook.CoverImage != null ? Image.FromStream(new System.IO.MemoryStream(selectedBook.CoverImage)) : null;
                txtAuthor.Text = selectedBook.BookID != null ? string.Join(", ", AuthorService.GetAuthorsByBookId(selectedBook.BookID).Select(a => a.FullName)) : string.Empty;
            }
        }


        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the image in the PictureBox
                    pictureBoxCoverImage.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBoxCoverImage.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }


        private void ClearBookInputFields()
        {
            txtBookId.Clear();
            txtTitle.Clear();
            txtISBN.Clear();
            txtTitle.Clear();
            cboPublisherName.SelectedIndex = -1;
            txtPublicationYear.Clear();
            cboCategory.SelectedIndex = -1;
            cboShelfLocation.SelectedIndex = -1;
            txtNumberOfPages.Clear();
            txtLanguage.Clear();
            txtDescription.Clear();
            pictureBoxCoverImage.Image = null;
        }

        private void btnAddBookAuthor_Click(object sender, EventArgs e)
        {
            BookAuthor newBookAuthor = new BookAuthor
            {
                BookID = txtBookIdBookAuthor.Text.Trim(),
                AuthorID = txtAuthorIdBookAuthorTab.Text.Trim(),
            };

            //Insert the book author relationship into the database
            try
            {
                if (BookAuthorsService.InsertBookAuthor(newBookAuthor) > 0)
            {
                MessageBox.Show("Thêm mối quan hệ sách - tác giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBookAuthors();
                ClearBookAuthorInputFields();
            }
            else
            {
                MessageBox.Show("Thêm mối quan hệ sách - tác giả thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi đã xảy ra trong quá trình thêm mối quan hệ sách - tác giả: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdateBookAuthor_Click(object sender, EventArgs e)
        {
            BookAuthor newBookAuthor = new BookAuthor
            {
                BookAuthorID = int.Parse(txtBookAuthorID.Text),
                BookID = txtBookIdBookAuthor.Text.Trim(),
                AuthorID = txtAuthorIdBookAuthorTab.Text.Trim()
            };

            try
            {
                if (BookAuthorsService.UpdateBookAuthor(newBookAuthor) > 0)
                {
                    MessageBox.Show("Cập nhật mối quan hệ sách - tác giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookAuthors();
                    ClearBookAuthorInputFields();
                }
                else
                {
                    MessageBox.Show("Cập nhật mối quan hệ sách - tác giả thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi đã xảy ra trong quá trình cập nhật mối quan hệ sách - tác giả: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteBookAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                string bookAuthorId = txtBookAuthorID.Text.Trim();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mối quan hệ sách - tác giả này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (BookAuthorsService.DeleteBookAuthor(bookAuthorId) > 0)
                    {
                        MessageBox.Show("Xóa mối quan hệ sách - tác giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookAuthors();
                        ClearBookAuthorInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Xóa mối quan hệ sách - tác giả thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Một lỗi đã xảy ra trong quá trình xóa mối quan hệ sách - tác giả: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshBookAuthor_Click(object sender, EventArgs e)
        {
            ClearBookAuthorInputFields();
            LoadBookAuthors();
        }

        private void dgvBookAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgvBookAuthor.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                var selectedBookAuthor = (BookAuthorViewModel)selectedRow.DataBoundItem;
                txtBookAuthorID.Text = selectedRow.Cells[0].Value.ToString();
                cboTitleBookAuthor.SelectedValue = selectedBookAuthor.MaSach;
                cboAuthorNameBookAuthorTab.SelectedValue = selectedBookAuthor.MaTacGia;
                txtBookIdBookAuthor.Text = selectedBookAuthor.MaSach;
                txtAuthorIdBookAuthorTab.Text = selectedBookAuthor.MaTacGia;
            }
            else
            {
                ClearBookAuthorInputFields();
            }
        }

        private void ClearBookAuthorInputFields()
        {
            cboTitleBookAuthor.SelectedIndex = -1;
            cboAuthorNameBookAuthorTab.SelectedIndex = -1;
            txtBookIdBookAuthor.Clear();
            txtAuthorIdBookAuthorTab.Clear();
            txtBookAuthorID.Clear();
        }

        private void cboTitleBookAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBookIdBookAuthor.Text = cboTitleBookAuthor.SelectedValue != null ? cboTitleBookAuthor.SelectedValue.ToString() : string.Empty;
        }

        private void cboAuthorNameBookAuthorTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAuthorIdBookAuthorTab.Text = cboAuthorNameBookAuthorTab.SelectedValue != null ? cboAuthorNameBookAuthorTab.SelectedValue.ToString() : string.Empty;
        }

        private void tabPageBook_Click(object sender, EventArgs e)
        {

        }
    }
}


