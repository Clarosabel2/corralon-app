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
    public partial class FormEmployees : Form
    {
        public FormEmployees()
        {
            InitializeComponent();
            LoadData();
        }
        internal void LoadData()
        {
            dgvEmployees.Rows.Clear();
            dgvEmployees.Columns.Clear();
            DataGridViewTextBoxColumn colObject = new DataGridViewTextBoxColumn
            {
                Name = "colObject",
                Visible = false
            };
            dgvEmployees.Columns.Add(colObject);
            dgvEmployees.Columns.Add("colID", "ID");
            dgvEmployees.Columns.Add("colArea", "Area");
            dgvEmployees.Columns.Add("colDNI", "DNI");
            dgvEmployees.Columns.Add("colName", "Nombre");
            dgvEmployees.Columns.Add("colLastname", "Apellido");
            dgvEmployees.Columns.Add("colAddress", "Domicilio");
            dgvEmployees.Columns.Add("colPhone", "Telefono");
            dgvEmployees.Columns.Add("colSalary", "Salario");

            foreach (BE_Employee e in BLL_Employee.GetAllEmployees())
            {
                dgvEmployees.Rows.Add(e, e.Id, e.Area, e.Dni, e.Name, e.Lastname, e.Address, e.NumPhone, e.Salario);
            }
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            FormCreateEmployee f = new FormCreateEmployee(this);
            f.BringToFront();
            f.StartPosition= FormStartPosition.CenterParent;
            f.ShowDialog();
        }
    }
}
