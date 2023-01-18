namespace YienExpressClient
{
    partial class ViewPackage
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.dgvPackage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(668, 394);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 29);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnView.Location = new System.Drawing.Point(351, 394);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(106, 29);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgvPackage
            // 
            this.dgvPackage.AllowUserToAddRows = false;
            this.dgvPackage.AllowUserToDeleteRows = false;
            this.dgvPackage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackage.Location = new System.Drawing.Point(182, 59);
            this.dgvPackage.Name = "dgvPackage";
            this.dgvPackage.ReadOnly = true;
            this.dgvPackage.RowHeadersWidth = 51;
            this.dgvPackage.RowTemplate.Height = 29;
            this.dgvPackage.Size = new System.Drawing.Size(803, 291);
            this.dgvPackage.TabIndex = 4;
            // 
            // ViewPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1296, 471);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dgvPackage);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "ViewPackage";
            this.Text = "ViewProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnBack;
        private Button btnView;
        private DataGridView dgvPackage;
    }
}