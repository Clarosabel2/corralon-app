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
            this.tlpRoot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 3;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.070492F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.86909F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.060421F));
            this.tlpRoot.Size = new System.Drawing.Size(1162, 902);
            this.tlpRoot.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(7, 7);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(1148, 49);
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
            this.tlpContent.Location = new System.Drawing.Point(2, 65);
            this.tlpContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(1158, 779);
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
            this.tlpLeft.Location = new System.Drawing.Point(2, 2);
            this.tlpLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 3;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Size = new System.Drawing.Size(690, 775);
            this.tlpLeft.TabIndex = 0;
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.lblDniCliente);
            this.grpCliente.Controls.Add(this.tlpCliente);
            this.grpCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCliente.Location = new System.Drawing.Point(2, 2);
            this.grpCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grpCliente.Size = new System.Drawing.Size(686, 64);
            this.grpCliente.TabIndex = 0;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Location = new System.Drawing.Point(9, 30);
            this.lblDniCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(43, 21);
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
            this.tlpCliente.Location = new System.Drawing.Point(7, 27);
            this.tlpCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpCliente.Name = "tlpCliente";
            this.tlpCliente.RowCount = 1;
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCliente.Size = new System.Drawing.Size(672, 30);
            this.tlpCliente.TabIndex = 0;
            // 
            // txtDNIClient
            // 
            this.txtDNIClient.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtDNIClient.Location = new System.Drawing.Point(49, 2);
            this.txtDNIClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDNIClient.Name = "txtDNIClient";
            this.txtDNIClient.Size = new System.Drawing.Size(621, 27);
            this.txtDNIClient.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtDNIClient, "Ingrese el DNI del cliente (solo números)");
            this.txtDNIClient.TextChanged += new System.EventHandler(this.txtDNIClient_TextChanged);
            this.txtDNIClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNIClient_KeyPress);
            // 
            // grpEntrega
            // 
            this.grpEntrega.Controls.Add(this.tlpEntrega);
            this.grpEntrega.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpEntrega.Location = new System.Drawing.Point(2, 70);
            this.grpEntrega.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEntrega.Name = "grpEntrega";
            this.grpEntrega.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grpEntrega.Size = new System.Drawing.Size(686, 443);
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
            this.tlpEntrega.Location = new System.Drawing.Point(7, 27);
            this.tlpEntrega.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpEntrega.Name = "tlpEntrega";
            this.tlpEntrega.RowCount = 7;
            this.tlpEntrega.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEntrega.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEntrega.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEntrega.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEntrega.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEntrega.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpEntrega.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tlpEntrega.Size = new System.Drawing.Size(672, 409);
            this.tlpEntrega.TabIndex = 0;
            // 
            // lblNotify
            // 
            this.lblNotify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNotify.AutoSize = true;
            this.lblNotify.Location = new System.Drawing.Point(2, 167);
            this.lblNotify.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotify.Name = "lblNotify";
            this.lblNotify.Size = new System.Drawing.Size(110, 21);
            this.lblNotify.TabIndex = 13;
            this.lblNotify.Text = "Notificar por:";
            // 
            // lblModoEntrega
            // 
            this.lblModoEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblModoEntrega.AutoSize = true;
            this.lblModoEntrega.Location = new System.Drawing.Point(2, 6);
            this.lblModoEntrega.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModoEntrega.Name = "lblModoEntrega";
            this.lblModoEntrega.Size = new System.Drawing.Size(60, 21);
            this.lblModoEntrega.TabIndex = 0;
            this.lblModoEntrega.Text = "Modo:";
            // 
            // pnlModoEntrega
            // 
            this.pnlModoEntrega.AutoSize = true;
            this.pnlModoEntrega.Controls.Add(this.rbRetiroLocal);
            this.pnlModoEntrega.Controls.Add(this.rbEnvioDomicilio);
            this.pnlModoEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModoEntrega.Location = new System.Drawing.Point(136, 2);
            this.pnlModoEntrega.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModoEntrega.Name = "pnlModoEntrega";
            this.pnlModoEntrega.Size = new System.Drawing.Size(534, 29);
            this.pnlModoEntrega.TabIndex = 1;
            // 
            // rbRetiroLocal
            // 
            this.rbRetiroLocal.AutoSize = true;
            this.rbRetiroLocal.Checked = true;
            this.rbRetiroLocal.Location = new System.Drawing.Point(2, 2);
            this.rbRetiroLocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbRetiroLocal.Name = "rbRetiroLocal";
            this.rbRetiroLocal.Size = new System.Drawing.Size(114, 25);
            this.rbRetiroLocal.TabIndex = 0;
            this.rbRetiroLocal.TabStop = true;
            this.rbRetiroLocal.Text = "Retiro local";
            this.rbRetiroLocal.UseVisualStyleBackColor = true;
            this.rbRetiroLocal.CheckedChanged += new System.EventHandler(this.rbRetiroLocal_CheckedChanged);
            // 
            // rbEnvioDomicilio
            // 
            this.rbEnvioDomicilio.AutoSize = true;
            this.rbEnvioDomicilio.Location = new System.Drawing.Point(120, 2);
            this.rbEnvioDomicilio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEnvioDomicilio.Name = "rbEnvioDomicilio";
            this.rbEnvioDomicilio.Size = new System.Drawing.Size(157, 25);
            this.rbEnvioDomicilio.TabIndex = 1;
            this.rbEnvioDomicilio.Text = "Envío a domicilio";
            this.rbEnvioDomicilio.UseVisualStyleBackColor = true;
            this.rbEnvioDomicilio.CheckedChanged += new System.EventHandler(this.rbEnvioDomicilio_CheckedChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(2, 38);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 21);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(136, 35);
            this.dtpDeliveryDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(414, 27);
            this.dtpDeliveryDate.TabIndex = 3;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(2, 69);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 21);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora:";
            // 
            // dtpDeliveryHour
            // 
            this.dtpDeliveryHour.CustomFormat = "HH:mm";
            this.dtpDeliveryHour.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpDeliveryHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDeliveryHour.Location = new System.Drawing.Point(136, 66);
            this.dtpDeliveryHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDeliveryHour.Name = "dtpDeliveryHour";
            this.dtpDeliveryHour.ShowUpDown = true;
            this.dtpDeliveryHour.Size = new System.Drawing.Size(116, 27);
            this.dtpDeliveryHour.TabIndex = 5;
            // 
            // lblDireccionEntrega
            // 
            this.lblDireccionEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDireccionEntrega.AutoSize = true;
            this.lblDireccionEntrega.Location = new System.Drawing.Point(2, 100);
            this.lblDireccionEntrega.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccionEntrega.Name = "lblDireccionEntrega";
            this.lblDireccionEntrega.Size = new System.Drawing.Size(87, 21);
            this.lblDireccionEntrega.TabIndex = 6;
            this.lblDireccionEntrega.Text = "Dirección:";
            // 
            // txtDireccionEntrega
            // 
            this.txtDireccionEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDireccionEntrega.Location = new System.Drawing.Point(136, 97);
            this.txtDireccionEntrega.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccionEntrega.Name = "txtDireccionEntrega";
            this.txtDireccionEntrega.Size = new System.Drawing.Size(534, 27);
            this.txtDireccionEntrega.TabIndex = 7;
            // 
            // lblCostoEnvio
            // 
            this.lblCostoEnvio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCostoEnvio.AutoSize = true;
            this.lblCostoEnvio.Location = new System.Drawing.Point(2, 131);
            this.lblCostoEnvio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCostoEnvio.Name = "lblCostoEnvio";
            this.lblCostoEnvio.Size = new System.Drawing.Size(104, 21);
            this.lblCostoEnvio.TabIndex = 8;
            this.lblCostoEnvio.Text = "Despues de:";
            // 
            // nudCostoEnvio
            // 
            this.nudCostoEnvio.DecimalPlaces = 2;
            this.nudCostoEnvio.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudCostoEnvio.Enabled = false;
            this.nudCostoEnvio.Location = new System.Drawing.Point(136, 128);
            this.nudCostoEnvio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudCostoEnvio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCostoEnvio.Name = "nudCostoEnvio";
            this.nudCostoEnvio.Size = new System.Drawing.Size(116, 27);
            this.nudCostoEnvio.TabIndex = 9;
            this.nudCostoEnvio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblObsEntrega
            // 
            this.lblObsEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblObsEntrega.AutoSize = true;
            this.lblObsEntrega.Location = new System.Drawing.Point(2, 293);
            this.lblObsEntrega.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObsEntrega.Name = "lblObsEntrega";
            this.lblObsEntrega.Size = new System.Drawing.Size(130, 21);
            this.lblObsEntrega.TabIndex = 11;
            this.lblObsEntrega.Text = "Observaciones:";
            // 
            // txtObservacionesEntrega
            // 
            this.txtObservacionesEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservacionesEntrega.Location = new System.Drawing.Point(136, 201);
            this.txtObservacionesEntrega.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObservacionesEntrega.Multiline = true;
            this.txtObservacionesEntrega.Name = "txtObservacionesEntrega";
            this.txtObservacionesEntrega.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacionesEntrega.Size = new System.Drawing.Size(534, 206);
            this.txtObservacionesEntrega.TabIndex = 12;
            // 
            // flpNotifyChks
            // 
            this.flpNotifyChks.Controls.Add(this.chkNotifyWhatsapp);
            this.flpNotifyChks.Controls.Add(this.chkNotifyEmail);
            this.flpNotifyChks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNotifyChks.Enabled = false;
            this.flpNotifyChks.Location = new System.Drawing.Point(137, 160);
            this.flpNotifyChks.Name = "flpNotifyChks";
            this.flpNotifyChks.Size = new System.Drawing.Size(532, 36);
            this.flpNotifyChks.TabIndex = 14;
            // 
            // chkNotifyWhatsapp
            // 
            this.chkNotifyWhatsapp.AutoSize = true;
            this.chkNotifyWhatsapp.Location = new System.Drawing.Point(2, 2);
            this.chkNotifyWhatsapp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkNotifyWhatsapp.Name = "chkNotifyWhatsapp";
            this.chkNotifyWhatsapp.Size = new System.Drawing.Size(113, 25);
            this.chkNotifyWhatsapp.TabIndex = 10;
            this.chkNotifyWhatsapp.Text = "WhatsApp";
            this.chkNotifyWhatsapp.UseVisualStyleBackColor = true;
            // 
            // chkNotifyEmail
            // 
            this.chkNotifyEmail.AutoSize = true;
            this.chkNotifyEmail.Location = new System.Drawing.Point(119, 2);
            this.chkNotifyEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkNotifyEmail.Name = "chkNotifyEmail";
            this.chkNotifyEmail.Size = new System.Drawing.Size(70, 25);
            this.chkNotifyEmail.TabIndex = 11;
            this.chkNotifyEmail.Text = "Email";
            this.chkNotifyEmail.UseVisualStyleBackColor = true;
            // 
            // grpObservaciones
            // 
            this.grpObservaciones.Controls.Add(this.txtObservaciones);
            this.grpObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpObservaciones.Location = new System.Drawing.Point(2, 517);
            this.grpObservaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpObservaciones.Name = "grpObservaciones";
            this.grpObservaciones.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grpObservaciones.Size = new System.Drawing.Size(686, 256);
            this.grpObservaciones.TabIndex = 2;
            this.grpObservaciones.TabStop = false;
            this.grpObservaciones.Text = "Observaciones de la venta";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservaciones.Location = new System.Drawing.Point(7, 27);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(672, 222);
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
            this.tlpRight.Location = new System.Drawing.Point(696, 2);
            this.tlpRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 3;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Size = new System.Drawing.Size(460, 775);
            this.tlpRight.TabIndex = 1;
            // 
            // grpComprobante
            // 
            this.grpComprobante.Controls.Add(this.tlpComprobante);
            this.grpComprobante.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpComprobante.Location = new System.Drawing.Point(2, 2);
            this.grpComprobante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpComprobante.Name = "grpComprobante";
            this.grpComprobante.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grpComprobante.Size = new System.Drawing.Size(456, 129);
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
            this.tlpComprobante.Location = new System.Drawing.Point(7, 27);
            this.tlpComprobante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpComprobante.Name = "tlpComprobante";
            this.tlpComprobante.RowCount = 3;
            this.tlpComprobante.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComprobante.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComprobante.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpComprobante.Size = new System.Drawing.Size(442, 95);
            this.tlpComprobante.TabIndex = 0;
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Location = new System.Drawing.Point(2, 6);
            this.lblTipoFactura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(134, 21);
            this.lblTipoFactura.TabIndex = 0;
            this.lblTipoFactura.Text = "Tipo de factura:";
            // 
            // cBTypesInvoice
            // 
            this.cBTypesInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBTypesInvoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTypesInvoice.FormattingEnabled = true;
            this.cBTypesInvoice.Location = new System.Drawing.Point(152, 2);
            this.cBTypesInvoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBTypesInvoice.Name = "cBTypesInvoice";
            this.cBTypesInvoice.Size = new System.Drawing.Size(288, 29);
            this.cBTypesInvoice.TabIndex = 1;
            // 
            // lblPtoVta
            // 
            this.lblPtoVta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPtoVta.AutoSize = true;
            this.lblPtoVta.Location = new System.Drawing.Point(2, 38);
            this.lblPtoVta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPtoVta.Name = "lblPtoVta";
            this.lblPtoVta.Size = new System.Drawing.Size(121, 21);
            this.lblPtoVta.TabIndex = 2;
            this.lblPtoVta.Text = "Punto de vta.:";
            // 
            // txtPtoVta
            // 
            this.txtPtoVta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPtoVta.Location = new System.Drawing.Point(152, 35);
            this.txtPtoVta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPtoVta.Name = "txtPtoVta";
            this.txtPtoVta.ReadOnly = true;
            this.txtPtoVta.Size = new System.Drawing.Size(288, 27);
            this.txtPtoVta.TabIndex = 3;
            // 
            // lblNroComp
            // 
            this.lblNroComp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNroComp.AutoSize = true;
            this.lblNroComp.Location = new System.Drawing.Point(2, 69);
            this.lblNroComp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroComp.Name = "lblNroComp";
            this.lblNroComp.Size = new System.Drawing.Size(146, 21);
            this.lblNroComp.TabIndex = 4;
            this.lblNroComp.Text = "N° comprobante:";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNroComprobante.Location = new System.Drawing.Point(152, 66);
            this.txtNroComprobante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.ReadOnly = true;
            this.txtNroComprobante.Size = new System.Drawing.Size(288, 27);
            this.txtNroComprobante.TabIndex = 5;
            // 
            // grpPago
            // 
            this.grpPago.Controls.Add(this.tlpPago);
            this.grpPago.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPago.Location = new System.Drawing.Point(2, 135);
            this.grpPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPago.Name = "grpPago";
            this.grpPago.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grpPago.Size = new System.Drawing.Size(456, 309);
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
            this.tlpPago.Location = new System.Drawing.Point(7, 27);
            this.tlpPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.tlpPago.Size = new System.Drawing.Size(442, 275);
            this.tlpPago.TabIndex = 0;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(2, 6);
            this.lblFormaPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(135, 21);
            this.lblFormaPago.TabIndex = 0;
            this.lblFormaPago.Text = "Forma de pago:";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cmbFormaPago.Location = new System.Drawing.Point(180, 2);
            this.cmbFormaPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(260, 29);
            this.cmbFormaPago.TabIndex = 1;
            // 
            // lblUltimos4
            // 
            this.lblUltimos4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUltimos4.AutoSize = true;
            this.lblUltimos4.Location = new System.Drawing.Point(2, 38);
            this.lblUltimos4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUltimos4.Name = "lblUltimos4";
            this.lblUltimos4.Size = new System.Drawing.Size(152, 21);
            this.lblUltimos4.TabIndex = 2;
            this.lblUltimos4.Text = "Últimos 4 (tarjeta):";
            // 
            // txtUltimos4
            // 
            this.txtUltimos4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUltimos4.Location = new System.Drawing.Point(180, 35);
            this.txtUltimos4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUltimos4.MaxLength = 4;
            this.txtUltimos4.Name = "txtUltimos4";
            this.txtUltimos4.Size = new System.Drawing.Size(260, 27);
            this.txtUltimos4.TabIndex = 3;
            // 
            // lblCuotas
            // 
            this.lblCuotas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(2, 70);
            this.lblCuotas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(71, 21);
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
            this.cmbCuotas.Location = new System.Drawing.Point(180, 66);
            this.cmbCuotas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCuotas.Name = "cmbCuotas";
            this.cmbCuotas.Size = new System.Drawing.Size(260, 29);
            this.cmbCuotas.TabIndex = 5;
            // 
            // lblComprobanteTransf
            // 
            this.lblComprobanteTransf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblComprobanteTransf.AutoSize = true;
            this.lblComprobanteTransf.Location = new System.Drawing.Point(2, 102);
            this.lblComprobanteTransf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComprobanteTransf.Name = "lblComprobanteTransf";
            this.lblComprobanteTransf.Size = new System.Drawing.Size(174, 21);
            this.lblComprobanteTransf.TabIndex = 6;
            this.lblComprobanteTransf.Text = "Comp. transferencia:";
            // 
            // txtComprobanteTransf
            // 
            this.txtComprobanteTransf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComprobanteTransf.Location = new System.Drawing.Point(180, 99);
            this.txtComprobanteTransf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComprobanteTransf.Name = "txtComprobanteTransf";
            this.txtComprobanteTransf.Size = new System.Drawing.Size(260, 27);
            this.txtComprobanteTransf.TabIndex = 7;
            // 
            // btnAdjuntarComp
            // 
            this.btnAdjuntarComp.AutoSize = true;
            this.btnAdjuntarComp.Location = new System.Drawing.Point(180, 130);
            this.btnAdjuntarComp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdjuntarComp.Name = "btnAdjuntarComp";
            this.btnAdjuntarComp.Size = new System.Drawing.Size(106, 31);
            this.btnAdjuntarComp.TabIndex = 8;
            this.btnAdjuntarComp.Text = "Adjuntar…";
            this.btnAdjuntarComp.UseVisualStyleBackColor = true;
            // 
            // lblLimiteCC
            // 
            this.lblLimiteCC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLimiteCC.AutoSize = true;
            this.lblLimiteCC.Location = new System.Drawing.Point(180, 163);
            this.lblLimiteCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.lblLimiteCC.Name = "lblLimiteCC";
            this.lblLimiteCC.Size = new System.Drawing.Size(223, 21);
            this.lblLimiteCC.TabIndex = 9;
            this.lblLimiteCC.Text = "Límite CC / saldo: (si aplica)";
            // 
            // lblDescuentoPorc
            // 
            this.lblDescuentoPorc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescuentoPorc.AutoSize = true;
            this.lblDescuentoPorc.Location = new System.Drawing.Point(2, 193);
            this.lblDescuentoPorc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescuentoPorc.Name = "lblDescuentoPorc";
            this.lblDescuentoPorc.Size = new System.Drawing.Size(131, 21);
            this.lblDescuentoPorc.TabIndex = 10;
            this.lblDescuentoPorc.Text = "Descuento (%) :";
            // 
            // nudDescuentoPorc
            // 
            this.nudDescuentoPorc.DecimalPlaces = 2;
            this.nudDescuentoPorc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudDescuentoPorc.Location = new System.Drawing.Point(180, 190);
            this.nudDescuentoPorc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudDescuentoPorc.Name = "nudDescuentoPorc";
            this.nudDescuentoPorc.Size = new System.Drawing.Size(260, 27);
            this.nudDescuentoPorc.TabIndex = 11;
            this.nudDescuentoPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDescuentoMonto
            // 
            this.lblDescuentoMonto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescuentoMonto.AutoSize = true;
            this.lblDescuentoMonto.Location = new System.Drawing.Point(2, 224);
            this.lblDescuentoMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescuentoMonto.Name = "lblDescuentoMonto";
            this.lblDescuentoMonto.Size = new System.Drawing.Size(171, 21);
            this.lblDescuentoMonto.TabIndex = 12;
            this.lblDescuentoMonto.Text = "Descuento (monto) :";
            // 
            // nudDescuentoMonto
            // 
            this.nudDescuentoMonto.DecimalPlaces = 2;
            this.nudDescuentoMonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudDescuentoMonto.Location = new System.Drawing.Point(180, 221);
            this.nudDescuentoMonto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudDescuentoMonto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDescuentoMonto.Name = "nudDescuentoMonto";
            this.nudDescuentoMonto.Size = new System.Drawing.Size(260, 27);
            this.nudDescuentoMonto.TabIndex = 13;
            this.nudDescuentoMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRecargoPorc
            // 
            this.lblRecargoPorc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecargoPorc.AutoSize = true;
            this.lblRecargoPorc.Location = new System.Drawing.Point(2, 255);
            this.lblRecargoPorc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecargoPorc.Name = "lblRecargoPorc";
            this.lblRecargoPorc.Size = new System.Drawing.Size(113, 21);
            this.lblRecargoPorc.TabIndex = 14;
            this.lblRecargoPorc.Text = "Recargo (%) :";
            // 
            // nudRecargoPorc
            // 
            this.nudRecargoPorc.DecimalPlaces = 2;
            this.nudRecargoPorc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudRecargoPorc.Location = new System.Drawing.Point(180, 252);
            this.nudRecargoPorc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudRecargoPorc.Name = "nudRecargoPorc";
            this.nudRecargoPorc.Size = new System.Drawing.Size(260, 27);
            this.nudRecargoPorc.TabIndex = 15;
            this.nudRecargoPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpResumen
            // 
            this.grpResumen.Controls.Add(this.tlpResumen);
            this.grpResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResumen.Location = new System.Drawing.Point(2, 448);
            this.grpResumen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpResumen.Name = "grpResumen";
            this.grpResumen.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.grpResumen.Size = new System.Drawing.Size(456, 325);
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
            this.tlpResumen.Location = new System.Drawing.Point(7, 27);
            this.tlpResumen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpResumen.Name = "tlpResumen";
            this.tlpResumen.RowCount = 2;
            this.tlpResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResumen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpResumen.Size = new System.Drawing.Size(442, 291);
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
            this.dgvCartSummary.Location = new System.Drawing.Point(2, 2);
            this.dgvCartSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCartSummary.MultiSelect = false;
            this.dgvCartSummary.Name = "dgvCartSummary";
            this.dgvCartSummary.ReadOnly = true;
            this.dgvCartSummary.RowHeadersVisible = false;
            this.dgvCartSummary.RowHeadersWidth = 62;
            this.dgvCartSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCartSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartSummary.Size = new System.Drawing.Size(438, 184);
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
            this.colQuantity.Width = 112;
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
            this.tlpTotals.Location = new System.Drawing.Point(2, 190);
            this.tlpTotals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpTotals.Name = "tlpTotals";
            this.tlpTotals.RowCount = 5;
            this.tlpTotals.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTotals.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTotals.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTotals.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTotals.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTotals.Size = new System.Drawing.Size(438, 99);
            this.tlpTotals.TabIndex = 1;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(2, 0);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(81, 21);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblSubtotalValue
            // 
            this.lblSubtotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotalValue.AutoSize = true;
            this.lblSubtotalValue.Location = new System.Drawing.Point(395, 0);
            this.lblSubtotalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotalValue.Name = "lblSubtotalValue";
            this.lblSubtotalValue.Size = new System.Drawing.Size(41, 21);
            this.lblSubtotalValue.TabIndex = 1;
            this.lblSubtotalValue.Text = "0,00";
            // 
            // lblIva
            // 
            this.lblIva.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(2, 21);
            this.lblIva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(43, 21);
            this.lblIva.TabIndex = 2;
            this.lblIva.Text = "IVA:";
            // 
            // lblIvaValue
            // 
            this.lblIvaValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIvaValue.AutoSize = true;
            this.lblIvaValue.Location = new System.Drawing.Point(395, 21);
            this.lblIvaValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIvaValue.Name = "lblIvaValue";
            this.lblIvaValue.Size = new System.Drawing.Size(41, 21);
            this.lblIvaValue.TabIndex = 3;
            this.lblIvaValue.Text = "0,00";
            // 
            // lblEnvio
            // 
            this.lblEnvio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Location = new System.Drawing.Point(2, 42);
            this.lblEnvio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(56, 21);
            this.lblEnvio.TabIndex = 4;
            this.lblEnvio.Text = "Envío:";
            // 
            // lblEnvioValue
            // 
            this.lblEnvioValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnvioValue.AutoSize = true;
            this.lblEnvioValue.Location = new System.Drawing.Point(395, 42);
            this.lblEnvioValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnvioValue.Name = "lblEnvioValue";
            this.lblEnvioValue.Size = new System.Drawing.Size(41, 21);
            this.lblEnvioValue.TabIndex = 5;
            this.lblEnvioValue.Text = "0,00";
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Location = new System.Drawing.Point(2, 63);
            this.lblDescuentos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(105, 21);
            this.lblDescuentos.TabIndex = 6;
            this.lblDescuentos.Text = "Descuentos:";
            // 
            // lblDescuentosValue
            // 
            this.lblDescuentosValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescuentosValue.AutoSize = true;
            this.lblDescuentosValue.Location = new System.Drawing.Point(395, 63);
            this.lblDescuentosValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescuentosValue.Name = "lblDescuentosValue";
            this.lblDescuentosValue.Size = new System.Drawing.Size(41, 21);
            this.lblDescuentosValue.TabIndex = 7;
            this.lblDescuentosValue.Text = "0,00";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(2, 84);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 15);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "TOTAL:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.Location = new System.Drawing.Point(405, 84);
            this.lblTotalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(31, 15);
            this.lblTotalValue.TabIndex = 9;
            this.lblTotalValue.Text = "0,00";
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.flpActions);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Location = new System.Drawing.Point(2, 848);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.pnlActions.Size = new System.Drawing.Size(1158, 52);
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
            this.flpActions.Location = new System.Drawing.Point(7, 10);
            this.flpActions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpActions.Name = "flpActions";
            this.flpActions.Size = new System.Drawing.Size(1144, 35);
            this.flpActions.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1049, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 31);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDraft
            // 
            this.btnDraft.AutoSize = true;
            this.btnDraft.Location = new System.Drawing.Point(886, 2);
            this.btnDraft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(159, 31);
            this.btnDraft.TabIndex = 1;
            this.btnDraft.Text = "Guardar borrador";
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.Location = new System.Drawing.Point(785, 2);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(97, 31);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormFinalizeSale
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1162, 902);
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(657, 460);
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
