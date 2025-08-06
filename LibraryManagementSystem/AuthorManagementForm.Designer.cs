namespace GUI_UI
{
    partial class AuthorManagementForm
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
            label2 = new Label();
            dgvAuthors = new DataGridView();
            txtAuthorID = new TextBox();
            label3 = new Label();
            txtFullName = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            dtpDateOfDeath = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtBiography = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(838, 28);
            label1.Name = "label1";
            label1.Size = new Size(495, 86);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Tác Giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(71, 218);
            label2.Name = "label2";
            label2.Size = new Size(55, 41);
            label2.TabIndex = 1;
            label2.Text = "ID ";
            // 
            // dgvAuthors
            // 
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.Location = new Point(11, 760);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.RowHeadersWidth = 92;
            dgvAuthors.Size = new Size(2098, 514);
            dgvAuthors.TabIndex = 2;
            dgvAuthors.CellClick += dgvAuthors_CellClick;
            // 
            // txtAuthorID
            // 
            txtAuthorID.Location = new Point(260, 220);
            txtAuthorID.Name = "txtAuthorID";
            txtAuthorID.ReadOnly = true;
            txtAuthorID.Size = new Size(503, 42);
            txtAuthorID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(71, 312);
            label3.Name = "label3";
            label3.Size = new Size(145, 41);
            label3.TabIndex = 1;
            label3.Text = "Họ và tên";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(260, 314);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(503, 42);
            txtFullName.TabIndex = 3;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(260, 418);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(501, 42);
            dtpDateOfBirth.TabIndex = 4;
            dtpDateOfBirth.ValueChanged += dtpDateOfBirth_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(71, 418);
            label4.Name = "label4";
            label4.Size = new Size(143, 41);
            label4.TabIndex = 1;
            label4.Text = "Năm sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(71, 521);
            label5.Name = "label5";
            label5.Size = new Size(140, 41);
            label5.TabIndex = 1;
            label5.Text = "Năm mất";
            // 
            // dtpDateOfDeath
            // 
            dtpDateOfDeath.Location = new Point(260, 523);
            dtpDateOfDeath.Name = "dtpDateOfDeath";
            dtpDateOfDeath.Size = new Size(501, 42);
            dtpDateOfDeath.TabIndex = 4;
            dtpDateOfDeath.ValueChanged += dtpDateOfDeath_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBiography);
            groupBox1.Location = new Point(1027, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1072, 446);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tiểu sử";
            // 
            // txtBiography
            // 
            txtBiography.Location = new Point(23, 54);
            txtBiography.Multiline = true;
            txtBiography.Name = "txtBiography";
            txtBiography.Size = new Size(1029, 368);
            txtBiography.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(174, 160, 249);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(35, 644);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(183, 67);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(174, 160, 249);
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(260, 644);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(183, 67);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(174, 160, 249);
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(497, 644);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(183, 67);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(174, 160, 249);
            btnRefresh.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(722, 644);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(183, 67);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(174, 160, 249);
            btnSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1921, 644);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(183, 67);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1050, 647);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(840, 64);
            txtSearch.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.875F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(71, 568);
            label6.Name = "label6";
            label6.Size = new Size(308, 30);
            label6.TabIndex = 8;
            label6.Text = "Thêm thông tin năm mất nếu có";
            // 
            // AuthorManagementForm
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 235, 248);
            ClientSize = new Size(2121, 1285);
            Controls.Add(label6);
            Controls.Add(dtpDateOfDeath);
            Controls.Add(label5);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txtFullName);
            Controls.Add(txtAuthorID);
            Controls.Add(dgvAuthors);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AuthorManagementForm";
            Text = "AuthorForm";
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvAuthors;
        private TextBox txtAuthorID;
        private Label label3;
        private TextBox txtFullName;
        private DateTimePicker dtpDateOfBirth;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpDateOfDeath;
        private GroupBox groupBox1;
        private TextBox txtBiography;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label6;
    }
}