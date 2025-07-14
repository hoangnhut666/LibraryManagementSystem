using BLL_Services;
using BLL_Services.Services;
using DTO_Models;
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
        public BookManagementForm()
        {
            BookService = new BookService();
            PublisherService = new PublisherService();
            CategoryService = new CategoryService();
            AuthorService = new AuthorService();

            InitializeComponent();
            SetupComponent(dgvBooks);
            LoadBooks();
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
            cboCategory.SelectedIndex = -1;
            cboCategory.DataSource = CategoryService.GetCategories();

            cboPublisherName.DisplayMember = "Name";
            cboPublisherName.ValueMember = "PublisherID";
            cboPublisherName.SelectedIndex = -1;
            cboPublisherName.DataSource = PublisherService.GetPublishers();

            // Set the TextBox properties
            txtDescription.Multiline = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtSearch.PlaceholderText = "Tìm sách theo id, tên sách, tác giả, thể loại";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ShelfLocation = txtShelfLocation.Text,
                NumberOfPages = int.TryParse(txtNumberOfPages.Text, out numberOfPages) ? numberOfPages : (int?)null,
                Language = txtLanguage.Text,
                Description = txtDescription.Text,
                CoverImage = pictureBoxCoverImage.Image != null ? ImageToByteArray(pictureBoxCoverImage.Image) : null
            };

            //Add the book to the database
            try
            {
                if (BookService.AddBook(newBook) > 0)
                {
                    MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to add book. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ShelfLocation = txtShelfLocation.Text,
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
                    MessageBox.Show("Book updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to update book. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Please select a book to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Delete the book from the database
                    if (BookService.DeleteBook(bookId) > 0)
                    {
                        MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBooks();
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete book. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadBooks();
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
                var searchResults = BookService.SearchBooks(searchTerm);
                if (searchResults != null && searchResults.Count > 0)
                {
                    dgvBooks.DataSource = searchResults;
                }
                else
                {
                    MessageBox.Show("No books found matching the search term.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtShelfLocation.Text = selectedBook.ShelfLocation;
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


        private void ClearInputFields()
        {   
            txtBookId.Clear();
            txtTitle.Clear();
            txtISBN.Clear();
            txtTitle.Clear();
            cboPublisherName.SelectedIndex = -1;
            txtPublicationYear.Clear();
            cboCategory.SelectedIndex = -1;
            txtShelfLocation.Clear();
            txtNumberOfPages.Clear();
            txtLanguage.Clear();
            txtDescription.Clear();
            pictureBoxCoverImage.Image = null;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}


