namespace YienExpressClient
{
    partial class YienExpressMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YienExpressMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.welcomeToYienExpressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCoporateCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageNormalCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPackagesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeToYienExpressToolStripMenuItem,
            this.packageToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.viewPackagesToolStripMenuItem1,
            this.addOrdersToolStripMenuItem,
            this.viewOrdersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // welcomeToYienExpressToolStripMenuItem
            // 
            this.welcomeToYienExpressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.welcomeToYienExpressToolStripMenuItem.Name = "welcomeToYienExpressToolStripMenuItem";
            this.welcomeToYienExpressToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.welcomeToYienExpressToolStripMenuItem.Text = "Yien Express Courier Services";
            this.welcomeToYienExpressToolStripMenuItem.Click += new System.EventHandler(this.welcomeToYienExpressToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // packageToolStripMenuItem
            // 
            this.packageToolStripMenuItem.Name = "packageToolStripMenuItem";
            this.packageToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.packageToolStripMenuItem.Text = "Manage Packages";
            this.packageToolStripMenuItem.Click += new System.EventHandler(this.packageToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.orderToolStripMenuItem.Text = "Manage Orders";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCoporateCustomersToolStripMenuItem,
            this.manageNormalCustomersToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.customerToolStripMenuItem.Text = "Manage Customers";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // manageCoporateCustomersToolStripMenuItem
            // 
            this.manageCoporateCustomersToolStripMenuItem.Name = "manageCoporateCustomersToolStripMenuItem";
            this.manageCoporateCustomersToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.manageCoporateCustomersToolStripMenuItem.Text = "Manage Coporate Customers";
            this.manageCoporateCustomersToolStripMenuItem.Click += new System.EventHandler(this.manageCoporateCustomersToolStripMenuItem_Click);
            // 
            // manageNormalCustomersToolStripMenuItem
            // 
            this.manageNormalCustomersToolStripMenuItem.Name = "manageNormalCustomersToolStripMenuItem";
            this.manageNormalCustomersToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.manageNormalCustomersToolStripMenuItem.Text = "Manage Normal Customers";
            this.manageNormalCustomersToolStripMenuItem.Click += new System.EventHandler(this.manageNormalCustomersToolStripMenuItem_Click);
            // 
            // viewPackagesToolStripMenuItem1
            // 
            this.viewPackagesToolStripMenuItem1.Name = "viewPackagesToolStripMenuItem1";
            this.viewPackagesToolStripMenuItem1.Size = new System.Drawing.Size(119, 24);
            this.viewPackagesToolStripMenuItem1.Text = "View Packages";
            this.viewPackagesToolStripMenuItem1.Click += new System.EventHandler(this.viewPackagesToolStripMenuItem1_Click);
            // 
            // addOrdersToolStripMenuItem
            // 
            this.addOrdersToolStripMenuItem.Name = "addOrdersToolStripMenuItem";
            this.addOrdersToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.addOrdersToolStripMenuItem.Text = "Add Orders";
            this.addOrdersToolStripMenuItem.Click += new System.EventHandler(this.addOrdersToolStripMenuItem_Click_1);
            // 
            // viewOrdersToolStripMenuItem
            // 
            this.viewOrdersToolStripMenuItem.Name = "viewOrdersToolStripMenuItem";
            this.viewOrdersToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.viewOrdersToolStripMenuItem.Text = "View Orders";
            this.viewOrdersToolStripMenuItem.Click += new System.EventHandler(this.viewOrdersToolStripMenuItem_Click);
            // 
            // YienExpressMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1104, 430);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "YienExpressMain";
            this.Text = "Yien Express Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.YienEmployee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem packageToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem welcomeToYienExpressToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem viewPackagesToolStripMenuItem1;
        private ToolStripMenuItem addOrdersToolStripMenuItem;
        private ToolStripMenuItem viewOrdersToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem manageCoporateCustomersToolStripMenuItem;
        private ToolStripMenuItem manageNormalCustomersToolStripMenuItem;
    }
}