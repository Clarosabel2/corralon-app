namespace UI
{
    partial class FormOrderDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.tlpPedido = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.txtFechaEmision = new System.Windows.Forms.TextBox();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.tlpCliente = new System.Windows.Forms.TableLayoutPanel();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.lblClienteEmail = new System.Windows.Forms.Label();
            this.txtClienteEmail = new System.Windows.Forms.TextBox();
            this.lblClienteTel = new System.Windows.Forms.Label();
            this.txtClienteTel = new System.Windows.Forms.TextBox();
            this.gbVendedor = new System.Windows.Forms.GroupBox();
            this.tlpVendedor = new System.Windows.Forms.TableLayoutPanel();
            this.lblVendedorNombre = new System.Windows.Forms.Label();
            this.txtVendedorNombre = new System.Windows.Forms.TextBox();
            this.gbRepartidor = new System.Windows.Forms.GroupBox();
            this.tlpRepartidor = new System.Windows.Forms.TableLayoutPanel();
            this.lblRepartidorNombre = new System.Windows.Forms.Label();
            this.txtRepartidorNombre = new System.Windows.Forms.TextBox();
            this.lblTracking = new System.Windows.Forms.Label();
            this.txtTracking = new System.Windows.Forms.TextBox();
            this.gbTiempos = new System.Windows.Forms.GroupBox();
            this.tlpTiempos = new System.Windows.Forms.TableLayoutPanel();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTotales = new System.Windows.Forms.GroupBox();
            this.tlpTotales = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.txtEnvio = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.flpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.gbPedido.SuspendLayout();
            this.tlpPedido.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.tlpCliente.SuspendLayout();
            this.gbVendedor.SuspendLayout();
            this.tlpVendedor.SuspendLayout();
            this.gbRepartidor.SuspendLayout();
            this.tlpRepartidor.SuspendLayout();
            this.gbTiempos.SuspendLayout();
            this.tlpTiempos.SuspendLayout();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbTotales.SuspendLayout();
            this.tlpTotales.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            this.flpAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.gbPedido, 0, 0);
            this.tlpMain.Controls.Add(this.gbCliente, 0, 1);
            this.tlpMain.Controls.Add(this.gbVendedor, 0, 2);
            this.tlpMain.Controls.Add(this.gbRepartidor, 1, 2);
            this.tlpMain.Controls.Add(this.gbTiempos, 0, 3);
            this.tlpMain.Controls.Add(this.gbProductos, 0, 4);
            this.tlpMain.Controls.Add(this.gbTotales, 0, 5);
            this.tlpMain.Controls.Add(this.panelAcciones, 1, 5);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(10);
            this.tlpMain.RowCount = 6;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(900, 800);
            this.tlpMain.TabIndex = 0;
            // 
            // gbPedido
            // 
            this.tlpMain.SetColumnSpan(this.gbPedido, 2);
            this.gbPedido.Controls.Add(this.tlpPedido);
            this.gbPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.gbPedido.Location = new System.Drawing.Point(13, 13);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Padding = new System.Windows.Forms.Padding(10);
            this.gbPedido.Size = new System.Drawing.Size(874, 55);
            this.gbPedido.TabIndex = 0;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Pedido";
            // 
            // tlpPedido
            // 
            this.tlpPedido.ColumnCount = 8;
            this.tlpPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPedido.Controls.Add(this.lblOrderId, 0, 0);
            this.tlpPedido.Controls.Add(this.txtOrderId, 1, 0);
            this.tlpPedido.Controls.Add(this.lblFechaEmision, 2, 0);
            this.tlpPedido.Controls.Add(this.txtFechaEmision, 3, 0);
            this.tlpPedido.Controls.Add(this.lblFechaEntrega, 4, 0);
            this.tlpPedido.Controls.Add(this.txtFechaEntrega, 5, 0);
            this.tlpPedido.Controls.Add(this.lblEstado, 6, 0);
            this.tlpPedido.Controls.Add(this.txtEstado, 7, 0);
            this.tlpPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPedido.Location = new System.Drawing.Point(10, 25);
            this.tlpPedido.Name = "tlpPedido";
            this.tlpPedido.RowCount = 1;
            this.tlpPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPedido.Size = new System.Drawing.Size(854, 20);
            this.tlpPedido.TabIndex = 0;
            // 
            // lblOrderId
            // 
            this.lblOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(3, 1);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(23, 17);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "ID:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderId.Location = new System.Drawing.Point(32, 3);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(130, 22);
            this.txtOrderId.TabIndex = 1;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Location = new System.Drawing.Point(175, 1);
            this.lblFechaEmision.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(94, 17);
            this.lblFechaEmision.TabIndex = 2;
            this.lblFechaEmision.Text = "Fecha Emisión:";
            // 
            // txtFechaEmision
            // 
            this.txtFechaEmision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaEmision.Location = new System.Drawing.Point(275, 3);
            this.txtFechaEmision.Name = "txtFechaEmision";
            this.txtFechaEmision.ReadOnly = true;
            this.txtFechaEmision.Size = new System.Drawing.Size(130, 22);
            this.txtFechaEmision.TabIndex = 3;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(418, 1);
            this.lblFechaEntrega.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(97, 17);
            this.lblFechaEntrega.TabIndex = 4;
            this.lblFechaEntrega.Text = "Fecha Entrega:";
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaEntrega.Location = new System.Drawing.Point(521, 3);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.ReadOnly = true;
            this.txtFechaEntrega.Size = new System.Drawing.Size(130, 22);
            this.txtFechaEntrega.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(664, 1);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 17);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstado.Location = new System.Drawing.Point(721, 3);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(130, 22);
            this.txtEstado.TabIndex = 7;
            // 
            // gbCliente
            // 
            this.tlpMain.SetColumnSpan(this.gbCliente, 2);
            this.gbCliente.Controls.Add(this.tlpCliente);
            this.gbCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.gbCliente.Location = new System.Drawing.Point(13, 74);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(10);
            this.gbCliente.Size = new System.Drawing.Size(874, 55);
            this.gbCliente.TabIndex = 1;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // tlpCliente
            // 
            this.tlpCliente.ColumnCount = 6;
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCliente.Controls.Add(this.lblClienteNombre, 0, 0);
            this.tlpCliente.Controls.Add(this.txtClienteNombre, 1, 0);
            this.tlpCliente.Controls.Add(this.lblClienteEmail, 2, 0);
            this.tlpCliente.Controls.Add(this.txtClienteEmail, 3, 0);
            this.tlpCliente.Controls.Add(this.lblClienteTel, 4, 0);
            this.tlpCliente.Controls.Add(this.txtClienteTel, 5, 0);
            this.tlpCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCliente.Location = new System.Drawing.Point(10, 25);
            this.tlpCliente.Name = "tlpCliente";
            this.tlpCliente.RowCount = 1;
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCliente.Size = new System.Drawing.Size(854, 20);
            this.tlpCliente.TabIndex = 1;
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Location = new System.Drawing.Point(3, 1);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(59, 17);
            this.lblClienteNombre.TabIndex = 0;
            this.lblClienteNombre.Text = "Nombre:";
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteNombre.Location = new System.Drawing.Point(68, 3);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.ReadOnly = true;
            this.txtClienteNombre.Size = new System.Drawing.Size(213, 22);
            this.txtClienteNombre.TabIndex = 1;
            // 
            // lblClienteEmail
            // 
            this.lblClienteEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClienteEmail.AutoSize = true;
            this.lblClienteEmail.Location = new System.Drawing.Point(294, 1);
            this.lblClienteEmail.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblClienteEmail.Name = "lblClienteEmail";
            this.lblClienteEmail.Size = new System.Drawing.Size(42, 17);
            this.lblClienteEmail.TabIndex = 2;
            this.lblClienteEmail.Text = "Email:";
            // 
            // txtClienteEmail
            // 
            this.txtClienteEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteEmail.Location = new System.Drawing.Point(342, 3);
            this.txtClienteEmail.Name = "txtClienteEmail";
            this.txtClienteEmail.ReadOnly = true;
            this.txtClienteEmail.Size = new System.Drawing.Size(213, 22);
            this.txtClienteEmail.TabIndex = 3;
            // 
            // lblClienteTel
            // 
            this.lblClienteTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClienteTel.AutoSize = true;
            this.lblClienteTel.Location = new System.Drawing.Point(568, 1);
            this.lblClienteTel.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblClienteTel.Name = "lblClienteTel";
            this.lblClienteTel.Size = new System.Drawing.Size(62, 17);
            this.lblClienteTel.TabIndex = 4;
            this.lblClienteTel.Text = "Teléfono:";
            // 
            // txtClienteTel
            // 
            this.txtClienteTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteTel.Location = new System.Drawing.Point(636, 3);
            this.txtClienteTel.Name = "txtClienteTel";
            this.txtClienteTel.ReadOnly = true;
            this.txtClienteTel.Size = new System.Drawing.Size(215, 22);
            this.txtClienteTel.TabIndex = 5;
            // 
            // gbVendedor
            // 
            this.gbVendedor.Controls.Add(this.tlpVendedor);
            this.gbVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.gbVendedor.Location = new System.Drawing.Point(13, 135);
            this.gbVendedor.Name = "gbVendedor";
            this.gbVendedor.Padding = new System.Windows.Forms.Padding(10);
            this.gbVendedor.Size = new System.Drawing.Size(434, 55);
            this.gbVendedor.TabIndex = 2;
            this.gbVendedor.TabStop = false;
            this.gbVendedor.Text = "Vendedor";
            // 
            // tlpVendedor
            // 
            this.tlpVendedor.ColumnCount = 2;
            this.tlpVendedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpVendedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVendedor.Controls.Add(this.lblVendedorNombre, 0, 0);
            this.tlpVendedor.Controls.Add(this.txtVendedorNombre, 1, 0);
            this.tlpVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVendedor.Location = new System.Drawing.Point(10, 25);
            this.tlpVendedor.Name = "tlpVendedor";
            this.tlpVendedor.RowCount = 1;
            this.tlpVendedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVendedor.Size = new System.Drawing.Size(414, 20);
            this.tlpVendedor.TabIndex = 0;
            // 
            // lblVendedorNombre
            // 
            this.lblVendedorNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVendedorNombre.AutoSize = true;
            this.lblVendedorNombre.Location = new System.Drawing.Point(3, 1);
            this.lblVendedorNombre.Name = "lblVendedorNombre";
            this.lblVendedorNombre.Size = new System.Drawing.Size(59, 17);
            this.lblVendedorNombre.TabIndex = 0;
            this.lblVendedorNombre.Text = "Nombre:";
            // 
            // txtVendedorNombre
            // 
            this.txtVendedorNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVendedorNombre.Location = new System.Drawing.Point(68, 3);
            this.txtVendedorNombre.Name = "txtVendedorNombre";
            this.txtVendedorNombre.ReadOnly = true;
            this.txtVendedorNombre.Size = new System.Drawing.Size(343, 22);
            this.txtVendedorNombre.TabIndex = 1;
            // 
            // gbRepartidor
            // 
            this.gbRepartidor.Controls.Add(this.tlpRepartidor);
            this.gbRepartidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRepartidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.gbRepartidor.Location = new System.Drawing.Point(453, 135);
            this.gbRepartidor.Name = "gbRepartidor";
            this.gbRepartidor.Padding = new System.Windows.Forms.Padding(10);
            this.gbRepartidor.Size = new System.Drawing.Size(434, 55);
            this.gbRepartidor.TabIndex = 3;
            this.gbRepartidor.TabStop = false;
            this.gbRepartidor.Text = "Repartidor";
            // 
            // tlpRepartidor
            // 
            this.tlpRepartidor.ColumnCount = 4;
            this.tlpRepartidor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpRepartidor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRepartidor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpRepartidor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRepartidor.Controls.Add(this.lblRepartidorNombre, 0, 0);
            this.tlpRepartidor.Controls.Add(this.txtRepartidorNombre, 1, 0);
            this.tlpRepartidor.Controls.Add(this.lblTracking, 2, 0);
            this.tlpRepartidor.Controls.Add(this.txtTracking, 3, 0);
            this.tlpRepartidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRepartidor.Location = new System.Drawing.Point(10, 25);
            this.tlpRepartidor.Name = "tlpRepartidor";
            this.tlpRepartidor.RowCount = 1;
            this.tlpRepartidor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRepartidor.Size = new System.Drawing.Size(414, 20);
            this.tlpRepartidor.TabIndex = 1;
            // 
            // lblRepartidorNombre
            // 
            this.lblRepartidorNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRepartidorNombre.AutoSize = true;
            this.lblRepartidorNombre.Location = new System.Drawing.Point(3, 1);
            this.lblRepartidorNombre.Name = "lblRepartidorNombre";
            this.lblRepartidorNombre.Size = new System.Drawing.Size(59, 17);
            this.lblRepartidorNombre.TabIndex = 0;
            this.lblRepartidorNombre.Text = "Nombre:";
            // 
            // txtRepartidorNombre
            // 
            this.txtRepartidorNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepartidorNombre.Location = new System.Drawing.Point(68, 3);
            this.txtRepartidorNombre.Name = "txtRepartidorNombre";
            this.txtRepartidorNombre.ReadOnly = true;
            this.txtRepartidorNombre.Size = new System.Drawing.Size(132, 22);
            this.txtRepartidorNombre.TabIndex = 1;
            // 
            // lblTracking
            // 
            this.lblTracking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTracking.AutoSize = true;
            this.lblTracking.Location = new System.Drawing.Point(213, 1);
            this.lblTracking.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblTracking.Name = "lblTracking";
            this.lblTracking.Size = new System.Drawing.Size(60, 17);
            this.lblTracking.TabIndex = 2;
            this.lblTracking.Text = "Tracking:";
            // 
            // txtTracking
            // 
            this.txtTracking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTracking.Location = new System.Drawing.Point(279, 3);
            this.txtTracking.Name = "txtTracking";
            this.txtTracking.ReadOnly = true;
            this.txtTracking.Size = new System.Drawing.Size(132, 22);
            this.txtTracking.TabIndex = 3;
            // 
            // gbTiempos
            // 
            this.tlpMain.SetColumnSpan(this.gbTiempos, 2);
            this.gbTiempos.Controls.Add(this.tlpTiempos);
            this.gbTiempos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTiempos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.gbTiempos.Location = new System.Drawing.Point(13, 196);
            this.gbTiempos.Name = "gbTiempos";
            this.gbTiempos.Padding = new System.Windows.Forms.Padding(10);
            this.gbTiempos.Size = new System.Drawing.Size(874, 55);
            this.gbTiempos.TabIndex = 4;
            this.gbTiempos.TabStop = false;
            this.gbTiempos.Text = "Tiempos del Pedido";
            // 
            // tlpTiempos
            // 
            this.tlpTiempos.ColumnCount = 4;
            this.tlpTiempos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTiempos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTiempos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTiempos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTiempos.Controls.Add(this.lblHoraSalida, 0, 0);
            this.tlpTiempos.Controls.Add(this.txtHoraSalida, 1, 0);
            this.tlpTiempos.Controls.Add(this.lblDuracion, 2, 0);
            this.tlpTiempos.Controls.Add(this.txtDuracion, 3, 0);
            this.tlpTiempos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTiempos.Location = new System.Drawing.Point(10, 25);
            this.tlpTiempos.Name = "tlpTiempos";
            this.tlpTiempos.RowCount = 1;
            this.tlpTiempos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTiempos.Size = new System.Drawing.Size(854, 20);
            this.tlpTiempos.TabIndex = 2;
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Location = new System.Drawing.Point(3, 1);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(48, 17);
            this.lblHoraSalida.TabIndex = 0;
            this.lblHoraSalida.Text = "Salida:";
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoraSalida.Location = new System.Drawing.Point(57, 3);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.ReadOnly = true;
            this.txtHoraSalida.Size = new System.Drawing.Size(355, 22);
            this.txtHoraSalida.TabIndex = 1;
            // 
            // lblDuracion
            // 
            this.lblDuracion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(425, 1);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(65, 17);
            this.lblDuracion.TabIndex = 2;
            this.lblDuracion.Text = "Duración:";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuracion.Location = new System.Drawing.Point(496, 3);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.ReadOnly = true;
            this.txtDuracion.Size = new System.Drawing.Size(355, 22);
            this.txtDuracion.TabIndex = 3;
            // 
            // gbProductos
            // 
            this.tlpMain.SetColumnSpan(this.gbProductos, 2);
            this.gbProductos.Controls.Add(this.dgvProductos);
            this.gbProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.gbProductos.Location = new System.Drawing.Point(13, 257);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Padding = new System.Windows.Forms.Padding(10);
            this.gbProductos.Size = new System.Drawing.Size(874, 383);
            this.gbProductos.TabIndex = 5;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos Comprados";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductos.ColumnHeadersHeight = 30;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colCantidad,
            this.colPrecioUnitario,
            this.colSubtotal});
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.dgvProductos.Location = new System.Drawing.Point(10, 25);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(854, 348);
            this.dgvProductos.TabIndex = 0;
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 150F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 150;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCantidad.DefaultCellStyle = dataGridViewCellStyle8;
            this.colCantidad.FillWeight = 60F;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "C2";
            this.colPrecioUnitario.DefaultCellStyle = dataGridViewCellStyle9;
            this.colPrecioUnitario.FillWeight = 80F;
            this.colPrecioUnitario.HeaderText = "P. Unitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            // 
            // colSubtotal
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.Format = "C2";
            this.colSubtotal.DefaultCellStyle = dataGridViewCellStyle10;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // gbTotales
            // 
            this.gbTotales.Controls.Add(this.tlpTotales);
            this.gbTotales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTotales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.gbTotales.Location = new System.Drawing.Point(13, 646);
            this.gbTotales.Name = "gbTotales";
            this.gbTotales.Padding = new System.Windows.Forms.Padding(10);
            this.gbTotales.Size = new System.Drawing.Size(434, 141);
            this.gbTotales.TabIndex = 6;
            this.gbTotales.TabStop = false;
            this.gbTotales.Text = "Totales";
            // 
            // tlpTotales
            // 
            this.tlpTotales.ColumnCount = 2;
            this.tlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTotales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotales.Controls.Add(this.lblSubtotal, 0, 0);
            this.tlpTotales.Controls.Add(this.txtSubtotal, 1, 0);
            this.tlpTotales.Controls.Add(this.lblEnvio, 0, 1);
            this.tlpTotales.Controls.Add(this.txtEnvio, 1, 1);
            this.tlpTotales.Controls.Add(this.lblDescuento, 0, 2);
            this.tlpTotales.Controls.Add(this.txtDescuento, 1, 2);
            this.tlpTotales.Controls.Add(this.lblTotal, 0, 3);
            this.tlpTotales.Controls.Add(this.txtTotal, 1, 3);
            this.tlpTotales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTotales.Location = new System.Drawing.Point(10, 25);
            this.tlpTotales.Name = "tlpTotales";
            this.tlpTotales.RowCount = 4;
            this.tlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTotales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTotales.Size = new System.Drawing.Size(414, 106);
            this.tlpTotales.TabIndex = 0;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(3, 4);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(62, 17);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtotal.Location = new System.Drawing.Point(85, 3);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(326, 22);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEnvio
            // 
            this.lblEnvio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Location = new System.Drawing.Point(3, 30);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(43, 17);
            this.lblEnvio.TabIndex = 2;
            this.lblEnvio.Text = "Envío:";
            // 
            // txtEnvio
            // 
            this.txtEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnvio.Location = new System.Drawing.Point(85, 29);
            this.txtEnvio.Name = "txtEnvio";
            this.txtEnvio.ReadOnly = true;
            this.txtEnvio.Size = new System.Drawing.Size(326, 22);
            this.txtEnvio.TabIndex = 3;
            this.txtEnvio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescuento
            // 
            this.lblDescuento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(3, 56);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(76, 17);
            this.lblDescuento.TabIndex = 4;
            this.lblDescuento.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescuento.Location = new System.Drawing.Point(85, 55);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(326, 22);
            this.txtDescuento.TabIndex = 5;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(3, 84);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 16);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(85, 81);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(326, 22);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelAcciones
            // 
            this.panelAcciones.Controls.Add(this.flpAcciones);
            this.panelAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAcciones.Location = new System.Drawing.Point(453, 646);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(434, 141);
            this.panelAcciones.TabIndex = 7;
            // 
            // flpAcciones
            // 
            this.flpAcciones.Controls.Add(this.btnClose);
            this.flpAcciones.Controls.Add(this.btnImprimir);
            this.flpAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAcciones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpAcciones.Location = new System.Drawing.Point(0, 0);
            this.flpAcciones.Name = "flpAcciones";
            this.flpAcciones.Padding = new System.Windows.Forms.Padding(10);
            this.flpAcciones.Size = new System.Drawing.Size(434, 141);
            this.flpAcciones.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(291, 20);
            this.btnClose.Margin = new System.Windows.Forms.Padding(10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 33);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(158, 20);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(10);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(113, 33);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // FormOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 800);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle del Pedido";
            this.tlpMain.ResumeLayout(false);
            this.gbPedido.ResumeLayout(false);
            this.tlpPedido.ResumeLayout(false);
            this.tlpPedido.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.tlpCliente.ResumeLayout(false);
            this.tlpCliente.PerformLayout();
            this.gbVendedor.ResumeLayout(false);
            this.tlpVendedor.ResumeLayout(false);
            this.tlpVendedor.PerformLayout();
            this.gbRepartidor.ResumeLayout(false);
            this.tlpRepartidor.ResumeLayout(false);
            this.tlpRepartidor.PerformLayout();
            this.gbTiempos.ResumeLayout(false);
            this.tlpTiempos.ResumeLayout(false);
            this.tlpTiempos.PerformLayout();
            this.gbProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbTotales.ResumeLayout(false);
            this.tlpTotales.ResumeLayout(false);
            this.tlpTotales.PerformLayout();
            this.panelAcciones.ResumeLayout(false);
            this.flpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.GroupBox gbVendedor;
        private System.Windows.Forms.GroupBox gbRepartidor;
        private System.Windows.Forms.GroupBox gbTiempos;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.GroupBox gbTotales;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.TableLayoutPanel tlpPedido;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.TextBox txtFechaEmision;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TableLayoutPanel tlpCliente;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Label lblClienteEmail;
        private System.Windows.Forms.TextBox txtClienteEmail;
        private System.Windows.Forms.Label lblClienteTel;
        private System.Windows.Forms.TextBox txtClienteTel;
        private System.Windows.Forms.TableLayoutPanel tlpVendedor;
        private System.Windows.Forms.Label lblVendedorNombre;
        private System.Windows.Forms.TextBox txtVendedorNombre;
        private System.Windows.Forms.TableLayoutPanel tlpRepartidor;
        private System.Windows.Forms.Label lblRepartidorNombre;
        private System.Windows.Forms.TextBox txtRepartidorNombre;
        private System.Windows.Forms.Label lblTracking;
        private System.Windows.Forms.TextBox txtTracking;
        private System.Windows.Forms.TableLayoutPanel tlpTiempos;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.TextBox txtHoraSalida;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TableLayoutPanel tlpTotales;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.TextBox txtEnvio;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.FlowLayoutPanel flpAcciones;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.TextBox txtFechaEntrega;
    }
}