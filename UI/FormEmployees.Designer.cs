namespace UI
{
    partial class FormEmployees
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
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCreateEmployee.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEmployee.Location = new System.Drawing.Point(0, 459);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(697, 42);
            this.btnCreateEmployee.TabIndex = 3;
            this.btnCreateEmployee.Text = "Crear Empleado";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 6);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(673, 447);
            this.dgvEmployees.TabIndex = 2;
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 501);
            this.Controls.Add(this.btnCreateEmployee);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "FormEmployees";
            this.Text = "FormEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.DataGridView dgvEmployees;
    }
}