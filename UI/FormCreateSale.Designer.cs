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
            this.lblCart = new System.Windows.Forms.Label();
            this.cBTipoProductos = new System.Windows.Forms.ComboBox();
            this.panelFinVenta = new System.Windows.Forms.Panel();
            this.checkBoxPaid = new System.Windows.Forms.CheckBox();
            this.cBTypesInvoice = new System.Windows.Forms.ComboBox();
            this.lblTypeInvoice = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtBClienteDNI = new System.Windows.Forms.TextBox();
            this.lblEstadoCliente = new System.Windows.Forms.Label();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.DPEntrega = new ReaLTaiizor.Controls.HopeDatePicker();
            this.lblInsertDniClient = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.IDItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetailsCart = new System.Windows.Forms.GroupBox();
            this.lblItemsTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gBFiltros = new System.Windows.Forms.GroupBox();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.buttonCerrarVenta = new System.Windows.Forms.Button();
            this.IDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFinVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.gbDetailsCart.SuspendLayout();
            this.gBFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCatogory
            // 
            this.lblCatogory.AutoSize = true;
            this.lblCatogory.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatogory.Location = new System.Drawing.Point(22, 46);
            this.lblCatogory.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCatogory.Name = "lblCatogory";
            this.lblCatogory.Size = new System.Drawing.Size(66, 16);
            this.lblCatogory.TabIndex = 8;
            this.lblCatogory.Text = "Categorias";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(25, 641);
            this.lblCart.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(31, 16);
            this.lblCart.TabIndex = 9;
            this.lblCart.Text = "Cart";
            // 
            // cBTipoProductos
            // 
            this.cBTipoProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTipoProductos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTipoProductos.FormattingEnabled = true;
            this.cBTipoProductos.Location = new System.Drawing.Point(154, 41);
            this.cBTipoProductos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cBTipoProductos.Name = "cBTipoProductos";
            this.cBTipoProductos.Size = new System.Drawing.Size(218, 24);
            this.cBTipoProductos.TabIndex = 10;
            this.cBTipoProductos.SelectedIndexChanged += new System.EventHandler(this.cBTipoProductos_SelectedIndexChanged);
            // 
            // panelFinVenta
            // 
            this.panelFinVenta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFinVenta.Controls.Add(this.checkBoxPaid);
            this.panelFinVenta.Controls.Add(this.cBTypesInvoice);
            this.panelFinVenta.Controls.Add(this.lblTypeInvoice);
            this.panelFinVenta.Controls.Add(this.btnAtras);
            this.panelFinVenta.Controls.Add(this.txtBClienteDNI);
            this.panelFinVenta.Controls.Add(this.lblEstadoCliente);
            this.panelFinVenta.Controls.Add(this.btnGenerarFactura);
            this.panelFinVenta.Controls.Add(this.lblDeliveryDate);
            this.panelFinVenta.Controls.Add(this.DPEntrega);
            this.panelFinVenta.Controls.Add(this.lblInsertDniClient);
            this.panelFinVenta.Location = new System.Drawing.Point(499, 81);
            this.panelFinVenta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelFinVenta.Name = "panelFinVenta";
            this.panelFinVenta.Size = new System.Drawing.Size(689, 1010);
            this.panelFinVenta.TabIndex = 13;
            this.panelFinVenta.Visible = false;
            // 
            // checkBoxPaid
            // 
            this.checkBoxPaid.AutoSize = true;
            this.checkBoxPaid.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.checkBoxPaid.Location = new System.Drawing.Point(26, 836);
            this.checkBoxPaid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.cBTypesInvoice.Location = new System.Drawing.Point(167, 175);
            this.cBTypesInvoice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cBTypesInvoice.Name = "cBTypesInvoice";
            this.cBTypesInvoice.Size = new System.Drawing.Size(171, 24);
            this.cBTypesInvoice.TabIndex = 10;
            // 
            // lblTypeInvoice
            // 
            this.lblTypeInvoice.AutoSize = true;
            this.lblTypeInvoice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeInvoice.Location = new System.Drawing.Point(20, 181);
            this.lblTypeInvoice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTypeInvoice.Name = "lblTypeInvoice";
            this.lblTypeInvoice.Size = new System.Drawing.Size(77, 16);
            this.lblTypeInvoice.TabIndex = 9;
            this.lblTypeInvoice.Text = "Tipo Factura:";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(6, 6);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(84, 52);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "<---";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtBClienteDNI
            // 
            this.txtBClienteDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBClienteDNI.Location = new System.Drawing.Point(11, 98);
            this.txtBClienteDNI.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBClienteDNI.MaxLength = 8;
            this.txtBClienteDNI.Multiline = true;
            this.txtBClienteDNI.Name = "txtBClienteDNI";
            this.txtBClienteDNI.Size = new System.Drawing.Size(327, 52);
            this.txtBClienteDNI.TabIndex = 7;
            this.txtBClienteDNI.TextChanged += new System.EventHandler(this.txtBClienteDNI_TextChanged);
            this.txtBClienteDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBClienteDNI_KeyPress);
            // 
            // lblEstadoCliente
            // 
            this.lblEstadoCliente.AutoSize = true;
            this.lblEstadoCliente.ForeColor = System.Drawing.Color.Green;
            this.lblEstadoCliente.Location = new System.Drawing.Point(352, 129);
            this.lblEstadoCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEstadoCliente.Name = "lblEstadoCliente";
            this.lblEstadoCliente.Size = new System.Drawing.Size(0, 24);
            this.lblEstadoCliente.TabIndex = 6;
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGenerarFactura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerarFactura.Enabled = false;
            this.btnGenerarFactura.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.Location = new System.Drawing.Point(0, 914);
            this.btnGenerarFactura.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(689, 96);
            this.btnGenerarFactura.TabIndex = 5;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = false;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryDate.Location = new System.Drawing.Point(20, 249);
            this.lblDeliveryDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
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
            this.DPEntrega.Location = new System.Drawing.Point(125, 306);
            this.DPEntrega.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.lblInsertDniClient.Location = new System.Drawing.Point(20, 63);
            this.lblInsertDniClient.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInsertDniClient.Name = "lblInsertDniClient";
            this.lblInsertDniClient.Size = new System.Drawing.Size(121, 16);
            this.lblInsertDniClient.TabIndex = 0;
            this.lblInsertDniClient.Text = "Ingrese DNI del Client";
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProduct,
            this.NameProduct,
            this.BrandName,
            this.CategoryProduct,
            this.stockProduct,
            this.priceProduct});
            this.dgvProducts.Location = new System.Drawing.Point(28, 109);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 72;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1500, 526);
            this.dgvProducts.TabIndex = 14;
            this.dgvProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProducts_CellFormatting);
            this.dgvProducts.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProducts_DataError);
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
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
            this.dgvCart.Location = new System.Drawing.Point(28, 669);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 72;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(1500, 579);
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
            // gbDetailsCart
            // 
            this.gbDetailsCart.Controls.Add(this.lblItemsTotal);
            this.gbDetailsCart.Controls.Add(this.label9);
            this.gbDetailsCart.Controls.Add(this.label8);
            this.gbDetailsCart.Controls.Add(this.label7);
            this.gbDetailsCart.Controls.Add(this.lblTotal);
            this.gbDetailsCart.Controls.Add(this.label5);
            this.gbDetailsCart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDetailsCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetailsCart.Location = new System.Drawing.Point(0, 1101);
            this.gbDetailsCart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDetailsCart.Name = "gbDetailsCart";
            this.gbDetailsCart.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDetailsCart.Size = new System.Drawing.Size(1758, 102);
            this.gbDetailsCart.TabIndex = 16;
            this.gbDetailsCart.TabStop = false;
            this.gbDetailsCart.Text = "Detalles del Cart";
            // 
            // lblItemsTotal
            // 
            this.lblItemsTotal.AutoSize = true;
            this.lblItemsTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblItemsTotal.Location = new System.Drawing.Point(722, 46);
            this.lblItemsTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblItemsTotal.Name = "lblItemsTotal";
            this.lblItemsTotal.Size = new System.Drawing.Size(17, 20);
            this.lblItemsTotal.TabIndex = 22;
            this.lblItemsTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label9.Location = new System.Drawing.Point(616, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Items:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label8.Location = new System.Drawing.Point(429, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "$0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(286, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Subtotal:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(106, 46);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 20);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "$0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total:";
            // 
            // gBFiltros
            // 
            this.gBFiltros.Controls.Add(this.txtFilterName);
            this.gBFiltros.Controls.Add(this.lblBrandName);
            this.gBFiltros.Controls.Add(this.cBTipoProductos);
            this.gBFiltros.Controls.Add(this.lblCatogory);
            this.gBFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBFiltros.Location = new System.Drawing.Point(0, 0);
            this.gBFiltros.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gBFiltros.Name = "gBFiltros";
            this.gBFiltros.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gBFiltros.Size = new System.Drawing.Size(1758, 98);
            this.gBFiltros.TabIndex = 17;
            this.gBFiltros.TabStop = false;
            this.gBFiltros.Text = "Filtros";
            // 
            // txtFilterName
            // 
            this.txtFilterName.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtFilterName.Location = new System.Drawing.Point(627, 42);
            this.txtFilterName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(180, 21);
            this.txtFilterName.TabIndex = 12;
            this.txtFilterName.TextChanged += new System.EventHandler(this.txtFilterName_TextChanged);
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandName.Location = new System.Drawing.Point(431, 46);
            this.lblBrandName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(101, 16);
            this.lblBrandName.TabIndex = 11;
            this.lblBrandName.Text = "Marca / Nombre:";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveItem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Image = global::UI.Properties.Resources.icons8_remove_from_clipboard_24;
            this.btnRemoveItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveItem.Location = new System.Drawing.Point(1534, 669);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(202, 217);
            this.btnRemoveItem.TabIndex = 11;
            this.btnRemoveItem.Text = "Eliminar \r\nItem";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCarrito.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCarrito.Image = global::UI.Properties.Resources.icons8_add_shopping_cart_20;
            this.btnAgregarCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCarrito.Location = new System.Drawing.Point(1538, 109);
            this.btnAgregarCarrito.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(198, 526);
            this.btnAgregarCarrito.TabIndex = 6;
            this.btnAgregarCarrito.Text = "Agregar \r\na Carrito";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // buttonCerrarVenta
            // 
            this.buttonCerrarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrarVenta.Enabled = false;
            this.buttonCerrarVenta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarVenta.Image = global::UI.Properties.Resources.icons8_close_window_20;
            this.buttonCerrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCerrarVenta.Location = new System.Drawing.Point(1534, 888);
            this.buttonCerrarVenta.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCerrarVenta.Name = "buttonCerrarVenta";
            this.buttonCerrarVenta.Size = new System.Drawing.Size(202, 360);
            this.buttonCerrarVenta.TabIndex = 7;
            this.buttonCerrarVenta.Text = "Cerrar \r\nCarrito";
            this.buttonCerrarVenta.UseVisualStyleBackColor = true;
            this.buttonCerrarVenta.Click += new System.EventHandler(this.buttonCerrarVenta_Click);
            // 
            // IDProduct
            // 
            this.IDProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDProduct.HeaderText = "ID";
            this.IDProduct.Name = "IDProduct";
            this.IDProduct.ReadOnly = true;
            // 
            // NameProduct
            // 
            this.NameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameProduct.HeaderText = "Nombre";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            // 
            // BrandName
            // 
            this.BrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrandName.HeaderText = "Marca";
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            // 
            // CategoryProduct
            // 
            this.CategoryProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryProduct.HeaderText = "Categoria";
            this.CategoryProduct.Name = "CategoryProduct";
            this.CategoryProduct.ReadOnly = true;
            // 
            // stockProduct
            // 
            this.stockProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stockProduct.HeaderText = "Stock";
            this.stockProduct.Name = "stockProduct";
            this.stockProduct.ReadOnly = true;
            // 
            // priceProduct
            // 
            this.priceProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceProduct.HeaderText = "Precio";
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.ReadOnly = true;
            // 
            // FormCreateSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1758, 1203);
            this.Controls.Add(this.panelFinVenta);
            this.Controls.Add(this.gbDetailsCart);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAgregarCarrito);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.buttonCerrarVenta);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.gBFiltros);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormCreateSale";
            this.Text = "FormCreateSale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCreateSale_FormClosed);
            this.Load += new System.EventHandler(this.FormCrearVenta_Load);
            this.ResizeEnd += new System.EventHandler(this.FormCrearVenta_ResizeEnd);
            this.Resize += new System.EventHandler(this.FormCrearVenta_Resize);
            this.panelFinVenta.ResumeLayout(false);
            this.panelFinVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.gbDetailsCart.ResumeLayout(false);
            this.gbDetailsCart.PerformLayout();
            this.gBFiltros.ResumeLayout(false);
            this.gBFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCerrarVenta;
        private System.Windows.Forms.Label lblCatogory;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.ComboBox cBTipoProductos;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.Button btnRemoveItem;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceProduct;
    }
}