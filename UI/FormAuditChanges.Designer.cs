namespace UI
{
    partial class FormAuditChanges
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTableSearch = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtColumnSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRestoreBeforeValue = new System.Windows.Forms.Button();
            this.buttonDefault1 = new UI.Controls.ButtonDefault();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auditoria de Cambios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tabla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filtro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Columna:";
            // 
            // txtTableSearch
            // 
            this.txtTableSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableSearch.Location = new System.Drawing.Point(76, 63);
            this.txtTableSearch.Name = "txtTableSearch";
            this.txtTableSearch.Size = new System.Drawing.Size(153, 27);
            this.txtTableSearch.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(76, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(404, 27);
            this.textBox2.TabIndex = 5;
            // 
            // txtColumnSearch
            // 
            this.txtColumnSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnSearch.Location = new System.Drawing.Point(327, 63);
            this.txtColumnSearch.Name = "txtColumnSearch";
            this.txtColumnSearch.Size = new System.Drawing.Size(153, 27);
            this.txtColumnSearch.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 129);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(569, 309);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnRestoreBeforeValue
            // 
            this.btnRestoreBeforeValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreBeforeValue.Location = new System.Drawing.Point(18, 444);
            this.btnRestoreBeforeValue.Name = "btnRestoreBeforeValue";
            this.btnRestoreBeforeValue.Size = new System.Drawing.Size(150, 60);
            this.btnRestoreBeforeValue.TabIndex = 9;
            this.btnRestoreBeforeValue.Text = "Restaurar";
            this.btnRestoreBeforeValue.UseVisualStyleBackColor = true;
            this.btnRestoreBeforeValue.Click += new System.EventHandler(this.btnRestoreBeforeValue_Click);
            // 
            // buttonDefault1
            // 
            this.buttonDefault1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(64)))), ((int)(((byte)(106)))));
            this.buttonDefault1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDefault1.FlatAppearance.BorderSize = 0;
            this.buttonDefault1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefault1.Font = new System.Drawing.Font("Century Gothic", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonDefault1.ForeColor = System.Drawing.Color.White;
            this.buttonDefault1.Location = new System.Drawing.Point(495, 63);
            this.buttonDefault1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDefault1.Name = "buttonDefault1";
            this.buttonDefault1.Size = new System.Drawing.Size(97, 48);
            this.buttonDefault1.TabIndex = 10;
            this.buttonDefault1.Text = "Buscar";
            this.buttonDefault1.UseVisualStyleBackColor = false;
            // 
            // FormAuditChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 549);
            this.Controls.Add(this.buttonDefault1);
            this.Controls.Add(this.btnRestoreBeforeValue);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtColumnSearch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTableSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAuditChanges";
            this.Text = "FormAuditChanges";
            this.Load += new System.EventHandler(this.FormAuditChanges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTableSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtColumnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRestoreBeforeValue;
        private Controls.ButtonDefault buttonDefault1;
    }
}