namespace UI
{
    partial class FormCreateEmployee
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
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBAreas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Enabled = false;
            this.btnSaveEmployee.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSaveEmployee.Location = new System.Drawing.Point(16, 218);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(310, 37);
            this.btnSaveEmployee.TabIndex = 28;
            this.btnSaveEmployee.Text = "Guardar";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtTelefono.Location = new System.Drawing.Point(100, 188);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(226, 24);
            this.txtTelefono.TabIndex = 27;
            this.txtTelefono.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTelefono.Location = new System.Drawing.Point(12, 191);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 19);
            this.lblTelefono.TabIndex = 26;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtEmail.Location = new System.Drawing.Point(100, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 24);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEmail.Location = new System.Drawing.Point(12, 161);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 19);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Email:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtDomicilio.Location = new System.Drawing.Point(100, 128);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(226, 24);
            this.txtDomicilio.TabIndex = 23;
            this.txtDomicilio.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblDomicilio.Location = new System.Drawing.Point(12, 131);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(75, 19);
            this.lblDomicilio.TabIndex = 22;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtApellido.Location = new System.Drawing.Point(100, 98);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(226, 24);
            this.txtApellido.TabIndex = 21;
            this.txtApellido.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblApellido.Location = new System.Drawing.Point(12, 101);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 19);
            this.lblApellido.TabIndex = 20;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtNombre.Location = new System.Drawing.Point(100, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 24);
            this.txtNombre.TabIndex = 19;
            this.txtNombre.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombre.Location = new System.Drawing.Point(12, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 19);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtDni.Location = new System.Drawing.Point(100, 6);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(226, 24);
            this.txtDni.TabIndex = 17;
            this.txtDni.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblDni.Location = new System.Drawing.Point(12, 9);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(36, 19);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Area:";
            // 
            // cBAreas
            // 
            this.cBAreas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBAreas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cBAreas.FormattingEnabled = true;
            this.cBAreas.Location = new System.Drawing.Point(100, 36);
            this.cBAreas.Name = "cBAreas";
            this.cBAreas.Size = new System.Drawing.Size(226, 25);
            this.cBAreas.TabIndex = 30;
            // 
            // FormCreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 263);
            this.Controls.Add(this.cBAreas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveEmployee);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormCreateEmployee";
            this.Text = "FormCreateEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBAreas;
    }
}