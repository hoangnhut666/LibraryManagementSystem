namespace GUI_UI
{
    partial class FineManagementForm
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
            chkPaid = new CheckBox();
            label1 = new Label();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            label10 = new Label();
            label9 = new Label();
            label4 = new Label();
            label3 = new Label();
            label11 = new Label();
            label6 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dgvFineList = new DataGridView();
            txtReason = new TextBox();
            txtAmount = new TextBox();
            txtSearch = new TextBox();
            txtFineID = new TextBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            cboFineMap = new ComboBox();
            dtpIssueDate = new DateTimePicker();
            cboLoanID = new ComboBox();
            txtMemberName = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnUpdateOverDueFines = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFineList).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // chkPaid
            // 
            chkPaid.AutoSize = true;
            chkPaid.Location = new Point(357, 894);
            chkPaid.Name = "chkPaid";
            chkPaid.Size = new Size(211, 40);
            chkPaid.TabIndex = 126;
            chkPaid.Text = "Đã thanh toán";
            chkPaid.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(767, 22);
            label1.Name = "label1";
            label1.Size = new Size(592, 86);
            label1.TabIndex = 109;
            label1.Text = "Quản lý phiếu phạt";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(174, 160, 249);
            btnRefresh.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = SystemColors.Control;
            btnRefresh.Location = new Point(1917, 1203);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(163, 59);
            btnRefresh.TabIndex = 123;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(174, 160, 249);
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(1705, 1203);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(163, 59);
            btnDelete.TabIndex = 122;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(174, 160, 249);
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(1503, 1203);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(163, 59);
            btnUpdate.TabIndex = 121;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(174, 160, 249);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(1315, 1203);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(163, 59);
            btnAdd.TabIndex = 120;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(174, 160, 249);
            btnSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(1927, 159);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(161, 58);
            btnSearch.TabIndex = 119;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(26, 892);
            label10.Name = "label10";
            label10.Size = new Size(148, 41);
            label10.TabIndex = 116;
            label10.Text = "Trạng thái";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(26, 734);
            label9.Name = "label9";
            label9.Size = new Size(204, 41);
            label9.TabIndex = 115;
            label9.Text = "Mô tả lỗi phạt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(1324, 409);
            label4.Name = "label4";
            label4.Size = new Size(230, 41);
            label4.TabIndex = 117;
            label4.Text = "Mã phiếu mượn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(1324, 517);
            label3.Name = "label3";
            label3.Size = new Size(210, 41);
            label3.TabIndex = 118;
            label3.Text = "Tên thành viên";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(26, 510);
            label11.Name = "label11";
            label11.Size = new Size(125, 41);
            label11.TabIndex = 114;
            label11.Text = "Lỗi phạt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(22, 384);
            label6.Name = "label6";
            label6.Size = new Size(156, 41);
            label6.TabIndex = 112;
            label6.Text = "Ngày phạt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(1324, 301);
            label2.Name = "label2";
            label2.Size = new Size(211, 41);
            label2.TabIndex = 111;
            label2.Text = "Mã phiếu phạt";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvFineList);
            groupBox1.Location = new Point(31, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1227, 1074);
            groupBox1.TabIndex = 110;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phiếu phạt";
            // 
            // dgvFineList
            // 
            dgvFineList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFineList.Location = new Point(6, 41);
            dgvFineList.Name = "dgvFineList";
            dgvFineList.RowHeadersWidth = 92;
            dgvFineList.Size = new Size(1198, 1018);
            dgvFineList.TabIndex = 0;
            dgvFineList.CellClick += dgvFineList_CellClick;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(353, 734);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.ReadOnly = true;
            txtReason.Size = new Size(422, 141);
            txtReason.TabIndex = 107;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(6, 41);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(420, 42);
            txtAmount.TabIndex = 105;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1308, 169);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(562, 46);
            txtSearch.TabIndex = 108;
            // 
            // txtFineID
            // 
            txtFineID.Location = new Point(1660, 304);
            txtFineID.Name = "txtFineID";
            txtFineID.ReadOnly = true;
            txtFineID.Size = new Size(420, 42);
            txtFineID.TabIndex = 102;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(chkPaid);
            groupBox2.Controls.Add(dtpIssueDate);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cboLoanID);
            groupBox2.Controls.Add(txtMemberName);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtReason);
            groupBox2.Location = new Point(1305, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(783, 948);
            groupBox2.TabIndex = 125;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtAmount);
            groupBox4.Location = new Point(346, 580);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(441, 87);
            groupBox4.TabIndex = 128;
            groupBox4.TabStop = false;
            groupBox4.Text = "Số tiền";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboFineMap);
            groupBox3.Location = new Point(346, 485);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(441, 90);
            groupBox3.TabIndex = 127;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh mục lỗi";
            // 
            // cboFineMap
            // 
            cboFineMap.FormattingEnabled = true;
            cboFineMap.Location = new Point(6, 40);
            cboFineMap.Name = "cboFineMap";
            cboFineMap.Size = new Size(418, 44);
            cboFineMap.TabIndex = 1;
            cboFineMap.SelectedIndexChanged += cboFineMap_SelectedIndexChanged;
            // 
            // dtpIssueDate
            // 
            dtpIssueDate.Location = new Point(357, 386);
            dtpIssueDate.Name = "dtpIssueDate";
            dtpIssueDate.Size = new Size(420, 42);
            dtpIssueDate.TabIndex = 0;
            dtpIssueDate.ValueChanged += dtpIssueDate_ValueChanged;
            // 
            // cboLoanID
            // 
            cboLoanID.FormattingEnabled = true;
            cboLoanID.Location = new Point(357, 169);
            cboLoanID.Name = "cboLoanID";
            cboLoanID.Size = new Size(418, 44);
            cboLoanID.TabIndex = 1;
            cboLoanID.SelectedIndexChanged += cboLoanID_SelectedIndexChanged;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(355, 280);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.ReadOnly = true;
            txtMemberName.Size = new Size(420, 42);
            txtMemberName.TabIndex = 105;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnUpdateOverDueFines
            // 
            btnUpdateOverDueFines.BackColor = Color.FromArgb(174, 160, 249);
            btnUpdateOverDueFines.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdateOverDueFines.ForeColor = SystemColors.Control;
            btnUpdateOverDueFines.Location = new Point(37, 1203);
            btnUpdateOverDueFines.Name = "btnUpdateOverDueFines";
            btnUpdateOverDueFines.Size = new Size(329, 59);
            btnUpdateOverDueFines.TabIndex = 120;
            btnUpdateOverDueFines.Text = "Cập nhật khoản phạt";
            btnUpdateOverDueFines.UseVisualStyleBackColor = false;
            btnUpdateOverDueFines.Click += btnUpdateOverDueFines_Click;
            // 
            // FineManagementForm
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 235, 248);
            ClientSize = new Size(2121, 1285);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnUpdateOverDueFines);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(txtSearch);
            Controls.Add(txtFineID);
            Controls.Add(groupBox2);
            Name = "FineManagementForm";
            Text = "Quản lý phiếu phạt";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFineList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkPaid;
        private Label label1;
        private ComboBox cboRole;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSearch;
        private Label label10;
        private Label label9;
        private Label label4;
        private Label label3;
        private Label label11;
        private Label label7;
        private Label label6;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridView dgvFineList;
        private TextBox txtReason;
        private TextBox txtFullName;
        private TextBox txtAmount;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox txtSearch;
        private TextBox txtFineID;
        private GroupBox groupBox2;
        private DateTimePicker dtpIssueDate;
        private ComboBox cboLoanID;
        private TextBox txtMemberName;
        private ComboBox cboFineMap;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnUpdateOverDueFines;
    }
}