namespace UI
{
    partial class FormCrearVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipoProductos = new System.Windows.Forms.ComboBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.buttonCerrarVenta = new System.Windows.Forms.Button();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.panelFinVenta = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txtBClienteDNI = new System.Windows.Forms.TextBox();
            this.lblEstadoCliente = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hopeDatePicker1 = new ReaLTaiizor.Controls.HopeDatePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.IDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelFinVenta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Carrito";
            // 
            // comboBoxTipoProductos
            // 
            this.comboBoxTipoProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoProductos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoProductos.FormattingEnabled = true;
            this.comboBoxTipoProductos.Items.AddRange(new object[] {
            "Todos",
            "Bolsa",
            "Arido",
            "Ladrillo",
            "Pintura"});
            this.comboBoxTipoProductos.Location = new System.Drawing.Point(79, 4);
            this.comboBoxTipoProductos.Name = "comboBoxTipoProductos";
            this.comboBoxTipoProductos.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTipoProductos.TabIndex = 10;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveItem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Image = global::UI.Properties.Resources.icons8_remove_from_clipboard_24;
            this.btnRemoveItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveItem.Location = new System.Drawing.Point(837, 314);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(110, 166);
            this.btnRemoveItem.TabIndex = 11;
            this.btnRemoveItem.Text = "Eliminar \r\nItem";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // buttonCerrarVenta
            // 
            this.buttonCerrarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrarVenta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarVenta.Image = global::UI.Properties.Resources.icons8_close_window_20;
            this.buttonCerrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCerrarVenta.Location = new System.Drawing.Point(837, 481);
            this.buttonCerrarVenta.Name = "buttonCerrarVenta";
            this.buttonCerrarVenta.Size = new System.Drawing.Size(110, 195);
            this.buttonCerrarVenta.TabIndex = 7;
            this.buttonCerrarVenta.Text = "Cerrar \r\nCarrito";
            this.buttonCerrarVenta.UseVisualStyleBackColor = true;
            this.buttonCerrarVenta.Click += new System.EventHandler(this.buttonCerrarVenta_Click);
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCarrito.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCarrito.Image = global::UI.Properties.Resources.icons8_add_shopping_cart_20;
            this.btnAgregarCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCarrito.Location = new System.Drawing.Point(839, 31);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(108, 259);
            this.btnAgregarCarrito.TabIndex = 6;
            this.btnAgregarCarrito.Text = "Agregar \r\na Carrito";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // panelFinVenta
            // 
            this.panelFinVenta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFinVenta.Controls.Add(this.btnAtras);
            this.panelFinVenta.Controls.Add(this.txtBClienteDNI);
            this.panelFinVenta.Controls.Add(this.lblEstadoCliente);
            this.panelFinVenta.Controls.Add(this.button2);
            this.panelFinVenta.Controls.Add(this.label4);
            this.panelFinVenta.Controls.Add(this.hopeDatePicker1);
            this.panelFinVenta.Controls.Add(this.groupBox1);
            this.panelFinVenta.Controls.Add(this.label3);
            this.panelFinVenta.Location = new System.Drawing.Point(272, 44);
            this.panelFinVenta.Name = "panelFinVenta";
            this.panelFinVenta.Size = new System.Drawing.Size(373, 514);
            this.panelFinVenta.TabIndex = 13;
            this.panelFinVenta.Visible = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(6, 459);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(110, 52);
            this.btnAtras.TabIndex = 8;
            this.btnAtras.Text = "<---";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txtBClienteDNI
            // 
            this.txtBClienteDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBClienteDNI.Location = new System.Drawing.Point(6, 37);
            this.txtBClienteDNI.MaxLength = 8;
            this.txtBClienteDNI.Multiline = true;
            this.txtBClienteDNI.Name = "txtBClienteDNI";
            this.txtBClienteDNI.Size = new System.Drawing.Size(180, 30);
            this.txtBClienteDNI.TabIndex = 7;
            this.txtBClienteDNI.TextChanged += new System.EventHandler(this.txtBClienteDNI_TextChanged);
            this.txtBClienteDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBClienteDNI_KeyPress);
            // 
            // lblEstadoCliente
            // 
            this.lblEstadoCliente.AutoSize = true;
            this.lblEstadoCliente.ForeColor = System.Drawing.Color.Green;
            this.lblEstadoCliente.Location = new System.Drawing.Point(212, 54);
            this.lblEstadoCliente.Name = "lblEstadoCliente";
            this.lblEstadoCliente.Size = new System.Drawing.Size(0, 13);
            this.lblEstadoCliente.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(260, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "Generar Factura";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha A Entregar";
            // 
            // hopeDatePicker1
            // 
            this.hopeDatePicker1.BackColor = System.Drawing.Color.White;
            this.hopeDatePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeDatePicker1.Date = new System.DateTime(2024, 5, 25, 0, 0, 0, 0);
            this.hopeDatePicker1.DayNames = "LMMJVSS";
            this.hopeDatePicker1.DaysTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.hopeDatePicker1.DayTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeDatePicker1.DayTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.hopeDatePicker1.HeaderFormat = "{0} Año - {1} Mes";
            this.hopeDatePicker1.HeaderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeDatePicker1.HeadLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.hopeDatePicker1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.hopeDatePicker1.Location = new System.Drawing.Point(57, 95);
            this.hopeDatePicker1.Name = "hopeDatePicker1";
            this.hopeDatePicker1.NMColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopeDatePicker1.NMHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeDatePicker1.NYColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopeDatePicker1.NYHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeDatePicker1.PMColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopeDatePicker1.PMHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeDatePicker1.PYColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopeDatePicker1.PYHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeDatePicker1.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeDatePicker1.SelectedTextColor = System.Drawing.Color.White;
            this.hopeDatePicker1.Size = new System.Drawing.Size(250, 270);
            this.hopeDatePicker1.TabIndex = 3;
            this.hopeDatePicker1.Text = "hopeDatePicker1";
            this.hopeDatePicker1.ValueTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2RadioButton2);
            this.groupBox1.Controls.Add(this.guna2RadioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 46);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medio de Pago";
            // 
            // guna2RadioButton2
            // 
            this.guna2RadioButton2.AutoSize = true;
            this.guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.BorderThickness = 0;
            this.guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton2.CheckedState.InnerOffset = -4;
            this.guna2RadioButton2.Location = new System.Drawing.Point(145, 20);
            this.guna2RadioButton2.Name = "guna2RadioButton2";
            this.guna2RadioButton2.Size = new System.Drawing.Size(146, 20);
            this.guna2RadioButton2.TabIndex = 1;
            this.guna2RadioButton2.Text = "Tarjeta Credito/Debito";
            this.guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2RadioButton1
            // 
            this.guna2RadioButton1.AutoSize = true;
            this.guna2RadioButton1.Checked = true;
            this.guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.BorderThickness = 0;
            this.guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2RadioButton1.CheckedState.InnerOffset = -4;
            this.guna2RadioButton1.Location = new System.Drawing.Point(56, 20);
            this.guna2RadioButton1.Name = "guna2RadioButton1";
            this.guna2RadioButton1.Size = new System.Drawing.Size(69, 20);
            this.guna2RadioButton1.TabIndex = 0;
            this.guna2RadioButton1.TabStop = true;
            this.guna2RadioButton1.Text = "Efectivo";
            this.guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2RadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ingrese DNI del Cliente";
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(15, 31);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(818, 259);
            this.dgvProducts.TabIndex = 14;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            // 
            // dgvCart
            // 
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProducto,
            this.Nombre,
            this.Cantidad});
            this.dgvCart.Location = new System.Drawing.Point(15, 314);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(818, 362);
            this.dgvCart.TabIndex = 15;
            // 
            // IDProducto
            // 
            this.IDProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDProducto.HeaderText = "IDProducto";
            this.IDProducto.Name = "IDProducto";
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "NombreProducto";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 682);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(959, 55);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del Carrito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "$0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Subtotal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(184, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "$0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(254, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Items:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(298, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "0";
            // 
            // FormCrearVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 737);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAgregarCarrito);
            this.Controls.Add(this.comboBoxTipoProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCerrarVenta);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panelFinVenta);
            this.Name = "FormCrearVenta";
            this.Text = "FormCrearVenta";
            this.Load += new System.EventHandler(this.FormCrearVenta_Load);
            this.panelFinVenta.ResumeLayout(false);
            this.panelFinVenta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCerrarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipoProductos;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Panel panelFinVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ReaLTaiizor.Controls.HopeDatePicker hopeDatePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton2;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEstadoCliente;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox txtBClienteDNI;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}