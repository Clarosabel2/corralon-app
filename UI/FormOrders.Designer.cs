namespace UI
{
    partial class FormOrders
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
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnDispatchOrder = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.lblOrders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrdersShipped = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMarkDelivered = new System.Windows.Forms.Button();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersShipped)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.btnDispatchOrder);
            this.groupBoxSearch.Controls.Add(this.txtSearch);
            this.groupBoxSearch.Controls.Add(this.lblSearch);
            this.groupBoxSearch.Controls.Add(this.dgvOrders);
            this.groupBoxSearch.Controls.Add(this.lblOrders);
            this.groupBoxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(749, 373);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            // 
            // btnDispatchOrder
            // 
            this.btnDispatchOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDispatchOrder.Location = new System.Drawing.Point(661, 91);
            this.btnDispatchOrder.Name = "btnDispatchOrder";
            this.btnDispatchOrder.Size = new System.Drawing.Size(82, 244);
            this.btnDispatchOrder.TabIndex = 3;
            this.btnDispatchOrder.Text = "Despachar Pedido";
            this.btnDispatchOrder.UseVisualStyleBackColor = true;
            this.btnDispatchOrder.Click += new System.EventHandler(this.btnDispatchOrder_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(86, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(424, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(71, 22);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Buscar";
            // 
            // dgvOrders
            // 
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(12, 91);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(643, 244);
            this.dgvOrders.TabIndex = 1;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(12, 66);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(187, 22);
            this.lblOrders.TabIndex = 2;
            this.lblOrders.Text = "Pedidos Pendientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pedidos Despachados";
            // 
            // dgvOrdersShipped
            // 
            this.dgvOrdersShipped.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrdersShipped.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdersShipped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersShipped.Location = new System.Drawing.Point(12, 41);
            this.dgvOrdersShipped.MultiSelect = false;
            this.dgvOrdersShipped.Name = "dgvOrdersShipped";
            this.dgvOrdersShipped.ReadOnly = true;
            this.dgvOrdersShipped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdersShipped.Size = new System.Drawing.Size(643, 246);
            this.dgvOrdersShipped.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnMarkDelivered);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvOrdersShipped);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 385);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(661, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 120);
            this.button2.TabIndex = 5;
            this.button2.Text = "Notificar Problema";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMarkDelivered
            // 
            this.btnMarkDelivered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkDelivered.Location = new System.Drawing.Point(661, 41);
            this.btnMarkDelivered.Name = "btnMarkDelivered";
            this.btnMarkDelivered.Size = new System.Drawing.Size(82, 120);
            this.btnMarkDelivered.TabIndex = 4;
            this.btnMarkDelivered.Text = "Marcar Entregado";
            this.btnMarkDelivered.UseVisualStyleBackColor = true;
            this.btnMarkDelivered.Click += new System.EventHandler(this.btnMarkDelivered_Click);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 726);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSearch);
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersShipped)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrdersShipped;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDispatchOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMarkDelivered;
    }
}