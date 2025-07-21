namespace GUI_UI
{
    partial class MembersManagementForm
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
            groupBox1 = new GroupBox();
            txtPhone = new TextBox();
            label8 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
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
            picMemberPhoto = new PictureBox();
            btnChonAnh = new Button();
            dgvMembers = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMemberPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnInsert);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 254);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(124, 122);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(243, 27);
            txtPhone.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 125);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 14;
            label8.Text = "Số điện thoại:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(338, 196);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(229, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(121, 196);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Sữa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 196);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Thêm";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnThem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 161);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 13;
            label7.Text = "Trạng thái:";
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(138, 160);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(103, 24);
            chkStatus.TabIndex = 12;
            chkStatus.Text = "Hoạt động";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Location = new Point(503, 88);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new Size(250, 27);
            dtpJoinDate.TabIndex = 11;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(124, 88);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(243, 27);
            dtpDateOfBirth.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 88);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 9;
            label6.Text = "Ngày đăng ký:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 88);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 8;
            label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(394, 62);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 7;
            label4.Text = "Địa chỉ:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(503, 55);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(243, 27);
            txtAddress.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(124, 55);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(243, 27);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 62);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(503, 22);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(243, 27);
            txtFullName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 29);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Họ và Tên:";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(124, 22);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.ReadOnly = true;
            txtMemberID.Size = new Size(243, 27);
            txtMemberID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 29);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // picMemberPhoto
            // 
            picMemberPhoto.BackgroundImage = Properties.Resources.logo3;
            picMemberPhoto.BackgroundImageLayout = ImageLayout.Zoom;
            picMemberPhoto.Location = new Point(864, 7);
            picMemberPhoto.Name = "picMemberPhoto";
            picMemberPhoto.Size = new Size(207, 186);
            picMemberPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            picMemberPhoto.TabIndex = 1;
            picMemberPhoto.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(917, 208);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(94, 29);
            btnChonAnh.TabIndex = 2;
            btnChonAnh.Text = "Chọn";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // dgvMembers
            // 
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(12, 276);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.Size = new Size(1210, 340);
            dgvMembers.TabIndex = 3;
            dgvMembers.CellClick += dgvMembers_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(864, 244);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(202, 27);
            txtSearch.TabIndex = 14;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1089, 244);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // MembersManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 628);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvMembers);
            Controls.Add(btnChonAnh);
            Controls.Add(picMemberPhoto);
            Controls.Add(groupBox1);
            Name = "MembersManagementForm";
            Text = "MembersManagementForm";
            Load += MembersManagementForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMemberPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtNgaySinh;
        private Label label5;
        private Label label4;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtFullName;
        private Label label2;
        private TextBox txtMemberID;
        private Label label6;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Label label7;
        private CheckBox chkStatus;
        private DateTimePicker dtpJoinDate;
        private DateTimePicker dtpDateOfBirth;
        private PictureBox picMemberPhoto;
        private Button btnChonAnh;
        private DataGridView dgvMembers;
        private TextBox txtSearch;
        private TextBox txtPhone;
        private Label label8;
        private Button btnSearch;
    }
}