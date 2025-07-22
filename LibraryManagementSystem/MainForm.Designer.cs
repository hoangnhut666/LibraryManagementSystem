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
            quảnLýMượnTrảToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            hỗTrợToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            giớiThiệuToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, quảnLýToolStripMenuItem, báoCáoToolStripMenuItem, hỗTrợToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(941, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { đổiToolStripMenuItem, đăngXuấtToolStripMenuItem });
            toolStripMenuItem1.Image = Properties.Resources.user;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(133, 40);
            toolStripMenuItem1.Text = " Tài khoản  ";
            // 
            // đổiToolStripMenuItem
            // 
            đổiToolStripMenuItem.Image = Properties.Resources.reset_password;
            đổiToolStripMenuItem.Name = "đổiToolStripMenuItem";
            đổiToolStripMenuItem.Size = new Size(181, 26);
            đổiToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Image = Properties.Resources.exit;
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(181, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLýThểLoạiSáchToolStripMenuItem, menuItemAuthorManagement, menuItemBookManagement, quảnLýThànhViênToolStripMenuItem, quảnLýMượnTrảToolStripMenuItem });
            quảnLýToolStripMenuItem.Image = Properties.Resources.project_manager;
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(117, 40);
            quảnLýToolStripMenuItem.Text = "Quản lý  ";
            // 
            // quảnLýThểLoạiSáchToolStripMenuItem
            // 
            quảnLýThểLoạiSáchToolStripMenuItem.Image = Properties.Resources.options;
            quảnLýThểLoạiSáchToolStripMenuItem.Name = "quảnLýThểLoạiSáchToolStripMenuItem";
            quảnLýThểLoạiSáchToolStripMenuItem.Size = new Size(229, 26);
            quảnLýThểLoạiSáchToolStripMenuItem.Text = "Quản lý thể loại sách";
            // 
            // menuItemAuthorManagement
            // 
            menuItemAuthorManagement.Image = Properties.Resources.authorize;
            menuItemAuthorManagement.Name = "menuItemAuthorManagement";
            menuItemAuthorManagement.Size = new Size(229, 26);
            menuItemAuthorManagement.Text = "Quản lý tác giả";
            menuItemAuthorManagement.Click += menuItemAuthorManagement_Click;
            // 
            // menuItemBookManagement
            // 
            menuItemBookManagement.Image = Properties.Resources.book;
            menuItemBookManagement.Name = "menuItemBookManagement";
            menuItemBookManagement.Size = new Size(229, 26);
            menuItemBookManagement.Text = "Quản lý sách";
            menuItemBookManagement.Click += menuItemBookManagement_Click;
            // 
            // quảnLýThànhViênToolStripMenuItem
            // 
            quảnLýThànhViênToolStripMenuItem.Image = Properties.Resources.member;
            quảnLýThànhViênToolStripMenuItem.Name = "quảnLýThànhViênToolStripMenuItem";
            quảnLýThànhViênToolStripMenuItem.Size = new Size(229, 26);
            quảnLýThànhViênToolStripMenuItem.Text = "Quản lý thành viên";
            // 
            // quảnLýMượnTrảToolStripMenuItem
            // 
            quảnLýMượnTrảToolStripMenuItem.Image = Properties.Resources.cash_flow;
            quảnLýMượnTrảToolStripMenuItem.Name = "quảnLýMượnTrảToolStripMenuItem";
            quảnLýMượnTrảToolStripMenuItem.Size = new Size(229, 26);
            quảnLýMượnTrảToolStripMenuItem.Text = "Quản lý mượn trả";
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.Image = Properties.Resources.increase;
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(113, 40);
            báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // hỗTrợToolStripMenuItem
            // 
            hỗTrợToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trợGiúpToolStripMenuItem, giớiThiệuToolStripMenuItem });
            hỗTrợToolStripMenuItem.Image = Properties.Resources.help;
            hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            hỗTrợToolStripMenuItem.Size = new Size(102, 40);
            hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.Image = Properties.Resources.helping_hand;
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(240, 42);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            trợGiúpToolStripMenuItem.Click += trợGiúpToolStripMenuItem_Click;
            // 
            // giớiThiệuToolStripMenuItem
            // 
            giớiThiệuToolStripMenuItem.Image = Properties.Resources.presentation;
            giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            giớiThiệuToolStripMenuItem.Size = new Size(156, 26);
            giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            giớiThiệuToolStripMenuItem.Click += giớiThiệuToolStripMenuItem_Click;
            // 
            // panelMainContainer
            // 
            panelMainContainer.Location = new Point(18, 32);
            panelMainContainer.Margin = new Padding(2);
            panelMainContainer.Name = "panelMainContainer";
            panelMainContainer.Size = new Size(1227, 751);
            panelMainContainer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(945, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "Chào bạn!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1042, 6);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 0;
            label2.Text = "Admin";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(36, 36);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSystemInfo, toolStripStatusLabel2, lblClock });
            statusStrip1.Location = new Point(0, 480);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 7, 0);
            statusStrip1.Size = new Size(941, 42);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblSystemInfo
            // 
            lblSystemInfo.Image = Properties.Resources.logo2;
            lblSystemInfo.Name = "lblSystemInfo";
            lblSystemInfo.Size = new Size(117, 36);
            lblSystemInfo.Text = "PolyLibrary";
            lblSystemInfo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(690, 36);
            toolStripStatusLabel2.Spring = true;
            // 
            // lblClock
            // 
            lblClock.Image = Properties.Resources.alarm;
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(126, 36);
            lblClock.Text = "CurrentTime";
            lblClock.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 522);
            Controls.Add(statusStrip1);
            Controls.Add(label2);
            Controls.Add(panelMainContainer);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Margin = new Padding(2);
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
        private ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem;
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
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}