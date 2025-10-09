namespace UI
{
    partial class FormBitacora
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpUntil;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.ComboBox cbEvents;
        private System.Windows.Forms.DataGridView dgvBitacora;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpUntil = new System.Windows.Forms.DateTimePicker();
            this.lblEvento = new System.Windows.Forms.Label();
            this.cbEvents = new System.Windows.Forms.ComboBox();
            this.txtSearchUsername = new System.Windows.Forms.TextBox();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.btnFilterBitacora = new UI.Controls.ButtonDefault();
            this.panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltros.Controls.Add(this.lblSubtitle);
            this.panelFiltros.Controls.Add(this.lblTitleForm);
            this.panelFiltros.Controls.Add(this.btnFilterBitacora);
            this.panelFiltros.Controls.Add(this.lblUsuario);
            this.panelFiltros.Controls.Add(this.lblDesde);
            this.panelFiltros.Controls.Add(this.dtpFrom);
            this.panelFiltros.Controls.Add(this.lblHasta);
            this.panelFiltros.Controls.Add(this.dtpUntil);
            this.panelFiltros.Controls.Add(this.lblEvento);
            this.panelFiltros.Controls.Add(this.cbEvents);
            this.panelFiltros.Controls.Add(this.txtSearchUsername);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFiltros.Location = new System.Drawing.Point(0, 0);
            this.panelFiltros.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panelFiltros.Size = new System.Drawing.Size(722, 173);
            this.panelFiltros.TabIndex = 1;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(11, 46);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(78, 30);
            this.lblSubtitle.TabIndex = 10;
            this.lblSubtitle.Text = "Filtros";
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleForm.Location = new System.Drawing.Point(1, 2);
            this.lblTitleForm.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(168, 44);
            this.lblTitleForm.TabIndex = 9;
            this.lblTitleForm.Text = "Bitacora";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(300, 87);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 22);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(12, 87);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(73, 22);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(9, 113);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(136, 26);
            this.dtpFrom.TabIndex = 3;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(152, 87);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(68, 22);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpUntil
            // 
            this.dtpUntil.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtpUntil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUntil.Location = new System.Drawing.Point(156, 113);
            this.dtpUntil.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.Size = new System.Drawing.Size(136, 26);
            this.dtpUntil.TabIndex = 5;
            this.dtpUntil.ValueChanged += new System.EventHandler(this.dtpUntil_ValueChanged);
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(447, 87);
            this.lblEvento.Margin = new System.Windows.Forms.Padding(0);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(81, 22);
            this.lblEvento.TabIndex = 6;
            this.lblEvento.Text = "Evento:";
            // 
            // cbEvents
            // 
            this.cbEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvents.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEvents.Location = new System.Drawing.Point(451, 113);
            this.cbEvents.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.cbEvents.Name = "cbEvents";
            this.cbEvents.Size = new System.Drawing.Size(136, 25);
            this.cbEvents.TabIndex = 7;
            this.cbEvents.SelectedIndexChanged += new System.EventHandler(this.cbEvents_SelectedIndexChanged);
            // 
            // txtSearchUsername
            // 
            this.txtSearchUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtSearchUsername.Location = new System.Drawing.Point(304, 113);
            this.txtSearchUsername.Name = "txtSearchUsername";
            this.txtSearchUsername.Size = new System.Drawing.Size(136, 26);
            this.txtSearchUsername.TabIndex = 11;
            this.txtSearchUsername.TextChanged += new System.EventHandler(this.txtSeachUsername_TextChanged);
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBitacora.Location = new System.Drawing.Point(0, 173);
            this.dgvBitacora.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.RowHeadersWidth = 62;
            this.dgvBitacora.Size = new System.Drawing.Size(722, 393);
            this.dgvBitacora.TabIndex = 0;
            // 
            // btnFilterBitacora
            // 
            this.btnFilterBitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnFilterBitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterBitacora.FlatAppearance.BorderSize = 0;
            this.btnFilterBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterBitacora.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnFilterBitacora.ForeColor = System.Drawing.Color.White;
            this.btnFilterBitacora.Location = new System.Drawing.Point(604, 97);
            this.btnFilterBitacora.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.btnFilterBitacora.Name = "btnFilterBitacora";
            this.btnFilterBitacora.Size = new System.Drawing.Size(108, 48);
            this.btnFilterBitacora.TabIndex = 8;
            this.btnFilterBitacora.Text = "Filtrar";
            this.btnFilterBitacora.UseVisualStyleBackColor = false;
            this.btnFilterBitacora.Click += new System.EventHandler(this.btnFilterBitacora_Click);
            // 
            // FormBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 566);
            this.Controls.Add(this.dgvBitacora);
            this.Controls.Add(this.panelFiltros);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Name = "FormBitacora";
            this.Text = "Bitácora de Eventos";
            this.Load += new System.EventHandler(this.FormBitacora_Load);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.ResumeLayout(false);

        }

        private Controls.ButtonDefault btnFilterBitacora;
        private System.Windows.Forms.Label lblTitleForm;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox txtSearchUsername;
    }
}
