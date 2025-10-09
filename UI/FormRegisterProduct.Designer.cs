namespace UI
{
    partial class FormRegisterProduct
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
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.lblDescriptionProduct = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStockAvailable = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbBrands = new System.Windows.Forms.ComboBox();
            this.cbCategoryProduct = new System.Windows.Forms.ComboBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtDescriptionProduct = new System.Windows.Forms.TextBox();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.txtStockAvailibleProduct = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelDataProduct = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelForm = new System.Windows.Forms.TableLayoutPanel();
            this.panelPictureProduct = new System.Windows.Forms.Panel();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadImgProduct = new System.Windows.Forms.Button();
            this.btnDeleteImgProduct = new System.Windows.Forms.Button();
            this.pictureBoxImgProduct = new System.Windows.Forms.PictureBox();
            this.btnSaveProduct = new UI.Controls.ButtonDefault();
            this.lblTitleMinStock = new System.Windows.Forms.Label();
            this.txtMinStock = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelDataProduct.SuspendLayout();
            this.tableLayoutPanelForm.SuspendLayout();
            this.panelPictureProduct.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblNameProduct.Location = new System.Drawing.Point(3, 0);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(236, 24);
            this.lblNameProduct.TabIndex = 0;
            this.lblNameProduct.Text = "Nombre del producto";
            // 
            // lblDescriptionProduct
            // 
            this.lblDescriptionProduct.AutoSize = true;
            this.lblDescriptionProduct.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblDescriptionProduct.Location = new System.Drawing.Point(3, 228);
            this.lblDescriptionProduct.Name = "lblDescriptionProduct";
            this.lblDescriptionProduct.Size = new System.Drawing.Size(129, 24);
            this.lblDescriptionProduct.TabIndex = 1;
            this.lblDescriptionProduct.Text = "Descripción";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblBrand.Location = new System.Drawing.Point(3, 171);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(77, 24);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Marca";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblPrice.Location = new System.Drawing.Point(3, 57);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 24);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Precio";
            // 
            // lblStockAvailable
            // 
            this.lblStockAvailable.AutoSize = true;
            this.lblStockAvailable.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblStockAvailable.Location = new System.Drawing.Point(3, 285);
            this.lblStockAvailable.Name = "lblStockAvailable";
            this.lblStockAvailable.Size = new System.Drawing.Size(174, 24);
            this.lblStockAvailable.TabIndex = 4;
            this.lblStockAvailable.Text = "Stock disponible";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblCategory.Location = new System.Drawing.Point(3, 114);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(113, 24);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Categoria";
            // 
            // cbBrands
            // 
            this.cbBrands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBrands.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.cbBrands.FormattingEnabled = true;
            this.cbBrands.Location = new System.Drawing.Point(269, 174);
            this.cbBrands.Name = "cbBrands";
            this.cbBrands.Size = new System.Drawing.Size(258, 32);
            this.cbBrands.TabIndex = 6;
            // 
            // cbCategoryProduct
            // 
            this.cbCategoryProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategoryProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoryProduct.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.cbCategoryProduct.FormattingEnabled = true;
            this.cbCategoryProduct.Location = new System.Drawing.Point(269, 117);
            this.cbCategoryProduct.Name = "cbCategoryProduct";
            this.cbCategoryProduct.Size = new System.Drawing.Size(258, 32);
            this.cbCategoryProduct.TabIndex = 7;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameProduct.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.txtNameProduct.Location = new System.Drawing.Point(269, 3);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(258, 33);
            this.txtNameProduct.TabIndex = 8;
            // 
            // txtDescriptionProduct
            // 
            this.txtDescriptionProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescriptionProduct.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.txtDescriptionProduct.Location = new System.Drawing.Point(269, 231);
            this.txtDescriptionProduct.Name = "txtDescriptionProduct";
            this.txtDescriptionProduct.Size = new System.Drawing.Size(258, 33);
            this.txtDescriptionProduct.TabIndex = 9;
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPriceProduct.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.txtPriceProduct.Location = new System.Drawing.Point(269, 60);
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(258, 33);
            this.txtPriceProduct.TabIndex = 10;
            // 
            // txtStockAvailibleProduct
            // 
            this.txtStockAvailibleProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockAvailibleProduct.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.txtStockAvailibleProduct.Location = new System.Drawing.Point(269, 288);
            this.txtStockAvailibleProduct.Name = "txtStockAvailibleProduct";
            this.txtStockAvailibleProduct.Size = new System.Drawing.Size(258, 33);
            this.txtStockAvailibleProduct.TabIndex = 11;
            // 
            // tableLayoutPanelDataProduct
            // 
            this.tableLayoutPanelDataProduct.ColumnCount = 2;
            this.tableLayoutPanelDataProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDataProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDataProduct.Controls.Add(this.txtMinStock, 1, 6);
            this.tableLayoutPanelDataProduct.Controls.Add(this.lblTitleMinStock, 0, 6);
            this.tableLayoutPanelDataProduct.Controls.Add(this.lblNameProduct, 0, 0);
            this.tableLayoutPanelDataProduct.Controls.Add(this.lblPrice, 0, 1);
            this.tableLayoutPanelDataProduct.Controls.Add(this.txtStockAvailibleProduct, 1, 5);
            this.tableLayoutPanelDataProduct.Controls.Add(this.lblCategory, 0, 2);
            this.tableLayoutPanelDataProduct.Controls.Add(this.txtPriceProduct, 1, 1);
            this.tableLayoutPanelDataProduct.Controls.Add(this.lblBrand, 0, 3);
            this.tableLayoutPanelDataProduct.Controls.Add(this.txtDescriptionProduct, 1, 4);
            this.tableLayoutPanelDataProduct.Controls.Add(this.lblDescriptionProduct, 0, 4);
            this.tableLayoutPanelDataProduct.Controls.Add(this.cbBrands, 1, 3);
            this.tableLayoutPanelDataProduct.Controls.Add(this.lblStockAvailable, 0, 5);
            this.tableLayoutPanelDataProduct.Controls.Add(this.cbCategoryProduct, 1, 2);
            this.tableLayoutPanelDataProduct.Controls.Add(this.txtNameProduct, 1, 0);
            this.tableLayoutPanelDataProduct.Location = new System.Drawing.Point(542, 4);
            this.tableLayoutPanelDataProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelDataProduct.Name = "tableLayoutPanelDataProduct";
            this.tableLayoutPanelDataProduct.RowCount = 7;
            this.tableLayoutPanelDataProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelDataProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelDataProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelDataProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelDataProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelDataProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelDataProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDataProduct.Size = new System.Drawing.Size(530, 368);
            this.tableLayoutPanelDataProduct.TabIndex = 13;
            // 
            // tableLayoutPanelForm
            // 
            this.tableLayoutPanelForm.ColumnCount = 2;
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelForm.Controls.Add(this.tableLayoutPanelDataProduct, 1, 0);
            this.tableLayoutPanelForm.Controls.Add(this.panelPictureProduct, 0, 0);
            this.tableLayoutPanelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            this.tableLayoutPanelForm.RowCount = 1;
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelForm.Size = new System.Drawing.Size(1077, 380);
            this.tableLayoutPanelForm.TabIndex = 14;
            // 
            // panelPictureProduct
            // 
            this.panelPictureProduct.Controls.Add(this.flowLayoutPanelButtons);
            this.panelPictureProduct.Controls.Add(this.pictureBoxImgProduct);
            this.panelPictureProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPictureProduct.Location = new System.Drawing.Point(4, 4);
            this.panelPictureProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPictureProduct.Name = "panelPictureProduct";
            this.panelPictureProduct.Size = new System.Drawing.Size(530, 372);
            this.panelPictureProduct.TabIndex = 14;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.btnLoadImgProduct);
            this.flowLayoutPanelButtons.Controls.Add(this.btnDeleteImgProduct);
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(105, 290);
            this.flowLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(338, 63);
            this.flowLayoutPanelButtons.TabIndex = 3;
            // 
            // btnLoadImgProduct
            // 
            this.btnLoadImgProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadImgProduct.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImgProduct.Location = new System.Drawing.Point(4, 4);
            this.btnLoadImgProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadImgProduct.Name = "btnLoadImgProduct";
            this.btnLoadImgProduct.Size = new System.Drawing.Size(165, 58);
            this.btnLoadImgProduct.TabIndex = 1;
            this.btnLoadImgProduct.Text = "Cargar imagen";
            this.btnLoadImgProduct.UseVisualStyleBackColor = true;
            this.btnLoadImgProduct.Click += new System.EventHandler(this.btnLoadImgProduct_Click);
            // 
            // btnDeleteImgProduct
            // 
            this.btnDeleteImgProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteImgProduct.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnDeleteImgProduct.Location = new System.Drawing.Point(177, 4);
            this.btnDeleteImgProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteImgProduct.Name = "btnDeleteImgProduct";
            this.btnDeleteImgProduct.Size = new System.Drawing.Size(146, 58);
            this.btnDeleteImgProduct.TabIndex = 2;
            this.btnDeleteImgProduct.Text = "Quitar";
            this.btnDeleteImgProduct.UseVisualStyleBackColor = true;
            this.btnDeleteImgProduct.Click += new System.EventHandler(this.btnDeleteImgProduct_Click);
            // 
            // pictureBoxImgProduct
            // 
            this.pictureBoxImgProduct.Image = global::UI.Properties.Resources.img_icon;
            this.pictureBoxImgProduct.Location = new System.Drawing.Point(132, 42);
            this.pictureBoxImgProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxImgProduct.Name = "pictureBoxImgProduct";
            this.pictureBoxImgProduct.Size = new System.Drawing.Size(280, 240);
            this.pictureBoxImgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImgProduct.TabIndex = 0;
            this.pictureBoxImgProduct.TabStop = false;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSaveProduct.FlatAppearance.BorderSize = 0;
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveProduct.ForeColor = System.Drawing.Color.White;
            this.btnSaveProduct.Location = new System.Drawing.Point(0, 388);
            this.btnSaveProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(1077, 54);
            this.btnSaveProduct.TabIndex = 4;
            this.btnSaveProduct.Text = "Guardar";
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click_1);
            // 
            // lblTitleMinStock
            // 
            this.lblTitleMinStock.AutoSize = true;
            this.lblTitleMinStock.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblTitleMinStock.Location = new System.Drawing.Point(3, 342);
            this.lblTitleMinStock.Name = "lblTitleMinStock";
            this.lblTitleMinStock.Size = new System.Drawing.Size(145, 24);
            this.lblTitleMinStock.TabIndex = 12;
            this.lblTitleMinStock.Text = "Minimo Stock";
            // 
            // txtMinStock
            // 
            this.txtMinStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinStock.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.txtMinStock.Location = new System.Drawing.Point(269, 345);
            this.txtMinStock.Name = "txtMinStock";
            this.txtMinStock.Size = new System.Drawing.Size(258, 33);
            this.txtMinStock.TabIndex = 13;
            // 
            // FormRegisterProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1077, 442);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.tableLayoutPanelForm);
            this.Name = "FormRegisterProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Producto";
            this.tableLayoutPanelDataProduct.ResumeLayout(false);
            this.tableLayoutPanelDataProduct.PerformLayout();
            this.tableLayoutPanelForm.ResumeLayout(false);
            this.panelPictureProduct.ResumeLayout(false);
            this.flowLayoutPanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Label lblDescriptionProduct;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStockAvailable;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbBrands;
        private System.Windows.Forms.ComboBox cbCategoryProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtDescriptionProduct;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.TextBox txtStockAvailibleProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDataProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelForm;
        private System.Windows.Forms.Panel panelPictureProduct;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button btnLoadImgProduct;
        private System.Windows.Forms.Button btnDeleteImgProduct;
        private System.Windows.Forms.PictureBox pictureBoxImgProduct;
        private Controls.ButtonDefault btnSaveProduct;
        private System.Windows.Forms.TextBox txtMinStock;
        private System.Windows.Forms.Label lblTitleMinStock;
    }
}