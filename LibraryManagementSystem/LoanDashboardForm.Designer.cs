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
            txtCopyID = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            cboStatus = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            dtpPurchaseDate = new DateTimePicker();
            label9 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label11 = new Label();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            label12 = new Label();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            // txtCopyID
            // 
            txtCopyID.Location = new Point(247, 154);
            txtCopyID.Name = "txtCopyID";
            txtCopyID.ReadOnly = true;
            txtCopyID.Size = new Size(450, 43);
            txtCopyID.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(1768, 286);
            label5.Name = "label5";
            label5.Size = new Size(0, 45);
            label5.TabIndex = 65;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 42);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(576, 43);
            textBox1.TabIndex = 62;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(1112, 160);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(450, 45);
            cboStatus.TabIndex = 73;
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
            label4.Size = new Size(233, 45);
            label4.TabIndex = 72;
            label4.Text = "Tên thành viên";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1112, 262);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(450, 45);
            comboBox1.TabIndex = 73;
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Location = new Point(248, 470);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(450, 43);
            dtpPurchaseDate.TabIndex = 75;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1112, 365);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(450, 43);
            dateTimePicker1.TabIndex = 75;
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
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1112, 475);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(450, 43);
            dateTimePicker2.TabIndex = 75;
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(248, 363);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(450, 45);
            comboBox2.TabIndex = 73;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 267);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(450, 43);
            textBox2.TabIndex = 53;
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
            txtSearch.Location = new Point(1690, 471);
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
            btnRefresh.Location = new Point(1231, 577);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(201, 70);
            btnRefresh.TabIndex = 81;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(174, 160, 249);
            btnDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(914, 577);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(201, 70);
            btnDelete.TabIndex = 80;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(174, 160, 249);
            btnUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(597, 577);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(201, 70);
            btnUpdate.TabIndex = 79;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(174, 160, 249);
            btnAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(280, 577);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(201, 70);
            btnAdd.TabIndex = 78;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(1684, 209);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(576, 208);
            groupBox1.TabIndex = 82;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ghi chú";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 53);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(570, 146);
            textBox3.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(1678, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(582, 99);
            groupBox2.TabIndex = 83;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tên sách";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(174, 160, 249);
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(1902, 577);
            button1.Name = "button1";
            button1.Size = new Size(201, 70);
            button1.TabIndex = 81;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // LoanDashboardForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 235, 248);
            ClientSize = new Size(2272, 1321);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtpPurchaseDate);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(cboStatus);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(txtCopyID);
            Controls.Add(dgvLoans);
            Name = "LoanDashboardForm";
            Text = "BorrowingsForm";
            ((System.ComponentModel.ISupportInitialize)dgvLoans).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLoans;
        private Label label1;
        private Label label2;
        private TextBox txtCopyID;
        private Label label5;
        private TextBox textBox1;
        private ComboBox cboStatus;
        private Label label6;
        private Label label4;
        private ComboBox comboBox1;
        private DateTimePicker dtpPurchaseDate;
        private Label label9;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private DateTimePicker dateTimePicker2;
        private Label label11;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Label label12;
        private TextBox txtSearch;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private GroupBox groupBox2;
        private Button button1;
    }
}