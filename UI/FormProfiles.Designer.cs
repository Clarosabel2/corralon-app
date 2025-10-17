namespace UI
{
    partial class FormProfiles
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
            this.lblProfiles = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cBProfiles = new System.Windows.Forms.ComboBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblUsers = new System.Windows.Forms.Label();
            this.btnConfigureProfile = new System.Windows.Forms.Button();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.btnDeleteFamily = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfiles
            // 
            this.lblProfiles.AutoSize = true;
            this.lblProfiles.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfiles.Location = new System.Drawing.Point(12, 50);
            this.lblProfiles.Name = "lblProfiles";
            this.lblProfiles.Size = new System.Drawing.Size(70, 22);
            this.lblProfiles.TabIndex = 2;
            this.lblProfiles.Text = "Perfiles";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(12, 83);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(245, 824);
            this.treeView1.TabIndex = 3;
            // 
            // cBProfiles
            // 
            this.cBProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBProfiles.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBProfiles.FormattingEnabled = true;
            this.cBProfiles.Location = new System.Drawing.Point(84, 49);
            this.cBProfiles.Name = "cBProfiles";
            this.cBProfiles.Size = new System.Drawing.Size(173, 28);
            this.cBProfiles.TabIndex = 4;
            this.cBProfiles.SelectedIndexChanged += new System.EventHandler(this.cBProfiles_SelectedIndexChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.GridColor = System.Drawing.SystemColors.Menu;
            this.dgvUsers.Location = new System.Drawing.Point(267, 83);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1428, 824);
            this.dgvUsers.TabIndex = 5;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(263, 55);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(82, 22);
            this.lblUsers.TabIndex = 6;
            this.lblUsers.Text = "Usuarios";
            // 
            // btnConfigureProfile
            // 
            this.btnConfigureProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfigureProfile.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigureProfile.Location = new System.Drawing.Point(12, 913);
            this.btnConfigureProfile.Name = "btnConfigureProfile";
            this.btnConfigureProfile.Size = new System.Drawing.Size(126, 33);
            this.btnConfigureProfile.TabIndex = 7;
            this.btnConfigureProfile.Text = "Configurar";
            this.btnConfigureProfile.UseVisualStyleBackColor = true;
            this.btnConfigureProfile.Click += new System.EventHandler(this.btnConfigureProfile_Click);
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProfile.Location = new System.Drawing.Point(12, 12);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(245, 31);
            this.btnCreateProfile.TabIndex = 8;
            this.btnCreateProfile.Text = "Crear Perfil";
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // btnDeleteFamily
            // 
            this.btnDeleteFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteFamily.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFamily.Location = new System.Drawing.Point(144, 913);
            this.btnDeleteFamily.Name = "btnDeleteFamily";
            this.btnDeleteFamily.Size = new System.Drawing.Size(113, 33);
            this.btnDeleteFamily.TabIndex = 9;
            this.btnDeleteFamily.Text = "Eliminar";
            this.btnDeleteFamily.UseVisualStyleBackColor = true;
            this.btnDeleteFamily.Click += new System.EventHandler(this.btnDeleteFamily_Click);
            // 
            // FormProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1723, 958);
            this.Controls.Add(this.btnDeleteFamily);
            this.Controls.Add(this.btnCreateProfile);
            this.Controls.Add(this.btnConfigureProfile);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.cBProfiles);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lblProfiles);
            this.Name = "FormProfiles";
            this.Text = "FormProfiles";
            this.Load += new System.EventHandler(this.FormProfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProfiles;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ComboBox cBProfiles;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Button btnConfigureProfile;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.Button btnDeleteFamily;
    }
}