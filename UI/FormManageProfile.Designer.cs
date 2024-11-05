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
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewProfile = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.treeViewPermissions = new System.Windows.Forms.TreeView();
            this.groupBoxTreeViews = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonCreateFamily = new System.Windows.Forms.Button();
            this.txtNameFamily = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonSaveFamily = new System.Windows.Forms.Button();
            this.txtDescripcionFamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTreeViews.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Perfil";
            // 
            // treeViewProfile
            // 
            this.treeViewProfile.AllowDrop = true;
            this.treeViewProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewProfile.Location = new System.Drawing.Point(252, 42);
            this.treeViewProfile.Name = "treeViewProfile";
            this.treeViewProfile.Size = new System.Drawing.Size(226, 477);
            this.treeViewProfile.TabIndex = 7;
            this.treeViewProfile.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewPermissions_ItemDrag);
            this.treeViewProfile.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView_NodeMouseHover);
            this.treeViewProfile.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewProfile_NodeMouseDoubleClick);
            this.treeViewProfile.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewProfile_DragDrop);
            this.treeViewProfile.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeviewProfile_DragEnter);
            this.treeViewProfile.MouseLeave += new System.EventHandler(this.treeView_MouseLeave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Permisos";
            // 
            // treeViewPermissions
            // 
            this.treeViewPermissions.AllowDrop = true;
            this.treeViewPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewPermissions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewPermissions.Location = new System.Drawing.Point(10, 42);
            this.treeViewPermissions.Name = "treeViewPermissions";
            this.treeViewPermissions.Size = new System.Drawing.Size(226, 477);
            this.treeViewPermissions.TabIndex = 5;
            this.treeViewPermissions.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewPermissions_ItemDrag);
            this.treeViewPermissions.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView_NodeMouseHover);
            this.treeViewPermissions.MouseLeave += new System.EventHandler(this.treeView_MouseLeave);
            // 
            // groupBoxTreeViews
            // 
            this.groupBoxTreeViews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxTreeViews.Controls.Add(this.ButtonSaveFamily);
            this.groupBoxTreeViews.Controls.Add(this.label3);
            this.groupBoxTreeViews.Controls.Add(this.treeViewProfile);
            this.groupBoxTreeViews.Controls.Add(this.label1);
            this.groupBoxTreeViews.Controls.Add(this.treeViewPermissions);
            this.groupBoxTreeViews.Enabled = false;
            this.groupBoxTreeViews.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTreeViews.Location = new System.Drawing.Point(0, 111);
            this.groupBoxTreeViews.Name = "groupBoxTreeViews";
            this.groupBoxTreeViews.Size = new System.Drawing.Size(490, 560);
            this.groupBoxTreeViews.TabIndex = 9;
            this.groupBoxTreeViews.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtDescripcionFamily);
            this.groupBox3.Controls.Add(this.ButtonCreateFamily);
            this.groupBox3.Controls.Add(this.txtNameFamily);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBox3.Location = new System.Drawing.Point(66, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(424, 118);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crear Familia";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ButtonBack.Location = new System.Drawing.Point(11, 21);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(52, 70);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "<--";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonCreateFamily
            // 
            this.ButtonCreateFamily.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ButtonCreateFamily.Location = new System.Drawing.Point(297, 28);
            this.ButtonCreateFamily.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCreateFamily.Name = "ButtonCreateFamily";
            this.ButtonCreateFamily.Size = new System.Drawing.Size(110, 56);
            this.ButtonCreateFamily.TabIndex = 4;
            this.ButtonCreateFamily.Text = "Crear";
            this.ButtonCreateFamily.UseVisualStyleBackColor = true;
            this.ButtonCreateFamily.Click += new System.EventHandler(this.ButtonAddFamily_Click);
            // 
            // txtNameFamily
            // 
            this.txtNameFamily.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFamily.Location = new System.Drawing.Point(119, 28);
            this.txtNameFamily.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameFamily.Name = "txtNameFamily";
            this.txtNameFamily.Size = new System.Drawing.Size(174, 26);
            this.txtNameFamily.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label5.Location = new System.Drawing.Point(25, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre:";
            // 
            // ButtonSaveFamily
            // 
            this.ButtonSaveFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSaveFamily.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.ButtonSaveFamily.Location = new System.Drawing.Point(11, 524);
            this.ButtonSaveFamily.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSaveFamily.Name = "ButtonSaveFamily";
            this.ButtonSaveFamily.Size = new System.Drawing.Size(467, 31);
            this.ButtonSaveFamily.TabIndex = 6;
            this.ButtonSaveFamily.Text = "Guardar";
            this.ButtonSaveFamily.UseVisualStyleBackColor = true;
            this.ButtonSaveFamily.Click += new System.EventHandler(this.ButtonSaveFamily_Click);
            // 
            // txtDescripcionFamily
            // 
            this.txtDescripcionFamily.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionFamily.Location = new System.Drawing.Point(119, 58);
            this.txtDescripcionFamily.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionFamily.Name = "txtDescripcionFamily";
            this.txtDescripcionFamily.Size = new System.Drawing.Size(174, 26);
            this.txtDescripcionFamily.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Desripción:";
            // 
            // FormManageProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 672);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxTreeViews);
            this.Controls.Add(this.ButtonBack);
            this.Name = "FormManageProfile";
            this.Text = "FormManageProfile";
            this.groupBoxTreeViews.ResumeLayout(false);
            this.groupBoxTreeViews.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeViewPermissions;
        private System.Windows.Forms.GroupBox groupBoxTreeViews;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ButtonCreateFamily;
        private System.Windows.Forms.TextBox txtNameFamily;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonSaveFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionFamily;
    }
}