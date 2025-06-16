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
            this.dgvDetailsOrder = new System.Windows.Forms.DataGridView();
            this.groupBoxAssingDealer = new System.Windows.Forms.GroupBox();
            this.gBDetailsClient = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblClientPhone = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.cBDealers = new System.Windows.Forms.ComboBox();
            this.lblDealer = new System.Windows.Forms.Label();
            this.buttonDispatchOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsOrder)).BeginInit();
            this.groupBoxAssingDealer.SuspendLayout();
            this.gBDetailsClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetailsOrder
            // 
            this.dgvDetailsOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetailsOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetailsOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailsOrder.Location = new System.Drawing.Point(0, 145);
            this.dgvDetailsOrder.Name = "dgvDetailsOrder";
            this.dgvDetailsOrder.ReadOnly = true;
            this.dgvDetailsOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailsOrder.Size = new System.Drawing.Size(510, 433);
            this.dgvDetailsOrder.TabIndex = 0;
            // 
            // groupBoxAssingDealer
            // 
            this.groupBoxAssingDealer.Controls.Add(this.gBDetailsClient);
            this.groupBoxAssingDealer.Controls.Add(this.cBDealers);
            this.groupBoxAssingDealer.Controls.Add(this.lblDealer);
            this.groupBoxAssingDealer.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAssingDealer.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAssingDealer.Name = "groupBoxAssingDealer";
            this.groupBoxAssingDealer.Size = new System.Drawing.Size(510, 139);
            this.groupBoxAssingDealer.TabIndex = 1;
            this.groupBoxAssingDealer.TabStop = false;
            // 
            // gBDetailsClient
            // 
            this.gBDetailsClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBDetailsClient.Controls.Add(this.textBox3);
            this.gBDetailsClient.Controls.Add(this.lblClientPhone);
            this.gBDetailsClient.Controls.Add(this.textBox2);
            this.gBDetailsClient.Controls.Add(this.textBox1);
            this.gBDetailsClient.Controls.Add(this.lblAddress);
            this.gBDetailsClient.Controls.Add(this.lblClient);
            this.gBDetailsClient.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDetailsClient.Location = new System.Drawing.Point(6, 49);
            this.gBDetailsClient.Name = "gBDetailsClient";
            this.gBDetailsClient.Size = new System.Drawing.Size(498, 82);
            this.gBDetailsClient.TabIndex = 3;
            this.gBDetailsClient.TabStop = false;
            this.gBDetailsClient.Text = "Detalles del Cliente";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(295, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(138, 21);
            this.textBox3.TabIndex = 5;
            // 
            // lblClientPhone
            // 
            this.lblClientPhone.AutoSize = true;
            this.lblClientPhone.Location = new System.Drawing.Point(234, 29);
            this.lblClientPhone.Name = "lblClientPhone";
            this.lblClientPhone.Size = new System.Drawing.Size(55, 16);
            this.lblClientPhone.TabIndex = 4;
            this.lblClientPhone.Text = "Telefono:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(141, 21);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(141, 21);
            this.textBox1.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 55);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 16);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Domicilio:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(7, 29);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(48, 16);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Cliente:";
            // 
            // cBDealers
            // 
            this.cBDealers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDealers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBDealers.FormattingEnabled = true;
            this.cBDealers.Location = new System.Drawing.Point(149, 18);
            this.cBDealers.Name = "cBDealers";
            this.cBDealers.Size = new System.Drawing.Size(188, 25);
            this.cBDealers.TabIndex = 1;
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(12, 16);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(131, 22);
            this.lblDealer.TabIndex = 0;
            this.lblDealer.Text = "Repartidores:";
            // 
            // buttonDispatchOrder
            // 
            this.buttonDispatchOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDispatchOrder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDispatchOrder.Location = new System.Drawing.Point(12, 584);
            this.buttonDispatchOrder.Name = "buttonDispatchOrder";
            this.buttonDispatchOrder.Size = new System.Drawing.Size(480, 33);
            this.buttonDispatchOrder.TabIndex = 3;
            this.buttonDispatchOrder.Text = "Despachar Pedido";
            this.buttonDispatchOrder.UseVisualStyleBackColor = true;
            this.buttonDispatchOrder.Click += new System.EventHandler(this.buttonDispatchOrder_Click);
            // 
            // FormPreShipOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 618);
            this.Controls.Add(this.buttonDispatchOrder);
            this.Controls.Add(this.groupBoxAssingDealer);
            this.Controls.Add(this.dgvDetailsOrder);
            this.Name = "FormPreShipOrder";
            this.Text = "FormPreShipOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsOrder)).EndInit();
            this.groupBoxAssingDealer.ResumeLayout(false);
            this.groupBoxAssingDealer.PerformLayout();
            this.gBDetailsClient.ResumeLayout(false);
            this.gBDetailsClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetailsOrder;
        private System.Windows.Forms.GroupBox groupBoxAssingDealer;
        private System.Windows.Forms.ComboBox cBDealers;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Button buttonDispatchOrder;
        private System.Windows.Forms.GroupBox gBDetailsClient;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblClientPhone;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblClient;
    }
}