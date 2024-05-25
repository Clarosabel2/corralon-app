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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipoProductos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCerrarVenta = new System.Windows.Forms.Button();
            this.btnAgregarCarrito = new System.Windows.Forms.Button();
            this.gbProducto = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblCantidad = new ReaLTaiizor.Controls.NightLabel();
            this.txtBoxCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelFinVenta = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2RadioButton1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2RadioButton2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.hopeDatePicker1 = new ReaLTaiizor.Controls.HopeDatePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbProducto.SuspendLayout();
            this.panelFinVenta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(725, 256);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(15, 312);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(725, 261);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 293);
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
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::UI.Properties.Resources.icons8_remove_from_clipboard_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(746, 314);
            this.button1.MaximumSize = new System.Drawing.Size(107, 57);
            this.button1.MinimumSize = new System.Drawing.Size(107, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 57);
            this.button1.TabIndex = 11;
            this.button1.Text = "Eliminar \r\nItem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCerrarVenta
            // 
            this.buttonCerrarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCerrarVenta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarVenta.Image = global::UI.Properties.Resources.icons8_close_window_20;
            this.buttonCerrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCerrarVenta.Location = new System.Drawing.Point(748, 375);
            this.buttonCerrarVenta.Name = "buttonCerrarVenta";
            this.buttonCerrarVenta.Size = new System.Drawing.Size(107, 57);
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
            this.btnAgregarCarrito.Location = new System.Drawing.Point(746, 233);
            this.btnAgregarCarrito.MaximumSize = new System.Drawing.Size(107, 57);
            this.btnAgregarCarrito.MinimumSize = new System.Drawing.Size(107, 57);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(107, 57);
            this.btnAgregarCarrito.TabIndex = 6;
            this.btnAgregarCarrito.Text = "Agregar \r\na Carrito";
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            // 
            // gbProducto
            // 
            this.gbProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProducto.Controls.Add(this.txtBoxCantidad);
            this.gbProducto.Controls.Add(this.lblCantidad);
            this.gbProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbProducto.Location = new System.Drawing.Point(746, 34);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(107, 193);
            this.gbProducto.TabIndex = 12;
            this.gbProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.lblCantidad.Location = new System.Drawing.Point(19, 85);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxCantidad.DefaultText = "";
            this.txtBoxCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxCantidad.Location = new System.Drawing.Point(3, 105);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.PasswordChar = '\0';
            this.txtBoxCantidad.PlaceholderText = "";
            this.txtBoxCantidad.SelectedText = "";
            this.txtBoxCantidad.Size = new System.Drawing.Size(101, 22);
            this.txtBoxCantidad.TabIndex = 1;
            // 
            // panelFinVenta
            // 
            this.panelFinVenta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFinVenta.Controls.Add(this.label5);
            this.panelFinVenta.Controls.Add(this.button2);
            this.panelFinVenta.Controls.Add(this.label4);
            this.panelFinVenta.Controls.Add(this.hopeDatePicker1);
            this.panelFinVenta.Controls.Add(this.groupBox1);
            this.panelFinVenta.Controls.Add(this.guna2TextBox1);
            this.panelFinVenta.Controls.Add(this.label3);
            this.panelFinVenta.Location = new System.Drawing.Point(272, 44);
            this.panelFinVenta.Name = "panelFinVenta";
            this.panelFinVenta.Size = new System.Drawing.Size(373, 514);
            this.panelFinVenta.TabIndex = 13;
            this.panelFinVenta.Visible = false;
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
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(6, 31);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 1;
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
            // hopeDatePicker1
            // 
            this.hopeDatePicker1.BackColor = System.Drawing.Color.White;
            this.hopeDatePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeDatePicker1.Date = new System.DateTime(2024, 5, 31, 0, 0, 0, 0);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(212, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cliente Registrado";
            // 
            // FormCrearVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 579);
            this.Controls.Add(this.panelFinVenta);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarCarrito);
            this.Controls.Add(this.comboBoxTipoProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCerrarVenta);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "FormCrearVenta";
            this.Text = "FormCrearVenta";
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.panelFinVenta.ResumeLayout(false);
            this.panelFinVenta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button buttonCerrarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipoProductos;
        private System.Windows.Forms.Button btnAgregarCarrito;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2GroupBox gbProducto;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxCantidad;
        private ReaLTaiizor.Controls.NightLabel lblCantidad;
        private System.Windows.Forms.Panel panelFinVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ReaLTaiizor.Controls.HopeDatePicker hopeDatePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton2;
        private Guna.UI2.WinForms.Guna2RadioButton guna2RadioButton1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}