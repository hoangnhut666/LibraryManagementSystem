namespace GUI_UI
{
    partial class ReportForm
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
            dgvReport = new DataGridView();
            groupBox2 = new GroupBox();
            cboFilter = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(819, 9);
            label1.Name = "label1";
            label1.Size = new Size(718, 96);
            label1.TabIndex = 19;
            label1.Text = "Báo cáo và Thống kê";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvReport);
            groupBox1.Location = new Point(9, 304);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2259, 1016);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả";
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(6, 42);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 92;
            dgvReport.Size = new Size(2245, 878);
            dgvReport.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboFilter);
            groupBox2.Location = new Point(24, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(907, 144);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn tiêu chí cần lọc";
            // 
            // cboFilter
            // 
            cboFilter.FormattingEnabled = true;
            cboFilter.Location = new Point(20, 57);
            cboFilter.Name = "cboFilter";
            cboFilter.Size = new Size(866, 45);
            cboFilter.TabIndex = 0;
            cboFilter.SelectedIndexChanged += cboFilter_SelectedIndexChanged;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 235, 248);
            ClientSize = new Size(2272, 1321);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ReportForm";
            Text = "Báo cáo và Thống kê";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvReport;
        private GroupBox groupBox2;
        private ComboBox cboFilter;
    }
}