namespace YienExpressClient
{
    partial class CustomerDetails
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
            this.lblID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(22, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 20);
            this.lblID.TabIndex = 33;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(122, 378);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 29);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(22, 378);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 29);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(227, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 29);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvCustomers.Location = new System.Drawing.Point(488, 70);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 29;
            this.dgvCustomers.Size = new System.Drawing.Size(743, 337);
            this.dgvCustomers.TabIndex = 27;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(22, 289);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(404, 27);
            this.txtEmail.TabIndex = 24;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(22, 266);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Location = new System.Drawing.Point(22, 223);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(404, 27);
            this.txtPhone.TabIndex = 22;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(22, 200);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 20);
            this.lblPhone.TabIndex = 21;
            this.lblPhone.Text = "Phone";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Location = new System.Drawing.Point(22, 158);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(404, 27);
            this.txtAddress.TabIndex = 20;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(22, 135);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 20);
            this.lblAddress.TabIndex = 19;
            this.lblAddress.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(22, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(404, 27);
            this.txtName.TabIndex = 18;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 20);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(343, 378);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 29);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1289, 479);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "CustomerDetails";
            this.Text = "CustomerDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblID;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridViewButtonColumn Column1;
        private Button btnDelete;
        private DataGridView dgvCustomers;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtName;
        private Label lblName;
        private Button btnBack;
    }
}