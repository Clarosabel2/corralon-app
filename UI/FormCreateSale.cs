using BDE;
using BDE.Language;
using BLL;
using ReaLTaiizor.Controls;
using SVC;
using SVC.LanguageManager;
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
    public partial class FormCreateSale : Form, IObserver
    {
        private List<BE_Product> products = BLL_Product.GetProducts();
        private BE_Client client;
        private int itemID = 1;
        public FormCreateSale()
        {
            InitializeComponent();
            client = null;
            LoadTypesProducts();
            BLL_Sale.CreateSale();
            LoadProducts(products);
            LanguageManager.Attach(this);
        }

        #region "Funciones Visuales"



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
        #endregion
        private void LoadTypesProducts()
        {
            DataTable dtCategorias = BLL_Product.GetCaterogyProducts();

            DataRow rowTodos = dtCategorias.NewRow();
            rowTodos["nombreCategoria"] = "Todos";
            rowTodos["id_Categoria"] = DBNull.Value;
            dtCategorias.Rows.InsertAt(rowTodos, 0);

            cBTipoProductos.DataSource = dtCategorias;
            cBTipoProductos.DisplayMember = "nombreCategoria";
            cBTipoProductos.ValueMember = "id_Categoria";
        }

        private void LoadProducts(List<BE_Product> prdts)
        {
            if (prdts is null) MessageBox.Show("lista null");

            BindingList<BE_Product> p = new BindingList<BE_Product>(prdts);
            dgvProducts.DataSource = p;

            if (!dgvProducts.Columns.Contains("Amount"))
            {
                DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
                amountColumn.Name = "Amount";
                amountColumn.HeaderText = "Amount";
                amountColumn.ReadOnly = false;
                amountColumn.ValueType = typeof(int);
                dgvProducts.Columns.Add(amountColumn);
            }
            FillCellsDGV(dgvProducts);
        }

        private void FillCellsDGV(DataGridView dgv)
        {
            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                if (columna.Name != "Amount")
                {
                    columna.ReadOnly = true;
                }
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];

                var product = selectedRow.DataBoundItem as BE_Product;

                int cantidad = int.Parse(selectedRow.Cells["Amount"].Value?.ToString());
                dgvProducts.SelectedRows[0].Cells["Amount"].Value = "";

                try
                {
                    var item = new BE_Item(itemID, product, cantidad);
                    BLL_Sale.newSale.AddItem(item);
                    dgvCart.DataSource = null;
                    dgvCart.Rows.Add(itemID, item.Product.Name, item.Amount, item.Subtotal);
                    FillCellsDGV(dgvCart);
                    itemID++;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Debes Seleccionar un Producto.");
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                try
                {
                    int row = dgvCart.CurrentRow.Index;
                    int itemID = int.Parse(dgvCart.Rows[row].Cells["IDItem"].Value.ToString());
                    var itemRemove = BLL_Sale.newSale.ItemsProducts.FirstOrDefault(i => i.Id == itemID);
                    BLL_Sale.newSale.RemoveItem(itemRemove);
                }
                catch
                {
                    MessageBox.Show("No hay productos para eliminar");
                }

                dgvCart.Rows.Clear();

                foreach (var i in BLL_Sale.newSale.ItemsProducts)
                {
                    dgvCart.Rows.Add(i.Id, i.Product.Name, i.Amount, i.Subtotal);
                }
                FillCellsDGV(dgvCart);
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
                cBTypesInvoice.DataSource = BLL_Invoice.GetTypesInvoice();
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
                client = BLL_Client.GetClient(dni);
                if (client != null)
                {
                    btnGenerarFactura.Enabled = true;
                    txtBClienteDNI.BackColor = Color.GreenYellow;
                    lblEstadoCliente.Text = client.Name + " " + client.Lastname;
                }
                else
                {
                    txtBClienteDNI.BackColor = Color.Red;

                    DialogResult r =
                        MessageBox.Show($"El cliente con DNI {dni} no esta registrado. Desea registrar el cliente?", "Aviso"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        txtBClienteDNI.Text = "";
                        FormRegisterClient f = new FormRegisterClient();
                        f.TopLevel = false;
                        this.Controls.Add(f);
                        f.BringToFront();
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

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterName.Text != "")
            {
                var prdtsFiltered = new List<BE_Product>();

                string name = txtFilterName.Text;
                prdtsFiltered = products.Where(p => p.Name.ToLower().Contains(name.ToLower()) ||
                                           p.Brand.Contains(name.ToLower())).ToList();
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
                var prdtsFiltered = new List<BE_Product>();
                string selectedCategory = ((DataRowView)cBTipoProductos.SelectedItem)["nombreCategoria"].ToString();
                prdtsFiltered = products.Where(p => p.Category == selectedCategory).ToList();
                LoadProducts(prdtsFiltered);
            }

        }


        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProducts.Columns[e.ColumnIndex].Name == "Amount")
            {
                int? amount = e.Value as int?;
                if (amount.HasValue && amount.Value == 0)
                {
                    e.Value = "";
                    e.FormattingApplied = true;
                }
            }
        }

        private void dgvProducts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
        private DataGridViewRow previousSelectedRow;
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (previousSelectedRow != null)
            {
                previousSelectedRow.Cells["Amount"].Value = "";
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
            double totalCartValue = BLL_Sale.newSale.Total;
            lblTotal.Text = "$ " + totalCartValue.ToString();
            lblItemsTotal.Text = (dgvCart.RowCount - 1).ToString();
            if (dgvCart.RowCount == 0)
            {
                buttonCerrarVenta.Enabled = false;
            }
            else { buttonCerrarVenta.Enabled = true; }
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            BLL_Sale.newSale.Client = client;
            BLL_Sale.newSale.TypeInvoice = cBTypesInvoice.GetItemText(cBTypesInvoice.SelectedItem)[0];
            BLL_Sale.newSale.Status = checkBoxPaid.Checked;

            BLL_Order.CreateOrder(DPEntrega.Date, BLL_Sale.newSale);

            try
            {
                if (BLL_Order.SaveOrder())
                {
                    DialogResult r = MessageBox.Show("Factura guardada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK) this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al guardar la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void Update(string language)
        {
            UITranslator.ApplyTranslations(this, LanguageManager.translations[language][this.Name]);
        }

        private void FormCreateSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            LanguageManager.Detach(this);
        }
    }
}
