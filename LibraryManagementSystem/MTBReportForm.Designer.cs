namespace GUI_UI
{
    partial class MTBReportForm
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
            cboReportType = new ComboBox();
            btnConfirm = new Button();
            dgvReport = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // cboReportType
            // 
            cboReportType.FormattingEnabled = true;
            cboReportType.Location = new Point(668, 123);
            cboReportType.Name = "cboReportType";
            cboReportType.Size = new Size(184, 28);
            cboReportType.TabIndex = 0;
            cboReportType.SelectedIndexChanged += cboReportType_SelectedIndexChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(869, 123);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(127, 29);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Xác nhận";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dgvReport
            // 
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(12, 157);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(1002, 278);
            dgvReport.TabIndex = 2;
            // 
            // MTBReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 447);
            Controls.Add(dgvReport);
            Controls.Add(btnConfirm);
            Controls.Add(cboReportType);
            Name = "MTBReportForm";
            Text = "MTBReportForm";
            Load += baform_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboReportType;
        private Button btnConfirm;
        private DataGridView dgvReport;
    }
}