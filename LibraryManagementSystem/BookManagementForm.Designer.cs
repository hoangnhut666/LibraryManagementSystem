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
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
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
            label9 = new Label();
            label3 = new Label();
            label7 = new Label();
            label11 = new Label();
            label4 = new Label();
            label6 = new Label();
            label2 = new Label();
            txtDescription = new TextBox();
            txtNumberOfPages = new TextBox();
            txtPulisherYear = new TextBox();
            groupBox1 = new GroupBox();
            dgvBooks = new DataGridView();
            txtLanguage = new TextBox();
            textBox1 = new TextBox();
            txtISBN = new TextBox();
            txtAuthors = new TextBox();
            label1 = new Label();
            txtSearch = new TextBox();
            txtBookId = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2248, 1305);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(237, 235, 248);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cboPublisherName);
            tabPage1.Controls.Add(cboCategory);
            tabPage1.Controls.Add(btnRefresh);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(btnAiGenerate);
            tabPage1.Controls.Add(btnUploadPicture);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(pictureBoxCoverImage);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtDescription);
            tabPage1.Controls.Add(txtNumberOfPages);
            tabPage1.Controls.Add(txtPulisherYear);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(txtLanguage);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(txtISBN);
            tabPage1.Controls.Add(txtAuthors);
            tabPage1.Controls.Add(txtSearch);
            tabPage1.Controls.Add(txtBookId);
            tabPage1.Location = new Point(10, 55);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(2228, 1240);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(10, 55);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(430, 160);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboPublisherName
            // 
            cboPublisherName.FormattingEnabled = true;
            cboPublisherName.Location = new Point(1112, 715);
            cboPublisherName.Name = "cboPublisherName";
            cboPublisherName.Size = new Size(437, 45);
            cboPublisherName.TabIndex = 39;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(1112, 512);
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
            // 
            // btnAiGenerate
            // 
            btnAiGenerate.BackColor = Color.FromArgb(174, 160, 249);
            btnAiGenerate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAiGenerate.ForeColor = SystemColors.Control;
            btnAiGenerate.Location = new Point(865, 115);
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
            btnUploadPicture.Location = new Point(1806, 699);
            btnUploadPicture.Name = "btnUploadPicture";
            btnUploadPicture.Size = new Size(202, 60);
            btnUploadPicture.TabIndex = 32;
            btnUploadPicture.Text = "Chọn ảnh";
            btnUploadPicture.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(174, 160, 249);
            btnSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(2004, 115);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(202, 60);
            btnSearch.TabIndex = 31;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // pictureBoxCoverImage
            // 
            pictureBoxCoverImage.Location = new Point(1604, 208);
            pictureBoxCoverImage.Name = "pictureBoxCoverImage";
            pictureBoxCoverImage.Size = new Size(610, 467);
            pictureBoxCoverImage.TabIndex = 30;
            pictureBoxCoverImage.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(866, 918);
            label5.Name = "label5";
            label5.Size = new Size(106, 45);
            label5.TabIndex = 28;
            label5.Text = "Mô tả";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(868, 712);
            label10.Name = "label10";
            label10.Size = new Size(216, 45);
            label10.TabIndex = 27;
            label10.Text = "Nhà xuất bản";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(869, 607);
            label8.Name = "label8";
            label8.Size = new Size(143, 45);
            label8.TabIndex = 26;
            label8.Text = "Số trang";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(867, 805);
            label9.Name = "label9";
            label9.Size = new Size(225, 45);
            label9.TabIndex = 25;
            label9.Text = "Năm xuất bản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(868, 302);
            label3.Name = "label3";
            label3.Size = new Size(91, 45);
            label3.TabIndex = 29;
            label3.Text = "ISBN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(1597, 804);
            label7.Name = "label7";
            label7.Size = new Size(168, 45);
            label7.TabIndex = 24;
            label7.Text = "Ngôn ngữ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(866, 405);
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
            label6.Location = new Point(869, 510);
            label6.Name = "label6";
            label6.Size = new Size(134, 45);
            label6.TabIndex = 21;
            label6.Text = "Thể loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(868, 205);
            label2.Name = "label2";
            label2.Size = new Size(141, 45);
            label2.TabIndex = 20;
            label2.Text = "Mã sách";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(865, 1023);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(1349, 108);
            txtDescription.TabIndex = 16;
            // 
            // txtNumberOfPages
            // 
            txtNumberOfPages.Location = new Point(1113, 610);
            txtNumberOfPages.Name = "txtNumberOfPages";
            txtNumberOfPages.Size = new Size(442, 43);
            txtNumberOfPages.TabIndex = 15;
            // 
            // txtPulisherYear
            // 
            txtPulisherYear.Location = new Point(1111, 808);
            txtPulisherYear.Name = "txtPulisherYear";
            txtPulisherYear.Size = new Size(442, 43);
            txtPulisherYear.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvBooks);
            groupBox1.Location = new Point(14, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(725, 1178);
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
            dgvBooks.Size = new Size(723, 1118);
            dgvBooks.TabIndex = 0;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(1776, 807);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(430, 43);
            txtLanguage.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1109, 408);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 43);
            textBox1.TabIndex = 12;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(1112, 305);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(442, 43);
            txtISBN.TabIndex = 11;
            // 
            // txtAuthors
            // 
            txtAuthors.Location = new Point(1770, 896);
            txtAuthors.Multiline = true;
            txtAuthors.Name = "txtAuthors";
            txtAuthors.ReadOnly = true;
            txtAuthors.Size = new Size(436, 100);
            txtAuthors.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(852, 0);
            label1.Name = "label1";
            label1.Size = new Size(457, 96);
            label1.TabIndex = 18;
            label1.Text = "Quản lý sách";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1596, 115);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(389, 57);
            txtSearch.TabIndex = 17;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(1112, 208);
            txtBookId.Name = "txtBookId";
            txtBookId.ReadOnly = true;
            txtBookId.Size = new Size(442, 43);
            txtBookId.TabIndex = 9;
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
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
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
        private TextBox txtPulisherYear;
        private GroupBox groupBox1;
        private DataGridView dgvBooks;
        private TextBox txtLanguage;
        private TextBox textBox1;
        private TextBox txtISBN;
        private TextBox txtAuthors;
        private TextBox txtSearch;
        private TextBox txtBookId;
    }
}