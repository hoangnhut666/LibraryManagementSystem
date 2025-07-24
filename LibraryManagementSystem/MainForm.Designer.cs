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
            đổiToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            quảnLýThểLoạiSáchToolStripMenuItem = new ToolStripMenuItem();
            menuItemAuthorManagement = new ToolStripMenuItem();
            menuItemBookManagement = new ToolStripMenuItem();
            quảnLýThànhViênToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItemLoanDashboard = new ToolStripMenuItem();
            ToolStripMenuItemUserManagement = new ToolStripMenuItem();
            ToolStripMenuItemFineManagement = new ToolStripMenuItem();
            menuItemBookCopiesManagement = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            hỗTrợToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItemSupport = new ToolStripMenuItem();
            ToolStripMenuItemIntroduce = new ToolStripMenuItem();
            panelMainContainer = new Panel();
            label1 = new Label();
            label2 = new Label();
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
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { đổiToolStripMenuItem, đăngXuấtToolStripMenuItem });
            toolStripMenuItem1.Image = Properties.Resources.user;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(208, 43);
            toolStripMenuItem1.Text = " Tài khoản  ";
            // 
            // đổiToolStripMenuItem
            // 
            đổiToolStripMenuItem.Image = Properties.Resources.reset_password;
            đổiToolStripMenuItem.Name = "đổiToolStripMenuItem";
            đổiToolStripMenuItem.Size = new Size(326, 48);
            đổiToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Image = Properties.Resources.exit;
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(326, 48);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýThểLoạiSáchToolStripMenuItem, menuItemAuthorManagement, menuItemBookManagement, quảnLýThànhViênToolStripMenuItem, ToolStripMenuItemLoanDashboard, ToolStripMenuItemUserManagement, ToolStripMenuItemFineManagement });
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
            // quảnLýThànhViênToolStripMenuItem
            // 
            quảnLýThànhViênToolStripMenuItem.Image = Properties.Resources.member;
            quảnLýThànhViênToolStripMenuItem.Name = "quảnLýThànhViênToolStripMenuItem";
            quảnLýThànhViênToolStripMenuItem.Size = new Size(413, 48);
            quảnLýThànhViênToolStripMenuItem.Text = "Quản lý thành viên";
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
            ToolStripMenuItemSupport.Size = new Size(403, 48);
            ToolStripMenuItemSupport.Text = "Trợ giúp";
            ToolStripMenuItemSupport.Click += ToolStripMenuItemSupport_Click;
            // 
            // ToolStripMenuItemIntroduce
            // 
            ToolStripMenuItemIntroduce.Image = Properties.Resources.presentation;
            ToolStripMenuItemIntroduce.Name = "ToolStripMenuItemIntroduce";
            ToolStripMenuItemIntroduce.Size = new Size(403, 48);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(1771, 12);
            label1.Name = "label1";
            label1.Size = new Size(170, 45);
            label1.TabIndex = 0;
            label1.Text = "Chào bạn!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1954, 12);
            label2.Name = "label2";
            label2.Size = new Size(119, 45);
            label2.TabIndex = 0;
            label2.Text = "Admin";
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
            Controls.Add(label2);
            Controls.Add(panelMainContainer);
            Controls.Add(label1);
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
        private ToolStripMenuItem quảnLýThànhViênToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItemLoanDashboard;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private Panel panelMainContainer;
        private Label label1;
        private Label label2;
        private ToolStripMenuItem đổiToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
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
    }
}