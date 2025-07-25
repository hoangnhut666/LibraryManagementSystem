namespace GUI_UI
{
    partial class CategoryManagementForm
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
            groupBox1 = new GroupBox();
            txtDescription = new TextBox();
            txtCategoryName = new TextBox();
            txtCategoryId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            dgvCategories = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(819, 23);
            label1.Name = "label1";
            label1.Size = new Size(722, 96);
            label1.TabIndex = 19;
            label1.Text = "Quản lý thể loại sách";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtCategoryName);
            groupBox1.Controls.Add(txtCategoryId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1213, 269);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1030, 732);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thể loại sách";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(297, 260);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(681, 430);
            txtDescription.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(297, 166);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(681, 43);
            txtCategoryName.TabIndex = 2;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(297, 70);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.ReadOnly = true;
            txtCategoryId.Size = new Size(681, 43);
            txtCategoryId.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(32, 260);
            label4.Name = "label4";
            label4.Size = new Size(113, 48);
            label4.TabIndex = 1;
            label4.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(32, 160);
            label3.Name = "label3";
            label3.Size = new Size(202, 48);
            label3.TabIndex = 1;
            label3.Text = "Tên thể loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(32, 65);
            label2.Name = "label2";
            label2.Size = new Size(198, 48);
            label2.TabIndex = 0;
            label2.Text = "Mã thể loại";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(174, 160, 249);
            btnSearch.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(2071, 173);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(172, 60);
            btnSearch.TabIndex = 33;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1213, 184);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(826, 43);
            txtSearch.TabIndex = 32;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(174, 160, 249);
            btnRefresh.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = SystemColors.Control;
            btnRefresh.Location = new Point(2035, 1080);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(208, 69);
            btnRefresh.TabIndex = 41;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(174, 160, 249);
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(1764, 1080);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(208, 69);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(174, 160, 249);
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(1490, 1080);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(208, 69);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(174, 160, 249);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(1213, 1080);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(208, 69);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvCategories);
            groupBox2.Location = new Point(12, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1126, 1124);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh mục các thể loại";
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(6, 42);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 92;
            dgvCategories.Size = new Size(1103, 1076);
            dgvCategories.TabIndex = 0;
            dgvCategories.CellClick += dgvCategories_CellClick;
            // 
            // CategoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 235, 248);
            ClientSize = new Size(2272, 1321);
            Controls.Add(groupBox2);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "CategoryManagementForm";
            Text = "Quản lý thể loại";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtDescription;
        private TextBox txtCategoryName;
        private TextBox txtCategoryId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox groupBox2;
        private DataGridView dgvCategories;
    }
}