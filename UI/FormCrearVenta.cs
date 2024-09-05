using BDE;
using BLL;
using SVC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class FormCrearVenta : Form
    {
        BE_Carrito cart;
        private List<BE_Producto> products = BLL_Producto.ObtenerProductos();
        public FormCrearVenta()
        {
            InitializeComponent();
            LoadTypesProducts();
            LoadProducts(products);
            CreateCart();

        }

        private void CreateCart()
        {
            cart = new BE_Carrito();
        }

        private void FormCrearVenta_Load(object sender, EventArgs e)
        {

        }
        private void FormCrearVenta_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                RecolatePanel();
            }
        }

        private void FormCrearVenta_ResizeEnd(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                RecolatePanel();
            }
        }

        private void RecolatePanel()
        {
            panelFinVenta.Location =
                new Point((this.ClientSize.Width - panelFinVenta.Width) / 2, (this.ClientSize.Height - panelFinVenta.Height) / 2);
        }
        private void LoadTypesProducts()
        {
            DataTable dtCategorias = BLL_Producto.ObtenerCategoriasProducto();

            DataRow rowTodos = dtCategorias.NewRow();
            rowTodos["nombreCategoria"] = "Todos";
            rowTodos["id_Categoria"] = DBNull.Value;
            dtCategorias.Rows.InsertAt(rowTodos, 0);

            cBTipoProductos.DataSource = dtCategorias;
            cBTipoProductos.DisplayMember = "nombreCategoria";
            cBTipoProductos.ValueMember = "id_Categoria";
        }

        private void LoadProducts(List<BE_Producto> prdts)
        {
            if (prdts is null) MessageBox.Show("lista null");

            BindingList<BE_Producto> p = new BindingList<BE_Producto>(prdts);
            dgvProducts.DataSource = p;
            FillCellsDGV(dgvProducts);
            if (dgvProducts.Columns["PrecioTotal"] != null)
            {
                dgvProducts.Columns["PrecioTotal"].Visible = false;
            }
            dgvProducts.Columns["Cantidad"].ReadOnly = false;

        }

        private void FillCellsDGV(DataGridView dgv)
        {
            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                columna.ReadOnly = true;
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];

                var product = selectedRow.DataBoundItem as BE_Producto;


                int cantidad = int.Parse(selectedRow.Cells["Cantidad"].Value?.ToString());
                dgvProducts.SelectedRows[0].Cells["Cantidad"].Value = "";


                product.Cantidad = cantidad;

                if (product.VerificarDisponibilidad())
                {
                    product.CalcularPrecioTotal();
                    cart.AgregarProducto(product);
                    dgvCart.DataSource = null;
                    dgvCart.DataSource = cart.Productos;
                    dgvCart.Columns["Categoria"].Visible = false;
                    dgvCart.Columns["Stock"].Visible = false;
                    FillCellsDGV(dgvCart);
                }
                else
                {
                    MessageBox.Show("No hay stock disponible para lo silicitado");
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
                    cart.RemoverProducto(selectedRow.DataBoundItem as BE_Producto);
                    dgvCart.DataSource = null;
                    dgvCart.DataSource = cart.Productos;
                    dgvCart.Columns["Categoria"].Visible = false;
                    dgvCart.Columns["Stock"].Visible = false;
                    FillCellsDGV(dgvCart);

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
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito. No se puede cerrar.");

            }
            else
            {
                panelFinVenta.Visible = true;
                panelFinVenta.BringToFront();
                cBTypesInvoice.DataSource = BLL_Venta.GetTypesInvoice();
                cBTypesInvoice.DisplayMember = "tipo";
                cBTypesInvoice.ValueMember = "id_Tipo";
                RecolatePanel();
                foreach (Control control in this.Controls)
                {
                    if (control != panelFinVenta && control.Parent != panelFinVenta)
                    {
                        control.Enabled = false;
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

        private void txtBClienteDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBClienteDNI_TextChanged(object sender, EventArgs e)
        {
            var dni = txtBClienteDNI.Text;
            txtBClienteDNI.BackColor = SystemColors.Window;
            if (txtBClienteDNI.Text.Length >= 8)
            {
                var cliente = BLL_Cliente.VerificarCliente(dni);
                if (cliente != null)
                {
                    btnGenerarFactura.Enabled = true;
                    txtBClienteDNI.BackColor = Color.GreenYellow;
                    lblEstadoCliente.Text = cliente.Nombre + " " + cliente.Apellido;
                }
                else
                {
                    txtBClienteDNI.BackColor = Color.Red;

                    DialogResult r =
                        MessageBox.Show($"El cliente con DNI {dni} no esta registrado. Desea registrar el cliente?", "Aviso"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        FormRegistrarCliente f = new FormRegistrarCliente();
                        f.TopLevel = false;
                        this.Controls.Add(f);
                        f.BringToFront();
                        f.StartPosition = FormStartPosition.CenterScreen;
                        f.txtDni.Text = dni;
                        f.Show();
                    }
                }
            }
            else
            {
                lblEstadoCliente.Text = "";
                btnGenerarFactura.Enabled = false;
            }

        }



        private DataGridViewRow previousSelectedRow;
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (previousSelectedRow != null)
            {
                //previousSelectedRow.Cells["Cantidad"].Value = "";
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
        private void dgvCart_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateDetailsCart();
        }

        private void dgvCart_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateDetailsCart();
        }
        private void UpdateDetailsCart()
        {
            decimal totalCartValue = (decimal)cart.Productos.Sum(p => p.PrecioTotal);
            lblTotal.Text = "$ " + totalCartValue.ToString();
            lblItemsTotal.Text = (dgvCart.RowCount).ToString();
            if (dgvCart.RowCount == 0)
            {
                buttonCerrarVenta.Enabled = false;
            }
            else { buttonCerrarVenta.Enabled = true; }
        }

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterName.Text != "")
            {
                var prdtsFiltered = new List<BE_Producto>();

                string name = txtFilterName.Text;
                prdtsFiltered = products.Where(p => p.Nombre.ToLower().Contains(name.ToLower()) ||
                                           p.Marca.Contains(name.ToLower())).ToList();
                LoadProducts(prdtsFiltered);
            }
            else
            {
                LoadProducts(products);
            }
        }

        private void cBTipoProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((DataRowView)cBTipoProductos.SelectedItem)["nombreCategoria"].ToString() == "Todos")
            {
                LoadProducts(products);
            }
            else
            {
                var prdtsFiltered = new List<BE_Producto>();
                string selectedCategory = ((DataRowView)cBTipoProductos.SelectedItem)["nombreCategoria"].ToString();
                prdtsFiltered = products.Where(p => p.Categoria == selectedCategory).ToList();
                LoadProducts(prdtsFiltered);
            }

        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProducts.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                if (e.Value != null && (int)e.Value == 0)
                {
                    e.Value = "";  // Establece la celda vacía
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvProducts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            BE_Venta newSale = new BE_Venta();
            newSale.Carrito = cart;
            newSale.Vendedor = SessionManager.GetInstance.usuario.Emp;
            newSale.Cliente = BLL_Cliente.VerificarCliente(txtBClienteDNI.Text);
            newSale.Tipo = cBTypesInvoice.GetItemText(cBTypesInvoice.SelectedItem)[0];
            newSale.FechaEntrega = DateTime.Parse(DPEntrega.Date.ToShortDateString());
            //FECHA ENTREGA
            BLL_Venta.SaveInvoice(newSale);
        }
    }
}
