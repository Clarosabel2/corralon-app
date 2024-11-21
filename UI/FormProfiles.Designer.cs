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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarPerfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.assignProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cBProfiles = new System.Windows.Forms.ComboBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfigureProfile = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patentesToolStripMenuItem
            // 
            this.patentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarPerfilesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.assignProfileToolStripMenuItem});
            this.patentesToolStripMenuItem.Name = "patentesToolStripMenuItem";
            this.patentesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.patentesToolStripMenuItem.Text = "Perfiles";
            // 
            // gestionarPerfilesToolStripMenuItem
            // 
            this.gestionarPerfilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewProfileToolStripMenuItem,
            this.modifyToolStripMenuItem});
            this.gestionarPerfilesToolStripMenuItem.Name = "gestionarPerfilesToolStripMenuItem";
            this.gestionarPerfilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarPerfilesToolStripMenuItem.Text = "Manage Profiles";
            // 
            // createNewProfileToolStripMenuItem
            // 
            this.createNewProfileToolStripMenuItem.Name = "createNewProfileToolStripMenuItem";
            this.createNewProfileToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.createNewProfileToolStripMenuItem.Text = "Create New Profile";
            this.createNewProfileToolStripMenuItem.Click += new System.EventHandler(this.createNewProfileToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modifyToolStripMenuItem.Text = "Modify Profile";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // assignProfileToolStripMenuItem
            // 
            this.assignProfileToolStripMenuItem.Name = "assignProfileToolStripMenuItem";
            this.assignProfileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.assignProfileToolStripMenuItem.Text = "Assign Profile";
            this.assignProfileToolStripMenuItem.Click += new System.EventHandler(this.assignProfileToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Perfiles";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(12, 83);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(245, 490);
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
            this.dgvUsers.Size = new System.Drawing.Size(495, 490);
            this.dgvUsers.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuarios";
            // 
            // btnConfigureProfile
            // 
            this.btnConfigureProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfigureProfile.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigureProfile.Location = new System.Drawing.Point(12, 579);
            this.btnConfigureProfile.Name = "btnConfigureProfile";
            this.btnConfigureProfile.Size = new System.Drawing.Size(245, 33);
            this.btnConfigureProfile.TabIndex = 7;
            this.btnConfigureProfile.Text = "Configurar";
            this.btnConfigureProfile.UseVisualStyleBackColor = true;
            this.btnConfigureProfile.Click += new System.EventHandler(this.btnConfigureProfile_Click);
            // 
            // FormProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 624);
            this.Controls.Add(this.btnConfigureProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.cBProfiles);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProfiles";
            this.Text = "FormProfiles";
            this.Load += new System.EventHandler(this.FormProfiles_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patentesToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem gestionarPerfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem assignProfileToolStripMenuItem;
        private System.Windows.Forms.ComboBox cBProfiles;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfigureProfile;
    }
}