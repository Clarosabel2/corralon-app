namespace UI
{
    partial class FormCreateSale
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
            this.lblCatogory = new System.Windows.Forms.Label();
            this.lblTitleCart = new System.Windows.Forms.Label();
            this.cBTipoProductos = new System.Windows.Forms.ComboBox();
            this.panelFinVenta = new System.Windows.Forms.Panel();
            this.checkBoxPaid = new System.Windows.Forms.CheckBox();
            this.cBTypesInvoice = new System.Windows.Forms.ComboBox();
            this.lblTypeInvoice = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.IDItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtBClienteDNI = new System.Windows.Forms.TextBox();
            this.lblEstadoCliente = new System.Windows.Forms.Label();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.DPEntrega = new ReaLTaiizor.Controls.HopeDatePicker();
            this.lblInsertDniClient = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.IDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageProduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetailsCart = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblItemsTotal = new System.Windows.Forms.Label();
            this.buttonCerrarVenta = new System.Windows.Forms.Button();
            this.gBFiltros = new System.Windows.Forms.GroupBox();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.lblTitleProducts = new System.Windows.Forms.Label();
            this.dgvProductsCart = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanelDGV = new System.Windows.Forms.TableLayoutPanel();
            this.panelFinVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbDetailsCart.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gBFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsCart)).BeginInit();
            this.tableLayoutPanelDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCatogory
            // 
            this.lblCatogory.AutoSize = true;
            this.lblCatogory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatogory.Location = new System.Drawing.Point(13, 28);
            this.lblCatogory.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCatogory.Name = "lblCatogory";
            this.lblCatogory.Size = new System.Drawing.Size(97, 21);
            this.lblCatogory.TabIndex = 8;
            this.lblCatogory.Text = "Categorias";
            // 
            // lblTitleCart
            // 
            this.lblTitleCart.AutoSize = true;
            this.lblTitleCart.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCart.Location = new System.Drawing.Point(545, 0);
            this.lblTitleCart.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTitleCart.Name = "lblTitleCart";
            this.lblTitleCart.Size = new System.Drawing.Size(93, 26);
            this.lblTitleCart.TabIndex = 9;
            this.lblTitleCart.Text = "Carrito";
            // 
            // cBTipoProductos
            // 
            this.cBTipoProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTipoProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTipoProductos.FormattingEnabled = true;
            this.cBTipoProductos.Location = new System.Drawing.Point(106, 26);
            this.cBTipoProductos.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cBTipoProductos.Name = "cBTipoProductos";
            this.cBTipoProductos.Size = new System.Drawing.Size(135, 29);
            this.cBTipoProductos.TabIndex = 10;
            this.cBTipoProductos.SelectedIndexChanged += new System.EventHandler(this.cBTipoProductos_SelectedIndexChanged);
            // 
            // panelFinVenta
            // 
            this.panelFinVenta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFinVenta.Controls.Add(this.checkBoxPaid);
            this.panelFinVenta.Controls.Add(this.cBTypesInvoice);
            this.panelFinVenta.Controls.Add(this.lblTypeInvoice);
            this.panelFinVenta.Controls.Add(this.dgvCart);
            this.panelFinVenta.Controls.Add(this.btnAtras);
            this.panelFinVenta.Controls.Add(this.txtBClienteDNI);
            this.panelFinVenta.Controls.Add(this.lblEstadoCliente);
            this.panelFinVenta.Controls.Add(this.btnGenerarFactura);
            this.panelFinVenta.Controls.Add(this.lblDeliveryDate);
            this.panelFinVenta.Controls.Add(this.DPEntrega);
            this.panelFinVenta.Controls.Add(this.lblInsertDniClient);
            this.panelFinVenta.Location = new System.Drawing.Point(598, 129);
            this.panelFinVenta.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panelFinVenta.Name = "panelFinVenta";
            this.panelFinVenta.Size = new System.Drawing.Size(434, 489);
            this.panelFinVenta.TabIndex = 13;
            this.panelFinVenta.Visible = false;
            // 
            // checkBoxPaid
            // 
            this.checkBoxPaid.AutoSize = true;
            this.checkBoxPaid.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.checkBoxPaid.Location = new System.Drawing.Point(3, 209);
            this.checkBoxPaid.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.checkBoxPaid.Name = "checkBoxPaid";
            this.checkBoxPaid.Size = new System.Drawing.Size(114, 20);
            this.checkBoxPaid.TabIndex = 12;
            this.checkBoxPaid.Text = "Marcar Pagado";
            this.checkBoxPaid.UseVisualStyleBackColor = true;
            // 
            // cBTypesInvoice
            // 
            this.cBTypesInvoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTypesInvoice.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.cBTypesInvoice.FormattingEnabled = true;
            this.cBTypesInvoice.Location = new System.Drawing.Point(19, 44);
            this.cBTypesInvoice.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cBTypesInvoice.Name = "cBTypesInvoice";
            this.cBTypesInvoice.Size = new System.Drawing.Size(23, 24);
            this.cBTypesInvoice.TabIndex = 10;
            // 
            // lblTypeInvoice
            // 
            this.lblTypeInvoice.AutoSize = true;
            this.lblTypeInvoice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeInvoice.Location = new System.Drawing.Point(2, 45);
            this.lblTypeInvoice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTypeInvoice.Name = "lblTypeInvoice";
            this.lblTypeInvoice.Size = new System.Drawing.Size(77, 16);
            this.lblTypeInvoice.TabIndex = 9;
            this.lblTypeInvoice.Text = "Tipo Factura:";
            // 
            // dgvCart
            // 
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDItem,
            this.ProductName,
            this.Amount,
            this.Subtotal});
            this.dgvCart.Location = new System.Drawing.Point(35, 153);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 72;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(385, 285);
            this.dgvCart.TabIndex = 15;
            this.dgvCart.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCart_RowsAdded);
            this.dgvCart.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvCart_RowsRemoved);
            // 
            // IDItem
            // 
            this.IDItem.HeaderText = "ID";
            this.IDItem.MinimumWidth = 9;
            this.IDItem.Name = "IDItem";
            this.IDItem.Width = 175;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product";
            this.ProductName.MinimumWidth = 9;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 9;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 9;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(1, 2);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(10, 13);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "<---";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtBClienteDNI
            // 
            this.txtBClienteDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBClienteDNI.Location = new System.Drawing.Point(1, 24);
            this.txtBClienteDNI.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtBClienteDNI.MaxLength = 8;
            this.txtBClienteDNI.Multiline = true;
            this.txtBClienteDNI.Name = "txtBClienteDNI";
            this.txtBClienteDNI.Size = new System.Drawing.Size(41, 16);
            this.txtBClienteDNI.TabIndex = 7;
            this.txtBClienteDNI.TextChanged += new System.EventHandler(this.txtBClienteDNI_TextChanged);
            this.txtBClienteDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBClienteDNI_KeyPress);
            // 
            // lblEstadoCliente
            // 
            this.lblEstadoCliente.AutoSize = true;
            this.lblEstadoCliente.ForeColor = System.Drawing.Color.Green;
            this.lblEstadoCliente.Location = new System.Drawing.Point(40, 32);
            this.lblEstadoCliente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEstadoCliente.Name = "lblEstadoCliente";
            this.lblEstadoCliente.Size = new System.Drawing.Size(0, 13);
            this.lblEstadoCliente.TabIndex = 6;
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerarFactura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerarFactura.Enabled = false;
            this.btnGenerarFactura.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.Location = new System.Drawing.Point(0, 465);
            this.btnGenerarFactura.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(434, 24);
            this.btnGenerarFactura.TabIndex = 5;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = false;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.Location = new System.Drawing.Point(2, 62);
            this.lblDeliveryDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(99, 16);
            this.lblDeliveryDate.TabIndex = 4;
            this.lblDeliveryDate.Text = "Fecha A Entregar";
            // 
            // DPEntrega
            // 
            this.DPEntrega.BackColor = System.Drawing.Color.White;
            this.DPEntrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DPEntrega.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.DPEntrega.Date = new System.DateTime(2024, 10, 4, 0, 0, 0, 0);
            this.DPEntrega.DayNames = "LMMJVSD";
            this.DPEntrega.DaysTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.DPEntrega.DayTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.DPEntrega.DayTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.DPEntrega.HeaderFormat = "{0} Año - {1} Mes";
            this.DPEntrega.HeaderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.DPEntrega.HeadLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.DPEntrega.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.DPEntrega.Location = new System.Drawing.Point(12, 76);
            this.DPEntrega.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.DPEntrega.Name = "DPEntrega";
            this.DPEntrega.NMColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.DPEntrega.NMHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.DPEntrega.NYColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.DPEntrega.NYHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.DPEntrega.PMColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.DPEntrega.PMHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.DPEntrega.PYColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.DPEntrega.PYHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.DPEntrega.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.DPEntrega.SelectedTextColor = System.Drawing.Color.White;
            this.DPEntrega.Size = new System.Drawing.Size(250, 270);
            this.DPEntrega.TabIndex = 3;
            this.DPEntrega.ValueTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            // 
            // lblInsertDniClient
            // 
            this.lblInsertDniClient.AutoSize = true;
            this.lblInsertDniClient.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertDniClient.Location = new System.Drawing.Point(2, 16);
            this.lblInsertDniClient.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblInsertDniClient.Name = "lblInsertDniClient";
            this.lblInsertDniClient.Size = new System.Drawing.Size(121, 16);
            this.lblInsertDniClient.TabIndex = 0;
            this.lblInsertDniClient.Text = "Ingrese DNI del Client";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProduct,
            this.ImageProduct,
            this.BrandName,
            this.NameProduct,
            this.stockProduct,
            this.priceProduct});
            this.dgvProducts.Location = new System.Drawing.Point(1, 87);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 72;
            this.dgvProducts.RowTemplate.Height = 60;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(542, 583);
            this.dgvProducts.TabIndex = 14;
            this.dgvProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProducts_CellFormatting);
            this.dgvProducts.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProducts_DataError);
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            // 
            // IDProduct
            // 
            this.IDProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IDProduct.HeaderText = "ID";
            this.IDProduct.MinimumWidth = 8;
            this.IDProduct.Name = "IDProduct";
            this.IDProduct.ReadOnly = true;
            this.IDProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IDProduct.Width = 43;
            // 
            // ImageProduct
            // 
            this.ImageProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ImageProduct.HeaderText = "";
            this.ImageProduct.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImageProduct.MinimumWidth = 40;
            this.ImageProduct.Name = "ImageProduct";
            this.ImageProduct.ReadOnly = true;
            this.ImageProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ImageProduct.Width = 40;
            // 
            // BrandName
            // 
            this.BrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BrandName.HeaderText = "Marca";
            this.BrandName.MinimumWidth = 8;
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            this.BrandName.Width = 62;
            // 
            // NameProduct
            // 
            this.NameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameProduct.HeaderText = "Nombre";
            this.NameProduct.MinimumWidth = 8;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // stockProduct
            // 
            this.stockProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.stockProduct.HeaderText = "Stock";
            this.stockProduct.MinimumWidth = 8;
            this.stockProduct.Name = "stockProduct";
            this.stockProduct.ReadOnly = true;
            this.stockProduct.Width = 60;
            // 
            // priceProduct
            // 
            this.priceProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.priceProduct.HeaderText = "Precio";
            this.priceProduct.MinimumWidth = 8;
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.ReadOnly = true;
            this.priceProduct.Width = 62;
            // 
            // gbDetailsCart
            // 
            this.gbDetailsCart.Controls.Add(this.flowLayoutPanel1);
            this.gbDetailsCart.Controls.Add(this.buttonCerrarVenta);
            this.gbDetailsCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetailsCart.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.gbDetailsCart.Location = new System.Drawing.Point(545, 28);
            this.gbDetailsCart.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gbDetailsCart.Name = "gbDetailsCart";
            this.gbDetailsCart.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gbDetailsCart.Size = new System.Drawing.Size(543, 55);
            this.gbDetailsCart.TabIndex = 16;
            this.gbDetailsCart.TabStop = false;
            this.gbDetailsCart.Text = "Detalles del Carrito";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.lblTotal);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.lblItemsTotal);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(309, 19);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(49, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(29, 20);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "$ 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label9.Location = new System.Drawing.Point(80, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Items:";
            // 
            // lblItemsTotal
            // 
            this.lblItemsTotal.AutoSize = true;
            this.lblItemsTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblItemsTotal.Location = new System.Drawing.Point(134, 0);
            this.lblItemsTotal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblItemsTotal.Name = "lblItemsTotal";
            this.lblItemsTotal.Size = new System.Drawing.Size(17, 20);
            this.lblItemsTotal.TabIndex = 22;
            this.lblItemsTotal.Text = "0";
            // 
            // buttonCerrarVenta
            // 
            this.buttonCerrarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrarVenta.Enabled = false;
            this.buttonCerrarVenta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarVenta.Image = global::UI.Properties.Resources.icons8_close_window_20;
            this.buttonCerrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCerrarVenta.Location = new System.Drawing.Point(318, 17);
            this.buttonCerrarVenta.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonCerrarVenta.Name = "buttonCerrarVenta";
            this.buttonCerrarVenta.Size = new System.Drawing.Size(222, 34);
            this.buttonCerrarVenta.TabIndex = 7;
            this.buttonCerrarVenta.Text = "Cerrar \r\nCarrito";
            this.buttonCerrarVenta.UseVisualStyleBackColor = true;
            this.buttonCerrarVenta.Click += new System.EventHandler(this.buttonCerrarVenta_Click);
            // 
            // gBFiltros
            // 
            this.gBFiltros.Controls.Add(this.txtFilterName);
            this.gBFiltros.Controls.Add(this.lblBrandName);
            this.gBFiltros.Controls.Add(this.cBTipoProductos);
            this.gBFiltros.Controls.Add(this.lblCatogory);
            this.gBFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBFiltros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBFiltros.Location = new System.Drawing.Point(1, 28);
            this.gBFiltros.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gBFiltros.Name = "gBFiltros";
            this.gBFiltros.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gBFiltros.Size = new System.Drawing.Size(542, 55);
            this.gBFiltros.TabIndex = 17;
            this.gBFiltros.TabStop = false;
            this.gBFiltros.Text = "Opciones de búsqueda";
            // 
            // txtFilterName
            // 
            this.txtFilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterName.Location = new System.Drawing.Point(327, 26);
            this.txtFilterName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(214, 27);
            this.txtFilterName.TabIndex = 12;
            this.txtFilterName.TextChanged += new System.EventHandler(this.txtFilterName_TextChanged);
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandName.Location = new System.Drawing.Point(259, 28);
            this.lblBrandName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(65, 21);
            this.lblBrandName.TabIndex = 11;
            this.lblBrandName.Text = "Buscar:";
            // 
            // lblTitleProducts
            // 
            this.lblTitleProducts.AutoSize = true;
            this.lblTitleProducts.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleProducts.Location = new System.Drawing.Point(1, 0);
            this.lblTitleProducts.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTitleProducts.Name = "lblTitleProducts";
            this.lblTitleProducts.Size = new System.Drawing.Size(131, 26);
            this.lblTitleProducts.TabIndex = 18;
            this.lblTitleProducts.Text = "Productos";
            // 
            // dgvProductsCart
            // 
            this.dgvProductsCart.AllowUserToAddRows = false;
            this.dgvProductsCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductsCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colImg,
            this.colName,
            this.colPrice,
            this.colSubtotal,
            this.colQuantity,
            this.btnDeleteCol});
            this.dgvProductsCart.Location = new System.Drawing.Point(545, 87);
            this.dgvProductsCart.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgvProductsCart.Name = "dgvProductsCart";
            this.dgvProductsCart.RowHeadersWidth = 62;
            this.dgvProductsCart.RowTemplate.Height = 40;
            this.dgvProductsCart.Size = new System.Drawing.Size(543, 583);
            this.dgvProductsCart.TabIndex = 19;
            this.dgvProductsCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsCart_CellClick);
            this.dgvProductsCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsCart_CellContentClick);
            this.dgvProductsCart.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductsCart_CellEndEdit);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 40;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 43;
            // 
            // colImg
            // 
            this.colImg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colImg.HeaderText = "";
            this.colImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImg.MinimumWidth = 30;
            this.colImg.Name = "colImg";
            this.colImg.ReadOnly = true;
            this.colImg.Width = 30;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Producto";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPrice.HeaderText = "Precio C/u";
            this.colPrice.MinimumWidth = 8;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 83;
            // 
            // colSubtotal
            // 
            this.colSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MinimumWidth = 8;
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 71;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colQuantity.HeaderText = "Cantidad";
            this.colQuantity.MinimumWidth = 8;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 74;
            // 
            // btnDeleteCol
            // 
            this.btnDeleteCol.HeaderText = "";
            this.btnDeleteCol.Image = global::UI.Properties.Resources.delete_icon_circle;
            this.btnDeleteCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnDeleteCol.MinimumWidth = 8;
            this.btnDeleteCol.Name = "btnDeleteCol";
            this.btnDeleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDeleteCol.Width = 150;
            // 
            // tableLayoutPanelDGV
            // 
            this.tableLayoutPanelDGV.ColumnCount = 2;
            this.tableLayoutPanelDGV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDGV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDGV.Controls.Add(this.dgvProducts, 0, 2);
            this.tableLayoutPanelDGV.Controls.Add(this.dgvProductsCart, 1, 2);
            this.tableLayoutPanelDGV.Controls.Add(this.lblTitleProducts, 0, 0);
            this.tableLayoutPanelDGV.Controls.Add(this.gBFiltros, 0, 1);
            this.tableLayoutPanelDGV.Controls.Add(this.lblTitleCart, 1, 0);
            this.tableLayoutPanelDGV.Controls.Add(this.gbDetailsCart, 1, 1);
            this.tableLayoutPanelDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDGV.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDGV.Name = "tableLayoutPanelDGV";
            this.tableLayoutPanelDGV.RowCount = 3;
            this.tableLayoutPanelDGV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.997609F));
            this.tableLayoutPanelDGV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.80174F));
            this.tableLayoutPanelDGV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.20065F));
            this.tableLayoutPanelDGV.Size = new System.Drawing.Size(1089, 672);
            this.tableLayoutPanelDGV.TabIndex = 20;
            // 
            // FormCreateSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1089, 672);
            this.Controls.Add(this.panelFinVenta);
            this.Controls.Add(this.tableLayoutPanelDGV);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FormCreateSale";
            this.Text = "FormCreateSale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCreateSale_FormClosed);
            this.Load += new System.EventHandler(this.FormCrearVenta_Load);
            this.ResizeEnd += new System.EventHandler(this.FormCrearVenta_ResizeEnd);
            this.Resize += new System.EventHandler(this.FormCrearVenta_Resize);
            this.panelFinVenta.ResumeLayout(false);
            this.panelFinVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbDetailsCart.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.gBFiltros.ResumeLayout(false);
            this.gBFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsCart)).EndInit();
            this.tableLayoutPanelDGV.ResumeLayout(false);
            this.tableLayoutPanelDGV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCerrarVenta;
        private System.Windows.Forms.Label lblCatogory;
        private System.Windows.Forms.Label lblTitleCart;
        private System.Windows.Forms.ComboBox cBTipoProductos;
        private System.Windows.Forms.Panel panelFinVenta;
        private System.Windows.Forms.Label lblInsertDniClient;
        private System.Windows.Forms.Label lblDeliveryDate;
        private ReaLTaiizor.Controls.HopeDatePicker DPEntrega;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Label lblEstadoCliente;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.TextBox txtBClienteDNI;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox gbDetailsCart;
        private System.Windows.Forms.Label lblItemsTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gBFiltros;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.ComboBox cBTypesInvoice;
        private System.Windows.Forms.Label lblTypeInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.CheckBox checkBoxPaid;
        private System.Windows.Forms.Label lblTitleProducts;
        private System.Windows.Forms.DataGridView dgvProductsCart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDGV;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewImageColumn colImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewImageColumn btnDeleteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProduct;
        private System.Windows.Forms.DataGridViewImageColumn ImageProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceProduct;
    }
}