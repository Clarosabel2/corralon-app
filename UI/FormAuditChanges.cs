using BDE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormAuditChanges : Form
    {
        public FormAuditChanges()
        {
            InitializeComponent();
        }

        private void ConfigDataGriedView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dataGridView1.IsCurrentCellDirty)
                    dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };

            var colSel = new DataGridViewCheckBoxColumn
            {
                Name = "colSel",
                HeaderText = "", // lo podés traducir si querés
                Width = 30
            };
            dataGridView1.Columns.Add(colSel);
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAuditID",
                HeaderText = "ID",
                DataPropertyName = "AuditID",
                Width = 60
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTableName",
                HeaderText = "Tabla",
                DataPropertyName = "TableName",
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colColumnName",
                HeaderText = "Columna",
                DataPropertyName = "ColumnName",
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRowKey",
                HeaderText = "Clave",
                DataPropertyName = "RowKey",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colOperation",
                HeaderText = "Operación",
                DataPropertyName = "Operation",
                Width = 90
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colOldValue",
                HeaderText = "Valor Anterior",
                DataPropertyName = "OldValue",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNewValue",
                HeaderText = "Valor Nuevo",
                DataPropertyName = "NewValue",
                Width = 150
            });

            var colChangeDate = new DataGridViewTextBoxColumn
            {
                Name = "colChangeDate",
                HeaderText = "Fecha",
                DataPropertyName = "ChangeDate",
                Width = 150,
                DefaultCellStyle = { Format = "yyyy-MM-dd HH:mm:ss" }
            };
            dataGridView1.Columns.Add(colChangeDate);

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colChangedBy",
                HeaderText = "Usuario",
                DataPropertyName = "ChangedBy",
                Width = 120
            });
        }
        private void LoadDataAuditChanges()
        {
            var data = BLL_AuditChange.GetAuditChanges();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data;
        }

        private BE_AuditChange GetCheckedObject()
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                var cell = r.Cells["colSel"];
                if (cell?.Value is bool checkedVal && checkedVal)
                {
                    return r.DataBoundItem as BE_AuditChange;
                }
            }
            return null;
        }
        private void FormAuditChanges_Load(object sender, EventArgs e)
        {
            ConfigDataGriedView();
            LoadDataAuditChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRestoreBeforeValue_Click(object sender, EventArgs e)
        {
            var audit = GetCheckedObject();
            if (audit == null)
            {
                MessageBox.Show("Selecciona un registro.");
                return;
            }
            if (!BLL_AuditChange.RestoreAuditValue(audit)) {
                MessageBox.Show("No se pudo restaurar el valor.");
            }
            else
            {
                MessageBox.Show("Valor restaurado correctamente.");
                LoadDataAuditChanges();
            }
        }
    }
}
