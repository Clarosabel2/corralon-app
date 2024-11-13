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
            this.familiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patentesToolStripMenuItem,
            this.familiasToolStripMenuItem});
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
            this.toolStripMenuItem2});
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
            this.gestionarPerfilesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
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
            this.toolStripMenuItem2.Size = new System.Drawing.Size(156, 6);
            // 
            // familiasToolStripMenuItem
            // 
            this.familiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPermisosToolStripMenuItem});
            this.familiasToolStripMenuItem.Name = "familiasToolStripMenuItem";
            this.familiasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.familiasToolStripMenuItem.Text = "Permisos";
            // 
            // verPermisosToolStripMenuItem
            // 
            this.verPermisosToolStripMenuItem.Name = "verPermisosToolStripMenuItem";
            this.verPermisosToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.verPermisosToolStripMenuItem.Text = "Ver Permisos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuarios";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(28, 81);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(245, 357);
            this.treeView1.TabIndex = 3;
            // 
            // FormProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 624);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProfiles";
            this.Text = "FormProfiles";
            this.Load += new System.EventHandler(this.FormProfiles_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familiasToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem verPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarPerfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.TreeView treeView1;
    }
}