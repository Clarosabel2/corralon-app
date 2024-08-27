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
    public partial class FormCrearVenta : Form
    {
        public FormCrearVenta()
        {
            InitializeComponent();
        }

        private void buttonCerrarVenta_Click(object sender, EventArgs e)
        {
            panelFinVenta.Visible = true;
        }

        private void FormCrearVenta_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = BLL_Producto.ObtenerProductos();
            foreach (DataGridViewColumn columna in dgvProducts.Columns)
            {
                columna.ReadOnly = true;
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            DataGridViewColumn columnaCantidad = new DataGridViewTextBoxColumn();
            columnaCantidad.Name = "Cantidad";
            columnaCantidad.HeaderText = "Cantidad";
            columnaCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnaCantidad.ReadOnly = false;
            dgvProducts.Columns.Add(columnaCantidad);
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
                string cantidad = selectedRow.Cells["Cantidad"].Value?.ToString();
                dgvProducts.SelectedRows[0].Cells["Cantidad"].Value = "";
                if (!string.IsNullOrWhiteSpace(cantidad) && int.TryParse(cantidad, out int cantidadInt) && cantidadInt > 0)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dgvCart);
                    newRow.Cells[0].Value = selectedRow.Cells[1].Value;
                    newRow.Cells[1].Value = selectedRow.Cells[4].Value; //Nombre del producto
                    newRow.Cells[2].Value = cantidad;
                    dgvCart.Rows.Add(newRow);
                }
                else
                {
                    MessageBox.Show("Debe ingresar una cantidad válida.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto primero.");
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvCart.SelectedRows[0];
                    dgvCart.Rows.Remove(selectedRow);
                }
                catch
                {
                    MessageBox.Show("No hay productos para eliminar");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }
    }
}
