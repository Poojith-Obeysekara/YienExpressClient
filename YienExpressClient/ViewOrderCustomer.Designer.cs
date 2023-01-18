namespace YienExpressClient
{
    partial class ViewOrderCustomer
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblOrder = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(40, 12);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 29;
            this.dgvOrder.Size = new System.Drawing.Size(1141, 291);
            this.dgvOrder.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(233, 431);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 37);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnView.Location = new System.Drawing.Point(51, 431);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(140, 37);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblOrder
            // 
            this.lblOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(51, 345);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(144, 20);
            this.lblOrder.TabIndex = 7;
            this.lblOrder.Text = "Enter your Order ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderID.Location = new System.Drawing.Point(233, 345);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(140, 27);
            this.txtOrderID.TabIndex = 8;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // ViewOrderCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1207, 465);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dgvOrder);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "ViewOrderCustomer";
            this.Text = "ViewOrderCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewOrderCustomer_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvOrder;
        private Button btnBack;
        private Button btnView;
        private Label lblOrder;
        private TextBox txtOrderID;
    }
}