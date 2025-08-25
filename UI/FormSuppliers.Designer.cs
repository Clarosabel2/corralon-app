using System.Windows.Forms;

namespace UI.FormsViewData
{
    partial class FormSuppliers
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
        private System.Windows.Forms.Button btnRegisterSupplier;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.DataGridView dgvBrands;
        private System.Windows.Forms.Label lblBrands;
        private void InitializeComponent()
        {
            this.btnRegisterSupplier = new System.Windows.Forms.Button();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.dgvBrands = new System.Windows.Forms.DataGridView();
            this.lblBrands = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegisterSupplier
            // 
            this.btnRegisterSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterSupplier.Location = new System.Drawing.Point(1102, 21);
            this.btnRegisterSupplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegisterSupplier.Name = "btnRegisterSupplier";
            this.btnRegisterSupplier.Size = new System.Drawing.Size(225, 34);
            this.btnRegisterSupplier.TabIndex = 2;
            this.btnRegisterSupplier.Text = "Register Supplier";
            this.btnRegisterSupplier.Click += new System.EventHandler(this.btnRegisterSupplier_Click);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuppliers.ColumnHeadersHeight = 34;
            this.dgvSuppliers.Location = new System.Drawing.Point(29, 69);
            this.dgvSuppliers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersWidth = 62;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(1297, 526);
            this.dgvSuppliers.TabIndex = 3;
            this.dgvSuppliers.SelectionChanged += new System.EventHandler(this.dgvSuppliers_SelectionChanged);
            // 
            // dgvBrands
            // 
            this.dgvBrands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBrands.ColumnHeadersHeight = 34;
            this.dgvBrands.Location = new System.Drawing.Point(29, 661);
            this.dgvBrands.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvBrands.Name = "dgvBrands";
            this.dgvBrands.ReadOnly = true;
            this.dgvBrands.RowHeadersWidth = 62;
            this.dgvBrands.Size = new System.Drawing.Size(1297, 258);
            this.dgvBrands.TabIndex = 5;
            // 
            // lblBrands
            // 
            this.lblBrands.AutoSize = true;
            this.lblBrands.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrands.Location = new System.Drawing.Point(3, 624);
            this.lblBrands.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrands.Name = "lblBrands";
            this.lblBrands.Size = new System.Drawing.Size(288, 24);
            this.lblBrands.TabIndex = 4;
            this.lblBrands.Text = "Brands of selected supplier:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Suppliers";
            // 
            // FormSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 931);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegisterSupplier);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.lblBrands);
            this.Controls.Add(this.dgvBrands);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormSuppliers";
            this.Text = "Supplier Management";
            this.Load += new System.EventHandler(this.FormSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
    }
}