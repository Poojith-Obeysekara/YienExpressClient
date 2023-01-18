namespace YienExpressClient
{
    partial class UpdateOrder
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTrack = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            this.dgvOrder.Location = new System.Drawing.Point(594, 36);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(846, 421);
            this.dgvOrder.TabIndex = 8;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.Width = 125;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1275, 483);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(38, 19);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 20);
            this.lblID.TabIndex = 30;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(942, 483);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 36);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(594, 483);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 36);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPackage
            // 
            this.txtPackage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPackage.Location = new System.Drawing.Point(216, 36);
            this.txtPackage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(334, 27);
            this.txtPackage.TabIndex = 66;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Location = new System.Drawing.Point(216, 91);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(334, 27);
            this.txtQuantity.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(26, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 64;
            this.label9.Text = "Package Name";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(26, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 63;
            this.label10.Text = "Quantity";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(216, 285);
            this.dtpDeliveryDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(334, 27);
            this.dtpDeliveryDate.TabIndex = 62;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpOrderDate.Location = new System.Drawing.Point(216, 233);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(334, 27);
            this.dtpOrderDate.TabIndex = 61;
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocation.Location = new System.Drawing.Point(216, 385);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(334, 27);
            this.txtLocation.TabIndex = 60;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc.Location = new System.Drawing.Point(216, 331);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(334, 27);
            this.txtDesc.TabIndex = 59;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTel.Location = new System.Drawing.Point(216, 186);
            this.txtTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(334, 27);
            this.txtTel.TabIndex = 58;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomer.Location = new System.Drawing.Point(216, 147);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(334, 27);
            this.txtCustomer.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Delivery Location";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Order Description";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Expected Delivery Date";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Date of Order";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Customer Tel";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(26, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Customer Name";
            // 
            // txtTrack
            // 
            this.txtTrack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrack.Location = new System.Drawing.Point(216, 430);
            this.txtTrack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrack.Name = "txtTrack";
            this.txtTrack.Size = new System.Drawing.Size(334, 27);
            this.txtTrack.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Track Status";
            // 
            // UpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1452, 531);
            this.Controls.Add(this.txtTrack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPackage);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "UpdateOrder";
            this.Text = "UpdateOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpdateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvOrder;
        private Button button2;
        private Label lblID;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridViewButtonColumn Edit;
        private TextBox txtPackage;
        private TextBox txtQuantity;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpDeliveryDate;
        private DateTimePicker dtpOrderDate;
        private TextBox txtLocation;
        private TextBox txtDesc;
        private TextBox txtTel;
        private TextBox txtCustomer;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label7;
        private Label label8;
        private TextBox txtTrack;
        private Label label1;
    }
}