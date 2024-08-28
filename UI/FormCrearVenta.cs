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
            LoadProducts();
        }

        private void FormCrearVenta_Load(object sender, EventArgs e)
        {
        }

        private void LoadProducts()
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
                    newRow.Cells[1].Value = selectedRow.Cells[8].Value;
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
        private void buttonCerrarVenta_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 1)
            {
                MessageBox.Show("No hay productos en el carrito. No se puede cerrar.");

            }
            else
            {
                panelFinVenta.Visible = true;
                panelFinVenta.BringToFront();
                panelFinVenta.Location = new Point(
                                                    (this.ClientSize.Width - panelFinVenta.Width) / 2,
                                                    (this.ClientSize.Height - panelFinVenta.Height) / 2
                                                );
                foreach (Control control in this.Controls)
                {
                    if (control != panelFinVenta && control.Parent != panelFinVenta)
                    {
                        control.Enabled = false;
                    }
                }
            }

        }

        private void txtBClienteDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBClienteDNI_TextChanged(object sender, EventArgs e)
        {
            if (txtBClienteDNI.Text.Length >= 8)
            {
                var dni = txtBClienteDNI.Text;
                if (BLL_Cliente.VerificarCliente(dni))
                {
                    lblEstadoCliente.Text = "Cliente registrado";
                    lblEstadoCliente.ForeColor = Color.Green;
                }
                else
                {
                    lblEstadoCliente.Text = "Cliente no registrado";
                    lblEstadoCliente.ForeColor = Color.Red;
                    DialogResult r =
                        MessageBox.Show($"El cliente con DNI {dni} no esta registrado. Desea registrar el cliente?", "Aviso"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {

                    }
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            panelFinVenta.Visible = false;
            foreach (Control control in this.Controls)
            {
                if (control != panelFinVenta && control.Parent != panelFinVenta)
                {
                    control.Enabled = true;
                }
            }
        }

        private DataGridViewRow previousSelectedRow;
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (previousSelectedRow != null)
            {
                previousSelectedRow.Cells["Cantidad"].Value = "";
            }
            if (dgvProducts.SelectedRows.Count > 0)
            {
                previousSelectedRow = dgvProducts.SelectedRows[0];
            }
            else
            {
                previousSelectedRow = null;
            }
        }

    }
}
