namespace GUI_UI
{
    partial class UserManagementForm
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
            dgvUserList = new DataGridView();
            txtConfirmPassword = new TextBox();
            txtUserName = new TextBox();
            txtSearch = new TextBox();
            txtUserId = new TextBox();
            label7 = new Label();
            cboRole = new ComboBox();
            groupBox2 = new GroupBox();
            chkShowConfirmPassword = new CheckBox();
            chkShowPassword = new CheckBox();
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            chkIsActive = new CheckBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(819, 18);
            label1.Name = "label1";
            label1.Size = new Size(695, 96);
            label1.TabIndex = 81;
            label1.Text = "Quản lý người dùng";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(174, 160, 249);
            btnRefresh.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = SystemColors.Control;
            btnRefresh.Location = new Point(2062, 1205);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(175, 61);
            btnRefresh.TabIndex = 96;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(174, 160, 249);
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(1834, 1205);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(175, 61);
            btnDelete.TabIndex = 95;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(174, 160, 249);
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(1618, 1205);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(175, 61);
            btnUpdate.TabIndex = 94;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(174, 160, 249);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(1417, 1205);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(175, 61);
            btnAdd.TabIndex = 93;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(174, 160, 249);
            btnSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(2062, 158);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(172, 60);
            btnSearch.TabIndex = 92;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(1415, 1084);
            label10.Name = "label10";
            label10.Size = new Size(324, 45);
            label10.TabIndex = 87;
            label10.Text = "Trạng thái hoạt động";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(1416, 859);
            label9.Name = "label9";
            label9.Size = new Size(98, 45);
            label9.TabIndex = 86;
            label9.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(1416, 415);
            label4.Name = "label4";
            label4.Size = new Size(236, 45);
            label4.TabIndex = 89;
            label4.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(1416, 526);
            label3.Name = "label3";
            label3.Size = new Size(158, 45);
            label3.TabIndex = 90;
            label3.Text = "Mật khẩu";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(1416, 637);
            label11.Name = "label11";
            label11.Size = new Size(299, 45);
            label11.TabIndex = 85;
            label11.Text = "Xác nhận mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(1416, 748);
            label6.Name = "label6";
            label6.Size = new Size(160, 45);
            label6.TabIndex = 84;
            label6.Text = "Họ và tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(1416, 304);
            label2.Name = "label2";
            label2.Size = new Size(246, 45);
            label2.TabIndex = 83;
            label2.Text = "Mã người dùng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvUserList);
            groupBox1.Location = new Point(30, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1315, 1165);
            groupBox1.TabIndex = 82;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách người dùng";
            // 
            // dgvUserList
            // 
            dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserList.Location = new Point(6, 42);
            dgvUserList.Name = "dgvUserList";
            dgvUserList.RowHeadersWidth = 92;
            dgvUserList.Size = new Size(1284, 1097);
            dgvUserList.TabIndex = 0;
            dgvUserList.CellClick += dgvUserList_CellClick;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(1776, 642);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(450, 43);
            txtConfirmPassword.TabIndex = 77;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(1777, 418);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(450, 43);
            txtUserName.TabIndex = 76;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1398, 169);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(602, 47);
            txtSearch.TabIndex = 80;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(1776, 307);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(450, 43);
            txtUserId.TabIndex = 75;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(1416, 967);
            label7.Name = "label7";
            label7.Size = new Size(114, 45);
            label7.TabIndex = 84;
            label7.Text = "Vai trò";
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(1776, 974);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(450, 45);
            cboRole.TabIndex = 97;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkShowConfirmPassword);
            groupBox2.Controls.Add(chkShowPassword);
            groupBox2.Location = new Point(1395, 241);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(839, 921);
            groupBox2.TabIndex = 100;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin người dùng";
      
            // 
            // chkShowConfirmPassword
            // 
            chkShowConfirmPassword.AutoSize = true;
            chkShowConfirmPassword.Location = new Point(347, 408);
            chkShowConfirmPassword.Name = "chkShowConfirmPassword";
            chkShowConfirmPassword.Size = new Size(28, 27);
            chkShowConfirmPassword.TabIndex = 102;
            chkShowConfirmPassword.UseVisualStyleBackColor = true;
            chkShowConfirmPassword.CheckedChanged += chkShowConfirmPassword_CheckedChanged;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(347, 297);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(28, 27);
            chkShowPassword.TabIndex = 102;
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1777, 529);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(450, 43);
            txtPassword.TabIndex = 76;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(1777, 748);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(450, 43);
            txtFullName.TabIndex = 77;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(1777, 859);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(450, 43);
            txtEmail.TabIndex = 77;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(1777, 1089);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(177, 41);
            chkIsActive.TabIndex = 101;
            chkIsActive.Text = "Hoạt động";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2272, 1321);
            Controls.Add(chkIsActive);
            Controls.Add(label1);
            Controls.Add(cboRole);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtSearch);
            Controls.Add(txtUserId);
            Controls.Add(groupBox2);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserList).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
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
        private Label label6;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridView dgvUserList;
        private TextBox txtConfirmPassword;
        private TextBox txtUserName;
        private TextBox txtSearch;
        private TextBox txtUserId;
        private Label label7;
        private ComboBox cboRole;
        private GroupBox groupBox2;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private CheckBox chkIsActive;
        private CheckBox chkShowConfirmPassword;
        private CheckBox chkShowPassword;
    }
}