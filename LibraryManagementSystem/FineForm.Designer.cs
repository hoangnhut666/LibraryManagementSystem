namespace GUI_UI
{
    partial class FineForm
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
            ReasonColumn = new DataGridViewTextBoxColumn();
            IssueDateColumn = new DataGridViewTextBoxColumn();
            AmountColumn = new DataGridViewTextBoxColumn();
            LoanIDColumn = new DataGridViewTextBoxColumn();
            FineIDColumn = new DataGridViewTextBoxColumn();
            PaidColumn = new DataGridViewCheckBoxColumn();
            dgvFines = new DataGridView();
            btnrefresh = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            btnedit = new Button();
            btnadd = new Button();
            chkPenaltyNotPaid = new CheckBox();
            chkPenaltyPaid = new CheckBox();
            cboissuedate = new ComboBox();
            txtreason = new TextBox();
            txtamount = new TextBox();
            txtLoadid = new TextBox();
            txtFineid = new TextBox();
            lblpaid = new Label();
            lblreason = new Label();
            lblloanid = new Label();
            lblissuedate = new Label();
            lblamount = new Label();
            lblFineid = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFines).BeginInit();
            SuspendLayout();
            // 
            // ReasonColumn
            // 
            ReasonColumn.HeaderText = "Reason";
            ReasonColumn.Name = "ReasonColumn";
            ReasonColumn.Width = 250;
            // 
            // IssueDateColumn
            // 
            IssueDateColumn.HeaderText = "IssueDate";
            IssueDateColumn.Name = "IssueDateColumn";
            IssueDateColumn.Width = 150;
            // 
            // AmountColumn
            // 
            AmountColumn.HeaderText = "Amount";
            AmountColumn.Name = "AmountColumn";
            AmountColumn.Width = 150;
            // 
            // LoanIDColumn
            // 
            LoanIDColumn.HeaderText = "LoanID";
            LoanIDColumn.Name = "LoanIDColumn";
            // 
            // FineIDColumn
            // 
            FineIDColumn.HeaderText = "FineID";
            FineIDColumn.Name = "FineIDColumn";
            // 
            // PaidColumn
            // 
            PaidColumn.HeaderText = "Paid";
            PaidColumn.Name = "PaidColumn";
            // 
            // dgvFines
            // 
            dgvFines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFines.Columns.AddRange(new DataGridViewColumn[] { FineIDColumn, LoanIDColumn, AmountColumn, IssueDateColumn, PaidColumn, ReasonColumn });
            dgvFines.Location = new Point(11, 239);
            dgvFines.Name = "dgvFines";
            dgvFines.Size = new Size(892, 287);
            dgvFines.TabIndex = 24;
            dgvFines.CellClick += dgvFines_CellClick;
            // 
            // btnrefresh
            // 
            btnrefresh.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnrefresh.Location = new Point(681, 183);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(97, 40);
            btnrefresh.TabIndex = 23;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndelete.Location = new Point(544, 183);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(97, 40);
            btndelete.TabIndex = 22;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(407, 183);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(97, 40);
            btnupdate.TabIndex = 21;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnedit
            // 
            btnedit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnedit.Location = new Point(275, 183);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(97, 40);
            btnedit.TabIndex = 20;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(142, 183);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(97, 40);
            btnadd.TabIndex = 19;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // chkPenaltyNotPaid
            // 
            chkPenaltyNotPaid.AutoSize = true;
            chkPenaltyNotPaid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkPenaltyNotPaid.Location = new Point(761, 84);
            chkPenaltyNotPaid.Name = "chkPenaltyNotPaid";
            chkPenaltyNotPaid.Size = new Size(142, 25);
            chkPenaltyNotPaid.TabIndex = 18;
            chkPenaltyNotPaid.Text = "Penalty Not Paid";
            chkPenaltyNotPaid.UseVisualStyleBackColor = true;
            chkPenaltyNotPaid.CheckedChanged += chkPenaltyNotPaid_CheckedChanged;
            // 
            // chkPenaltyPaid
            // 
            chkPenaltyPaid.AutoSize = true;
            chkPenaltyPaid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkPenaltyPaid.Location = new Point(603, 82);
            chkPenaltyPaid.Name = "chkPenaltyPaid";
            chkPenaltyPaid.Size = new Size(112, 25);
            chkPenaltyPaid.TabIndex = 17;
            chkPenaltyPaid.Text = "Penalty Paid";
            chkPenaltyPaid.UseVisualStyleBackColor = true;
            chkPenaltyPaid.CheckedChanged += chkPenaltyPaid_CheckedChanged;
            // 
            // cboissuedate
            // 
            cboissuedate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboissuedate.FormattingEnabled = true;
            cboissuedate.Items.AddRange(new object[] { "21/07/2025  ", "20/07/2025  ", "19/07/2025  ", "18/07/2025  ", "17/07/2025  ", "16/07/2025" });
            cboissuedate.Location = new Point(603, 28);
            cboissuedate.Name = "cboissuedate";
            cboissuedate.Size = new Size(300, 29);
            cboissuedate.TabIndex = 16;
            // 
            // txtreason
            // 
            txtreason.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtreason.Location = new Point(603, 134);
            txtreason.Name = "txtreason";
            txtreason.Size = new Size(300, 29);
            txtreason.TabIndex = 15;
            // 
            // txtamount
            // 
            txtamount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtamount.Location = new Point(146, 134);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(285, 29);
            txtamount.TabIndex = 14;
            // 
            // txtLoadid
            // 
            txtLoadid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoadid.Location = new Point(146, 80);
            txtLoadid.Name = "txtLoadid";
            txtLoadid.Size = new Size(285, 29);
            txtLoadid.TabIndex = 13;
            // 
            // txtFineid
            // 
            txtFineid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFineid.Location = new Point(146, 28);
            txtFineid.Name = "txtFineid";
            txtFineid.Size = new Size(285, 29);
            txtFineid.TabIndex = 12;
            // 
            // lblpaid
            // 
            lblpaid.AutoSize = true;
            lblpaid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpaid.Location = new Point(473, 80);
            lblpaid.Name = "lblpaid";
            lblpaid.Size = new Size(52, 25);
            lblpaid.TabIndex = 10;
            lblpaid.Text = "Paid:";
            // 
            // lblreason
            // 
            lblreason.AutoSize = true;
            lblreason.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblreason.Location = new Point(473, 134);
            lblreason.Name = "lblreason";
            lblreason.Size = new Size(76, 25);
            lblreason.TabIndex = 9;
            lblreason.Text = "Reason:";
            // 
            // lblloanid
            // 
            lblloanid.AutoSize = true;
            lblloanid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblloanid.Location = new Point(20, 80);
            lblloanid.Name = "lblloanid";
            lblloanid.Size = new Size(75, 25);
            lblloanid.TabIndex = 8;
            lblloanid.Text = "LoanID:";
            // 
            // lblissuedate
            // 
            lblissuedate.AutoSize = true;
            lblissuedate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblissuedate.Location = new Point(473, 28);
            lblissuedate.Name = "lblissuedate";
            lblissuedate.Size = new Size(102, 25);
            lblissuedate.TabIndex = 7;
            lblissuedate.Text = "Issue Date:";
            // 
            // lblamount
            // 
            lblamount.AutoSize = true;
            lblamount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblamount.Location = new Point(20, 134);
            lblamount.Name = "lblamount";
            lblamount.Size = new Size(83, 25);
            lblamount.TabIndex = 11;
            lblamount.Text = "Amount:";
            // 
            // lblFineid
            // 
            lblFineid.AutoSize = true;
            lblFineid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFineid.Location = new Point(20, 28);
            lblFineid.Name = "lblFineid";
            lblFineid.Size = new Size(69, 25);
            lblFineid.TabIndex = 6;
            lblFineid.Text = "FineID:";
            // 
            // FineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 554);
            Controls.Add(dgvFines);
            Controls.Add(btnrefresh);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(chkPenaltyNotPaid);
            Controls.Add(chkPenaltyPaid);
            Controls.Add(cboissuedate);
            Controls.Add(txtreason);
            Controls.Add(txtamount);
            Controls.Add(txtLoadid);
            Controls.Add(txtFineid);
            Controls.Add(lblpaid);
            Controls.Add(lblreason);
            Controls.Add(lblloanid);
            Controls.Add(lblissuedate);
            Controls.Add(lblamount);
            Controls.Add(lblFineid);
            Name = "FineForm";
            Text = "FineForm";
            Load += FineForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn ReasonColumn;
        private DataGridViewTextBoxColumn IssueDateColumn;
        private DataGridViewTextBoxColumn AmountColumn;
        private DataGridViewTextBoxColumn LoanIDColumn;
        private DataGridViewTextBoxColumn FineIDColumn;
        private DataGridViewCheckBoxColumn PaidColumn;
        private DataGridView dgvFines;
        private Button btnrefresh;
        private Button btndelete;
        private Button btnupdate;
        private Button btnedit;
        private Button btnadd;
        private CheckBox chkPenaltyNotPaid;
        private CheckBox chkPenaltyPaid;
        private ComboBox cboissuedate;
        private TextBox txtreason;
        private TextBox txtamount;
        private TextBox txtLoadid;
        private TextBox txtFineid;
        private Label lblpaid;
        private Label lblreason;
        private Label lblloanid;
        private Label lblissuedate;
        private Label lblamount;
        private Label lblFineid;
    }
}