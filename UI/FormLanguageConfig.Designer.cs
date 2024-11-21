namespace UI
{
    partial class FormLanguageConfig
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
            this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.btnSetDefaultLanguage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBLanguages = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBForms = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTranslation = new System.Windows.Forms.DataGridView();
            this.btnUpdateTranlationsControls = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranslation)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLanguages
            // 
            this.comboBoxLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguages.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLanguages.FormattingEnabled = true;
            this.comboBoxLanguages.Location = new System.Drawing.Point(12, 54);
            this.comboBoxLanguages.Name = "comboBoxLanguages";
            this.comboBoxLanguages.Size = new System.Drawing.Size(182, 24);
            this.comboBoxLanguages.TabIndex = 0;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(9, 35);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(58, 16);
            this.lblLanguage.TabIndex = 1;
            this.lblLanguage.Text = "IDIOMAS:";
            // 
            // btnSetDefaultLanguage
            // 
            this.btnSetDefaultLanguage.Location = new System.Drawing.Point(12, 84);
            this.btnSetDefaultLanguage.Name = "btnSetDefaultLanguage";
            this.btnSetDefaultLanguage.Size = new System.Drawing.Size(182, 49);
            this.btnSetDefaultLanguage.TabIndex = 2;
            this.btnSetDefaultLanguage.Text = "ESTABLECER COMO PREDESTERMINADO";
            this.btnSetDefaultLanguage.UseVisualStyleBackColor = true;
            this.btnSetDefaultLanguage.Click += new System.EventHandler(this.btnSetDefaultLanguage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Idioma:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetDefaultLanguage);
            this.groupBox1.Controls.Add(this.comboBoxLanguages);
            this.groupBox1.Controls.Add(this.lblLanguage);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 155);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion";
            // 
            // cBLanguages
            // 
            this.cBLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cBLanguages.FormattingEnabled = true;
            this.cBLanguages.Location = new System.Drawing.Point(12, 92);
            this.cBLanguages.Name = "cBLanguages";
            this.cBLanguages.Size = new System.Drawing.Size(182, 25);
            this.cBLanguages.TabIndex = 5;
            this.cBLanguages.SelectedIndexChanged += new System.EventHandler(this.cBLanguages_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBForms);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cBLanguages);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 147);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // cBForms
            // 
            this.cBForms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cBForms.FormattingEnabled = true;
            this.cBForms.Location = new System.Drawing.Point(12, 42);
            this.cBForms.Name = "cBForms";
            this.cBForms.Size = new System.Drawing.Size(182, 25);
            this.cBForms.TabIndex = 7;
            this.cBForms.SelectedIndexChanged += new System.EventHandler(this.cBForms_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Form";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnUpdateTranlationsControls);
            this.groupBox3.Controls.Add(this.dgvTranslation);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(230, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 618);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controles";
            // 
            // dgvTranslation
            // 
            this.dgvTranslation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTranslation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTranslation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranslation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTranslation.Location = new System.Drawing.Point(3, 19);
            this.dgvTranslation.Name = "dgvTranslation";
            this.dgvTranslation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTranslation.Size = new System.Drawing.Size(413, 596);
            this.dgvTranslation.TabIndex = 0;
            // 
            // btnUpdateTranlationsControls
            // 
            this.btnUpdateTranlationsControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdateTranlationsControls.Location = new System.Drawing.Point(3, 578);
            this.btnUpdateTranlationsControls.Name = "btnUpdateTranlationsControls";
            this.btnUpdateTranlationsControls.Size = new System.Drawing.Size(413, 37);
            this.btnUpdateTranlationsControls.TabIndex = 1;
            this.btnUpdateTranlationsControls.Text = "Actualizar";
            this.btnUpdateTranlationsControls.UseVisualStyleBackColor = true;
            this.btnUpdateTranlationsControls.Click += new System.EventHandler(this.btnUpdateTranlationsControls_Click);
            // 
            // FormLanguageConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 630);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLanguageConfig";
            this.Text = "FormLanguageConfig";
            this.Load += new System.EventHandler(this.FormLanguageConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranslation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLanguages;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Button btnSetDefaultLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBLanguages;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cBForms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTranslation;
        private System.Windows.Forms.Button btnUpdateTranlationsControls;
    }
}