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
            this.lblLanguageSetting = new System.Windows.Forms.Label();
            this.btnSetDefaultLanguage = new System.Windows.Forms.Button();
            this.lblLanguageFilter = new System.Windows.Forms.Label();
            this.gBSettingLanguage = new System.Windows.Forms.GroupBox();
            this.cBLanguages = new System.Windows.Forms.ComboBox();
            this.gBFilters = new System.Windows.Forms.GroupBox();
            this.cBForms = new System.Windows.Forms.ComboBox();
            this.lblFormFilter = new System.Windows.Forms.Label();
            this.gBControls = new System.Windows.Forms.GroupBox();
            this.btnUpdateTranlationsControls = new System.Windows.Forms.Button();
            this.dgvTranslation = new System.Windows.Forms.DataGridView();
            this.btnCreateNewLanguage = new System.Windows.Forms.Button();
            this.gBSettingLanguage.SuspendLayout();
            this.gBFilters.SuspendLayout();
            this.gBControls.SuspendLayout();
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
            // lblLanguageSetting
            // 
            this.lblLanguageSetting.AutoSize = true;
            this.lblLanguageSetting.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguageSetting.Location = new System.Drawing.Point(9, 35);
            this.lblLanguageSetting.Name = "lblLanguageSetting";
            this.lblLanguageSetting.Size = new System.Drawing.Size(58, 16);
            this.lblLanguageSetting.TabIndex = 1;
            this.lblLanguageSetting.Text = "IDIOMAS:";
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
            // lblLanguageFilter
            // 
            this.lblLanguageFilter.AutoSize = true;
            this.lblLanguageFilter.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblLanguageFilter.Location = new System.Drawing.Point(8, 70);
            this.lblLanguageFilter.Name = "lblLanguageFilter";
            this.lblLanguageFilter.Size = new System.Drawing.Size(61, 19);
            this.lblLanguageFilter.TabIndex = 3;
            this.lblLanguageFilter.Text = "Idioma:";
            // 
            // gBSettingLanguage
            // 
            this.gBSettingLanguage.Controls.Add(this.btnSetDefaultLanguage);
            this.gBSettingLanguage.Controls.Add(this.comboBoxLanguages);
            this.gBSettingLanguage.Controls.Add(this.lblLanguageSetting);
            this.gBSettingLanguage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBSettingLanguage.Location = new System.Drawing.Point(2, 153);
            this.gBSettingLanguage.Name = "gBSettingLanguage";
            this.gBSettingLanguage.Size = new System.Drawing.Size(225, 142);
            this.gBSettingLanguage.TabIndex = 4;
            this.gBSettingLanguage.TabStop = false;
            this.gBSettingLanguage.Text = "Configuracion";
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
            // gBFilters
            // 
            this.gBFilters.Controls.Add(this.cBForms);
            this.gBFilters.Controls.Add(this.lblFormFilter);
            this.gBFilters.Controls.Add(this.lblLanguageFilter);
            this.gBFilters.Controls.Add(this.cBLanguages);
            this.gBFilters.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBFilters.Location = new System.Drawing.Point(0, 0);
            this.gBFilters.Name = "gBFilters";
            this.gBFilters.Size = new System.Drawing.Size(225, 147);
            this.gBFilters.TabIndex = 6;
            this.gBFilters.TabStop = false;
            this.gBFilters.Text = "Filtros";
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
            // lblFormFilter
            // 
            this.lblFormFilter.AutoSize = true;
            this.lblFormFilter.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lblFormFilter.Location = new System.Drawing.Point(8, 20);
            this.lblFormFilter.Name = "lblFormFilter";
            this.lblFormFilter.Size = new System.Drawing.Size(42, 19);
            this.lblFormFilter.TabIndex = 6;
            this.lblFormFilter.Text = "Form";
            // 
            // gBControls
            // 
            this.gBControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBControls.Controls.Add(this.btnUpdateTranlationsControls);
            this.gBControls.Controls.Add(this.dgvTranslation);
            this.gBControls.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBControls.Location = new System.Drawing.Point(230, 0);
            this.gBControls.Name = "gBControls";
            this.gBControls.Size = new System.Drawing.Size(419, 618);
            this.gBControls.TabIndex = 7;
            this.gBControls.TabStop = false;
            this.gBControls.Text = "Controles";
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
            // btnCreateNewLanguage
            // 
            this.btnCreateNewLanguage.Location = new System.Drawing.Point(2, 301);
            this.btnCreateNewLanguage.Name = "btnCreateNewLanguage";
            this.btnCreateNewLanguage.Size = new System.Drawing.Size(225, 49);
            this.btnCreateNewLanguage.TabIndex = 3;
            this.btnCreateNewLanguage.Text = "Crear Nuevo Idioma";
            this.btnCreateNewLanguage.UseVisualStyleBackColor = true;
            this.btnCreateNewLanguage.Click += new System.EventHandler(this.btnCreateNewLanguage_Click);
            // 
            // FormLanguageConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 630);
            this.Controls.Add(this.btnCreateNewLanguage);
            this.Controls.Add(this.gBControls);
            this.Controls.Add(this.gBFilters);
            this.Controls.Add(this.gBSettingLanguage);
            this.Name = "FormLanguageConfig";
            this.Text = "FormLanguageConfig";
            this.Load += new System.EventHandler(this.FormLanguageConfig_Load);
            this.gBSettingLanguage.ResumeLayout(false);
            this.gBSettingLanguage.PerformLayout();
            this.gBFilters.ResumeLayout(false);
            this.gBFilters.PerformLayout();
            this.gBControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranslation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLanguages;
        private System.Windows.Forms.Label lblLanguageSetting;
        private System.Windows.Forms.Button btnSetDefaultLanguage;
        private System.Windows.Forms.Label lblLanguageFilter;
        private System.Windows.Forms.GroupBox gBSettingLanguage;
        private System.Windows.Forms.ComboBox cBLanguages;
        private System.Windows.Forms.GroupBox gBFilters;
        private System.Windows.Forms.ComboBox cBForms;
        private System.Windows.Forms.Label lblFormFilter;
        private System.Windows.Forms.GroupBox gBControls;
        private System.Windows.Forms.DataGridView dgvTranslation;
        private System.Windows.Forms.Button btnUpdateTranlationsControls;
        private System.Windows.Forms.Button btnCreateNewLanguage;
    }
}