using BLL_Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Models;
using BLL_Services;

namespace GUI_UI
{
    public partial class BookManagementForm : Form
    {
        private BookService BookService { get; set; }
        private PublisherService PublisherService { get; set; }
        private CategoryService CategoryService { get; set; }
        public BookManagementForm()
        {
            BookService = new BookService();
            PublisherService = new PublisherService();
            CategoryService = new CategoryService();

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
            txtSearch.PlaceholderText = "Nhập id hoặc tên sách cần tìm";
        }

        //Load all books from the database
        private void LoadBooks()
        {
            try
            {
                var books = BookService.GetBooks();
                dgvBooks.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
