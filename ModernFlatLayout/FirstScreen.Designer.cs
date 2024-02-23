namespace ModernFlatLayout
{
    partial class FirstScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PanelMenu = new Panel();
            IconButtonSetting = new FontAwesome.Sharp.IconButton();
            IconButtonMarketing = new FontAwesome.Sharp.IconButton();
            IconButtonProducts = new FontAwesome.Sharp.IconButton();
            IconButtonOrders = new FontAwesome.Sharp.IconButton();
            IconButtonDashboard = new FontAwesome.Sharp.IconButton();
            PanelLogo = new Panel();
            PBBtnHome = new PictureBox();
            PanelHeader = new Panel();
            IconButtonFullScreen = new FontAwesome.Sharp.IconButton();
            IconButtonClose = new FontAwesome.Sharp.IconButton();
            IconButtonMaximize = new FontAwesome.Sharp.IconButton();
            IconButtonMinimize = new FontAwesome.Sharp.IconButton();
            LabelHome = new Label();
            IconButtonHome = new FontAwesome.Sharp.IconButton();
            PanelDesktop = new Panel();
            FormTimer = new System.Windows.Forms.Timer(components);
            PanelMenu.SuspendLayout();
            PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBBtnHome).BeginInit();
            PanelHeader.SuspendLayout();
            PanelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(31, 30, 68);
            PanelMenu.Controls.Add(IconButtonSetting);
            PanelMenu.Controls.Add(IconButtonMarketing);
            PanelMenu.Controls.Add(IconButtonProducts);
            PanelMenu.Controls.Add(IconButtonOrders);
            PanelMenu.Controls.Add(IconButtonDashboard);
            PanelMenu.Controls.Add(PanelLogo);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(220, 679);
            PanelMenu.TabIndex = 0;
            // 
            // IconButtonSetting
            // 
            IconButtonSetting.Dock = DockStyle.Top;
            IconButtonSetting.FlatAppearance.BorderSize = 0;
            IconButtonSetting.FlatStyle = FlatStyle.Flat;
            IconButtonSetting.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconButtonSetting.ForeColor = Color.White;
            IconButtonSetting.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            IconButtonSetting.IconColor = Color.White;
            IconButtonSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButtonSetting.IconSize = 32;
            IconButtonSetting.ImageAlign = ContentAlignment.MiddleLeft;
            IconButtonSetting.Location = new Point(0, 321);
            IconButtonSetting.Name = "IconButtonSetting";
            IconButtonSetting.Padding = new Padding(10, 0, 20, 0);
            IconButtonSetting.Size = new Size(220, 60);
            IconButtonSetting.TabIndex = 4;
            IconButtonSetting.Text = "Setting";
            IconButtonSetting.TextAlign = ContentAlignment.MiddleLeft;
            IconButtonSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            IconButtonSetting.UseVisualStyleBackColor = true;
            IconButtonSetting.Click += BtnSettingClick;
            // 
            // IconButtonMarketing
            // 
            IconButtonMarketing.Dock = DockStyle.Top;
            IconButtonMarketing.FlatAppearance.BorderSize = 0;
            IconButtonMarketing.FlatStyle = FlatStyle.Flat;
            IconButtonMarketing.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconButtonMarketing.ForeColor = Color.White;
            IconButtonMarketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            IconButtonMarketing.IconColor = Color.White;
            IconButtonMarketing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButtonMarketing.IconSize = 32;
            IconButtonMarketing.ImageAlign = ContentAlignment.MiddleLeft;
            IconButtonMarketing.Location = new Point(0, 261);
            IconButtonMarketing.Name = "IconButtonMarketing";
            IconButtonMarketing.Padding = new Padding(10, 0, 20, 0);
            IconButtonMarketing.Size = new Size(220, 60);
            IconButtonMarketing.TabIndex = 3;
            IconButtonMarketing.Text = "Marketing";
            IconButtonMarketing.TextAlign = ContentAlignment.MiddleLeft;
            IconButtonMarketing.TextImageRelation = TextImageRelation.ImageBeforeText;
            IconButtonMarketing.UseVisualStyleBackColor = true;
            IconButtonMarketing.Click += BtnMarketingClick;
            // 
            // IconButtonProducts
            // 
            IconButtonProducts.Dock = DockStyle.Top;
            IconButtonProducts.FlatAppearance.BorderSize = 0;
            IconButtonProducts.FlatStyle = FlatStyle.Flat;
            IconButtonProducts.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconButtonProducts.ForeColor = Color.White;
            IconButtonProducts.IconChar = FontAwesome.Sharp.IconChar.Tag;
            IconButtonProducts.IconColor = Color.White;
            IconButtonProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButtonProducts.IconSize = 32;
            IconButtonProducts.ImageAlign = ContentAlignment.MiddleLeft;
            IconButtonProducts.Location = new Point(0, 201);
            IconButtonProducts.Name = "IconButtonProducts";
            IconButtonProducts.Padding = new Padding(10, 0, 20, 0);
            IconButtonProducts.Size = new Size(220, 60);
            IconButtonProducts.TabIndex = 2;
            IconButtonProducts.Text = "Products";
            IconButtonProducts.TextAlign = ContentAlignment.MiddleLeft;
            IconButtonProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            IconButtonProducts.UseVisualStyleBackColor = true;
            IconButtonProducts.Click += BtnProductsClick;
            // 
            // IconButtonOrders
            // 
            IconButtonOrders.Dock = DockStyle.Top;
            IconButtonOrders.FlatAppearance.BorderSize = 0;
            IconButtonOrders.FlatStyle = FlatStyle.Flat;
            IconButtonOrders.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconButtonOrders.ForeColor = Color.White;
            IconButtonOrders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            IconButtonOrders.IconColor = Color.White;
            IconButtonOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButtonOrders.IconSize = 32;
            IconButtonOrders.ImageAlign = ContentAlignment.MiddleLeft;
            IconButtonOrders.Location = new Point(0, 141);
            IconButtonOrders.Name = "IconButtonOrders";
            IconButtonOrders.Padding = new Padding(10, 0, 20, 0);
            IconButtonOrders.Size = new Size(220, 60);
            IconButtonOrders.TabIndex = 1;
            IconButtonOrders.Text = "Orders";
            IconButtonOrders.TextAlign = ContentAlignment.MiddleLeft;
            IconButtonOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            IconButtonOrders.UseVisualStyleBackColor = true;
            IconButtonOrders.Click += BtnOrdersClick;
            // 
            // IconButtonDashboard
            // 
            IconButtonDashboard.Dock = DockStyle.Top;
            IconButtonDashboard.FlatAppearance.BorderSize = 0;
            IconButtonDashboard.FlatStyle = FlatStyle.Flat;
            IconButtonDashboard.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IconButtonDashboard.ForeColor = Color.White;
            IconButtonDashboard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            IconButtonDashboard.IconColor = Color.White;
            IconButtonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButtonDashboard.IconSize = 32;
            IconButtonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            IconButtonDashboard.Location = new Point(0, 81);
            IconButtonDashboard.Name = "IconButtonDashboard";
            IconButtonDashboard.Padding = new Padding(10, 0, 20, 0);
            IconButtonDashboard.Size = new Size(220, 60);
            IconButtonDashboard.TabIndex = 0;
            IconButtonDashboard.Text = "Dashboard";
            IconButtonDashboard.TextAlign = ContentAlignment.MiddleLeft;
            IconButtonDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            IconButtonDashboard.UseVisualStyleBackColor = true;
            IconButtonDashboard.Click += BtnDashboardClick;
            // 
            // PanelLogo
            // 
            PanelLogo.Controls.Add(PBBtnHome);
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(220, 81);
            PanelLogo.TabIndex = 0;
            // 
            // PBBtnHome
            // 
            PBBtnHome.Cursor = Cursors.Hand;
            PBBtnHome.Image = Properties.Resources.C_1;
            PBBtnHome.Location = new Point(0, 0);
            PBBtnHome.Name = "PBBtnHome";
            PBBtnHome.Size = new Size(220, 81);
            PBBtnHome.SizeMode = PictureBoxSizeMode.Zoom;
            PBBtnHome.TabIndex = 0;
            PBBtnHome.TabStop = false;
            PBBtnHome.Click += PBBtnHomeClick;
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(26, 25, 62);
            PanelHeader.Controls.Add(IconButtonFullScreen);
            PanelHeader.Controls.Add(IconButtonClose);
            PanelHeader.Controls.Add(IconButtonMaximize);
            PanelHeader.Controls.Add(IconButtonMinimize);
            PanelHeader.Controls.Add(LabelHome);
            PanelHeader.Controls.Add(IconButtonHome);
            PanelHeader.Dock = DockStyle.Top;
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1149, 78);
            PanelHeader.TabIndex = 1;
            PanelHeader.MouseDown += PanelHeaderMouseDown;
            // 
            // IconButtonFullScreen
            // 
            IconButtonFullScreen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconButtonFullScreen.Cursor = Cursors.Hand;
            IconButtonFullScreen.FlatAppearance.BorderSize = 0;
            IconButtonFullScreen.FlatStyle = FlatStyle.Flat;
            IconButtonFullScreen.IconChar = FontAwesome.Sharp.IconChar.ExpandArrowsAlt;
            IconButtonFullScreen.IconColor = Color.Gainsboro;
            IconButtonFullScreen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButtonFullScreen.IconSize = 32;
            IconButtonFullScreen.Location = new Point(989, 12);
            IconButtonFullScreen.Name = "IconButtonFullScreen";
            IconButtonFullScreen.Size = new Size(25, 24);
            IconButtonFullScreen.TabIndex = 5;
            IconButtonFullScreen.UseVisualStyleBackColor = true;
            IconButtonFullScreen.Click += BtnFullScreenClick;
            // 
            // IconButtonClose
            // 
            IconButtonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconButtonClose.Cursor = Cursors.Hand;
            IconButtonClose.FlatAppearance.BorderSize = 0;
            IconButtonClose.FlatStyle = FlatStyle.Flat;
            IconButtonClose.IconChar = FontAwesome.Sharp.IconChar.X;
            IconButtonClose.IconColor = Color.Gainsboro;
            IconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButtonClose.IconSize = 32;
            IconButtonClose.Location = new Point(1109, 12);
            IconButtonClose.Name = "IconButtonClose";
            IconButtonClose.Size = new Size(25, 24);
            IconButtonClose.TabIndex = 4;
            IconButtonClose.UseVisualStyleBackColor = true;
            IconButtonClose.Click += BtnCloseClick;
            // 
            // IconButtonMaximize
            // 
            IconButtonMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconButtonMaximize.Cursor = Cursors.Hand;
            IconButtonMaximize.FlatAppearance.BorderSize = 0;
            IconButtonMaximize.FlatStyle = FlatStyle.Flat;
            IconButtonMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            IconButtonMaximize.IconColor = Color.Gainsboro;
            IconButtonMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButtonMaximize.IconSize = 32;
            IconButtonMaximize.Location = new Point(1078, 12);
            IconButtonMaximize.Name = "IconButtonMaximize";
            IconButtonMaximize.Size = new Size(25, 24);
            IconButtonMaximize.TabIndex = 3;
            IconButtonMaximize.UseVisualStyleBackColor = true;
            IconButtonMaximize.Click += BtnMaximizeClick;
            // 
            // IconButtonMinimize
            // 
            IconButtonMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconButtonMinimize.Cursor = Cursors.Hand;
            IconButtonMinimize.FlatAppearance.BorderSize = 0;
            IconButtonMinimize.FlatStyle = FlatStyle.Flat;
            IconButtonMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            IconButtonMinimize.IconColor = Color.Gainsboro;
            IconButtonMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButtonMinimize.IconSize = 32;
            IconButtonMinimize.Location = new Point(1045, 25);
            IconButtonMinimize.Name = "IconButtonMinimize";
            IconButtonMinimize.Size = new Size(27, 11);
            IconButtonMinimize.TabIndex = 2;
            IconButtonMinimize.UseVisualStyleBackColor = true;
            IconButtonMinimize.Click += BtnMinimizeClick;
            // 
            // LabelHome
            // 
            LabelHome.AutoSize = true;
            LabelHome.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelHome.ForeColor = Color.White;
            LabelHome.Location = new Point(74, 25);
            LabelHome.Name = "LabelHome";
            LabelHome.Size = new Size(54, 20);
            LabelHome.TabIndex = 1;
            LabelHome.Text = "Home";
            // 
            // IconButtonHome
            // 
            IconButtonHome.FlatAppearance.BorderSize = 0;
            IconButtonHome.FlatStyle = FlatStyle.Flat;
            IconButtonHome.ForeColor = SystemColors.ControlText;
            IconButtonHome.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            IconButtonHome.IconColor = Color.MediumPurple;
            IconButtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButtonHome.Location = new Point(24, 12);
            IconButtonHome.Name = "IconButtonHome";
            IconButtonHome.Size = new Size(44, 47);
            IconButtonHome.TabIndex = 0;
            IconButtonHome.UseVisualStyleBackColor = true;
            // 
            // PanelDesktop
            // 
            PanelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            PanelDesktop.Controls.Add(PanelHeader);
            PanelDesktop.Dock = DockStyle.Fill;
            PanelDesktop.Location = new Point(220, 0);
            PanelDesktop.Name = "PanelDesktop";
            PanelDesktop.Size = new Size(1149, 679);
            PanelDesktop.TabIndex = 3;
            // 
            // FormTimer
            // 
            FormTimer.Enabled = true;
            FormTimer.Tick += TimerListener;
            // 
            // FirstScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1369, 679);
            ControlBox = false;
            Controls.Add(PanelDesktop);
            Controls.Add(PanelMenu);
            MinimumSize = new Size(1387, 697);
            Name = "FirstScreen";
            TransparencyKey = Color.Black;
            PanelMenu.ResumeLayout(false);
            PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBBtnHome).EndInit();
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            PanelDesktop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Panel PanelLogo;
        private FontAwesome.Sharp.IconButton IconButtonDashboard;
        private FontAwesome.Sharp.IconButton IconButtonSetting;
        private FontAwesome.Sharp.IconButton IconButtonMarketing;
        private FontAwesome.Sharp.IconButton IconButtonProducts;
        private FontAwesome.Sharp.IconButton IconButtonOrders;
        private PictureBox PBBtnHome;
        private Panel PanelHeader;
        private FontAwesome.Sharp.IconButton IconButtonClose;
        private FontAwesome.Sharp.IconButton IconButtonMaximize;
        private FontAwesome.Sharp.IconButton IconButtonMinimize;
        private Label LabelHome;
        private FontAwesome.Sharp.IconButton IconButtonHome;
        private Panel PanelDesktop;
        private FontAwesome.Sharp.IconButton IconButtonFullScreen;
        private System.Windows.Forms.Timer FormTimer;
    }
}
