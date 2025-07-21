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
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(479, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(309, 54);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Tác Giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(41, 121);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 25);
            label2.TabIndex = 1;
            label2.Text = "ID ";
            // 
            // dgvAuthors
            // 
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.Location = new Point(6, 422);
            dgvAuthors.Margin = new Padding(2, 2, 2, 2);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.RowHeadersWidth = 92;
            dgvAuthors.Size = new Size(1199, 285);
            dgvAuthors.TabIndex = 2;
            dgvAuthors.CellClick += dgvAuthors_CellClick;
            // 
            // txtAuthorID
            // 
            txtAuthorID.Location = new Point(149, 122);
            txtAuthorID.Margin = new Padding(2, 2, 2, 2);
            txtAuthorID.Name = "txtAuthorID";
            txtAuthorID.ReadOnly = true;
            txtAuthorID.Size = new Size(289, 27);
            txtAuthorID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(41, 174);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 1;
            label3.Text = "Họ và tên";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(149, 175);
            txtFullName.Margin = new Padding(2, 2, 2, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(289, 27);
            txtFullName.TabIndex = 3;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(149, 232);
            dtpDateOfBirth.Margin = new Padding(2, 2, 2, 2);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(288, 27);
            dtpDateOfBirth.TabIndex = 4;
            dtpDateOfBirth.ValueChanged += dtpDateOfBirth_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(41, 232);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 1;
            label4.Text = "Năm sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(41, 296);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 1;
            label5.Text = "Năm mất";
            // 
            // dtpDateOfDeath
            // 
            dtpDateOfDeath.Location = new Point(149, 297);
            dtpDateOfDeath.Margin = new Padding(2, 2, 2, 2);
            dtpDateOfDeath.Name = "dtpDateOfDeath";
            dtpDateOfDeath.Size = new Size(288, 27);
            dtpDateOfDeath.TabIndex = 4;
            dtpDateOfDeath.ValueChanged += dtpDateOfDeath_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBiography);
            groupBox1.Location = new Point(587, 97);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(613, 248);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tiểu sử";
            // 
            // txtBiography
            // 
            txtBiography.Location = new Point(13, 30);
            txtBiography.Margin = new Padding(2, 2, 2, 2);
            txtBiography.Multiline = true;
            txtBiography.Name = "txtBiography";
            txtBiography.Size = new Size(590, 206);
            txtBiography.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 192, 255);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(20, 358);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 37);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 192, 255);
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(149, 358);
            btnUpdate.Margin = new Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 37);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 192, 255);
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(284, 358);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 37);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(192, 192, 255);
            btnRefresh.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(413, 358);
            btnRefresh.Margin = new Padding(2, 2, 2, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 37);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 192, 255);
            btnSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1098, 358);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 37);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(600, 359);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(482, 38);
            txtSearch.TabIndex = 7;
            // 
            // AuthorManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 235, 248);
            ClientSize = new Size(1026, 570);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Controls.Add(dtpDateOfDeath);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txtFullName);
            Controls.Add(txtAuthorID);
            Controls.Add(dgvAuthors);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AuthorManagementForm";
            Text = "AuthorForm";
            Load += AuthorManagementForm_Load;
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
    }
}