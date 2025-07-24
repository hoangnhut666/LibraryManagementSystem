namespace GUI_UI
{
    partial class MemberManagementForm
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
            txtSearch = new TextBox();
            dgvMembers = new DataGridView();
            picMemberPhoto = new PictureBox();
            groupBox1 = new GroupBox();
            txtPhone = new TextBox();
            label8 = new Label();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label7 = new Label();
            chkStatus = new CheckBox();
            dtpJoinDate = new DateTimePicker();
            dtpDateOfBirth = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            txtMemberID = new TextBox();
            label1 = new Label();
            label9 = new Label();
            btnSearch = new Button();
            btnSelectCoverImage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMemberPhoto).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1631, 122);
            txtSearch.Margin = new Padding(6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(375, 43);
            txtSearch.TabIndex = 20;
            // 
            // dgvMembers
            // 
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(2, 670);
            dgvMembers.Margin = new Padding(6);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.Size = new Size(2269, 616);
            dgvMembers.TabIndex = 19;
            dgvMembers.CellClick += dgvMembers_CellClick;
            // 
            // picMemberPhoto
            // 
            picMemberPhoto.BackgroundImageLayout = ImageLayout.Zoom;
            picMemberPhoto.Location = new Point(1631, 208);
            picMemberPhoto.Margin = new Padding(6);
            picMemberPhoto.Name = "picMemberPhoto";
            picMemberPhoto.Size = new Size(375, 368);
            picMemberPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picMemberPhoto.TabIndex = 17;
            picMemberPhoto.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(chkStatus);
            groupBox1.Controls.Add(dtpJoinDate);
            groupBox1.Controls.Add(dtpDateOfBirth);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMemberID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, 106);
            groupBox1.Margin = new Padding(6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(1474, 537);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thành viên";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(232, 324);
            txtPhone.Margin = new Padding(6);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(452, 43);
            txtPhone.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 332);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(180, 37);
            label8.TabIndex = 14;
            label8.Text = "Số điện thoại:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(174, 160, 249);
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(763, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(201, 70);
            btnDelete.TabIndex = 84;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(174, 160, 249);
            btnRefresh.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = SystemColors.Control;
            btnRefresh.Location = new Point(1070, 410);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(201, 70);
            btnRefresh.TabIndex = 86;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(174, 160, 249);
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(446, 410);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(201, 70);
            btnUpdate.TabIndex = 83;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(174, 160, 249);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(129, 410);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(201, 70);
            btnAdd.TabIndex = 82;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(764, 323);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(141, 37);
            label7.TabIndex = 13;
            label7.Text = "Trạng thái:";
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(965, 323);
            chkStatus.Margin = new Padding(6);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(177, 41);
            chkStatus.TabIndex = 12;
            chkStatus.Text = "Hoạt động";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Location = new Point(965, 228);
            dtpJoinDate.Margin = new Padding(6);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new Size(452, 43);
            dtpJoinDate.TabIndex = 11;
            dtpJoinDate.ValueChanged += dtpJoinDate_ValueChanged;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(232, 228);
            dtpDateOfBirth.Margin = new Padding(6);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(452, 43);
            dtpDateOfBirth.TabIndex = 10;
            dtpDateOfBirth.ValueChanged += dtpDateOfBirth_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(764, 233);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(187, 37);
            label6.TabIndex = 9;
            label6.Text = "Ngày đăng ký:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 231);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(141, 37);
            label5.TabIndex = 8;
            label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(764, 155);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 37);
            label4.TabIndex = 7;
            label4.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(965, 139);
            txtAddress.Margin = new Padding(6);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(452, 43);
            txtAddress.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(232, 129);
            txtEmail.Margin = new Padding(6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(452, 43);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 145);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 37);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(965, 41);
            txtFullName.Margin = new Padding(6);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(452, 43);
            txtFullName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(764, 67);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 37);
            label2.TabIndex = 2;
            label2.Text = "Họ và Tên:";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(232, 41);
            txtMemberID.Margin = new Padding(6);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.ReadOnly = true;
            txtMemberID.Size = new Size(452, 43);
            txtMemberID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 57);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 37);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.MediumSlateBlue;
            label9.Location = new Point(801, 9);
            label9.Name = "label9";
            label9.Size = new Size(658, 96);
            label9.TabIndex = 55;
            label9.Text = "Quản lý thành viên";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(174, 160, 249);
            btnSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(2059, 106);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(201, 70);
            btnSearch.TabIndex = 85;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSelectCoverImage
            // 
            btnSelectCoverImage.BackColor = Color.FromArgb(174, 160, 249);
            btnSelectCoverImage.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSelectCoverImage.ForeColor = SystemColors.Control;
            btnSelectCoverImage.Location = new Point(2059, 208);
            btnSelectCoverImage.Name = "btnSelectCoverImage";
            btnSelectCoverImage.Size = new Size(201, 70);
            btnSelectCoverImage.TabIndex = 85;
            btnSelectCoverImage.Text = "Chọn ảnh";
            btnSelectCoverImage.UseVisualStyleBackColor = false;
            btnSelectCoverImage.Click += btnSelectCoverImage_Click;
            // 
            // MembersManagementForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 235, 248);
            ClientSize = new Size(2272, 1321);
            Controls.Add(btnSelectCoverImage);
            Controls.Add(btnSearch);
            Controls.Add(label9);
            Controls.Add(txtSearch);
            Controls.Add(dgvMembers);
            Controls.Add(picMemberPhoto);
            Controls.Add(groupBox1);
            Name = "MembersManagementForm";
            Text = "Quản lý thành viên";
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMemberPhoto).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSearch;
        private DataGridView dgvMembers;
        private PictureBox picMemberPhoto;
        private GroupBox groupBox1;
        private TextBox txtPhone;
        private Label label8;
        private Label label7;
        private CheckBox chkStatus;
        private DateTimePicker dtpJoinDate;
        private DateTimePicker dtpDateOfBirth;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtFullName;
        private Label label2;
        private TextBox txtMemberID;
        private Label label1;
        private Label label9;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnSelectCoverImage;
    }
}