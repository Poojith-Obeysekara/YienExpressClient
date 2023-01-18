namespace YienExpressClient
{
    partial class PackageDetails
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtReorder = new System.Windows.Forms.TextBox();
            this.lblReorder = new System.Windows.Forms.Label();
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(53, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(388, 27);
            this.txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Location = new System.Drawing.Point(53, 142);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(388, 27);
            this.txtPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(53, 119);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStock.Location = new System.Drawing.Point(53, 207);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(388, 27);
            this.txtStock.TabIndex = 5;
            // 
            // lblStock
            // 
            this.lblStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(53, 184);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(46, 20);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock";
            // 
            // txtReorder
            // 
            this.txtReorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReorder.Location = new System.Drawing.Point(53, 273);
            this.txtReorder.Name = "txtReorder";
            this.txtReorder.Size = new System.Drawing.Size(388, 27);
            this.txtReorder.TabIndex = 7;
            // 
            // lblReorder
            // 
            this.lblReorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReorder.AutoSize = true;
            this.lblReorder.Location = new System.Drawing.Point(53, 250);
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.Size = new System.Drawing.Size(100, 20);
            this.lblReorder.TabIndex = 6;
            this.lblReorder.Text = "Reorder level";
            // 
            // dgvPackages
            // 
            this.dgvPackages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvPackages.Location = new System.Drawing.Point(518, 39);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.RowHeadersWidth = 51;
            this.dgvPackages.RowTemplate.Height = 29;
            this.dgvPackages.Size = new System.Drawing.Size(827, 437);
            this.dgvPackages.TabIndex = 10;
            this.dgvPackages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackages_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Edit";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(53, 448);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 29);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(151, 448);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 29);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(251, 448);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 29);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(53, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 20);
            this.lblID.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategory.Location = new System.Drawing.Point(53, 363);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(388, 27);
            this.txtCategory.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(358, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PackageDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1372, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPackages);
            this.Controls.Add(this.txtReorder);
            this.Controls.Add(this.lblReorder);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "PackageDetails";
            this.Text = "Manage Packages";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtStock;
        private Label lblStock;
        private TextBox txtReorder;
        private Label lblReorder;
        private DataGridView dgvPackages;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridViewButtonColumn Column1;
        private Label lblID;
        private Label label1;
        private TextBox txtCategory;
        private Button button1;
    }
}