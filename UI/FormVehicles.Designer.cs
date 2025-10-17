using System.Drawing;
using System.Windows.Forms;
using UI.common;

namespace UI
{
    partial class FormVehicles
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private TableLayoutPanel tblRoot;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private DataGridView dgvMaintenance;
        private GroupBox grpNewCheck;
        private TableLayoutPanel tblNewCheck;
        private Label lblDate, lblOdometer, lblType, lblNotes;
        private DateTimePicker dtpDate;
        private NumericUpDown numOdometer;
        private ComboBox cboType;
        private TextBox txtNotes;
        private FlowLayoutPanel pnlButtons;
        private Button btnAdd;
        private Button btnClose;

        private DataGridViewTextBoxColumn colDate, colOdometer, colType, colNotes;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.dgvMaintenance = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOdometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpNewCheck = new System.Windows.Forms.GroupBox();
            this.tblNewCheck = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblOdometer = new System.Windows.Forms.Label();
            this.numOdometer = new System.Windows.Forms.NumericUpDown();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblRoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).BeginInit();
            this.grpNewCheck.SuspendLayout();
            this.tblNewCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOdometer)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblRoot
            // 
            this.tblRoot.ColumnCount = 1;
            this.tblRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRoot.Controls.Add(this.pnlHeader, 0, 0);
            this.tblRoot.Controls.Add(this.dgvMaintenance, 0, 1);
            this.tblRoot.Controls.Add(this.grpNewCheck, 0, 2);
            this.tblRoot.Controls.Add(this.pnlButtons, 0, 3);
            this.tblRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRoot.Location = new System.Drawing.Point(0, 0);
            this.tblRoot.Margin = new System.Windows.Forms.Padding(4);
            this.tblRoot.Name = "tblRoot";
            this.tblRoot.Padding = new System.Windows.Forms.Padding(12);
            this.tblRoot.RowCount = 4;
            this.tblRoot.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.00544F));
            this.tblRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.73866F));
            this.tblRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblRoot.Size = new System.Drawing.Size(980, 693);
            this.tblRoot.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 11);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(16, 17, 16, 17);
            this.pnlHeader.Size = new System.Drawing.Size(956, 107);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mantenimiento del Vehículo";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubtitle.Location = new System.Drawing.Point(4, 36);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(209, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Registros de chequeo y servicio";
            // 
            // dgvMaintenance
            // 
            this.dgvMaintenance.AllowUserToAddRows = false;
            this.dgvMaintenance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.dgvMaintenance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaintenance.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaintenance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colOdometer,
            this.colType,
            this.colNotes});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaintenance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaintenance.EnableHeadersVisualStyles = false;
            this.dgvMaintenance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(226)))), ((int)(((byte)(236)))));
            this.dgvMaintenance.Location = new System.Drawing.Point(16, 134);
            this.dgvMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMaintenance.MultiSelect = false;
            this.dgvMaintenance.Name = "dgvMaintenance";
            this.dgvMaintenance.ReadOnly = true;
            this.dgvMaintenance.RowHeadersVisible = false;
            this.dgvMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaintenance.Size = new System.Drawing.Size(948, 251);
            this.dgvMaintenance.TabIndex = 1;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Fecha";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colOdometer
            // 
            this.colOdometer.HeaderText = "Odómetro";
            this.colOdometer.Name = "colOdometer";
            this.colOdometer.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Tipo de servicio";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colNotes
            // 
            this.colNotes.HeaderText = "Notas";
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            // 
            // grpNewCheck
            // 
            this.grpNewCheck.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpNewCheck.Controls.Add(this.tblNewCheck);
            this.grpNewCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNewCheck.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewCheck.Location = new System.Drawing.Point(16, 393);
            this.grpNewCheck.Margin = new System.Windows.Forms.Padding(4);
            this.grpNewCheck.Name = "grpNewCheck";
            this.grpNewCheck.Padding = new System.Windows.Forms.Padding(12);
            this.grpNewCheck.Size = new System.Drawing.Size(948, 233);
            this.grpNewCheck.TabIndex = 2;
            this.grpNewCheck.TabStop = false;
            this.grpNewCheck.Text = "Nuevo chequeo / mantenimiento";
            // 
            // tblNewCheck
            // 
            this.tblNewCheck.ColumnCount = 2;
            this.tblNewCheck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblNewCheck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblNewCheck.Controls.Add(this.lblDate, 0, 0);
            this.tblNewCheck.Controls.Add(this.dtpDate, 1, 0);
            this.tblNewCheck.Controls.Add(this.lblOdometer, 0, 1);
            this.tblNewCheck.Controls.Add(this.numOdometer, 1, 1);
            this.tblNewCheck.Controls.Add(this.lblType, 0, 2);
            this.tblNewCheck.Controls.Add(this.cboType, 1, 2);
            this.tblNewCheck.Controls.Add(this.lblNotes, 0, 3);
            this.tblNewCheck.Controls.Add(this.txtNotes, 1, 3);
            this.tblNewCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNewCheck.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblNewCheck.Location = new System.Drawing.Point(12, 27);
            this.tblNewCheck.Margin = new System.Windows.Forms.Padding(4);
            this.tblNewCheck.Name = "tblNewCheck";
            this.tblNewCheck.Padding = new System.Windows.Forms.Padding(4);
            this.tblNewCheck.RowCount = 4;
            this.tblNewCheck.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblNewCheck.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblNewCheck.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblNewCheck.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblNewCheck.Size = new System.Drawing.Size(924, 194);
            this.tblNewCheck.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDate.Location = new System.Drawing.Point(8, 6);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Fecha:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(237, 8);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(119, 22);
            this.dtpDate.TabIndex = 1;
            // 
            // lblOdometer
            // 
            this.lblOdometer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOdometer.Location = new System.Drawing.Point(8, 36);
            this.lblOdometer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdometer.Name = "lblOdometer";
            this.lblOdometer.Size = new System.Drawing.Size(107, 25);
            this.lblOdometer.TabIndex = 2;
            this.lblOdometer.Text = "Odómetro (km):";
            // 
            // numOdometer
            // 
            this.numOdometer.Location = new System.Drawing.Point(237, 38);
            this.numOdometer.Margin = new System.Windows.Forms.Padding(4);
            this.numOdometer.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.numOdometer.Name = "numOdometer";
            this.numOdometer.Size = new System.Drawing.Size(120, 22);
            this.numOdometer.TabIndex = 3;
            this.numOdometer.ThousandsSeparator = true;
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblType.Location = new System.Drawing.Point(8, 68);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(107, 25);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Tipo:";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Items.AddRange(new object[] {
            "Service general",
            "Cambio de aceite",
            "Frenos",
            "Neumáticos",
            "Inspección técnica",
            "Otro"});
            this.cboType.Location = new System.Drawing.Point(237, 68);
            this.cboType.Margin = new System.Windows.Forms.Padding(4);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(119, 25);
            this.cboType.TabIndex = 5;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNotes.Location = new System.Drawing.Point(8, 131);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(67, 25);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notas:";
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(237, 101);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(679, 85);
            this.txtNotes.TabIndex = 7;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlButtons.Location = new System.Drawing.Point(12, 641);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(956, 40);
            this.pnlButtons.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(874, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnClose.Size = new System.Drawing.Size(82, 41);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(716, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.btnAdd.Size = new System.Drawing.Size(150, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Guardar registro";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // FormVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 693);
            this.Controls.Add(this.tblRoot);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mantenimiento del Vehículo";
            this.tblRoot.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).EndInit();
            this.grpNewCheck.ResumeLayout(false);
            this.tblNewCheck.ResumeLayout(false);
            this.tblNewCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOdometer)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
