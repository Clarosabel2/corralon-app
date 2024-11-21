namespace UI
{
    partial class FormAssignProfile
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.comboBoxRols = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(428, 330);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAssign);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.comboBoxRols);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignar Perfil";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(12, 79);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(325, 23);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.Text = "Asignar";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(64, 42);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(146, 20);
            this.txtUser.TabIndex = 2;
            // 
            // comboBoxRols
            // 
            this.comboBoxRols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRols.FormattingEnabled = true;
            this.comboBoxRols.Location = new System.Drawing.Point(216, 42);
            this.comboBoxRols.Name = "comboBoxRols";
            this.comboBoxRols.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRols.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // FormAssignProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUsers);
            this.Name = "FormAssignProfile";
            this.Text = "FormAssignProfile";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox comboBoxRols;
        private System.Windows.Forms.Label label1;
    }
}