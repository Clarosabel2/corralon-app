namespace UI
{
    partial class FormManageProfile
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
            this.lblProfile = new System.Windows.Forms.Label();
            this.treeViewProfile = new System.Windows.Forms.TreeView();
            this.lblPermissions = new System.Windows.Forms.Label();
            this.treeViewPermissions = new System.Windows.Forms.TreeView();
            this.groupBoxTreeViews = new System.Windows.Forms.GroupBox();
            this.ButtonSaveFamily = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDescriptionFamily = new System.Windows.Forms.Label();
            this.txtDescripcionFamily = new System.Windows.Forms.TextBox();
            this.ButtonCreateFamily = new System.Windows.Forms.Button();
            this.txtNameFamily = new System.Windows.Forms.TextBox();
            this.lblNameFamily = new System.Windows.Forms.Label();
            this.cBTypePermission = new System.Windows.Forms.ComboBox();
            this.groupBoxTreeViews.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProfile
            // 
            this.lblProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(248, 17);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(51, 22);
            this.lblProfile.TabIndex = 8;
            this.lblProfile.Text = "Perfil";
            // 
            // treeViewProfile
            // 
            this.treeViewProfile.AllowDrop = true;
            this.treeViewProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewProfile.Location = new System.Drawing.Point(252, 42);
            this.treeViewProfile.Name = "treeViewProfile";
            this.treeViewProfile.Size = new System.Drawing.Size(226, 412);
            this.treeViewProfile.TabIndex = 7;
            this.treeViewProfile.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewPermissions_ItemDrag);
            this.treeViewProfile.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView_NodeMouseHover);
            this.treeViewProfile.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewProfile_NodeMouseDoubleClick);
            this.treeViewProfile.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewProfile_DragDrop);
            this.treeViewProfile.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeviewProfile_DragEnter);
            this.treeViewProfile.MouseLeave += new System.EventHandler(this.treeView_MouseLeave);
            // 
            // lblPermissions
            // 
            this.lblPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPermissions.AutoSize = true;
            this.lblPermissions.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermissions.Location = new System.Drawing.Point(6, 17);
            this.lblPermissions.Name = "lblPermissions";
            this.lblPermissions.Size = new System.Drawing.Size(85, 22);
            this.lblPermissions.TabIndex = 6;
            this.lblPermissions.Text = "Permisos";
            // 
            // treeViewPermissions
            // 
            this.treeViewPermissions.AllowDrop = true;
            this.treeViewPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewPermissions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewPermissions.Location = new System.Drawing.Point(10, 42);
            this.treeViewPermissions.Name = "treeViewPermissions";
            this.treeViewPermissions.Size = new System.Drawing.Size(226, 412);
            this.treeViewPermissions.TabIndex = 5;
            this.treeViewPermissions.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewPermissions_ItemDrag);
            this.treeViewPermissions.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView_NodeMouseHover);
            this.treeViewPermissions.MouseLeave += new System.EventHandler(this.treeView_MouseLeave);
            // 
            // groupBoxTreeViews
            // 
            this.groupBoxTreeViews.Controls.Add(this.cBTypePermission);
            this.groupBoxTreeViews.Controls.Add(this.ButtonSaveFamily);
            this.groupBoxTreeViews.Controls.Add(this.lblPermissions);
            this.groupBoxTreeViews.Controls.Add(this.treeViewProfile);
            this.groupBoxTreeViews.Controls.Add(this.lblProfile);
            this.groupBoxTreeViews.Controls.Add(this.treeViewPermissions);
            this.groupBoxTreeViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTreeViews.Enabled = false;
            this.groupBoxTreeViews.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTreeViews.Location = new System.Drawing.Point(0, 105);
            this.groupBoxTreeViews.Name = "groupBoxTreeViews";
            this.groupBoxTreeViews.Size = new System.Drawing.Size(490, 495);
            this.groupBoxTreeViews.TabIndex = 9;
            this.groupBoxTreeViews.TabStop = false;
            // 
            // ButtonSaveFamily
            // 
            this.ButtonSaveFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSaveFamily.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ButtonSaveFamily.Location = new System.Drawing.Point(11, 459);
            this.ButtonSaveFamily.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSaveFamily.Name = "ButtonSaveFamily";
            this.ButtonSaveFamily.Size = new System.Drawing.Size(467, 31);
            this.ButtonSaveFamily.TabIndex = 6;
            this.ButtonSaveFamily.Text = "Guardar";
            this.ButtonSaveFamily.UseVisualStyleBackColor = true;
            this.ButtonSaveFamily.Click += new System.EventHandler(this.ButtonSaveFamily_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDescriptionFamily);
            this.groupBox3.Controls.Add(this.txtDescripcionFamily);
            this.groupBox3.Controls.Add(this.ButtonCreateFamily);
            this.groupBox3.Controls.Add(this.txtNameFamily);
            this.groupBox3.Controls.Add(this.lblNameFamily);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(490, 105);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // lblDescriptionFamily
            // 
            this.lblDescriptionFamily.AutoSize = true;
            this.lblDescriptionFamily.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblDescriptionFamily.Location = new System.Drawing.Point(4, 58);
            this.lblDescriptionFamily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescriptionFamily.Name = "lblDescriptionFamily";
            this.lblDescriptionFamily.Size = new System.Drawing.Size(90, 20);
            this.lblDescriptionFamily.TabIndex = 7;
            this.lblDescriptionFamily.Text = "Desripción:";
            // 
            // txtDescripcionFamily
            // 
            this.txtDescripcionFamily.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionFamily.Location = new System.Drawing.Point(119, 55);
            this.txtDescripcionFamily.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionFamily.Name = "txtDescripcionFamily";
            this.txtDescripcionFamily.Size = new System.Drawing.Size(248, 26);
            this.txtDescripcionFamily.TabIndex = 6;
            // 
            // ButtonCreateFamily
            // 
            this.ButtonCreateFamily.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ButtonCreateFamily.Location = new System.Drawing.Point(378, 18);
            this.ButtonCreateFamily.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCreateFamily.Name = "ButtonCreateFamily";
            this.ButtonCreateFamily.Size = new System.Drawing.Size(108, 63);
            this.ButtonCreateFamily.TabIndex = 4;
            this.ButtonCreateFamily.Text = "Crear";
            this.ButtonCreateFamily.UseVisualStyleBackColor = true;
            this.ButtonCreateFamily.Click += new System.EventHandler(this.ButtonAddFamily_Click);
            // 
            // txtNameFamily
            // 
            this.txtNameFamily.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFamily.Location = new System.Drawing.Point(119, 18);
            this.txtNameFamily.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameFamily.Name = "txtNameFamily";
            this.txtNameFamily.Size = new System.Drawing.Size(248, 26);
            this.txtNameFamily.TabIndex = 3;
            // 
            // lblNameFamily
            // 
            this.lblNameFamily.AutoSize = true;
            this.lblNameFamily.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblNameFamily.Location = new System.Drawing.Point(4, 21);
            this.lblNameFamily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameFamily.Name = "lblNameFamily";
            this.lblNameFamily.Size = new System.Drawing.Size(72, 20);
            this.lblNameFamily.TabIndex = 2;
            this.lblNameFamily.Text = "Nombre:";
            // 
            // cBTypePermission
            // 
            this.cBTypePermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTypePermission.FormattingEnabled = true;
            this.cBTypePermission.Items.AddRange(new object[] {
            "Sistema",
            "Creadas"});
            this.cBTypePermission.Location = new System.Drawing.Point(97, 15);
            this.cBTypePermission.Name = "cBTypePermission";
            this.cBTypePermission.Size = new System.Drawing.Size(139, 24);
            this.cBTypePermission.TabIndex = 9;
            this.cBTypePermission.SelectedIndexChanged += new System.EventHandler(this.cBTypePermission_SelectedIndexChanged);
            // 
            // FormManageProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 600);
            this.Controls.Add(this.groupBoxTreeViews);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormManageProfile";
            this.Text = "FormManageProfile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormManageProfile_FormClosing);
            this.groupBoxTreeViews.ResumeLayout(false);
            this.groupBoxTreeViews.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.TreeView treeViewProfile;
        private System.Windows.Forms.Label lblPermissions;
        private System.Windows.Forms.TreeView treeViewPermissions;
        private System.Windows.Forms.GroupBox groupBoxTreeViews;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ButtonCreateFamily;
        private System.Windows.Forms.TextBox txtNameFamily;
        private System.Windows.Forms.Label lblNameFamily;
        private System.Windows.Forms.Button ButtonSaveFamily;
        private System.Windows.Forms.Label lblDescriptionFamily;
        private System.Windows.Forms.TextBox txtDescripcionFamily;
        private System.Windows.Forms.ComboBox cBTypePermission;
    }
}