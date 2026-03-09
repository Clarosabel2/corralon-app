namespace UI
{
    partial class FormRegisterVehicle
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.grpTruckDetails = new System.Windows.Forms.GroupBox();
            this.lblAxles = new System.Windows.Forms.Label();
            this.numAxles = new System.Windows.Forms.NumericUpDown();
            this.lblLoadCapacity = new System.Windows.Forms.Label();
            this.numLoadCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.grpTruckDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAxles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(21, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Registrar Camión";
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(26, 64);
            this.lblLicensePlate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(54, 16);
            this.lblLicensePlate.TabIndex = 1;
            this.lblLicensePlate.Text = "Patente:";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(105, 62);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(176, 21);
            this.txtLicensePlate.TabIndex = 2;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(26, 100);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(47, 16);
            this.lblBrand.TabIndex = 3;
            this.lblBrand.Text = "Marca:";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(105, 97);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(176, 21);
            this.txtBrand.TabIndex = 4;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(26, 135);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 16);
            this.lblModel.TabIndex = 5;
            this.lblModel.Text = "Modelo:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(105, 134);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(176, 21);
            this.txtModel.TabIndex = 6;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(26, 172);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(31, 16);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Año:";
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(105, 170);
            this.numYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(88, 21);
            this.numYear.TabIndex = 8;
            this.numYear.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // grpTruckDetails
            // 
            this.grpTruckDetails.Controls.Add(this.lblAxles);
            this.grpTruckDetails.Controls.Add(this.numAxles);
            this.grpTruckDetails.Controls.Add(this.lblLoadCapacity);
            this.grpTruckDetails.Controls.Add(this.numLoadCapacity);
            this.grpTruckDetails.Location = new System.Drawing.Point(306, 57);
            this.grpTruckDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTruckDetails.Name = "grpTruckDetails";
            this.grpTruckDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTruckDetails.Size = new System.Drawing.Size(262, 135);
            this.grpTruckDetails.TabIndex = 9;
            this.grpTruckDetails.TabStop = false;
            this.grpTruckDetails.Text = "Especificaciones Camión";
            // 
            // lblAxles
            // 
            this.lblAxles.AutoSize = true;
            this.lblAxles.Location = new System.Drawing.Point(18, 32);
            this.lblAxles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAxles.Name = "lblAxles";
            this.lblAxles.Size = new System.Drawing.Size(81, 16);
            this.lblAxles.TabIndex = 0;
            this.lblAxles.Text = "Cant. de Ejes:";
            // 
            // numAxles
            // 
            this.numAxles.Location = new System.Drawing.Point(122, 31);
            this.numAxles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numAxles.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAxles.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numAxles.Name = "numAxles";
            this.numAxles.Size = new System.Drawing.Size(70, 21);
            this.numAxles.TabIndex = 1;
            this.numAxles.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblLoadCapacity
            // 
            this.lblLoadCapacity.AutoSize = true;
            this.lblLoadCapacity.Location = new System.Drawing.Point(18, 71);
            this.lblLoadCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoadCapacity.Name = "lblLoadCapacity";
            this.lblLoadCapacity.Size = new System.Drawing.Size(96, 16);
            this.lblLoadCapacity.TabIndex = 2;
            this.lblLoadCapacity.Text = "Carga Máx (kg):";
            // 
            // numLoadCapacity
            // 
            this.numLoadCapacity.Location = new System.Drawing.Point(122, 70);
            this.numLoadCapacity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numLoadCapacity.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numLoadCapacity.Name = "numLoadCapacity";
            this.numLoadCapacity.Size = new System.Drawing.Size(105, 21);
            this.numLoadCapacity.TabIndex = 3;
            this.numLoadCapacity.ThousandsSeparator = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(455, 240);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 32);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(332, 240);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormRegisterVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 298);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpTruckDetails);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.lblLicensePlate);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormRegisterVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Vehículos";
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.grpTruckDetails.ResumeLayout(false);
            this.grpTruckDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAxles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoadCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.GroupBox grpTruckDetails;
        private System.Windows.Forms.Label lblAxles;
        private System.Windows.Forms.NumericUpDown numAxles;
        private System.Windows.Forms.Label lblLoadCapacity;
        private System.Windows.Forms.NumericUpDown numLoadCapacity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}