namespace GUI_UI
{
    partial class LoanDashboardForm
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
            dgvLoans = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtLoanId = new TextBox();
            label5 = new Label();
            txtTitle = new TextBox();
            label6 = new Label();
            label4 = new Label();
            cboMemberID = new ComboBox();
            dtpLoanDate = new DateTimePicker();
            label9 = new Label();
            label7 = new Label();
            dtpDueDate = new DateTimePicker();
            label8 = new Label();
            dtpReturnDate = new DateTimePicker();
            label11 = new Label();
            cboStatus = new ComboBox();
            label12 = new Label();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            txtNotes = new TextBox();
            groupBox2 = new GroupBox();
            btnSearch = new Button();
            txtUserFullName = new TextBox();
            cboCopyId = new ComboBox();
            groupBox3 = new GroupBox();
            txtMemberName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLoans
            // 
            dgvLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoans.Location = new Point(12, 698);
            dgvLoans.Name = "dgvLoans";
            dgvLoans.RowHeadersWidth = 92;
            dgvLoans.Size = new Size(2248, 611);
            dgvLoans.TabIndex = 0;
            dgvLoans.CellClick += dgvLoans_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(881, 22);
            label1.Name = "label1";
            label1.Size = new Size(618, 96);
            label1.TabIndex = 54;
            label1.Text = "Quản lý mượn trả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 151);
            label2.Name = "label2";
            label2.Size = new Size(162, 45);
            label2.TabIndex = 55;
            label2.Text = "Mã mượn";
            // 
            // txtLoanId
            // 
            txtLoanId.Location = new Point(247, 154);
            txtLoanId.Name = "txtLoanId";
            txtLoanId.ReadOnly = true;
            txtLoanId.Size = new Size(450, 43);
            txtLoanId.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(1678, 286);
            label5.Name = "label5";
            label5.Size = new Size(0, 45);
            label5.TabIndex = 65;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(6, 42);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(576, 43);
            txtTitle.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(820, 152);
            label6.Name = "label6";
            label6.Size = new Size(222, 45);
            label6.TabIndex = 72;
            label6.Text = "Tên nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(820, 267);
            label4.Name = "label4";
            label4.Size = new Size(230, 45);
            label4.TabIndex = 72;
            label4.Text = "Mã thành viên";
            // 
            // cboMemberID
            // 
            cboMemberID.FormattingEnabled = true;
            cboMemberID.Location = new Point(1112, 262);
            cboMemberID.Name = "cboMemberID";
            cboMemberID.Size = new Size(450, 45);
            cboMemberID.TabIndex = 73;
            cboMemberID.SelectedIndexChanged += cboMemberID_SelectedIndexChanged;
            // 
            // dtpLoanDate
            // 
            dtpLoanDate.Location = new Point(248, 470);
            dtpLoanDate.Name = "dtpLoanDate";
            dtpLoanDate.Size = new Size(450, 43);
            dtpLoanDate.TabIndex = 75;
            dtpLoanDate.ValueChanged += dtpLoanDate_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(12, 466);
            label9.Name = "label9";
            label9.Size = new Size(192, 45);
            label9.TabIndex = 74;
            label9.Text = "Ngày mượn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(820, 364);
            label7.Name = "label7";
            label7.Size = new Size(127, 45);
            label7.TabIndex = 74;
            label7.Text = "Hạn trả";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(1112, 365);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(450, 43);
            dtpDueDate.TabIndex = 75;
            dtpDueDate.ValueChanged += dtpDueDate_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(820, 468);
            label8.Name = "label8";
            label8.Size = new Size(145, 45);
            label8.TabIndex = 74;
            label8.Text = "Ngày trả";
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(1112, 475);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(450, 43);
            dtpReturnDate.TabIndex = 75;
            dtpReturnDate.ValueChanged += dtpReturnDate_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(12, 361);
            label11.Name = "label11";
            label11.Size = new Size(164, 45);
            label11.TabIndex = 72;
            label11.Text = "Trạng thái";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(248, 363);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(450, 45);
            cboStatus.TabIndex = 73;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F);
            label12.Location = new Point(12, 256);
            label12.Name = "label12";
            label12.Size = new Size(190, 45);
            label12.TabIndex = 55;
            label12.Text = "Mã bản sao";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1684, 586);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(570, 47);
            txtSearch.TabIndex = 76;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(174, 160, 249);
            btnRefresh.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = SystemColors.Control;
            btnRefresh.Location = new Point(1020, 570);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(201, 70);
            btnRefresh.TabIndex = 81;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(174, 160, 249);
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(703, 570);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(201, 70);
            btnDelete.TabIndex = 80;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(174, 160, 249);
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(386, 570);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(201, 70);
            btnUpdate.TabIndex = 79;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(174, 160, 249);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(69, 570);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(201, 70);
            btnAdd.TabIndex = 78;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Location = new Point(1678, 318);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(576, 200);
            groupBox1.TabIndex = 82;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ghi chú";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(6, 53);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(570, 146);
            txtNotes.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTitle);
            groupBox2.Location = new Point(1678, 107);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(582, 99);
            groupBox2.TabIndex = 83;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tên sách";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(174, 160, 249);
            btnSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(1330, 570);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(201, 70);
            btnSearch.TabIndex = 81;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtUserFullName
            // 
            txtUserFullName.Location = new Point(1112, 154);
            txtUserFullName.Name = "txtUserFullName";
            txtUserFullName.ReadOnly = true;
            txtUserFullName.Size = new Size(450, 43);
            txtUserFullName.TabIndex = 53;
            // 
            // cboCopyId
            // 
            cboCopyId.FormattingEnabled = true;
            cboCopyId.Location = new Point(247, 261);
            cboCopyId.Name = "cboCopyId";
            cboCopyId.Size = new Size(451, 45);
            cboCopyId.TabIndex = 84;
            cboCopyId.SelectedIndexChanged += cboCopyId_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtMemberName);
            groupBox3.Location = new Point(1678, 206);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(582, 106);
            groupBox3.TabIndex = 82;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tên thành viên";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(6, 53);
            txtMemberName.Multiline = true;
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(570, 146);
            txtMemberName.TabIndex = 0;
            // 
            // LoanDashboardForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 235, 248);
            ClientSize = new Size(2272, 1321);
            Controls.Add(cboCopyId);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(dtpReturnDate);
            Controls.Add(dtpDueDate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtpLoanDate);
            Controls.Add(label9);
            Controls.Add(cboStatus);
            Controls.Add(cboMemberID);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(txtUserFullName);
            Controls.Add(txtLoanId);
            Controls.Add(dgvLoans);
            Name = "LoanDashboardForm";
            Text = "BorrowingsForm";
            ((System.ComponentModel.ISupportInitialize)dgvLoans).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLoans;
        private Label label1;
        private Label label2;
        private TextBox txtLoanId;
        private Label label5;
        private TextBox txtTitle;
        private Label label6;
        private Label label4;
        private ComboBox cboMemberID;
        private DateTimePicker dtpLoanDate;
        private Label label9;
        private Label label7;
        private DateTimePicker dtpDueDate;
        private Label label8;
        private DateTimePicker dtpReturnDate;
        private Label label11;
        private ComboBox cboStatus;
        private Label label12;
        private TextBox txtSearch;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox groupBox1;
        private TextBox txtNotes;
        private GroupBox groupBox2;
        private Button btnSearch;
        private TextBox txtUserFullName;
        private ComboBox cboCopyId;
        private GroupBox groupBox3;
        private TextBox txtMemberName;
    }
}