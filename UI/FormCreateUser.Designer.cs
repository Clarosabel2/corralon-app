namespace UI
{
    partial class FormCreateUser
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
            this.lblRols = new System.Windows.Forms.Label();
            this.comboBoxRols = new System.Windows.Forms.ComboBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRols
            // 
            this.lblRols.AutoSize = true;
            this.lblRols.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblRols.Location = new System.Drawing.Point(12, 9);
            this.lblRols.Name = "lblRols";
            this.lblRols.Size = new System.Drawing.Size(87, 19);
            this.lblRols.TabIndex = 3;
            this.lblRols.Text = "Asignar Rol:";
            // 
            // comboBoxRols
            // 
            this.comboBoxRols.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRols.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRols.FormattingEnabled = true;
            this.comboBoxRols.Location = new System.Drawing.Point(16, 31);
            this.comboBoxRols.Name = "comboBoxRols";
            this.comboBoxRols.Size = new System.Drawing.Size(350, 25);
            this.comboBoxRols.TabIndex = 6;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCreateUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.Location = new System.Drawing.Point(0, 74);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(378, 41);
            this.btnCreateUser.TabIndex = 10;
            this.btnCreateUser.Text = "Crear Usuario";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // FormCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 115);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.comboBoxRols);
            this.Controls.Add(this.lblRols);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCreateUser";
            this.Text = "FormCreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRols;
        private System.Windows.Forms.ComboBox comboBoxRols;
        private System.Windows.Forms.Button btnCreateUser;
    }
}