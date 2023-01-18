namespace YienExpressClient
{
    partial class YienExpressLogin
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(352, 149);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(78, 20);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "User Type";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(352, 207);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(354, 261);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(533, 200);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 27);
            this.txtName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(533, 258);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 27);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login.Location = new System.Drawing.Point(533, 352);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(106, 29);
            this.Login.TabIndex = 6;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(708, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 29);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbType
            // 
            this.cmbType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Employee",
            "Coporate_Customer",
            "Normal_Customer"});
            this.cmbType.Location = new System.Drawing.Point(533, 141);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(280, 28);
            this.cmbType.TabIndex = 8;
            // 
            // YienExpressLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 460);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblType);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "YienExpressLogin";
            this.Text = "YienExpressLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.YienExpressLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblType;
        private Label lblName;
        private Label lblPassword;
        private TextBox txtName;
        private TextBox txtPassword;
        private Button Login;
        private Button btnExit;
        private ComboBox cmbType;
    }
}