namespace UI
{
    partial class FormEmployeeDetails
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
            this.bigLabelFullname = new ReaLTaiizor.Controls.BigLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LabelDNI = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelArea = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelDateAdmission = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LabelAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnEditEmployee = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblRolTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRol = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.lblUsernameTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bigLabelFullname
            // 
            this.bigLabelFullname.AutoSize = true;
            this.bigLabelFullname.BackColor = System.Drawing.Color.Transparent;
            this.bigLabelFullname.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabelFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabelFullname.Location = new System.Drawing.Point(289, 9);
            this.bigLabelFullname.Name = "bigLabelFullname";
            this.bigLabelFullname.Size = new System.Drawing.Size(181, 50);
            this.bigLabelFullname.TabIndex = 0;
            this.bigLabelFullname.Text = "bigLabel1";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::UI.Properties.Resources.user_photo_profile;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(8, 20);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(300, 300);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // LabelDNI
            // 
            this.LabelDNI.BackColor = System.Drawing.Color.Transparent;
            this.LabelDNI.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDNI.Location = new System.Drawing.Point(332, 86);
            this.LabelDNI.Name = "LabelDNI";
            this.LabelDNI.Size = new System.Drawing.Size(41, 24);
            this.LabelDNI.TabIndex = 2;
            this.LabelDNI.Text = "DNI:";
            // 
            // LabelArea
            // 
            this.LabelArea.BackColor = System.Drawing.Color.Transparent;
            this.LabelArea.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelArea.Location = new System.Drawing.Point(332, 146);
            this.LabelArea.Name = "LabelArea";
            this.LabelArea.Size = new System.Drawing.Size(54, 24);
            this.LabelArea.TabIndex = 3;
            this.LabelArea.Text = "Area:";
            // 
            // LabelEmail
            // 
            this.LabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.Location = new System.Drawing.Point(332, 176);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(54, 24);
            this.LabelEmail.TabIndex = 4;
            this.LabelEmail.Text = "Email:";
            // 
            // LabelPhone
            // 
            this.LabelPhone.BackColor = System.Drawing.Color.Transparent;
            this.LabelPhone.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPhone.Location = new System.Drawing.Point(332, 206);
            this.LabelPhone.Name = "LabelPhone";
            this.LabelPhone.Size = new System.Drawing.Size(85, 24);
            this.LabelPhone.TabIndex = 5;
            this.LabelPhone.Text = "Telefono:";
            // 
            // LabelDateAdmission
            // 
            this.LabelDateAdmission.BackColor = System.Drawing.Color.Transparent;
            this.LabelDateAdmission.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDateAdmission.Location = new System.Drawing.Point(332, 236);
            this.LabelDateAdmission.Name = "LabelDateAdmission";
            this.LabelDateAdmission.Size = new System.Drawing.Size(138, 24);
            this.LabelDateAdmission.TabIndex = 6;
            this.LabelDateAdmission.Text = "Fecha Ingreso:";
            // 
            // LabelStatus
            // 
            this.LabelStatus.BackColor = System.Drawing.Color.Transparent;
            this.LabelStatus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(332, 266);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(70, 24);
            this.LabelStatus.TabIndex = 7;
            this.LabelStatus.Text = "Estado:";
            this.LabelStatus.Visible = false;
            // 
            // LabelAddress
            // 
            this.LabelAddress.BackColor = System.Drawing.Color.Transparent;
            this.LabelAddress.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddress.Location = new System.Drawing.Point(332, 116);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(87, 24);
            this.LabelAddress.TabIndex = 8;
            this.LabelAddress.Text = "Domicilio:";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCreateUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.Location = new System.Drawing.Point(8, 332);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(300, 23);
            this.btnCreateUser.TabIndex = 9;
            this.btnCreateUser.Tag = "CreateUser";
            this.btnCreateUser.Text = "Crear cuenta para este empleado";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEmployee.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDeleteEmployee.Image = global::UI.Properties.Resources.delete_icon_circle;
            this.btnDeleteEmployee.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDeleteEmployee.ImageRotate = 0F;
            this.btnDeleteEmployee.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDeleteEmployee.Location = new System.Drawing.Point(797, 74);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDeleteEmployee.Size = new System.Drawing.Size(48, 48);
            this.btnDeleteEmployee.TabIndex = 11;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEditEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditEmployee.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEditEmployee.Image = global::UI.Properties.Resources.edit_icon_circle;
            this.btnEditEmployee.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEditEmployee.ImageRotate = 0F;
            this.btnEditEmployee.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEditEmployee.Location = new System.Drawing.Point(797, 20);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.PressedState.Image = global::UI.Properties.Resources.edit_icon_circle;
            this.btnEditEmployee.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEditEmployee.Size = new System.Drawing.Size(48, 48);
            this.btnEditEmployee.TabIndex = 12;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // lblRolTitle
            // 
            this.lblRolTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRolTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolTitle.Location = new System.Drawing.Point(332, 296);
            this.lblRolTitle.Name = "lblRolTitle";
            this.lblRolTitle.Size = new System.Drawing.Size(35, 24);
            this.lblRolTitle.TabIndex = 13;
            this.lblRolTitle.Text = "Rol:";
            this.lblRolTitle.Visible = false;
            // 
            // lblRol
            // 
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(373, 296);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(3, 2);
            this.lblRol.TabIndex = 14;
            this.lblRol.Visible = false;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnResetPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.Location = new System.Drawing.Point(8, 361);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(300, 23);
            this.btnResetPassword.TabIndex = 15;
            this.btnResetPassword.Tag = "CreateUser";
            this.btnResetPassword.Text = "Reestablecer Contraseña";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Visible = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // lblUsernameTitle
            // 
            this.lblUsernameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameTitle.Location = new System.Drawing.Point(332, 326);
            this.lblUsernameTitle.Name = "lblUsernameTitle";
            this.lblUsernameTitle.Size = new System.Drawing.Size(73, 24);
            this.lblUsernameTitle.TabIndex = 16;
            this.lblUsernameTitle.Text = "Usuario:";
            this.lblUsernameTitle.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(411, 326);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(3, 2);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Visible = false;
            // 
            // FormEmployeeDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(857, 392);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUsernameTitle);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblRolTitle);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.LabelAddress);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.LabelDateAdmission);
            this.Controls.Add(this.LabelPhone);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelArea);
            this.Controls.Add(this.bigLabelFullname);
            this.Controls.Add(this.LabelDNI);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEmployeeDetails_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabelFullname;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelDNI;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelArea;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelDateAdmission;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelAddress;
        private System.Windows.Forms.Button btnCreateUser;
        private Guna.UI2.WinForms.Guna2ImageButton btnDeleteEmployee;
        private Guna.UI2.WinForms.Guna2ImageButton btnEditEmployee;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRolTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRol;
        private System.Windows.Forms.Button btnResetPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsernameTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
    }
}