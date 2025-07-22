namespace GUI_UI
{
    partial class BookCopiesManagementForm
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
            label1 = new Label();
            cboStatus = new ComboBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            pictureBoxCoverImage = new PictureBox();
            label5 = new Label();
            label10 = new Label();
            label9 = new Label();
            label3 = new Label();
            label11 = new Label();
            label6 = new Label();
            label2 = new Label();
            txtConditionNotes = new TextBox();
            groupBox1 = new GroupBox();
            dgvBookCopies = new DataGridView();
            txtBarcode = new TextBox();
            txtSearch = new TextBox();
            txtCopyID = new TextBox();
            dtpPurchaseDate = new DateTimePicker();
            txtPurchasePrice = new TextBox();
            txtTitle = new TextBox();
            label4 = new Label();
            cboBookId = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookCopies).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(932, 33);
            label1.Name = "label1";
            label1.Size = new Size(465, 96);
            label1.TabIndex = 50;
            label1.Text = "Kiểm kê sách";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(1130, 643);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(450, 45);
            cboStatus.TabIndex = 71;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(174, 160, 249);
            btnRefresh.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = SystemColors.Control;
            btnRefresh.Location = new Point(1944, 1193);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(201, 70);
            btnRefresh.TabIndex = 70;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(174, 160, 249);
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(1619, 1193);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(201, 70);
            btnDelete.TabIndex = 69;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(174, 160, 249);
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(1297, 1193);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(201, 70);
            btnUpdate.TabIndex = 68;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(174, 160, 249);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(991, 1193);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(201, 70);
            btnAdd.TabIndex = 67;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(174, 160, 249);
            btnSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(2060, 826);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(172, 60);
            btnSearch.TabIndex = 64;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pictureBoxCoverImage
            // 
            pictureBoxCoverImage.Location = new Point(1728, 247);
            pictureBoxCoverImage.Name = "pictureBoxCoverImage";
            pictureBoxCoverImage.Size = new Size(497, 444);
            pictureBoxCoverImage.TabIndex = 63;
            pictureBoxCoverImage.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(888, 951);
            label5.Name = "label5";
            label5.Size = new Size(286, 45);
            label5.TabIndex = 61;
            label5.Text = "Tình trạng hiện tại";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(888, 849);
            label10.Name = "label10";
            label10.Size = new Size(141, 45);
            label10.TabIndex = 60;
            label10.Text = "Giá mua";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(888, 748);
            label9.Name = "label9";
            label9.Size = new Size(170, 45);
            label9.TabIndex = 58;
            label9.Text = "Ngày mua";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(888, 430);
            label3.Name = "label3";
            label3.Size = new Size(176, 45);
            label3.TabIndex = 62;
            label3.Text = "Mã ấn bản";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(888, 533);
            label11.Name = "label11";
            label11.Size = new Size(137, 45);
            label11.TabIndex = 55;
            label11.Text = "Barcode";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(888, 632);
            label6.Name = "label6";
            label6.Size = new Size(164, 45);
            label6.TabIndex = 53;
            label6.Text = "Trạng thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(888, 244);
            label2.Name = "label2";
            label2.Size = new Size(190, 45);
            label2.TabIndex = 52;
            label2.Text = "Mã bản sao";
            // 
            // txtConditionNotes
            // 
            txtConditionNotes.Location = new Point(887, 1037);
            txtConditionNotes.Multiline = true;
            txtConditionNotes.Name = "txtConditionNotes";
            txtConditionNotes.Size = new Size(1349, 133);
            txtConditionNotes.TabIndex = 48;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvBookCopies);
            groupBox1.Location = new Point(36, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(782, 1178);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh mục sách";
            // 
            // dgvBookCopies
            // 
            dgvBookCopies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookCopies.Location = new Point(6, 42);
            dgvBookCopies.Name = "dgvBookCopies";
            dgvBookCopies.RowHeadersWidth = 92;
            dgvBookCopies.Size = new Size(758, 1118);
            dgvBookCopies.TabIndex = 0;
            dgvBookCopies.CellClick += dgvBookCopies_CellClick;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(1130, 544);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(450, 43);
            txtBarcode.TabIndex = 43;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1732, 752);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(504, 47);
            txtSearch.TabIndex = 49;
            // 
            // txtCopyID
            // 
            txtCopyID.Location = new Point(1130, 247);
            txtCopyID.Name = "txtCopyID";
            txtCopyID.ReadOnly = true;
            txtCopyID.Size = new Size(450, 43);
            txtCopyID.TabIndex = 40;
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Location = new Point(1130, 744);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(450, 43);
            dtpPurchaseDate.TabIndex = 73;
            dtpPurchaseDate.ValueChanged += dtpPurchaseDate_ValueChanged;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(1130, 843);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(450, 43);
            txtPurchasePrice.TabIndex = 47;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(1130, 346);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(450, 43);
            txtTitle.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(887, 343);
            label4.Name = "label4";
            label4.Size = new Size(126, 45);
            label4.TabIndex = 62;
            label4.Text = "Tiêu đề";
            // 
            // cboBookId
            // 
            cboBookId.FormattingEnabled = true;
            cboBookId.Location = new Point(1130, 433);
            cboBookId.Name = "cboBookId";
            cboBookId.Size = new Size(450, 45);
            cboBookId.TabIndex = 74;
            cboBookId.SelectedIndexChanged += cboBookId_SelectedIndexChanged;
            // 
            // BookCopiesManagementForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 235, 248);
            ClientSize = new Size(2272, 1321);
            Controls.Add(cboBookId);
            Controls.Add(dtpPurchaseDate);
            Controls.Add(label1);
            Controls.Add(cboStatus);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(pictureBoxCoverImage);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtConditionNotes);
            Controls.Add(txtPurchasePrice);
            Controls.Add(groupBox1);
            Controls.Add(txtBarcode);
            Controls.Add(txtTitle);
            Controls.Add(txtSearch);
            Controls.Add(txtCopyID);
            Name = "BookCopiesManagementForm";
            Text = "BookCopiesManagementForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCoverImage).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBookCopies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboStatus;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSearch;
        private PictureBox pictureBoxCoverImage;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label3;
        private Label label11;
        private Label label6;
        private Label label2;
        private TextBox txtConditionNotes;
        private GroupBox groupBox1;
        private DataGridView dgvBookCopies;
        private TextBox txtBarcode;
        private TextBox txtSearch;
        private TextBox txtCopyID;
        private DateTimePicker dtpPurchaseDate;
        private TextBox txtPurchasePrice;
        private TextBox txtTitle;
        private Label label4;
        private ComboBox cboBookId;
    }
}