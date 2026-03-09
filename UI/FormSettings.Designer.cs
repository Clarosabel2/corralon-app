namespace UI
{
    partial class FormSettings
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.lblCompanyPhone = new System.Windows.Forms.Label();
            this.txtCompanyPhone = new System.Windows.Forms.TextBox();
            this.lblCompanyCuit = new System.Windows.Forms.Label();
            this.txtCompanyCuit = new System.Windows.Forms.TextBox();
            this.grpAppearance = new System.Windows.Forms.GroupBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.grpNotifications = new System.Windows.Forms.GroupBox();
            this.chkEmailNotifications = new System.Windows.Forms.CheckBox();
            this.chkSoundAlerts = new System.Windows.Forms.CheckBox();
            this.chkAutoBackup = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpAppearance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            this.grpNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Location = new System.Drawing.Point(20, 15);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(940, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Configuracion";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255);
            this.lblSubtitle.Location = new System.Drawing.Point(22, 48);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(350, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Ajustes generales de la aplicacion";
            // 
            // grpGeneral
            // 
            this.grpGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGeneral.BackColor = System.Drawing.Color.White;
            this.grpGeneral.Controls.Add(this.lblCompanyName);
            this.grpGeneral.Controls.Add(this.txtCompanyName);
            this.grpGeneral.Controls.Add(this.lblCompanyAddress);
            this.grpGeneral.Controls.Add(this.txtCompanyAddress);
            this.grpGeneral.Controls.Add(this.lblCompanyPhone);
            this.grpGeneral.Controls.Add(this.txtCompanyPhone);
            this.grpGeneral.Controls.Add(this.lblCompanyCuit);
            this.grpGeneral.Controls.Add(this.txtCompanyCuit);
            this.grpGeneral.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpGeneral.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.grpGeneral.Location = new System.Drawing.Point(20, 110);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.grpGeneral.Size = new System.Drawing.Size(940, 180);
            this.grpGeneral.TabIndex = 1;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "  Datos de la Empresa  ";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblCompanyName.Location = new System.Drawing.Point(25, 35);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(120, 19);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Razon Social:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCompanyName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtCompanyName.Location = new System.Drawing.Point(160, 33);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(350, 25);
            this.txtCompanyName.TabIndex = 1;
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCompanyAddress.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblCompanyAddress.Location = new System.Drawing.Point(25, 70);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(80, 19);
            this.lblCompanyAddress.TabIndex = 2;
            this.lblCompanyAddress.Text = "Direccion:";
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtCompanyAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCompanyAddress.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtCompanyAddress.Location = new System.Drawing.Point(160, 68);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(350, 25);
            this.txtCompanyAddress.TabIndex = 3;
            // 
            // lblCompanyPhone
            // 
            this.lblCompanyPhone.AutoSize = true;
            this.lblCompanyPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCompanyPhone.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblCompanyPhone.Location = new System.Drawing.Point(25, 105);
            this.lblCompanyPhone.Name = "lblCompanyPhone";
            this.lblCompanyPhone.Size = new System.Drawing.Size(80, 19);
            this.lblCompanyPhone.TabIndex = 4;
            this.lblCompanyPhone.Text = "Telefono:";
            // 
            // txtCompanyPhone
            // 
            this.txtCompanyPhone.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtCompanyPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCompanyPhone.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtCompanyPhone.Location = new System.Drawing.Point(160, 103);
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.txtCompanyPhone.Size = new System.Drawing.Size(200, 25);
            this.txtCompanyPhone.TabIndex = 5;
            // 
            // lblCompanyCuit
            // 
            this.lblCompanyCuit.AutoSize = true;
            this.lblCompanyCuit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCompanyCuit.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblCompanyCuit.Location = new System.Drawing.Point(25, 140);
            this.lblCompanyCuit.Name = "lblCompanyCuit";
            this.lblCompanyCuit.Size = new System.Drawing.Size(50, 19);
            this.lblCompanyCuit.TabIndex = 6;
            this.lblCompanyCuit.Text = "CUIT:";
            // 
            // txtCompanyCuit
            // 
            this.txtCompanyCuit.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtCompanyCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompanyCuit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCompanyCuit.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.txtCompanyCuit.Location = new System.Drawing.Point(160, 138);
            this.txtCompanyCuit.Name = "txtCompanyCuit";
            this.txtCompanyCuit.Size = new System.Drawing.Size(200, 25);
            this.txtCompanyCuit.TabIndex = 7;
            // 
            // grpAppearance
            // 
            this.grpAppearance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAppearance.BackColor = System.Drawing.Color.White;
            this.grpAppearance.Controls.Add(this.lblTheme);
            this.grpAppearance.Controls.Add(this.cmbTheme);
            this.grpAppearance.Controls.Add(this.lblFontSize);
            this.grpAppearance.Controls.Add(this.numFontSize);
            this.grpAppearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpAppearance.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.grpAppearance.Location = new System.Drawing.Point(20, 305);
            this.grpAppearance.Name = "grpAppearance";
            this.grpAppearance.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.grpAppearance.Size = new System.Drawing.Size(940, 110);
            this.grpAppearance.TabIndex = 2;
            this.grpAppearance.TabStop = false;
            this.grpAppearance.Text = "  Apariencia  ";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTheme.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblTheme.Location = new System.Drawing.Point(25, 38);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(50, 19);
            this.lblTheme.TabIndex = 0;
            this.lblTheme.Text = "Tema:";
            // 
            // cmbTheme
            // 
            this.cmbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTheme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTheme.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Items.AddRange(new object[] {
            "Claro",
            "Oscuro"});
            this.cmbTheme.Location = new System.Drawing.Point(160, 35);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(200, 25);
            this.cmbTheme.TabIndex = 1;
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFontSize.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblFontSize.Location = new System.Drawing.Point(25, 73);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(130, 19);
            this.lblFontSize.TabIndex = 2;
            this.lblFontSize.Text = "Tamano de fuente:";
            // 
            // numFontSize
            // 
            this.numFontSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numFontSize.Location = new System.Drawing.Point(160, 71);
            this.numFontSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFontSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(80, 25);
            this.numFontSize.TabIndex = 3;
            this.numFontSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // grpNotifications
            // 
            this.grpNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNotifications.BackColor = System.Drawing.Color.White;
            this.grpNotifications.Controls.Add(this.chkEmailNotifications);
            this.grpNotifications.Controls.Add(this.chkSoundAlerts);
            this.grpNotifications.Controls.Add(this.chkAutoBackup);
            this.grpNotifications.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.grpNotifications.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.grpNotifications.Location = new System.Drawing.Point(20, 430);
            this.grpNotifications.Name = "grpNotifications";
            this.grpNotifications.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.grpNotifications.Size = new System.Drawing.Size(940, 130);
            this.grpNotifications.TabIndex = 3;
            this.grpNotifications.TabStop = false;
            this.grpNotifications.Text = "  Notificaciones y Respaldo  ";
            // 
            // chkEmailNotifications
            // 
            this.chkEmailNotifications.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkEmailNotifications.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.chkEmailNotifications.Location = new System.Drawing.Point(25, 35);
            this.chkEmailNotifications.Name = "chkEmailNotifications";
            this.chkEmailNotifications.Size = new System.Drawing.Size(300, 24);
            this.chkEmailNotifications.TabIndex = 0;
            this.chkEmailNotifications.Text = "Activar notificaciones por email";
            // 
            // chkSoundAlerts
            // 
            this.chkSoundAlerts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkSoundAlerts.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.chkSoundAlerts.Location = new System.Drawing.Point(25, 65);
            this.chkSoundAlerts.Name = "chkSoundAlerts";
            this.chkSoundAlerts.Size = new System.Drawing.Size(300, 24);
            this.chkSoundAlerts.TabIndex = 1;
            this.chkSoundAlerts.Text = "Activar alertas sonoras";
            // 
            // chkAutoBackup
            // 
            this.chkAutoBackup.Checked = true;
            this.chkAutoBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoBackup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkAutoBackup.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.chkAutoBackup.Location = new System.Drawing.Point(25, 95);
            this.chkAutoBackup.Name = "chkAutoBackup";
            this.chkAutoBackup.Size = new System.Drawing.Size(350, 24);
            this.chkAutoBackup.TabIndex = 2;
            this.chkAutoBackup.Text = "Backup automatico al cerrar sesion";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(21, 128, 61);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(810, 580);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnCancel.Location = new System.Drawing.Point(645, 580);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 42);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // FormSettings
            // 
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(980, 650);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.grpAppearance);
            this.Controls.Add(this.grpNotifications);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuracion";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpAppearance.ResumeLayout(false);
            this.grpAppearance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.grpNotifications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.Label lblCompanyPhone;
        private System.Windows.Forms.TextBox txtCompanyPhone;
        private System.Windows.Forms.Label lblCompanyCuit;
        private System.Windows.Forms.TextBox txtCompanyCuit;
        private System.Windows.Forms.GroupBox grpAppearance;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.GroupBox grpNotifications;
        private System.Windows.Forms.CheckBox chkEmailNotifications;
        private System.Windows.Forms.CheckBox chkSoundAlerts;
        private System.Windows.Forms.CheckBox chkAutoBackup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}


