// FormPreShipOrder.Designer.cs
namespace UI
{
    partial class FormPreShipOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.tblRoot = new System.Windows.Forms.TableLayoutPanel();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.tblCustomer = new System.Windows.Forms.TableLayoutPanel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblCustomerNotes = new System.Windows.Forms.Label();
            this.txtCustomerNotes = new System.Windows.Forms.TextBox();
            this.grpDealerAssignment = new System.Windows.Forms.GroupBox();
            this.tblAssignee = new System.Windows.Forms.TableLayoutPanel();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lstDealers = new System.Windows.Forms.ListBox();
            this.pnlAssignButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnUnassign = new System.Windows.Forms.Button();
            this.lblAssignedDealer = new System.Windows.Forms.Label();
            this.txtAssignedDealer = new System.Windows.Forms.TextBox();
            this.chkCashOnDelivery = new System.Windows.Forms.CheckBox();
            this.chkFragile = new System.Windows.Forms.CheckBox();
            this.grpOrderItems = new System.Windows.Forms.GroupBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colSku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImgProduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblRoot.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.tblCustomer.SuspendLayout();
            this.grpDealerAssignment.SuspendLayout();
            this.tblAssignee.SuspendLayout();
            this.pnlAssignButtons.SuspendLayout();
            this.grpOrderItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblRoot
            // 
            this.tblRoot.ColumnCount = 2;
            this.tblRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblRoot.Controls.Add(this.grpCustomer, 0, 0);
            this.tblRoot.Controls.Add(this.grpDealerAssignment, 1, 0);
            this.tblRoot.Controls.Add(this.grpOrderItems, 0, 1);
            this.tblRoot.Controls.Add(this.pnlActions, 0, 2);
            this.tblRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRoot.Location = new System.Drawing.Point(0, 0);
            this.tblRoot.Margin = new System.Windows.Forms.Padding(4);
            this.tblRoot.Name = "tblRoot";
            this.tblRoot.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tblRoot.RowCount = 3;
            this.tblRoot.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRoot.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRoot.Size = new System.Drawing.Size(1128, 826);
            this.tblRoot.TabIndex = 0;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.tblCustomer);
            this.grpCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCustomer.Location = new System.Drawing.Point(12, 13);
            this.grpCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.grpCustomer.Size = new System.Drawing.Size(659, 188);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Datos del Cliente";
            // 
            // tblCustomer
            // 
            this.tblCustomer.ColumnCount = 4;
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCustomer.Controls.Add(this.lblFullName, 0, 0);
            this.tblCustomer.Controls.Add(this.txtFullName, 1, 0);
            this.tblCustomer.Controls.Add(this.lblAddress, 0, 1);
            this.tblCustomer.Controls.Add(this.txtAddress, 1, 1);
            this.tblCustomer.Controls.Add(this.lblPhone, 0, 2);
            this.tblCustomer.Controls.Add(this.txtPhone, 1, 2);
            this.tblCustomer.Controls.Add(this.lblCustomerNotes, 0, 3);
            this.tblCustomer.Controls.Add(this.txtCustomerNotes, 1, 3);
            this.tblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCustomer.Location = new System.Drawing.Point(8, 23);
            this.tblCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.tblCustomer.Name = "tblCustomer";
            this.tblCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.tblCustomer.RowCount = 4;
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblCustomer.Size = new System.Drawing.Size(643, 156);
            this.tblCustomer.TabIndex = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(8, 10);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(108, 16);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Nombre completo:";
            // 
            // txtFullName
            // 
            this.tblCustomer.SetColumnSpan(this.txtFullName, 3);
            this.txtFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFullName.Location = new System.Drawing.Point(166, 8);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(469, 21);
            this.txtFullName.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(8, 39);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 16);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Domicilio:";
            // 
            // txtAddress
            // 
            this.tblCustomer.SetColumnSpan(this.txtAddress, 3);
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(166, 37);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(469, 21);
            this.txtAddress.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(8, 68);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 16);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Teléfono:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(166, 66);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(141, 21);
            this.txtPhone.TabIndex = 5;
            // 
            // lblCustomerNotes
            // 
            this.lblCustomerNotes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustomerNotes.AutoSize = true;
            this.lblCustomerNotes.Location = new System.Drawing.Point(8, 116);
            this.lblCustomerNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerNotes.Name = "lblCustomerNotes";
            this.lblCustomerNotes.Size = new System.Drawing.Size(92, 16);
            this.lblCustomerNotes.TabIndex = 6;
            this.lblCustomerNotes.Text = "Observaciones:";
            // 
            // txtCustomerNotes
            // 
            this.tblCustomer.SetColumnSpan(this.txtCustomerNotes, 3);
            this.txtCustomerNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomerNotes.Location = new System.Drawing.Point(166, 95);
            this.txtCustomerNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerNotes.Multiline = true;
            this.txtCustomerNotes.Name = "txtCustomerNotes";
            this.txtCustomerNotes.Size = new System.Drawing.Size(469, 58);
            this.txtCustomerNotes.TabIndex = 7;
            // 
            // grpDealerAssignment
            // 
            this.grpDealerAssignment.Controls.Add(this.tblAssignee);
            this.grpDealerAssignment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDealerAssignment.Location = new System.Drawing.Point(679, 13);
            this.grpDealerAssignment.Margin = new System.Windows.Forms.Padding(4);
            this.grpDealerAssignment.Name = "grpDealerAssignment";
            this.grpDealerAssignment.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.grpDealerAssignment.Size = new System.Drawing.Size(437, 188);
            this.grpDealerAssignment.TabIndex = 1;
            this.grpDealerAssignment.TabStop = false;
            this.grpDealerAssignment.Text = "Asignación de Repartidor";
            // 
            // tblAssignee
            // 
            this.tblAssignee.ColumnCount = 3;
            this.tblAssignee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblAssignee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblAssignee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblAssignee.Controls.Add(this.lblAvailable, 0, 0);
            this.tblAssignee.Controls.Add(this.lstDealers, 0, 1);
            this.tblAssignee.Controls.Add(this.pnlAssignButtons, 1, 1);
            this.tblAssignee.Controls.Add(this.lblAssignedDealer, 2, 0);
            this.tblAssignee.Controls.Add(this.txtAssignedDealer, 2, 1);
            this.tblAssignee.Controls.Add(this.chkCashOnDelivery, 2, 2);
            this.tblAssignee.Controls.Add(this.chkFragile, 2, 3);
            this.tblAssignee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAssignee.Location = new System.Drawing.Point(8, 23);
            this.tblAssignee.Margin = new System.Windows.Forms.Padding(4);
            this.tblAssignee.Name = "tblAssignee";
            this.tblAssignee.Padding = new System.Windows.Forms.Padding(4);
            this.tblAssignee.RowCount = 5;
            this.tblAssignee.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblAssignee.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblAssignee.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblAssignee.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblAssignee.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblAssignee.Size = new System.Drawing.Size(421, 156);
            this.tblAssignee.TabIndex = 0;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(8, 4);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(69, 16);
            this.lblAvailable.TabIndex = 0;
            this.lblAvailable.Text = "Disponibles:";
            // 
            // lstDealers
            // 
            this.lstDealers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDealers.FormattingEnabled = true;
            this.lstDealers.ItemHeight = 16;
            this.lstDealers.Location = new System.Drawing.Point(8, 24);
            this.lstDealers.Margin = new System.Windows.Forms.Padding(4);
            this.lstDealers.Name = "lstDealers";
            this.tblAssignee.SetRowSpan(this.lstDealers, 4);
            this.lstDealers.Size = new System.Drawing.Size(154, 144);
            this.lstDealers.TabIndex = 1;
            // 
            // pnlAssignButtons
            // 
            this.pnlAssignButtons.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlAssignButtons.AutoSize = true;
            this.pnlAssignButtons.Controls.Add(this.btnAssign);
            this.pnlAssignButtons.Controls.Add(this.btnUnassign);
            this.pnlAssignButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlAssignButtons.Location = new System.Drawing.Point(170, 24);
            this.pnlAssignButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAssignButtons.Name = "pnlAssignButtons";
            this.pnlAssignButtons.Size = new System.Drawing.Size(110, 84);
            this.pnlAssignButtons.TabIndex = 2;
            // 
            // btnAssign
            // 
            this.btnAssign.AutoSize = true;
            this.btnAssign.Location = new System.Drawing.Point(4, 4);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(102, 34);
            this.btnAssign.TabIndex = 0;
            this.btnAssign.Text = "Asignar ▶";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnUnassign
            // 
            this.btnUnassign.AutoSize = true;
            this.btnUnassign.Location = new System.Drawing.Point(4, 46);
            this.btnUnassign.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnassign.Name = "btnUnassign";
            this.btnUnassign.Size = new System.Drawing.Size(90, 34);
            this.btnUnassign.TabIndex = 1;
            this.btnUnassign.Text = "◀ Quitar";
            this.btnUnassign.UseVisualStyleBackColor = true;
            this.btnUnassign.Click += new System.EventHandler(this.btnUnassign_Click);
            // 
            // lblAssignedDealer
            // 
            this.lblAssignedDealer.AutoSize = true;
            this.lblAssignedDealer.Location = new System.Drawing.Point(288, 4);
            this.lblAssignedDealer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssignedDealer.Name = "lblAssignedDealer";
            this.lblAssignedDealer.Size = new System.Drawing.Size(121, 16);
            this.lblAssignedDealer.TabIndex = 3;
            this.lblAssignedDealer.Text = "Repartidor asignado:";
            // 
            // txtAssignedDealer
            // 
            this.txtAssignedDealer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAssignedDealer.Location = new System.Drawing.Point(288, 24);
            this.txtAssignedDealer.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssignedDealer.Name = "txtAssignedDealer";
            this.txtAssignedDealer.ReadOnly = true;
            this.txtAssignedDealer.Size = new System.Drawing.Size(125, 21);
            this.txtAssignedDealer.TabIndex = 4;
            // 
            // chkCashOnDelivery
            // 
            this.chkCashOnDelivery.AutoSize = true;
            this.chkCashOnDelivery.Location = new System.Drawing.Point(288, 116);
            this.chkCashOnDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.chkCashOnDelivery.Name = "chkCashOnDelivery";
            this.chkCashOnDelivery.Size = new System.Drawing.Size(122, 20);
            this.chkCashOnDelivery.TabIndex = 5;
            this.chkCashOnDelivery.Text = "Contra reembolso";
            this.chkCashOnDelivery.UseVisualStyleBackColor = true;
            // 
            // chkFragile
            // 
            this.chkFragile.AutoSize = true;
            this.chkFragile.Location = new System.Drawing.Point(288, 144);
            this.chkFragile.Margin = new System.Windows.Forms.Padding(4);
            this.chkFragile.Name = "chkFragile";
            this.chkFragile.Size = new System.Drawing.Size(53, 20);
            this.chkFragile.TabIndex = 6;
            this.chkFragile.Text = "Frágil";
            this.chkFragile.UseVisualStyleBackColor = true;
            // 
            // grpOrderItems
            // 
            this.tblRoot.SetColumnSpan(this.grpOrderItems, 2);
            this.grpOrderItems.Controls.Add(this.dgvItems);
            this.grpOrderItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOrderItems.Location = new System.Drawing.Point(12, 209);
            this.grpOrderItems.Margin = new System.Windows.Forms.Padding(4);
            this.grpOrderItems.Name = "grpOrderItems";
            this.grpOrderItems.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.grpOrderItems.Size = new System.Drawing.Size(1104, 552);
            this.grpOrderItems.TabIndex = 2;
            this.grpOrderItems.TabStop = false;
            this.grpOrderItems.Text = "Productos del Pedido";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSku,
            this.colImgProduct,
            this.colDescription,
            this.colQuantity,
            this.colNotes});
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(8, 23);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 62;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(1088, 520);
            this.dgvItems.TabIndex = 0;
            // 
            // colSku
            // 
            this.colSku.HeaderText = "SKU";
            this.colSku.MinimumWidth = 40;
            this.colSku.Name = "colSku";
            this.colSku.ReadOnly = true;
            this.colSku.Width = 40;
            // 
            // colImgProduct
            // 
            this.colImgProduct.HeaderText = "";
            this.colImgProduct.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImgProduct.MinimumWidth = 80;
            this.colImgProduct.Name = "colImgProduct";
            this.colImgProduct.ReadOnly = true;
            this.colImgProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colImgProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colImgProduct.Width = 90;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.HeaderText = "Descripción";
            this.colDescription.MinimumWidth = 8;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Cantidad";
            this.colQuantity.MinimumWidth = 80;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 90;
            // 
            // colNotes
            // 
            this.colNotes.HeaderText = "Observaciones";
            this.colNotes.MinimumWidth = 120;
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            this.colNotes.Width = 160;
            // 
            // pnlActions
            // 
            this.tblRoot.SetColumnSpan(this.pnlActions, 2);
            this.pnlActions.Controls.Add(this.btnClose);
            this.pnlActions.Controls.Add(this.btnPrint);
            this.pnlActions.Controls.Add(this.btnValidate);
            this.pnlActions.Controls.Add(this.btnSave);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlActions.Location = new System.Drawing.Point(12, 769);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Padding = new System.Windows.Forms.Padding(4);
            this.pnlActions.Size = new System.Drawing.Size(1104, 44);
            this.pnlActions.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Location = new System.Drawing.Point(1012, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 34);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = true;
            this.btnPrint.Location = new System.Drawing.Point(803, 8);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(201, 34);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Imprimir Hoja de Ruta";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnValidate
            // 
            this.btnValidate.AutoSize = true;
            this.btnValidate.Location = new System.Drawing.Point(715, 8);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(80, 34);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "Validar";
            this.btnValidate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(616, 8);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormPreShipOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 826);
            this.Controls.Add(this.tblRoot);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(980, 680);
            this.Name = "FormPreShipOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pre-Despacho de Pedido";
            this.tblRoot.ResumeLayout(false);
            this.grpCustomer.ResumeLayout(false);
            this.tblCustomer.ResumeLayout(false);
            this.tblCustomer.PerformLayout();
            this.grpDealerAssignment.ResumeLayout(false);
            this.tblAssignee.ResumeLayout(false);
            this.tblAssignee.PerformLayout();
            this.pnlAssignButtons.ResumeLayout(false);
            this.pnlAssignButtons.PerformLayout();
            this.grpOrderItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblRoot;

        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TableLayoutPanel tblCustomer;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblCustomerNotes;
        private System.Windows.Forms.TextBox txtCustomerNotes;

        private System.Windows.Forms.GroupBox grpDealerAssignment;
        private System.Windows.Forms.TableLayoutPanel tblAssignee;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.ListBox lstDealers;
        private System.Windows.Forms.FlowLayoutPanel pnlAssignButtons;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnUnassign;
        private System.Windows.Forms.Label lblAssignedDealer;
        private System.Windows.Forms.TextBox txtAssignedDealer;
        private System.Windows.Forms.CheckBox chkCashOnDelivery;
        private System.Windows.Forms.CheckBox chkFragile;

        private System.Windows.Forms.GroupBox grpOrderItems;
        private System.Windows.Forms.DataGridView dgvItems;

        private System.Windows.Forms.FlowLayoutPanel pnlActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSku;
        private System.Windows.Forms.DataGridViewImageColumn colImgProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
    }
}
