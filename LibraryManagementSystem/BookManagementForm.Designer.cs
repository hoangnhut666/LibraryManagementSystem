using System.Windows.Forms;

namespace GUI_UI
{
    partial class BookManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageBook = new TabPage();
            cboShelfLocation = new ComboBox();
            label1 = new Label();
            cboPublisherName = new ComboBox();
            cboCategory = new ComboBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnAiGenerate = new Button();
            btnUploadPicture = new Button();
            btnSearch = new Button();
            pictureBoxCoverImage = new PictureBox();
            label5 = new Label();
            label10 = new Label();
            label8 = new Label();
            label12 = new Label();
            label9 = new Label();
            label3 = new Label();
            label7 = new Label();
            label11 = new Label();
            label4 = new Label();
            label6 = new Label();
            label2 = new Label();
            txtDescription = new TextBox();
            txtNumberOfPages = new TextBox();
            txtPublicationYear = new TextBox();
            groupBox1 = new GroupBox();
            dgvBooks = new DataGridView();
            txtLanguage = new TextBox();
            txtTitle = new TextBox();
            txtISBN = new TextBox();
            txtAuthor = new TextBox();
            txtSearch = new TextBox();
            txtBookId = new TextBox();
            tabPageBookAuthor = new TabPage();
            txtBookAuthorID = new TextBox();
            btnRefreshBookAuthor = new Button();
            btnUpdateBookAuthor = new Button();
            btnDeleteBookAuthor = new Button();
            btnAddBookAuthor = new Button();
            cboAuthorNameBookAuthorTab = new ComboBox();
            cboTitleBookAuthor = new ComboBox();
            txtAuthorIdBookAuthorTab = new TextBox();
            txtBookIdBookAuthor = new TextBox();
            label16 = new Label();
            label15 = new Label();
            lblAuthorId = new Label();
            label14 = new Label();
            label13 = new Label();
            dgvBookAuthor = new DataGridView();
            tabControl1.SuspendLayout();
            tabPageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            tabPageBookAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookAuthor).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageBook);
            tabControl1.Controls.Add(tabPageBookAuthor);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2248, 1305);
            tabControl1.TabIndex = 0;
            // 
            // tabPageBook
            // 
            tabPageBook.BackColor = Color.FromArgb(237, 235, 248);
            tabPageBook.Controls.Add(cboShelfLocation);
            tabPageBook.Controls.Add(label1);
            tabPageBook.Controls.Add(cboPublisherName);
            tabPageBook.Controls.Add(cboCategory);
            tabPageBook.Controls.Add(btnRefresh);
            tabPageBook.Controls.Add(btnDelete);
            tabPageBook.Controls.Add(btnUpdate);
            tabPageBook.Controls.Add(btnAdd);
            tabPageBook.Controls.Add(btnAiGenerate);
            tabPageBook.Controls.Add(btnUploadPicture);
            tabPageBook.Controls.Add(btnSearch);
            tabPageBook.Controls.Add(pictureBoxCoverImage);
            tabPageBook.Controls.Add(label5);
            tabPageBook.Controls.Add(label10);
            tabPageBook.Controls.Add(label8);
            tabPageBook.Controls.Add(label12);
            tabPageBook.Controls.Add(label9);
            tabPageBook.Controls.Add(label3);
            tabPageBook.Controls.Add(label7);
            tabPageBook.Controls.Add(label11);
            tabPageBook.Controls.Add(label4);
            tabPageBook.Controls.Add(label6);
            tabPageBook.Controls.Add(label2);
            tabPageBook.Controls.Add(txtDescription);
            tabPageBook.Controls.Add(txtNumberOfPages);
            tabPageBook.Controls.Add(txtPublicationYear);
            tabPageBook.Controls.Add(groupBox1);
            tabPageBook.Controls.Add(txtLanguage);
            tabPageBook.Controls.Add(txtTitle);
            tabPageBook.Controls.Add(txtISBN);
            tabPageBook.Controls.Add(txtAuthor);
            tabPageBook.Controls.Add(txtSearch);
            tabPageBook.Controls.Add(txtBookId);
            tabPageBook.Location = new Point(10, 55);
            tabPageBook.Name = "tabPageBook";
            tabPageBook.Padding = new Padding(3);
            tabPageBook.Size = new Size(2228, 1240);
            tabPageBook.TabIndex = 0;
            tabPageBook.Text = "Quản lý sách  ";
            // 
            // cboShelfLocation
            // 
            cboShelfLocation.FormattingEnabled = true;
            cboShelfLocation.Location = new Point(1765, 713);
            cboShelfLocation.Name = "cboShelfLocation";
            cboShelfLocation.Size = new Size(436, 45);
            cboShelfLocation.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(852, 0);
            label1.Name = "label1";
            label1.Size = new Size(700, 96);
            label1.TabIndex = 18;
            label1.Text = "Quản lý ấn bản sách";
            // 
            // cboPublisherName
            // 
            cboPublisherName.FormattingEnabled = true;
            cboPublisherName.Location = new Point(1108, 808);
            cboPublisherName.Name = "cboPublisherName";
            cboPublisherName.Size = new Size(444, 45);
            cboPublisherName.TabIndex = 39;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(1765, 811);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(441, 45);
            cboCategory.TabIndex = 38;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(174, 160, 249);
            btnRefresh.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = SystemColors.Control;
            btnRefresh.Location = new Point(1922, 1154);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(201, 70);
            btnRefresh.TabIndex = 37;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(174, 160, 249);
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(1597, 1154);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(201, 70);
            btnDelete.TabIndex = 36;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(174, 160, 249);
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(1275, 1154);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(201, 70);
            btnUpdate.TabIndex = 35;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(174, 160, 249);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(969, 1154);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(201, 70);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAiGenerate
            // 
            btnAiGenerate.BackColor = Color.FromArgb(174, 160, 249);
            btnAiGenerate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAiGenerate.ForeColor = SystemColors.Control;
            btnAiGenerate.Location = new Point(852, 115);
            btnAiGenerate.Name = "btnAiGenerate";
            btnAiGenerate.Size = new Size(337, 60);
            btnAiGenerate.TabIndex = 33;
            btnAiGenerate.Text = "Tạo nội dung với AI";
            btnAiGenerate.UseVisualStyleBackColor = false;
            // 
            // btnUploadPicture
            // 
            btnUploadPicture.BackColor = Color.FromArgb(174, 160, 249);
            btnUploadPicture.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUploadPicture.ForeColor = SystemColors.Control;
            btnUploadPicture.Location = new Point(1801, 619);
            btnUploadPicture.Name = "btnUploadPicture";
            btnUploadPicture.Size = new Size(202, 60);
            btnUploadPicture.TabIndex = 32;
            btnUploadPicture.Text = "Chọn ảnh";
            btnUploadPicture.UseVisualStyleBackColor = false;
            btnUploadPicture.Click += btnUploadPicture_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(174, 160, 249);
            btnSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(2022, 115);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(172, 60);
            btnSearch.TabIndex = 31;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pictureBoxCoverImage
            // 
            pictureBoxCoverImage.Location = new Point(1653, 208);
            pictureBoxCoverImage.Name = "pictureBoxCoverImage";
            pictureBoxCoverImage.Size = new Size(497, 379);
            pictureBoxCoverImage.TabIndex = 30;
            pictureBoxCoverImage.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(852, 918);
            label5.Name = "label5";
            label5.Size = new Size(106, 45);
            label5.TabIndex = 28;
            label5.Text = "Mô tả";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(852, 805);
            label10.Name = "label10";
            label10.Size = new Size(216, 45);
            label10.TabIndex = 27;
            label10.Text = "Nhà xuất bản";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(852, 605);
            label8.Name = "label8";
            label8.Size = new Size(143, 45);
            label8.TabIndex = 26;
            label8.Text = "Số trang";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F);
            label12.Location = new Point(1606, 710);
            label12.Name = "label12";
            label12.Size = new Size(130, 45);
            label12.TabIndex = 25;
            label12.Text = "Kệ sách";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(852, 705);
            label9.Name = "label9";
            label9.Size = new Size(225, 45);
            label9.TabIndex = 25;
            label9.Text = "Năm xuất bản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(852, 305);
            label3.Name = "label3";
            label3.Size = new Size(91, 45);
            label3.TabIndex = 29;
            label3.Text = "ISBN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(852, 505);
            label7.Name = "label7";
            label7.Size = new Size(168, 45);
            label7.TabIndex = 24;
            label7.Text = "Ngôn ngữ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(852, 405);
            label11.Name = "label11";
            label11.Size = new Size(144, 45);
            label11.TabIndex = 23;
            label11.Text = "Tên sách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(1604, 918);
            label4.Name = "label4";
            label4.Size = new Size(118, 45);
            label4.TabIndex = 22;
            label4.Text = "Tác giả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(1604, 811);
            label6.Name = "label6";
            label6.Size = new Size(134, 45);
            label6.TabIndex = 21;
            label6.Text = "Thể loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(852, 205);
            label2.Name = "label2";
            label2.Size = new Size(141, 45);
            label2.TabIndex = 20;
            label2.Text = "Mã sách";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(852, 1023);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(1349, 108);
            txtDescription.TabIndex = 16;
            // 
            // txtNumberOfPages
            // 
            txtNumberOfPages.Location = new Point(1108, 608);
            txtNumberOfPages.Name = "txtNumberOfPages";
            txtNumberOfPages.Size = new Size(444, 43);
            txtNumberOfPages.TabIndex = 15;
            // 
            // txtPublicationYear
            // 
            txtPublicationYear.Location = new Point(1108, 708);
            txtPublicationYear.Name = "txtPublicationYear";
            txtPublicationYear.Size = new Size(444, 43);
            txtPublicationYear.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvBooks);
            groupBox1.Location = new Point(14, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(782, 1178);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh mục sách";
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(6, 42);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 92;
            dgvBooks.Size = new Size(758, 1118);
            dgvBooks.TabIndex = 0;
            dgvBooks.CellClick += dgvBooks_CellClick;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(1108, 508);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(444, 43);
            txtLanguage.TabIndex = 13;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(1108, 408);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(444, 43);
            txtTitle.TabIndex = 12;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(1108, 308);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(444, 43);
            txtISBN.TabIndex = 11;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(1770, 896);
            txtAuthor.Multiline = true;
            txtAuthor.Name = "txtAuthor";
            txtAuthor.ReadOnly = true;
            txtAuthor.Size = new Size(436, 100);
            txtAuthor.TabIndex = 10;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1653, 23);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(541, 57);
            txtSearch.TabIndex = 17;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(1108, 208);
            txtBookId.Name = "txtBookId";
            txtBookId.ReadOnly = true;
            txtBookId.Size = new Size(444, 43);
            txtBookId.TabIndex = 9;
            // 
            // tabPageBookAuthor
            // 
            tabPageBookAuthor.BackColor = Color.FromArgb(237, 235, 248);
            tabPageBookAuthor.Controls.Add(txtBookAuthorID);
            tabPageBookAuthor.Controls.Add(btnRefreshBookAuthor);
            tabPageBookAuthor.Controls.Add(btnUpdateBookAuthor);
            tabPageBookAuthor.Controls.Add(btnDeleteBookAuthor);
            tabPageBookAuthor.Controls.Add(btnAddBookAuthor);
            tabPageBookAuthor.Controls.Add(cboAuthorNameBookAuthorTab);
            tabPageBookAuthor.Controls.Add(cboTitleBookAuthor);
            tabPageBookAuthor.Controls.Add(txtAuthorIdBookAuthorTab);
            tabPageBookAuthor.Controls.Add(txtBookIdBookAuthor);
            tabPageBookAuthor.Controls.Add(label16);
            tabPageBookAuthor.Controls.Add(label15);
            tabPageBookAuthor.Controls.Add(lblAuthorId);
            tabPageBookAuthor.Controls.Add(label14);
            tabPageBookAuthor.Controls.Add(label13);
            tabPageBookAuthor.Controls.Add(dgvBookAuthor);
            tabPageBookAuthor.Location = new Point(10, 55);
            tabPageBookAuthor.Name = "tabPageBookAuthor";
            tabPageBookAuthor.Padding = new Padding(3);
            tabPageBookAuthor.Size = new Size(2228, 1240);
            tabPageBookAuthor.TabIndex = 1;
            tabPageBookAuthor.Text = "Quản lý tác giả và sách";
            // 
            // txtBookAuthorID
            // 
            txtBookAuthorID.Location = new Point(1528, 77);
            txtBookAuthorID.Name = "txtBookAuthorID";
            txtBookAuthorID.ReadOnly = true;
            txtBookAuthorID.Size = new Size(225, 43);
            txtBookAuthorID.TabIndex = 36;
            // 
            // btnRefreshBookAuthor
            // 
            btnRefreshBookAuthor.BackColor = Color.FromArgb(174, 160, 249);
            btnRefreshBookAuthor.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRefreshBookAuthor.ForeColor = SystemColors.Control;
            btnRefreshBookAuthor.Location = new Point(1565, 374);
            btnRefreshBookAuthor.Name = "btnRefreshBookAuthor";
            btnRefreshBookAuthor.Size = new Size(201, 70);
            btnRefreshBookAuthor.TabIndex = 35;
            btnRefreshBookAuthor.Text = "Làm mới";
            btnRefreshBookAuthor.UseVisualStyleBackColor = false;
            btnRefreshBookAuthor.Click += btnRefreshBookAuthor_Click;
            // 
            // btnUpdateBookAuthor
            // 
            btnUpdateBookAuthor.BackColor = Color.FromArgb(174, 160, 249);
            btnUpdateBookAuthor.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdateBookAuthor.ForeColor = SystemColors.Control;
            btnUpdateBookAuthor.Location = new Point(873, 374);
            btnUpdateBookAuthor.Name = "btnUpdateBookAuthor";
            btnUpdateBookAuthor.Size = new Size(201, 70);
            btnUpdateBookAuthor.TabIndex = 35;
            btnUpdateBookAuthor.Text = "Sửa";
            btnUpdateBookAuthor.UseVisualStyleBackColor = false;
            btnUpdateBookAuthor.Click += btnUpdateBookAuthor_Click;
            // 
            // btnDeleteBookAuthor
            // 
            btnDeleteBookAuthor.BackColor = Color.FromArgb(174, 160, 249);
            btnDeleteBookAuthor.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDeleteBookAuthor.ForeColor = SystemColors.Control;
            btnDeleteBookAuthor.Location = new Point(1218, 374);
            btnDeleteBookAuthor.Name = "btnDeleteBookAuthor";
            btnDeleteBookAuthor.Size = new Size(201, 70);
            btnDeleteBookAuthor.TabIndex = 35;
            btnDeleteBookAuthor.Text = "Xóa";
            btnDeleteBookAuthor.UseVisualStyleBackColor = false;
            btnDeleteBookAuthor.Click += btnDeleteBookAuthor_Click;
            // 
            // btnAddBookAuthor
            // 
            btnAddBookAuthor.BackColor = Color.FromArgb(174, 160, 249);
            btnAddBookAuthor.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAddBookAuthor.ForeColor = SystemColors.Control;
            btnAddBookAuthor.Location = new Point(526, 374);
            btnAddBookAuthor.Name = "btnAddBookAuthor";
            btnAddBookAuthor.Size = new Size(201, 70);
            btnAddBookAuthor.TabIndex = 35;
            btnAddBookAuthor.Text = "Thêm";
            btnAddBookAuthor.UseVisualStyleBackColor = false;
            btnAddBookAuthor.Click += btnAddBookAuthor_Click;
            // 
            // cboAuthorNameBookAuthorTab
            // 
            cboAuthorNameBookAuthorTab.FormattingEnabled = true;
            cboAuthorNameBookAuthorTab.Location = new Point(1400, 263);
            cboAuthorNameBookAuthorTab.Name = "cboAuthorNameBookAuthorTab";
            cboAuthorNameBookAuthorTab.Size = new Size(450, 45);
            cboAuthorNameBookAuthorTab.TabIndex = 5;
            cboAuthorNameBookAuthorTab.SelectedIndexChanged += cboAuthorNameBookAuthorTab_SelectedIndexChanged;
            // 
            // cboTitleBookAuthor
            // 
            cboTitleBookAuthor.FormattingEnabled = true;
            cboTitleBookAuthor.Location = new Point(622, 257);
            cboTitleBookAuthor.Name = "cboTitleBookAuthor";
            cboTitleBookAuthor.Size = new Size(450, 45);
            cboTitleBookAuthor.TabIndex = 5;
            cboTitleBookAuthor.SelectedIndexChanged += cboTitleBookAuthor_SelectedIndexChanged;
            // 
            // txtAuthorIdBookAuthorTab
            // 
            txtAuthorIdBookAuthorTab.Location = new Point(1400, 155);
            txtAuthorIdBookAuthorTab.Name = "txtAuthorIdBookAuthorTab";
            txtAuthorIdBookAuthorTab.ReadOnly = true;
            txtAuthorIdBookAuthorTab.Size = new Size(450, 43);
            txtAuthorIdBookAuthorTab.TabIndex = 4;
            // 
            // txtBookIdBookAuthor
            // 
            txtBookIdBookAuthor.Location = new Point(622, 152);
            txtBookIdBookAuthor.Name = "txtBookIdBookAuthor";
            txtBookIdBookAuthor.ReadOnly = true;
            txtBookIdBookAuthor.Size = new Size(450, 43);
            txtBookIdBookAuthor.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F);
            label16.Location = new Point(1198, 260);
            label16.Name = "label16";
            label16.Size = new Size(118, 45);
            label16.TabIndex = 3;
            label16.Text = "Tác giả";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F);
            label15.Location = new Point(424, 254);
            label15.Name = "label15";
            label15.Size = new Size(144, 45);
            label15.TabIndex = 3;
            label15.Text = "Tên sách";
            // 
            // lblAuthorId
            // 
            lblAuthorId.AutoSize = true;
            lblAuthorId.Font = new Font("Segoe UI", 11F);
            lblAuthorId.Location = new Point(1198, 152);
            lblAuthorId.Name = "lblAuthorId";
            lblAuthorId.Size = new Size(181, 45);
            lblAuthorId.TabIndex = 3;
            lblAuthorId.Text = "Mã tác giả ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F);
            label14.Location = new Point(424, 152);
            label14.Name = "label14";
            label14.Size = new Size(141, 45);
            label14.TabIndex = 3;
            label14.Text = "Mã sách";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.MediumSlateBlue;
            label13.Location = new Point(835, 30);
            label13.Name = "label13";
            label13.Size = new Size(567, 72);
            label13.TabIndex = 1;
            label13.Text = "Quản lý Sách - Tác giả";
            // 
            // dgvBookAuthor
            // 
            dgvBookAuthor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookAuthor.Location = new Point(17, 503);
            dgvBookAuthor.Name = "dgvBookAuthor";
            dgvBookAuthor.RowHeadersWidth = 92;
            dgvBookAuthor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookAuthor.Size = new Size(2205, 731);
            dgvBookAuthor.TabIndex = 0;
            dgvBookAuthor.CellClick += dgvBookAuthor_CellClick;
            // 
            // BookManagementForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 235, 248);
            ClientSize = new Size(2272, 1321);
            Controls.Add(tabControl1);
            Name = "BookManagementForm";
            Text = "BookManagementForm";
            tabControl1.ResumeLayout(false);
            tabPageBook.ResumeLayout(false);
            tabPageBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            tabPageBookAuthor.ResumeLayout(false);
            tabPageBookAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookAuthor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageBook;
        private TabPage tabPageBookAuthor;
        private Label label1;
        private ComboBox cboPublisherName;
        private ComboBox cboCategory;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnAiGenerate;
        private Button btnUploadPicture;
        private Button btnSearch;
        private PictureBox pictureBoxCoverImage;
        private Label label5;
        private Label label10;
        private Label label8;
        private Label label9;
        private Label label3;
        private Label label7;
        private Label label11;
        private Label label4;
        private Label label6;
        private Label label2;
        private TextBox txtDescription;
        private TextBox txtNumberOfPages;
        private TextBox txtPublicationYear;
        private GroupBox groupBox1;
        private DataGridView dgvBooks;
        private TextBox txtLanguage;
        private TextBox txtTitle;
        private TextBox txtISBN;
        private TextBox txtAuthor;
        private TextBox txtSearch;
        private TextBox txtBookId;
        private Label label12;
        private Label label13;
        private DataGridView dgvBookAuthor;
        private ComboBox cboTitleBookAuthor;
        private TextBox txtBookIdBookAuthor;
        private Label label14;
        private ComboBox cboAuthorNameBookAuthorTab;
        private Label label16;
        private Label label15;
        private Button btnRefreshBookAuthor;
        private Button btnUpdateBookAuthor;
        private Button btnDeleteBookAuthor;
        private Button btnAddBookAuthor;
        private TextBox txtAuthorIdBookAuthorTab;
        private Label lblAuthorId;
        private ComboBox cboShelfLocation;
        private TextBox txtBookAuthorID;
    }
}