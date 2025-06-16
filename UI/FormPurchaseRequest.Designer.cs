namespace UI
{
    partial class FormPurchaseRequest
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvLowStockProducts;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblPhoneTitle;
        private System.Windows.Forms.Label lblAddressTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvLowStockProducts = new System.Windows.Forms.DataGridView();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.lblAddressTitle = new System.Windows.Forms.Label();
            this.btnRequestPurchase = new ReaLTaiizor.Controls.AirButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStockProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLowStockProducts
            // 
            this.dgvLowStockProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLowStockProducts.ColumnHeadersHeight = 34;
            this.dgvLowStockProducts.Location = new System.Drawing.Point(27, 23);
            this.dgvLowStockProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvLowStockProducts.Name = "dgvLowStockProducts";
            this.dgvLowStockProducts.ReadOnly = true;
            this.dgvLowStockProducts.RowHeadersWidth = 62;
            this.dgvLowStockProducts.Size = new System.Drawing.Size(800, 345);
            this.dgvLowStockProducts.TabIndex = 0;
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuppliers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuppliers.Location = new System.Drawing.Point(834, 34);
            this.cbSuppliers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(416, 38);
            this.cbSuppliers.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(928, 136);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(17, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "-";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(928, 170);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(17, 23);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "-";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(928, 205);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(17, 23);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "-";
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.Location = new System.Drawing.Point(834, 136);
            this.lblEmailTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(67, 23);
            this.lblEmailTitle.TabIndex = 2;
            this.lblEmailTitle.Text = "Email:";
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Location = new System.Drawing.Point(834, 170);
            this.lblPhoneTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(77, 23);
            this.lblPhoneTitle.TabIndex = 4;
            this.lblPhoneTitle.Text = "Phone:";
            // 
            // lblAddressTitle
            // 
            this.lblAddressTitle.AutoSize = true;
            this.lblAddressTitle.Location = new System.Drawing.Point(834, 205);
            this.lblAddressTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressTitle.Name = "lblAddressTitle";
            this.lblAddressTitle.Size = new System.Drawing.Size(93, 23);
            this.lblAddressTitle.TabIndex = 6;
            this.lblAddressTitle.Text = "Address:";
            // 
            // btnRequestPurchase
            // 
            this.btnRequestPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRequestPurchase.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnRequestPurchase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRequestPurchase.Image = null;
            this.btnRequestPurchase.Location = new System.Drawing.Point(834, 317);
            this.btnRequestPurchase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRequestPurchase.Name = "btnRequestPurchase";
            this.btnRequestPurchase.NoRounding = false;
            this.btnRequestPurchase.Size = new System.Drawing.Size(416, 51);
            this.btnRequestPurchase.TabIndex = 9;
            this.btnRequestPurchase.Text = "Request Purchase";
            this.btnRequestPurchase.Transparent = false;
            // 
            // FormPurchaseRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 395);
            this.Controls.Add(this.btnRequestPurchase);
            this.Controls.Add(this.dgvLowStockProducts);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.lblEmailTitle);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneTitle);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddressTitle);
            this.Controls.Add(this.lblAddress);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormPurchaseRequest";
            this.Text = "Purchase Request";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStockProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.AirButton btnRequestPurchase;
    }
}
