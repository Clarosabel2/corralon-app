namespace UI
{
    partial class FormUserProfile
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
            this.panelEditProfile = new System.Windows.Forms.Panel();
            this.checkBoxChangeData = new System.Windows.Forms.CheckBox();
            this.checkBoxChangePassword = new System.Windows.Forms.CheckBox();
            this.btnSaveMyData = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSurname2 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblEditMyData = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPosition2 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lnkEditProfile = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cBLanguages = new System.Windows.Forms.ComboBox();
            this.btnChangeLanguage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEditProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEditProfile
            // 
            this.panelEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelEditProfile.Controls.Add(this.checkBoxChangeData);
            this.panelEditProfile.Controls.Add(this.checkBoxChangePassword);
            this.panelEditProfile.Controls.Add(this.btnSaveMyData);
            this.panelEditProfile.Controls.Add(this.btnCancel);
            this.panelEditProfile.Controls.Add(this.txtCurrentPassword);
            this.panelEditProfile.Controls.Add(this.txtConfirmPassword);
            this.panelEditProfile.Controls.Add(this.txtPassword);
            this.panelEditProfile.Controls.Add(this.txtEmail);
            this.panelEditProfile.Controls.Add(this.txtLastName);
            this.panelEditProfile.Controls.Add(this.txtFirstName);
            this.panelEditProfile.Controls.Add(this.lblCurrentPassword);
            this.panelEditProfile.Controls.Add(this.lblConfirmPassword);
            this.panelEditProfile.Controls.Add(this.lblPassword);
            this.panelEditProfile.Controls.Add(this.label5);
            this.panelEditProfile.Controls.Add(this.lblSurname2);
            this.panelEditProfile.Controls.Add(this.lblName2);
            this.panelEditProfile.Controls.Add(this.lblEditMyData);
            this.panelEditProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEditProfile.Location = new System.Drawing.Point(400, 0);
            this.panelEditProfile.Name = "panelEditProfile";
            this.panelEditProfile.Size = new System.Drawing.Size(329, 564);
            this.panelEditProfile.TabIndex = 0;
            this.panelEditProfile.Visible = false;
            // 
            // checkBoxChangeData
            // 
            this.checkBoxChangeData.AutoSize = true;
            this.checkBoxChangeData.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChangeData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxChangeData.Location = new System.Drawing.Point(143, 71);
            this.checkBoxChangeData.Name = "checkBoxChangeData";
            this.checkBoxChangeData.Size = new System.Drawing.Size(111, 20);
            this.checkBoxChangeData.TabIndex = 19;
            this.checkBoxChangeData.Text = "Modificar Datos";
            this.checkBoxChangeData.UseVisualStyleBackColor = true;
            this.checkBoxChangeData.CheckedChanged += new System.EventHandler(this.checkBoxEditData_CheckedChanged);
            // 
            // checkBoxChangePassword
            // 
            this.checkBoxChangePassword.AutoSize = true;
            this.checkBoxChangePassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChangePassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxChangePassword.Location = new System.Drawing.Point(143, 256);
            this.checkBoxChangePassword.Name = "checkBoxChangePassword";
            this.checkBoxChangePassword.Size = new System.Drawing.Size(144, 20);
            this.checkBoxChangePassword.TabIndex = 18;
            this.checkBoxChangePassword.Text = "Modificar Contraseña";
            this.checkBoxChangePassword.UseVisualStyleBackColor = true;
            this.checkBoxChangePassword.CheckedChanged += new System.EventHandler(this.checkBoxChangePassword_CheckedChanged);
            // 
            // btnSaveMyData
            // 
            this.btnSaveMyData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(141)))));
            this.btnSaveMyData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveMyData.FlatAppearance.BorderSize = 0;
            this.btnSaveMyData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnSaveMyData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnSaveMyData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMyData.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveMyData.ForeColor = System.Drawing.Color.Silver;
            this.btnSaveMyData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveMyData.Location = new System.Drawing.Point(156, 440);
            this.btnSaveMyData.Name = "btnSaveMyData";
            this.btnSaveMyData.Size = new System.Drawing.Size(131, 41);
            this.btnSaveMyData.TabIndex = 17;
            this.btnSaveMyData.Text = "Guardar";
            this.btnSaveMyData.UseVisualStyleBackColor = false;
            this.btnSaveMyData.Click += new System.EventHandler(this.btnSaveMyData_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(19, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 41);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(19, 386);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(268, 20);
            this.txtCurrentPassword.TabIndex = 14;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(19, 331);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(268, 20);
            this.txtConfirmPassword.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(19, 276);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(268, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(19, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(268, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(19, 138);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(268, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(19, 91);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(268, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPassword.Location = new System.Drawing.Point(15, 363);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(151, 20);
            this.lblCurrentPassword.TabIndex = 7;
            this.lblCurrentPassword.Text = "Contraseña Actual:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(15, 308);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(170, 20);
            this.lblConfirmPassword.TabIndex = 6;
            this.lblConfirmPassword.Text = "Confirme Contraseña:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(15, 253);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 20);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // lblSurname2
            // 
            this.lblSurname2.AutoSize = true;
            this.lblSurname2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname2.ForeColor = System.Drawing.Color.White;
            this.lblSurname2.Location = new System.Drawing.Point(15, 114);
            this.lblSurname2.Name = "lblSurname2";
            this.lblSurname2.Size = new System.Drawing.Size(73, 20);
            this.lblSurname2.TabIndex = 3;
            this.lblSurname2.Text = "Apellido:";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.ForeColor = System.Drawing.Color.White;
            this.lblName2.Location = new System.Drawing.Point(15, 68);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(72, 20);
            this.lblName2.TabIndex = 2;
            this.lblName2.Text = "Nombre:";
            // 
            // lblEditMyData
            // 
            this.lblEditMyData.AutoSize = true;
            this.lblEditMyData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMyData.ForeColor = System.Drawing.Color.White;
            this.lblEditMyData.Location = new System.Drawing.Point(13, 20);
            this.lblEditMyData.Name = "lblEditMyData";
            this.lblEditMyData.Size = new System.Drawing.Size(213, 31);
            this.lblEditMyData.TabIndex = 0;
            this.lblEditMyData.Text = "Editar Mis Datos";
            this.lblEditMyData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblTittle.Location = new System.Drawing.Point(12, 20);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(111, 31);
            this.lblTittle.TabIndex = 1;
            this.lblTittle.Text = "Mi Perfil";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUsername.Location = new System.Drawing.Point(156, 77);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(64, 18);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Usuario:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblName.Location = new System.Drawing.Point(156, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSurname.Location = new System.Drawing.Point(156, 146);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(77, 18);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Lastname:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label14.Location = new System.Drawing.Point(156, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 18);
            this.label14.TabIndex = 5;
            this.label14.Text = "Email:";
            // 
            // lblPosition2
            // 
            this.lblPosition2.AutoSize = true;
            this.lblPosition2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblPosition2.Location = new System.Drawing.Point(156, 214);
            this.lblPosition2.Name = "lblPosition2";
            this.lblPosition2.Size = new System.Drawing.Size(53, 18);
            this.lblPosition2.TabIndex = 6;
            this.lblPosition2.Text = "Cargo:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUser.Location = new System.Drawing.Point(163, 95);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(28, 16);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "user";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFirstName.Location = new System.Drawing.Point(163, 130);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 16);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "firstname";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLastName.Location = new System.Drawing.Point(163, 164);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(57, 16);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "lastname";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmail.Location = new System.Drawing.Point(163, 198);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(29, 16);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "mail";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPosition.Location = new System.Drawing.Point(163, 234);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(48, 16);
            this.lblPosition.TabIndex = 11;
            this.lblPosition.Text = "position";
            // 
            // lnkEditProfile
            // 
            this.lnkEditProfile.AutoSize = true;
            this.lnkEditProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkEditProfile.LinkColor = System.Drawing.Color.SteelBlue;
            this.lnkEditProfile.Location = new System.Drawing.Point(30, 218);
            this.lnkEditProfile.Name = "lnkEditProfile";
            this.lnkEditProfile.Size = new System.Drawing.Size(60, 13);
            this.lnkEditProfile.TabIndex = 12;
            this.lnkEditProfile.TabStop = true;
            this.lnkEditProfile.Text = "Editar Perfil";
            this.lnkEditProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditProfile_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(156, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Idioma:";
            // 
            // cBLanguages
            // 
            this.cBLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBLanguages.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBLanguages.FormattingEnabled = true;
            this.cBLanguages.Location = new System.Drawing.Point(159, 279);
            this.cBLanguages.Name = "cBLanguages";
            this.cBLanguages.Size = new System.Drawing.Size(121, 25);
            this.cBLanguages.TabIndex = 15;
            this.cBLanguages.SelectedIndexChanged += new System.EventHandler(this.cBLanguages_SelectedIndexChanged);
            // 
            // btnChangeLanguage
            // 
            this.btnChangeLanguage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeLanguage.Location = new System.Drawing.Point(286, 279);
            this.btnChangeLanguage.Name = "btnChangeLanguage";
            this.btnChangeLanguage.Size = new System.Drawing.Size(75, 25);
            this.btnChangeLanguage.TabIndex = 16;
            this.btnChangeLanguage.Text = "Guardar";
            this.btnChangeLanguage.UseVisualStyleBackColor = true;
            this.btnChangeLanguage.Click += new System.EventHandler(this.btnChangeLanguage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.user_photo_profile;
            this.pictureBox1.Location = new System.Drawing.Point(33, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FormUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 564);
            this.Controls.Add(this.btnChangeLanguage);
            this.Controls.Add(this.cBLanguages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lnkEditProfile);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPosition2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.panelEditProfile);
            this.Name = "FormUserProfile";
            this.Text = "Mi Perfil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUserProfile_FormClosed);
            this.panelEditProfile.ResumeLayout(false);
            this.panelEditProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEditProfile;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSurname2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblEditMyData;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveMyData;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPosition2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.LinkLabel lnkEditProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxChangePassword;
        private System.Windows.Forms.CheckBox checkBoxChangeData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBLanguages;
        private System.Windows.Forms.Button btnChangeLanguage;
    }
}