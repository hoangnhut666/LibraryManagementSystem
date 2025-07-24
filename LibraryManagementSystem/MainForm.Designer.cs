namespace GUI_UI
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripMenuItemChangePassword = new ToolStripMenuItem();
            ToolStripMenuItemLogout = new ToolStripMenuItem();
            ToolStripMenuItemRestart = new ToolStripMenuItem();
            ToolStripMenuItemExit = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýThểLoạiSáchToolStripMenuItem = new ToolStripMenuItem();
            menuItemAuthorManagement = new ToolStripMenuItem();
            menuItemBookManagement = new ToolStripMenuItem();
            ToolStripMenuItemMemberManagement = new ToolStripMenuItem();
            ToolStripMenuItemLoanDashboard = new ToolStripMenuItem();
            ToolStripMenuItemUserManagement = new ToolStripMenuItem();
            ToolStripMenuItemFineManagement = new ToolStripMenuItem();
            menuItemBookCopiesManagement = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            hỗTrợToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItemSupport = new ToolStripMenuItem();
            ToolStripMenuItemIntroduce = new ToolStripMenuItem();
            panelMainContainer = new Panel();
            lblWelcome = new Label();
            statusStrip1 = new StatusStrip();
            lblSystemInfo = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(36, 36);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, quảnLýToolStripMenuItem, menuItemBookCopiesManagement, báoCáoToolStripMenuItem, hỗTrợToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2372, 47);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemChangePassword, ToolStripMenuItemLogout, ToolStripMenuItemRestart, ToolStripMenuItemExit });
            toolStripMenuItem1.Image = Properties.Resources.user;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(208, 43);
            toolStripMenuItem1.Text = " Tài khoản  ";
            // 
            // ToolStripMenuItemChangePassword
            // 
            ToolStripMenuItemChangePassword.Image = Properties.Resources.reset_password;
            ToolStripMenuItemChangePassword.Name = "ToolStripMenuItemChangePassword";
            ToolStripMenuItemChangePassword.Size = new Size(403, 48);
            ToolStripMenuItemChangePassword.Text = "Đổi mật khẩu";
            ToolStripMenuItemChangePassword.Click += ToolStripMenuItemChangePassword_Click;
            // 
            // ToolStripMenuItemLogout
            // 
            ToolStripMenuItemLogout.Image = Properties.Resources.exit;
            ToolStripMenuItemLogout.Name = "ToolStripMenuItemLogout";
            ToolStripMenuItemLogout.Size = new Size(403, 48);
            ToolStripMenuItemLogout.Text = "Đăng xuất";
            ToolStripMenuItemLogout.Click += ToolStripMenuItemLogout_Click;
            // 
            // ToolStripMenuItemRestart
            // 
            ToolStripMenuItemRestart.Image = Properties.Resources.reloading;
            ToolStripMenuItemRestart.Name = "ToolStripMenuItemRestart";
            ToolStripMenuItemRestart.Size = new Size(403, 48);
            ToolStripMenuItemRestart.Text = "Khởi động lại";
            ToolStripMenuItemRestart.Click += ToolStripMenuItemRestart_Click;
            // 
            // ToolStripMenuItemExit
            // 
            ToolStripMenuItemExit.Image = Properties.Resources.exit1;
            ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            ToolStripMenuItemExit.Size = new Size(403, 48);
            ToolStripMenuItemExit.Text = "Thoát";
            ToolStripMenuItemExit.Click += ToolStripMenuItemExit_Click_1;
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýThểLoạiSáchToolStripMenuItem, menuItemAuthorManagement, menuItemBookManagement, ToolStripMenuItemMemberManagement, ToolStripMenuItemLoanDashboard, ToolStripMenuItemUserManagement, ToolStripMenuItemFineManagement });
            quảnLýToolStripMenuItem.Image = Properties.Resources.project_manager;
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(180, 43);
            quảnLýToolStripMenuItem.Text = "Quản lý  ";
            // 
            // quảnLýThểLoạiSáchToolStripMenuItem
            // 
            quảnLýThểLoạiSáchToolStripMenuItem.Image = Properties.Resources.options;
            quảnLýThểLoạiSáchToolStripMenuItem.Name = "quảnLýThểLoạiSáchToolStripMenuItem";
            quảnLýThểLoạiSáchToolStripMenuItem.Size = new Size(413, 48);
            quảnLýThểLoạiSáchToolStripMenuItem.Text = "Quản lý thể loại sách";
            // 
            // menuItemAuthorManagement
            // 
            menuItemAuthorManagement.Image = Properties.Resources.authorize;
            menuItemAuthorManagement.Name = "menuItemAuthorManagement";
            menuItemAuthorManagement.Size = new Size(413, 48);
            menuItemAuthorManagement.Text = "Quản lý tác giả";
            menuItemAuthorManagement.Click += menuItemAuthorManagement_Click;
            // 
            // menuItemBookManagement
            // 
            menuItemBookManagement.Image = Properties.Resources.book;
            menuItemBookManagement.Name = "menuItemBookManagement";
            menuItemBookManagement.Size = new Size(413, 48);
            menuItemBookManagement.Text = "Quản lý sách";
            menuItemBookManagement.Click += menuItemBookManagement_Click;
            // 
            // ToolStripMenuItemMemberManagement
            // 
            ToolStripMenuItemMemberManagement.Image = Properties.Resources.member;
            ToolStripMenuItemMemberManagement.Name = "ToolStripMenuItemMemberManagement";
            ToolStripMenuItemMemberManagement.Size = new Size(413, 48);
            ToolStripMenuItemMemberManagement.Text = "Quản lý thành viên";
            ToolStripMenuItemMemberManagement.Click += ToolStripMenuItemMemberManagement_Click;
            // 
            // ToolStripMenuItemLoanDashboard
            // 
            ToolStripMenuItemLoanDashboard.Image = Properties.Resources.cash_flow;
            ToolStripMenuItemLoanDashboard.Name = "ToolStripMenuItemLoanDashboard";
            ToolStripMenuItemLoanDashboard.Size = new Size(413, 48);
            ToolStripMenuItemLoanDashboard.Text = "Quản lý mượn trả";
            ToolStripMenuItemLoanDashboard.Click += ToolStripMenuItemLoanDashboard_Click;
            // 
            // ToolStripMenuItemUserManagement
            // 
            ToolStripMenuItemUserManagement.Image = Properties.Resources.librarian;
            ToolStripMenuItemUserManagement.Name = "ToolStripMenuItemUserManagement";
            ToolStripMenuItemUserManagement.Size = new Size(413, 48);
            ToolStripMenuItemUserManagement.Text = "Quản lý người dùng";
            ToolStripMenuItemUserManagement.Click += ToolStripMenuItemUserManagement_Click;
            // 
            // ToolStripMenuItemFineManagement
            // 
            ToolStripMenuItemFineManagement.Image = Properties.Resources.fine;
            ToolStripMenuItemFineManagement.Name = "ToolStripMenuItemFineManagement";
            ToolStripMenuItemFineManagement.Size = new Size(413, 48);
            ToolStripMenuItemFineManagement.Text = "Quản lý khoản phạt";
            ToolStripMenuItemFineManagement.Click += ToolStripMenuItemFineManagement_Click;
            // 
            // menuItemBookCopiesManagement
            // 
            menuItemBookCopiesManagement.Image = Properties.Resources.inventory;
            menuItemBookCopiesManagement.Name = "menuItemBookCopiesManagement";
            menuItemBookCopiesManagement.Size = new Size(228, 43);
            menuItemBookCopiesManagement.Text = "Kiểm kê sách";
            menuItemBookCopiesManagement.Click += menuItemBookCopiesManagement_Click;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.Image = Properties.Resources.increase;
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(169, 43);
            báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // hỗTrợToolStripMenuItem
            // 
            hỗTrợToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemSupport, ToolStripMenuItemIntroduce });
            hỗTrợToolStripMenuItem.Image = Properties.Resources.help;
            hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            hỗTrợToolStripMenuItem.Size = new Size(151, 43);
            hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // ToolStripMenuItemSupport
            // 
            ToolStripMenuItemSupport.Image = Properties.Resources.helping_hand;
            ToolStripMenuItemSupport.Name = "ToolStripMenuItemSupport";
            ToolStripMenuItemSupport.Size = new Size(283, 48);
            ToolStripMenuItemSupport.Text = "Trợ giúp";
            ToolStripMenuItemSupport.Click += ToolStripMenuItemSupport_Click;
            // 
            // ToolStripMenuItemIntroduce
            // 
            ToolStripMenuItemIntroduce.Image = Properties.Resources.presentation;
            ToolStripMenuItemIntroduce.Name = "ToolStripMenuItemIntroduce";
            ToolStripMenuItemIntroduce.Size = new Size(283, 48);
            ToolStripMenuItemIntroduce.Text = "Giới thiệu";
            ToolStripMenuItemIntroduce.Click += ToolStripMenuItemIntroduce_Click;
            // 
            // panelMainContainer
            // 
            panelMainContainer.Location = new Point(34, 60);
            panelMainContainer.Name = "panelMainContainer";
            panelMainContainer.Size = new Size(2300, 1390);
            panelMainContainer.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(1639, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(170, 45);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Chào bạn!";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(36, 36);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSystemInfo, toolStripStatusLabel2, lblClock });
            statusStrip1.Location = new Point(0, 1476);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(2372, 48);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblSystemInfo
            // 
            lblSystemInfo.Image = Properties.Resources.logo2;
            lblSystemInfo.Name = "lblSystemInfo";
            lblSystemInfo.Size = new Size(184, 37);
            lblSystemInfo.Text = "PolyLibrary";
            lblSystemInfo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(1974, 37);
            toolStripStatusLabel2.Spring = true;
            // 
            // lblClock
            // 
            lblClock.Image = Properties.Resources.alarm;
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(199, 37);
            lblClock.Text = "CurrentTime";
            lblClock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2372, 1524);
            Controls.Add(statusStrip1);
            Controls.Add(panelMainContainer);
            Controls.Add(lblWelcome);
            Controls.Add(menuStrip1);
            Name = "MainForm";
            Text = "Trang chủ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem quảnLýThểLoạiSáchToolStripMenuItem;
        private ToolStripMenuItem menuItemAuthorManagement;
        private ToolStripMenuItem menuItemBookManagement;
        private ToolStripMenuItem ToolStripMenuItemMemberManagement;
        private ToolStripMenuItem ToolStripMenuItemLoanDashboard;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private Panel panelMainContainer;
        private Label lblWelcome;
        private ToolStripMenuItem ToolStripMenuItemChangePassword;
        private ToolStripMenuItem ToolStripMenuItemLogout;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSystemInfo;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblClock;
        private ToolStripMenuItem hỗTrợToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItemSupport;
        private ToolStripMenuItem ToolStripMenuItemIntroduce;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem menuItemBookCopiesManagement;
        private ToolStripMenuItem ToolStripMenuItemUserManagement;
        private ToolStripMenuItem ToolStripMenuItemFineManagement;
        private ToolStripMenuItem ToolStripMenuItemRestart;
        private ToolStripMenuItem ToolStripMenuItemExit;
    }
}