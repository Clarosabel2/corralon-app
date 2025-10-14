using System;
using System.Windows.Forms;

namespace UI
{
    partial class FormFinalizeSale
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.tlpCliente = new System.Windows.Forms.TableLayoutPanel();
            this.txtDNIClient = new System.Windows.Forms.TextBox();
            this.grpEntrega = new System.Windows.Forms.GroupBox();
            this.tlpEntrega = new System.Windows.Forms.TableLayoutPanel();
            this.lblNotify = new System.Windows.Forms.Label();
            this.lblModoEntrega = new System.Windows.Forms.Label();
            this.pnlModoEntrega = new System.Windows.Forms.FlowLayoutPanel();
            this.rbRetiroLocal = new System.Windows.Forms.RadioButton();
            this.rbEnvioDomicilio = new System.Windows.Forms.RadioButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpDeliveryHour = new System.Windows.Forms.DateTimePicker();
            this.lblDireccionEntrega = new System.Windows.Forms.Label();
            this.txtDireccionEntrega = new System.Windows.Forms.TextBox();
            this.lblCostoEnvio = new System.Windows.Forms.Label();
            this.nudCostoEnvio = new System.Windows.Forms.NumericUpDown();
            this.lblObsEntrega = new System.Windows.Forms.Label();
            this.txtObservacionesEntrega = new System.Windows.Forms.TextBox();
            this.flpNotifyChks = new System.Windows.Forms.FlowLayoutPanel();
            this.chkNotifyWhatsapp = new System.Windows.Forms.CheckBox();
            this.chkNotifyEmail = new System.Windows.Forms.CheckBox();
            this.grpObservaciones = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.grpComprobante = new System.Windows.Forms.GroupBox();
            this.tlpComprobante = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.cBTypesInvoice = new System.Windows.Forms.ComboBox();
            this.lblPtoVta = new System.Windows.Forms.Label();
            this.txtPtoVta = new System.Windows.Forms.TextBox();
            this.lblNroComp = new System.Windows.Forms.Label();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.tlpPago = new System.Windows.Forms.TableLayoutPanel();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.lblUltimos4 = new System.Windows.Forms.Label();
            this.txtUltimos4 = new System.Windows.Forms.TextBox();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.cmbCuotas = new System.Windows.Forms.ComboBox();
            this.lblComprobanteTransf = new System.Windows.Forms.Label();
            this.txtComprobanteTransf = new System.Windows.Forms.TextBox();
            this.btnAdjuntarComp = new System.Windows.Forms.Button();
            this.lblLimiteCC = new System.Windows.Forms.Label();
            this.lblDescuentoPorc = new System.Windows.Forms.Label();
            this.nudDescuentoPorc = new System.Windows.Forms.NumericUpDown();
            this.lblDescuentoMonto = new System.Windows.Forms.Label();
            this.nudDescuentoMonto = new System.Windows.Forms.NumericUpDown();
            this.lblRecargoPorc = new System.Windows.Forms.Label();
            this.nudRecargoPorc = new System.Windows.Forms.NumericUpDown();
            this.grpResumen = new System.Windows.Forms.GroupBox();
            this.tlpResumen = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCartSummary = new System.Windows.Forms.DataGridView();
            this.colImgProduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpTotals = new System.Windows.Forms.TableLayoutPanel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalValue = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblIvaValue = new System.Windows.Forms.Label();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.lblEnvioValue = new System.Windows.Forms.Label();
            this.lblDescuentos = new System.Windows.Forms.Label();
            this.lblDescuentosValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.flpActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDraft = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tlpRoot.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            this.grpCliente.SuspendLayout();
            this.tlpCliente.SuspendLayout();
            this.grpEntrega.SuspendLayout();
            this.tlpEntrega.SuspendLayout();
            this.pnlModoEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoEnvio)).BeginInit();
            this.flpNotifyChks.SuspendLayout();
            this.grpObservaciones.SuspendLayout();
            this.tlpRight.SuspendLayout();
            this.grpComprobante.SuspendLayout();
            this.tlpComprobante.SuspendLayout();
            this.grpPago.SuspendLayout();
            this.tlpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuentoPorc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuentoMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecargoPorc)).BeginInit();
            this.grpResumen.SuspendLayout();
            this.tlpResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartSummary)).BeginInit();
            this.tlpTotals.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.flpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Controls.Add(this.lblHeader, 0, 0);
            this.tlpRoot.Controls.Add(this.tlpContent, 0, 1);
            this.tlpRoot.Controls.Add(this.pnlActions, 0, 2);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 3;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.070492F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.86909F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.060421F));
            this.tlpRoot.Size = new System.Drawing.Size(1743, 1353);
            this.tlpRoot.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(10, 10);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1723, 75);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Confirmar venta";
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpContent.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpContent.Controls.Add(this.tlpRight, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(3, 98);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(1737, 1169);
            this.tlpContent.TabIndex = 1;
            // 
            // tlpLeft
            // 
            this.tlpLeft.AutoSize = true;
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Controls.Add(this.grpCliente, 0, 0);
            this.tlpLeft.Controls.Add(this.grpEntrega, 0, 1);
            this.tlpLeft.Controls.Add(this.grpObservaciones, 0, 2);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(3, 3);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 3;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Size = new System.Drawing.Size(1036, 1163);
            this.tlpLeft.TabIndex = 0;
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.lblDniCliente);
            this.grpCliente.Controls.Add(this.tlpCliente);
            this.grpCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCliente.Location = new System.Drawing.Point(3, 3);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.grpCliente.Size = new System.Drawing.Size(1030, 96);
            this.grpCliente.TabIndex = 0;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Location = new System.Drawing.Point(14, 45);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(62, 30);
            this.lblDniCliente.TabIndex = 0;
            this.lblDniCliente.Text = "DNI:";
            // 
            // tlpCliente
            // 
            this.tlpCliente.AutoSize = true;
            this.tlpCliente.ColumnCount = 2;
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCliente.Controls.Add(this.txtDNIClient, 1, 0);
            this.tlpCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCliente.Location = new System.Drawing.Point(10, 40);
            this.tlpCliente.Name = "tlpCliente";
            this.tlpCliente.RowCount = 1;
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCliente.Size = new System.Drawing.Size(1010, 46);
            this.tlpCliente.TabIndex = 0;
            // 
            // txtDNIClient
            // 
            this.txtDNIClient.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDNIClient.Location = new System.Drawing.Point(77, 3);
            this.txtDNIClient.Name = "txtDNIClient";
            this.txtDNIClient.Size = new System.Drawing.Size(930, 37);
            this.txtDNIClient.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtDNIClient, "Ingrese el DNI del cliente (solo números)");
            this.txtDNIClient.TextChanged += new System.EventHandler(this.txtDNIClient_TextChanged);
            // 
            // grpEntrega
            // 
            this.grpEntrega.Controls.Add(this.tlpEntrega);
            this.grpEntrega.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEntrega.Location = new System.Drawing.Point(3, 105);
            this.grpEntrega.Name = "grpEntrega";
            this.grpEntrega.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.grpEntrega.Size = new System.Drawing.Size(1030, 664);
            this.grpEntrega.TabIndex = 1;
            this.grpEntrega.TabStop = false;
            this.grpEntrega.Text = "Entrega";
            // 
            // tlpEntrega
            // 
            this.tlpEntrega.AutoSize = true;
            this.tlpEntrega.ColumnCount = 2;
            this.tlpEntrega.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpEntrega.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEntrega.Controls.Add(this.lblNotify, 0, 5);
            this.tlpEntrega.Controls.Add(this.lblModoEntrega, 0, 0);
            this.tlpEntrega.Controls.Add(this.pnlModoEntrega, 1, 0);
            this.tlpEntrega.Controls.Add(this.lblFecha, 0, 1);
            this.tlpEntrega.Controls.Add(this.dtpDeliveryDate, 1, 1);
            this.tlpEntrega.Controls.Add(this.lblHora, 0, 2);
            this.tlpEntrega.Controls.Add(this.dtpDeliveryHour, 1, 2);
            this.tlpEntrega.Controls.Add(this.lblDireccionEntrega, 0, 3);
            this.tlpEntrega.Controls.Add(this.txtDireccionEntrega, 1, 3);
            this.tlpEntrega.Controls.Add(this.lblCostoEnvio, 0, 4);
            this.tlpEntrega.Controls.Add(this.nudCostoEnvio, 1, 4);
            this.tlpEntrega.Controls.Add(this.lblObsEntrega, 0, 6);
            this.tlpEntrega.Controls.Add(this.txtObservacionesEntrega, 1, 6);
            this.tlpEntrega.Controls.Add(this.flpNotifyChks, 1, 5);
            this.tlpEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEntrega.Location = new System.Drawing.Point(10, 40);
            this.tlpEntrega.Name = "tlpEntrega";
            this.tlpEntrega.RowCount = 7;
            this.tlpEntrega.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEntrega.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEntrega.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEntrega.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEntrega.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEntrega.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpEntrega.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tlpEntrega.Size = new System.Drawing.Size(1010, 614);
            this.tlpEntrega.TabIndex = 0;
            // 
            // lblNotify
            // 
            this.lblNotify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNotify.AutoSize = true;
            this.lblNotify.Location = new System.Drawing.Point(3, 236);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(167, 30);
            this.lblNotify.TabIndex = 13;
            this.lblNotify.Text = "Notificar por:";
            // 
            // lblModoEntrega
            // 
            this.lblModoEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblModoEntrega.AutoSize = true;
            this.lblModoEntrega.Location = new System.Drawing.Point(3, 8);
            this.lblModoEntrega.Name = "lblModoEntrega";
            this.lblModoEntrega.Size = new System.Drawing.Size(91, 30);
            this.lblModoEntrega.TabIndex = 0;
            this.lblModoEntrega.Text = "Modo:";
            // 
            // pnlModoEntrega
            // 
            this.pnlModoEntrega.AutoSize = true;
            this.pnlModoEntrega.Controls.Add(this.rbRetiroLocal);
            this.pnlModoEntrega.Controls.Add(this.rbEnvioDomicilio);
            this.pnlModoEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModoEntrega.Location = new System.Drawing.Point(209, 3);
            this.pnlModoEntrega.Name = "pnlModoEntrega";
            this.pnlModoEntrega.Size = new System.Drawing.Size(798, 40);
            this.pnlModoEntrega.TabIndex = 1;
            // 
            // rbRetiroLocal
            // 
            this.rbRetiroLocal.AutoSize = true;
            this.rbRetiroLocal.Checked = true;
            this.rbRetiroLocal.Location = new System.Drawing.Point(3, 3);
            this.rbRetiroLocal.Name = "rbRetiroLocal";
            this.rbRetiroLocal.Size = new System.Drawing.Size(173, 34);
            this.rbRetiroLocal.TabIndex = 0;
            this.rbRetiroLocal.TabStop = true;
            this.rbRetiroLocal.Text = "Retiro local";
            this.rbRetiroLocal.UseVisualStyleBackColor = true;
            this.rbRetiroLocal.CheckedChanged += new System.EventHandler(this.rbRetiroLocal_CheckedChanged);
            // 
            // rbEnvioDomicilio
            // 
            this.rbEnvioDomicilio.AutoSize = true;
            this.rbEnvioDomicilio.Location = new System.Drawing.Point(182, 3);
            this.rbEnvioDomicilio.Name = "rbEnvioDomicilio";
            this.rbEnvioDomicilio.Size = new System.Drawing.Size(245, 34);
            this.rbEnvioDomicilio.TabIndex = 1;
            this.rbEnvioDomicilio.Text = "Envío a domicilio";
            this.rbEnvioDomicilio.UseVisualStyleBackColor = true;
            this.rbEnvioDomicilio.CheckedChanged += new System.EventHandler(this.rbEnvioDomicilio_CheckedChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(3, 52);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(95, 30);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(209, 49);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(619, 37);
            this.dtpDeliveryDate.TabIndex = 3;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(3, 95);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(75, 30);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora:";
            // 
            // dtpDeliveryHour
            // 
            this.dtpDeliveryHour.CustomFormat = "HH:mm";
            this.dtpDeliveryHour.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpDeliveryHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDeliveryHour.Location = new System.Drawing.Point(209, 92);
            this.dtpDeliveryHour.Name = "dtpDeliveryHour";
            this.dtpDeliveryHour.ShowUpDown = true;
            this.dtpDeliveryHour.Size = new System.Drawing.Size(172, 37);
            this.dtpDeliveryHour.TabIndex = 5;
            // 
            // lblDireccionEntrega
            // 
            this.lblDireccionEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDireccionEntrega.AutoSize = true;
            this.lblDireccionEntrega.Location = new System.Drawing.Point(3, 138);
            this.lblDireccionEntrega.Name = "lblDireccionEntrega";
            this.lblDireccionEntrega.Size = new System.Drawing.Size(136, 30);
            this.lblDireccionEntrega.TabIndex = 6;
            this.lblDireccionEntrega.Text = "Dirección:";
            // 
            // txtDireccionEntrega
            // 
            this.txtDireccionEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDireccionEntrega.Location = new System.Drawing.Point(209, 135);
            this.txtDireccionEntrega.Name = "txtDireccionEntrega";
            this.txtDireccionEntrega.Size = new System.Drawing.Size(798, 37);
            this.txtDireccionEntrega.TabIndex = 7;
            // 
            // lblCostoEnvio
            // 
            this.lblCostoEnvio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCostoEnvio.AutoSize = true;
            this.lblCostoEnvio.Location = new System.Drawing.Point(3, 181);
            this.lblCostoEnvio.Name = "lblCostoEnvio";
            this.lblCostoEnvio.Size = new System.Drawing.Size(160, 30);
            this.lblCostoEnvio.TabIndex = 8;
            this.lblCostoEnvio.Text = "Despues de:";
            // 
            // nudCostoEnvio
            // 
            this.nudCostoEnvio.DecimalPlaces = 2;
            this.nudCostoEnvio.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudCostoEnvio.Enabled = false;
            this.nudCostoEnvio.Location = new System.Drawing.Point(209, 178);
            this.nudCostoEnvio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCostoEnvio.Name = "nudCostoEnvio";
            this.nudCostoEnvio.Size = new System.Drawing.Size(174, 37);
            this.nudCostoEnvio.TabIndex = 9;
            this.nudCostoEnvio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblObsEntrega
            // 
            this.lblObsEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblObsEntrega.AutoSize = true;
            this.lblObsEntrega.Location = new System.Drawing.Point(3, 434);
            this.lblObsEntrega.Name = "lblObsEntrega";
            this.lblObsEntrega.Size = new System.Drawing.Size(200, 30);
            this.lblObsEntrega.TabIndex = 11;
            this.lblObsEntrega.Text = "Observaciones:";
            // 
            // txtObservacionesEntrega
            // 
            this.txtObservacionesEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacionesEntrega.Location = new System.Drawing.Point(209, 287);
            this.txtObservacionesEntrega.Multiline = true;
            this.txtObservacionesEntrega.Name = "txtObservacionesEntrega";
            this.txtObservacionesEntrega.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacionesEntrega.Size = new System.Drawing.Size(798, 324);
            this.txtObservacionesEntrega.TabIndex = 12;
            // 
            // flpNotifyChks
            // 
            this.flpNotifyChks.Controls.Add(this.chkNotifyWhatsapp);
            this.flpNotifyChks.Controls.Add(this.chkNotifyEmail);
            this.flpNotifyChks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNotifyChks.Enabled = false;
            this.flpNotifyChks.Location = new System.Drawing.Point(210, 222);
            this.flpNotifyChks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpNotifyChks.Name = "flpNotifyChks";
            this.flpNotifyChks.Size = new System.Drawing.Size(796, 58);
            this.flpNotifyChks.TabIndex = 14;
            // 
            // chkNotifyWhatsapp
            // 
            this.chkNotifyWhatsapp.AutoSize = true;
            this.chkNotifyWhatsapp.Location = new System.Drawing.Point(3, 3);
            this.chkNotifyWhatsapp.Name = "chkNotifyWhatsapp";
            this.chkNotifyWhatsapp.Size = new System.Drawing.Size(160, 34);
            this.chkNotifyWhatsapp.TabIndex = 10;
            this.chkNotifyWhatsapp.Text = "WhatsApp";
            this.chkNotifyWhatsapp.UseVisualStyleBackColor = true;
            // 
            // chkNotifyEmail
            // 
            this.chkNotifyEmail.AutoSize = true;
            this.chkNotifyEmail.Location = new System.Drawing.Point(169, 3);
            this.chkNotifyEmail.Name = "chkNotifyEmail";
            this.chkNotifyEmail.Size = new System.Drawing.Size(104, 34);
            this.chkNotifyEmail.TabIndex = 11;
            this.chkNotifyEmail.Text = "Email";
            this.chkNotifyEmail.UseVisualStyleBackColor = true;
            // 
            // grpObservaciones
            // 
            this.grpObservaciones.Controls.Add(this.txtObservaciones);
            this.grpObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpObservaciones.Location = new System.Drawing.Point(3, 775);
            this.grpObservaciones.Name = "grpObservaciones";
            this.grpObservaciones.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.grpObservaciones.Size = new System.Drawing.Size(1030, 385);
            this.grpObservaciones.TabIndex = 2;
            this.grpObservaciones.TabStop = false;
            this.grpObservaciones.Text = "Observaciones de la venta";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservaciones.Location = new System.Drawing.Point(10, 40);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(1010, 335);
            this.txtObservaciones.TabIndex = 0;
            // 
            // tlpRight
            // 
            this.tlpRight.AutoSize = true;
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Controls.Add(this.grpComprobante, 0, 0);
            this.tlpRight.Controls.Add(this.grpPago, 0, 1);
            this.tlpRight.Controls.Add(this.grpResumen, 0, 2);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(1045, 3);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 3;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Size = new System.Drawing.Size(689, 1163);
            this.tlpRight.TabIndex = 1;
            // 
            // grpComprobante
            // 
            this.grpComprobante.Controls.Add(this.tlpComprobante);
            this.grpComprobante.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpComprobante.Location = new System.Drawing.Point(3, 3);
            this.grpComprobante.Name = "grpComprobante";
            this.grpComprobante.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.grpComprobante.Size = new System.Drawing.Size(683, 194);
            this.grpComprobante.TabIndex = 0;
            this.grpComprobante.TabStop = false;
            this.grpComprobante.Text = "Comprobante";
            // 
            // tlpComprobante
            // 
            this.tlpComprobante.AutoSize = true;
            this.tlpComprobante.ColumnCount = 2;
            this.tlpComprobante.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpComprobante.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComprobante.Controls.Add(this.lblTipoFactura, 0, 0);
            this.tlpComprobante.Controls.Add(this.cBTypesInvoice, 1, 0);
            this.tlpComprobante.Controls.Add(this.lblPtoVta, 0, 1);
            this.tlpComprobante.Controls.Add(this.txtPtoVta, 1, 1);
            this.tlpComprobante.Controls.Add(this.lblNroComp, 0, 2);
            this.tlpComprobante.Controls.Add(this.txtNroComprobante, 1, 2);
            this.tlpComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpComprobante.Location = new System.Drawing.Point(10, 40);
            this.tlpComprobante.Name = "tlpComprobante";
            this.tlpComprobante.RowCount = 3;
            this.tlpComprobante.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComprobante.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComprobante.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComprobante.Size = new System.Drawing.Size(663, 144);
            this.tlpComprobante.TabIndex = 0;
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Location = new System.Drawing.Point(3, 7);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(201, 30);
            this.lblTipoFactura.TabIndex = 0;
            this.lblTipoFactura.Text = "Tipo de factura:";
            // 
            // cBTypesInvoice
            // 
            this.cBTypesInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBTypesInvoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTypesInvoice.FormattingEnabled = true;
            this.cBTypesInvoice.Location = new System.Drawing.Point(230, 3);
            this.cBTypesInvoice.Name = "cBTypesInvoice";
            this.cBTypesInvoice.Size = new System.Drawing.Size(430, 38);
            this.cBTypesInvoice.TabIndex = 1;
            // 
            // lblPtoVta
            // 
            this.lblPtoVta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPtoVta.AutoSize = true;
            this.lblPtoVta.Location = new System.Drawing.Point(3, 50);
            this.lblPtoVta.Name = "lblPtoVta";
            this.lblPtoVta.Size = new System.Drawing.Size(180, 30);
            this.lblPtoVta.TabIndex = 2;
            this.lblPtoVta.Text = "Punto de vta.:";
            // 
            // txtPtoVta
            // 
            this.txtPtoVta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPtoVta.Location = new System.Drawing.Point(230, 47);
            this.txtPtoVta.Name = "txtPtoVta";
            this.txtPtoVta.ReadOnly = true;
            this.txtPtoVta.Size = new System.Drawing.Size(430, 37);
            this.txtPtoVta.TabIndex = 3;
            // 
            // lblNroComp
            // 
            this.lblNroComp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNroComp.AutoSize = true;
            this.lblNroComp.Location = new System.Drawing.Point(3, 100);
            this.lblNroComp.Name = "lblNroComp";
            this.lblNroComp.Size = new System.Drawing.Size(221, 30);
            this.lblNroComp.TabIndex = 4;
            this.lblNroComp.Text = "N° comprobante:";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNroComprobante.Location = new System.Drawing.Point(230, 90);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.ReadOnly = true;
            this.txtNroComprobante.Size = new System.Drawing.Size(430, 37);
            this.txtNroComprobante.TabIndex = 5;
            // 
            // grpPago
            // 
            this.grpPago.Controls.Add(this.tlpPago);
            this.grpPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPago.Location = new System.Drawing.Point(3, 203);
            this.grpPago.Name = "grpPago";
            this.grpPago.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.grpPago.Size = new System.Drawing.Size(683, 464);
            this.grpPago.TabIndex = 1;
            this.grpPago.TabStop = false;
            this.grpPago.Text = "Pago";
            // 
            // tlpPago
            // 
            this.tlpPago.AutoSize = true;
            this.tlpPago.ColumnCount = 2;
            this.tlpPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPago.Controls.Add(this.lblFormaPago, 0, 0);
            this.tlpPago.Controls.Add(this.cmbFormaPago, 1, 0);
            this.tlpPago.Controls.Add(this.lblUltimos4, 0, 1);
            this.tlpPago.Controls.Add(this.txtUltimos4, 1, 1);
            this.tlpPago.Controls.Add(this.lblCuotas, 0, 2);
            this.tlpPago.Controls.Add(this.cmbCuotas, 1, 2);
            this.tlpPago.Controls.Add(this.lblComprobanteTransf, 0, 3);
            this.tlpPago.Controls.Add(this.txtComprobanteTransf, 1, 3);
            this.tlpPago.Controls.Add(this.btnAdjuntarComp, 1, 4);
            this.tlpPago.Controls.Add(this.lblLimiteCC, 1, 5);
            this.tlpPago.Controls.Add(this.lblDescuentoPorc, 0, 6);
            this.tlpPago.Controls.Add(this.nudDescuentoPorc, 1, 6);
            this.tlpPago.Controls.Add(this.lblDescuentoMonto, 0, 7);
            this.tlpPago.Controls.Add(this.nudDescuentoMonto, 1, 7);
            this.tlpPago.Controls.Add(this.lblRecargoPorc, 0, 8);
            this.tlpPago.Controls.Add(this.nudRecargoPorc, 1, 8);
            this.tlpPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPago.Location = new System.Drawing.Point(10, 40);
            this.tlpPago.Name = "tlpPago";
            this.tlpPago.RowCount = 9;
            this.tlpPago.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPago.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPago.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPago.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPago.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPago.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPago.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPago.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPago.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPago.Size = new System.Drawing.Size(663, 414);
            this.tlpPago.TabIndex = 0;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(3, 7);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(205, 30);
            this.lblFormaPago.TabIndex = 0;
            this.lblFormaPago.Text = "Forma de pago:";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Items.AddRange(new object[] {
            "Efectivo"});
            this.cmbFormaPago.Location = new System.Drawing.Point(275, 3);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(385, 38);
            this.cmbFormaPago.TabIndex = 1;
            // 
            // lblUltimos4
            // 
            this.lblUltimos4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUltimos4.AutoSize = true;
            this.lblUltimos4.Location = new System.Drawing.Point(3, 50);
            this.lblUltimos4.Name = "lblUltimos4";
            this.lblUltimos4.Size = new System.Drawing.Size(226, 30);
            this.lblUltimos4.TabIndex = 2;
            this.lblUltimos4.Text = "Últimos 4 (tarjeta):";
            // 
            // txtUltimos4
            // 
            this.txtUltimos4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUltimos4.Location = new System.Drawing.Point(275, 47);
            this.txtUltimos4.MaxLength = 4;
            this.txtUltimos4.Name = "txtUltimos4";
            this.txtUltimos4.Size = new System.Drawing.Size(385, 37);
            this.txtUltimos4.TabIndex = 3;
            // 
            // lblCuotas
            // 
            this.lblCuotas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(3, 94);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(105, 30);
            this.lblCuotas.TabIndex = 4;
            this.lblCuotas.Text = "Cuotas:";
            // 
            // cmbCuotas
            // 
            this.cmbCuotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuotas.FormattingEnabled = true;
            this.cmbCuotas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbCuotas.Location = new System.Drawing.Point(275, 90);
            this.cmbCuotas.Name = "cmbCuotas";
            this.cmbCuotas.Size = new System.Drawing.Size(385, 38);
            this.cmbCuotas.TabIndex = 5;
            // 
            // lblComprobanteTransf
            // 
            this.lblComprobanteTransf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblComprobanteTransf.AutoSize = true;
            this.lblComprobanteTransf.Location = new System.Drawing.Point(3, 137);
            this.lblComprobanteTransf.Name = "lblComprobanteTransf";
            this.lblComprobanteTransf.Size = new System.Drawing.Size(266, 30);
            this.lblComprobanteTransf.TabIndex = 6;
            this.lblComprobanteTransf.Text = "Comp. transferencia:";
            // 
            // txtComprobanteTransf
            // 
            this.txtComprobanteTransf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComprobanteTransf.Location = new System.Drawing.Point(275, 134);
            this.txtComprobanteTransf.Name = "txtComprobanteTransf";
            this.txtComprobanteTransf.Size = new System.Drawing.Size(385, 37);
            this.txtComprobanteTransf.TabIndex = 7;
            // 
            // btnAdjuntarComp
            // 
            this.btnAdjuntarComp.AutoSize = true;
            this.btnAdjuntarComp.Location = new System.Drawing.Point(275, 177);
            this.btnAdjuntarComp.Name = "btnAdjuntarComp";
            this.btnAdjuntarComp.Size = new System.Drawing.Size(159, 46);
            this.btnAdjuntarComp.TabIndex = 8;
            this.btnAdjuntarComp.Text = "Adjuntar…";
            this.btnAdjuntarComp.UseVisualStyleBackColor = true;
            // 
            // lblLimiteCC
            // 
            this.lblLimiteCC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLimiteCC.AutoSize = true;
            this.lblLimiteCC.Location = new System.Drawing.Point(275, 226);
            this.lblLimiteCC.Margin = new System.Windows.Forms.Padding(3, 0, 3, 6);
            this.lblLimiteCC.Name = "lblLimiteCC";
            this.lblLimiteCC.Size = new System.Drawing.Size(349, 30);
            this.lblLimiteCC.TabIndex = 9;
            this.lblLimiteCC.Text = "Límite CC / saldo: (si aplica)";
            // 
            // lblDescuentoPorc
            // 
            this.lblDescuentoPorc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescuentoPorc.AutoSize = true;
            this.lblDescuentoPorc.Location = new System.Drawing.Point(3, 268);
            this.lblDescuentoPorc.Name = "lblDescuentoPorc";
            this.lblDescuentoPorc.Size = new System.Drawing.Size(200, 30);
            this.lblDescuentoPorc.TabIndex = 10;
            this.lblDescuentoPorc.Text = "Descuento (%) :";
            // 
            // nudDescuentoPorc
            // 
            this.nudDescuentoPorc.DecimalPlaces = 2;
            this.nudDescuentoPorc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudDescuentoPorc.Location = new System.Drawing.Point(275, 265);
            this.nudDescuentoPorc.Name = "nudDescuentoPorc";
            this.nudDescuentoPorc.Size = new System.Drawing.Size(385, 37);
            this.nudDescuentoPorc.TabIndex = 11;
            this.nudDescuentoPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescuentoMonto
            // 
            this.lblDescuentoMonto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescuentoMonto.AutoSize = true;
            this.lblDescuentoMonto.Location = new System.Drawing.Point(3, 311);
            this.lblDescuentoMonto.Name = "lblDescuentoMonto";
            this.lblDescuentoMonto.Size = new System.Drawing.Size(260, 30);
            this.lblDescuentoMonto.TabIndex = 12;
            this.lblDescuentoMonto.Text = "Descuento (monto) :";
            // 
            // nudDescuentoMonto
            // 
            this.nudDescuentoMonto.DecimalPlaces = 2;
            this.nudDescuentoMonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudDescuentoMonto.Location = new System.Drawing.Point(275, 308);
            this.nudDescuentoMonto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDescuentoMonto.Name = "nudDescuentoMonto";
            this.nudDescuentoMonto.Size = new System.Drawing.Size(385, 37);
            this.nudDescuentoMonto.TabIndex = 13;
            this.nudDescuentoMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRecargoPorc
            // 
            this.lblRecargoPorc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecargoPorc.AutoSize = true;
            this.lblRecargoPorc.Location = new System.Drawing.Point(3, 366);
            this.lblRecargoPorc.Name = "lblRecargoPorc";
            this.lblRecargoPorc.Size = new System.Drawing.Size(172, 30);
            this.lblRecargoPorc.TabIndex = 14;
            this.lblRecargoPorc.Text = "Recargo (%) :";
            // 
            // nudRecargoPorc
            // 
            this.nudRecargoPorc.DecimalPlaces = 2;
            this.nudRecargoPorc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRecargoPorc.Location = new System.Drawing.Point(275, 351);
            this.nudRecargoPorc.Name = "nudRecargoPorc";
            this.nudRecargoPorc.Size = new System.Drawing.Size(385, 37);
            this.nudRecargoPorc.TabIndex = 15;
            this.nudRecargoPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpResumen
            // 
            this.grpResumen.Controls.Add(this.tlpResumen);
            this.grpResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResumen.Location = new System.Drawing.Point(3, 673);
            this.grpResumen.Name = "grpResumen";
            this.grpResumen.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.grpResumen.Size = new System.Drawing.Size(683, 487);
            this.grpResumen.TabIndex = 2;
            this.grpResumen.TabStop = false;
            this.grpResumen.Text = "Resumen del carrito";
            // 
            // tlpResumen
            // 
            this.tlpResumen.ColumnCount = 1;
            this.tlpResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResumen.Controls.Add(this.dgvCartSummary, 0, 0);
            this.tlpResumen.Controls.Add(this.tlpTotals, 0, 1);
            this.tlpResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResumen.Location = new System.Drawing.Point(10, 40);
            this.tlpResumen.Name = "tlpResumen";
            this.tlpResumen.RowCount = 2;
            this.tlpResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResumen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpResumen.Size = new System.Drawing.Size(663, 437);
            this.tlpResumen.TabIndex = 0;
            // 
            // dgvCartSummary
            // 
            this.dgvCartSummary.AllowUserToAddRows = false;
            this.dgvCartSummary.AllowUserToDeleteRows = false;
            this.dgvCartSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCartSummary.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCartSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImgProduct,
            this.colProductName,
            this.colQuantity});
            this.dgvCartSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCartSummary.Location = new System.Drawing.Point(3, 3);
            this.dgvCartSummary.MultiSelect = false;
            this.dgvCartSummary.Name = "dgvCartSummary";
            this.dgvCartSummary.ReadOnly = true;
            this.dgvCartSummary.RowHeadersVisible = false;
            this.dgvCartSummary.RowHeadersWidth = 62;
            this.dgvCartSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCartSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartSummary.Size = new System.Drawing.Size(657, 280);
            this.dgvCartSummary.TabIndex = 0;
            // 
            // colImgProduct
            // 
            this.colImgProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colImgProduct.HeaderText = "";
            this.colImgProduct.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImgProduct.MinimumWidth = 100;
            this.colImgProduct.Name = "colImgProduct";
            this.colImgProduct.ReadOnly = true;
            // 
            // colProductName
            // 
            this.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProductName.HeaderText = "Producto";
            this.colProductName.MinimumWidth = 8;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colQuantity.HeaderText = "Cantidad";
            this.colQuantity.MinimumWidth = 8;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 162;
            // 
            // tlpTotals
            // 
            this.tlpTotals.AutoSize = true;
            this.tlpTotals.ColumnCount = 2;
            this.tlpTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotals.Controls.Add(this.lblSubtotal, 0, 0);
            this.tlpTotals.Controls.Add(this.lblSubtotalValue, 1, 0);
            this.tlpTotals.Controls.Add(this.lblIva, 0, 1);
            this.tlpTotals.Controls.Add(this.lblIvaValue, 1, 1);
            this.tlpTotals.Controls.Add(this.lblEnvio, 0, 2);
            this.tlpTotals.Controls.Add(this.lblEnvioValue, 1, 2);
            this.tlpTotals.Controls.Add(this.lblDescuentos, 0, 3);
            this.tlpTotals.Controls.Add(this.lblDescuentosValue, 1, 3);
            this.tlpTotals.Controls.Add(this.lblTotal, 0, 4);
            this.tlpTotals.Controls.Add(this.lblTotalValue, 1, 4);
            this.tlpTotals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpTotals.Location = new System.Drawing.Point(3, 289);
            this.tlpTotals.Name = "tlpTotals";
            this.tlpTotals.RowCount = 5;
            this.tlpTotals.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTotals.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTotals.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTotals.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTotals.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTotals.Size = new System.Drawing.Size(657, 145);
            this.tlpTotals.TabIndex = 1;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(3, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(117, 30);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotalValue.AutoSize = true;
            this.lblSubtotalValue.Location = new System.Drawing.Point(595, 0);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(59, 30);
            this.lblSubtotalValue.TabIndex = 1;
            this.lblSubtotalValue.Text = "0,00";
            // 
            // lblIva
            // 
            this.lblIva.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(3, 30);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(60, 30);
            this.lblIva.TabIndex = 2;
            this.lblIva.Text = "IVA:";
            // 
            // lblIvaValue
            // 
            this.lblIvaValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIvaValue.AutoSize = true;
            this.lblIvaValue.Location = new System.Drawing.Point(595, 30);
            this.lblIvaValue.Name = "lblIvaValue";
            this.lblIvaValue.Size = new System.Drawing.Size(59, 30);
            this.lblIvaValue.TabIndex = 3;
            this.lblIvaValue.Text = "0,00";
            // 
            // lblEnvio
            // 
            this.lblEnvio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Location = new System.Drawing.Point(3, 60);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(85, 30);
            this.lblEnvio.TabIndex = 4;
            this.lblEnvio.Text = "Envío:";
            // 
            // lblEnvioValue
            // 
            this.lblEnvioValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnvioValue.AutoSize = true;
            this.lblEnvioValue.Location = new System.Drawing.Point(595, 60);
            this.lblEnvioValue.Name = "lblEnvioValue";
            this.lblEnvioValue.Size = new System.Drawing.Size(59, 30);
            this.lblEnvioValue.TabIndex = 5;
            this.lblEnvioValue.Text = "0,00";
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Location = new System.Drawing.Point(3, 90);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(160, 30);
            this.lblDescuentos.TabIndex = 6;
            this.lblDescuentos.Text = "Descuentos:";
            // 
            // lblDescuentosValue
            // 
            this.lblDescuentosValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescuentosValue.AutoSize = true;
            this.lblDescuentosValue.Location = new System.Drawing.Point(595, 90);
            this.lblDescuentosValue.Name = "lblDescuentosValue";
            this.lblDescuentosValue.Size = new System.Drawing.Size(59, 30);
            this.lblDescuentosValue.TabIndex = 7;
            this.lblDescuentosValue.Text = "0,00";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(3, 120);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(72, 25);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.Location = new System.Drawing.Point(607, 120);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(47, 25);
            this.lblTotalValue.TabIndex = 9;
            this.lblTotalValue.Text = "0,00";
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.flpActions);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Location = new System.Drawing.Point(3, 1273);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pnlActions.Size = new System.Drawing.Size(1737, 77);
            this.pnlActions.TabIndex = 2;
            // 
            // flpActions
            // 
            this.flpActions.AutoSize = true;
            this.flpActions.Controls.Add(this.btnCancel);
            this.flpActions.Controls.Add(this.btnDraft);
            this.flpActions.Controls.Add(this.btnConfirm);
            this.flpActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpActions.Location = new System.Drawing.Point(10, 15);
            this.flpActions.Name = "flpActions";
            this.flpActions.Size = new System.Drawing.Size(1717, 52);
            this.flpActions.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1574, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 46);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDraft
            // 
            this.btnDraft.AutoSize = true;
            this.btnDraft.Location = new System.Drawing.Point(1330, 3);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(238, 46);
            this.btnDraft.TabIndex = 1;
            this.btnDraft.Text = "Guardar borrador";
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.Location = new System.Drawing.Point(1178, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(146, 46);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormFinalizeSale
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1743, 1353);
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(978, 671);
            this.Name = "FormFinalizeSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar venta";
            this.tlpRoot.ResumeLayout(false);
            this.tlpRoot.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.tlpContent.PerformLayout();
            this.tlpLeft.ResumeLayout(false);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.tlpCliente.ResumeLayout(false);
            this.tlpCliente.PerformLayout();
            this.grpEntrega.ResumeLayout(false);
            this.grpEntrega.PerformLayout();
            this.tlpEntrega.ResumeLayout(false);
            this.tlpEntrega.PerformLayout();
            this.pnlModoEntrega.ResumeLayout(false);
            this.pnlModoEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoEnvio)).EndInit();
            this.flpNotifyChks.ResumeLayout(false);
            this.flpNotifyChks.PerformLayout();
            this.grpObservaciones.ResumeLayout(false);
            this.grpObservaciones.PerformLayout();
            this.tlpRight.ResumeLayout(false);
            this.grpComprobante.ResumeLayout(false);
            this.grpComprobante.PerformLayout();
            this.tlpComprobante.ResumeLayout(false);
            this.tlpComprobante.PerformLayout();
            this.grpPago.ResumeLayout(false);
            this.grpPago.PerformLayout();
            this.tlpPago.ResumeLayout(false);
            this.tlpPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuentoPorc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuentoMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecargoPorc)).EndInit();
            this.grpResumen.ResumeLayout(false);
            this.tlpResumen.ResumeLayout(false);
            this.tlpResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartSummary)).EndInit();
            this.tlpTotals.ResumeLayout(false);
            this.tlpTotals.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.flpActions.ResumeLayout(false);
            this.flpActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.TableLayoutPanel tlpCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.TextBox txtDNIClient;

        private System.Windows.Forms.GroupBox grpEntrega;
        private System.Windows.Forms.TableLayoutPanel tlpEntrega;
        private System.Windows.Forms.Label lblModoEntrega;
        private System.Windows.Forms.FlowLayoutPanel pnlModoEntrega;
        private System.Windows.Forms.RadioButton rbRetiroLocal;
        private System.Windows.Forms.RadioButton rbEnvioDomicilio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpDeliveryHour;
        private System.Windows.Forms.Label lblDireccionEntrega;
        private System.Windows.Forms.TextBox txtDireccionEntrega;
        private System.Windows.Forms.Label lblCostoEnvio;
        private System.Windows.Forms.NumericUpDown nudCostoEnvio;
        private System.Windows.Forms.CheckBox chkNotifyWhatsapp;
        private System.Windows.Forms.Label lblObsEntrega;
        private System.Windows.Forms.TextBox txtObservacionesEntrega;

        private System.Windows.Forms.GroupBox grpObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;

        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.GroupBox grpComprobante;
        private System.Windows.Forms.TableLayoutPanel tlpComprobante;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.ComboBox cBTypesInvoice;
        private System.Windows.Forms.Label lblPtoVta;
        private System.Windows.Forms.TextBox txtPtoVta;
        private System.Windows.Forms.Label lblNroComp;
        private System.Windows.Forms.TextBox txtNroComprobante;

        private System.Windows.Forms.GroupBox grpPago;
        private System.Windows.Forms.TableLayoutPanel tlpPago;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private System.Windows.Forms.Label lblUltimos4;
        private System.Windows.Forms.TextBox txtUltimos4;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.ComboBox cmbCuotas;
        private System.Windows.Forms.Label lblComprobanteTransf;
        private System.Windows.Forms.TextBox txtComprobanteTransf;
        private System.Windows.Forms.Button btnAdjuntarComp;
        private System.Windows.Forms.Label lblLimiteCC;
        private System.Windows.Forms.Label lblDescuentoPorc;
        private System.Windows.Forms.NumericUpDown nudDescuentoPorc;
        private System.Windows.Forms.Label lblDescuentoMonto;
        private System.Windows.Forms.NumericUpDown nudDescuentoMonto;
        private System.Windows.Forms.Label lblRecargoPorc;
        private System.Windows.Forms.NumericUpDown nudRecargoPorc;

        private System.Windows.Forms.GroupBox grpResumen;
        private System.Windows.Forms.TableLayoutPanel tlpResumen;
        private System.Windows.Forms.DataGridView dgvCartSummary;
        private System.Windows.Forms.TableLayoutPanel tlpTotals;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalValue;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblIvaValue;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.Label lblEnvioValue;
        private System.Windows.Forms.Label lblDescuentos;
        private System.Windows.Forms.Label lblDescuentosValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;

        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.FlowLayoutPanel flpActions;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Button btnDraft;
        private DataGridViewImageColumn colImgProduct;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colQuantity;
        private Label lblNotify;
        private FlowLayoutPanel flpNotifyChks;
        private CheckBox chkNotifyEmail;
    }
}
