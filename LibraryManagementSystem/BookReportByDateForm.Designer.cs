namespace GUI_UI
{
    partial class BookReportByDateForm
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
            btnConfirm = new Button();
            dtbStartTime = new DateTimePicker();
            dgvBookStatistics = new DataGridView();
            dtbEndTime = new DateTimePicker();
            btnShowAll = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBookStatistics).BeginInit();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(813, 138);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Lọc";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // dtbStartTime
            // 
            dtbStartTime.Location = new Point(171, 140);
            dtbStartTime.Name = "dtbStartTime";
            dtbStartTime.Size = new Size(250, 27);
            dtbStartTime.TabIndex = 1;
            // 
            // dgvBookStatistics
            // 
            dgvBookStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookStatistics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookStatistics.Location = new Point(12, 191);
            dgvBookStatistics.Name = "dgvBookStatistics";
            dgvBookStatistics.RowHeadersWidth = 51;
            dgvBookStatistics.Size = new Size(1002, 353);
            dgvBookStatistics.TabIndex = 2;
            // 
            // dtbEndTime
            // 
            dtbEndTime.Location = new Point(545, 140);
            dtbEndTime.Name = "dtbEndTime";
            dtbEndTime.Size = new Size(250, 27);
            dtbEndTime.TabIndex = 3;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(913, 138);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(94, 29);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Hiện tất cả";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(274, 26);
            label1.Name = "label1";
            label1.Size = new Size(470, 28);
            label1.TabIndex = 5;
            label1.Text = "THỐNG KÊ TRẠNG THÁI SÁCH THEO THỜI GIAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 144);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 6;
            label2.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 142);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 7;
            label3.Text = "Ngày bắt đầu";
            // 
            // BookReportByDateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 570);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnShowAll);
            Controls.Add(dtbEndTime);
            Controls.Add(dgvBookStatistics);
            Controls.Add(dtbStartTime);
            Controls.Add(btnConfirm);
            Name = "BookReportByDateForm";
            Text = "BookReportByDateForm";
            Load += BookStatisticsOverTimeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookStatistics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private DateTimePicker dtbStartTime;
        private DataGridView dgvBookStatistics;
        private DateTimePicker dtbEndTime;
        private Button btnShowAll;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}