namespace GUI_UI
{
    partial class ChangePasswordForm
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
            btnExit = new Button();
            btnChangePassword = new Button();
            chkShowConfirmNewPassword = new CheckBox();
            chkShowNewPassword = new CheckBox();
            chkShowOldPassword = new CheckBox();
            txtConfirmNewPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtOldPassword = new TextBox();
            txtUserName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnChangePassword);
            groupBox1.Controls.Add(chkShowConfirmNewPassword);
            groupBox1.Controls.Add(chkShowNewPassword);
            groupBox1.Controls.Add(chkShowOldPassword);
            groupBox1.Controls.Add(txtConfirmNewPassword);
            groupBox1.Controls.Add(txtNewPassword);
            groupBox1.Controls.Add(txtOldPassword);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(622, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1046, 1084);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(213, 203, 239);
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(248, 873);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(567, 75);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(213, 203, 239);
            btnChangePassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(248, 745);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(567, 75);
            btnChangePassword.TabIndex = 4;
            btnChangePassword.Text = "Đổi mật khẩu";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // chkShowConfirmNewPassword
            // 
            chkShowConfirmNewPassword.AutoSize = true;
            chkShowConfirmNewPassword.Location = new Point(489, 628);
            chkShowConfirmNewPassword.Name = "chkShowConfirmNewPassword";
            chkShowConfirmNewPassword.Size = new Size(221, 41);
            chkShowConfirmNewPassword.TabIndex = 3;
            chkShowConfirmNewPassword.Text = "Hiện mật khẩu";
            chkShowConfirmNewPassword.UseVisualStyleBackColor = true;
            chkShowConfirmNewPassword.CheckedChanged += chkShowConfirmNewPassword_CheckedChanged;
            // 
            // chkShowNewPassword
            // 
            chkShowNewPassword.AutoSize = true;
            chkShowNewPassword.Location = new Point(489, 493);
            chkShowNewPassword.Name = "chkShowNewPassword";
            chkShowNewPassword.Size = new Size(221, 41);
            chkShowNewPassword.TabIndex = 3;
            chkShowNewPassword.Text = "Hiện mật khẩu";
            chkShowNewPassword.UseVisualStyleBackColor = true;
            chkShowNewPassword.CheckedChanged += chkShowNewPassword_CheckedChanged;
            // 
            // chkShowOldPassword
            // 
            chkShowOldPassword.AutoSize = true;
            chkShowOldPassword.Location = new Point(489, 371);
            chkShowOldPassword.Name = "chkShowOldPassword";
            chkShowOldPassword.Size = new Size(221, 41);
            chkShowOldPassword.TabIndex = 3;
            chkShowOldPassword.Text = "Hiện mật khẩu";
            chkShowOldPassword.UseVisualStyleBackColor = true;
            chkShowOldPassword.CheckedChanged += chkShowOldPassword_CheckedChanged;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(489, 579);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(449, 43);
            txtConfirmNewPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(489, 444);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(449, 43);
            txtNewPassword.TabIndex = 2;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(489, 322);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(449, 43);
            txtOldPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(489, 199);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(449, 43);
            txtUserName.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(125, 573);
            label5.Name = "label5";
            label5.Size = new Size(321, 48);
            label5.TabIndex = 1;
            label5.Text = "Xác nhận mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(125, 439);
            label4.Name = "label4";
            label4.Size = new Size(240, 48);
            label4.TabIndex = 1;
            label4.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(125, 310);
            label3.Name = "label3";
            label3.Size = new Size(215, 48);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(125, 193);
            label2.Name = "label2";
            label2.Size = new Size(253, 48);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 76);
            label1.Name = "label1";
            label1.Size = new Size(370, 65);
            label1.TabIndex = 0;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._390741178_c08f2dd8_1af4_4640_a288_5f775936bead;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2267, 1330);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2272, 1321);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnExit;
        private Button btnChangePassword;
        private TextBox txtOldPassword;
        private TextBox txtUserName;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox chkShowOldPassword;
        private TextBox txtNewPassword;
        private Label label4;
        private CheckBox chkShowConfirmNewPassword;
        private CheckBox chkShowNewPassword;
        private TextBox txtConfirmNewPassword;
        private Label label5;
    }
}