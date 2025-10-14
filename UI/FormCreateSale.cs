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
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.common.Styles;
using UI.common.Utils;

namespace UI
{
    public partial class FormCreateSale : Form, IObserver
    {

        private List<BE_Product> _listProducts;
        private const string PRODUCT_FORMAT = "BE_Product";
        public FormCreateSale()
        {
            InitializeComponent();
            _listProducts = BLL_Product.GetProducts();
            ConfigFilters();
            ConfigDGVs();
            BLL_Sale.CreateSale();
            LoadProducts(_listProducts);
            LanguageManager.Attach(this);
        }

        #region "Funciones Visuales"



        private void FormCrearVenta_Load(object sender, EventArgs e)
        {
            DPEntrega.Date = DateTime.Now;

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

        #region "Funciones Carga de Datos a DGV"
        private void ConfigFilters()
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
        private void ConfigDGVs()
        {
            ApplyStyleCommon.DGVStyle(this.dgvProducts);
            ApplyStyleCommon.DGVStyle(this.dgvProductsCart);

            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14f, FontStyle.Bold);
            dgvProducts.DefaultCellStyle.Font = new Font("Century Gothic", 11f, FontStyle.Regular);


            dgvProductsCart.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14f, FontStyle.Bold);
            dgvProductsCart.DefaultCellStyle.Font = new Font("Century Gothic", 11f, FontStyle.Regular);

            dgvProducts.MouseDown += DgvProducts_MouseDown;
            dgvProducts.MouseMove += DgvProducts_MouseMove;
            dgvProductsCart.DataError += dgvProductsCart_DataError;
            dgvProducts.MultiSelect = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // DESTINO: carrito
            dgvProductsCart.AllowDrop = true;
            dgvProductsCart.DragEnter += DgvProductsCart_DragEnter;
            dgvProductsCart.DragDrop += DgvProductsCart_DragDrop;

            // (Opcional) evitar drag inverso
            dgvProductsCart.MouseDown -= DgvProducts_MouseDown;
            dgvProductsCart.MouseMove -= DgvProducts_MouseMove;

            dgvProductsCart.AllowDrop = true;


            dgvProductsCart.CellEndEdit += DgvProductsCart_CellEndEdit;
            dgvProductsCart.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void DgvProductsCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProductsCart.Columns[e.ColumnIndex].Name == "colQuantity")
            {
                DataGridViewRow row = dgvProductsCart.Rows[e.RowIndex];

                int? idxExist = int.TryParse(row.Cells["colId"].Value?.ToString(), out int idExist) ? idExist : (int?)null;

                var item = BLL_Sale.CurrentSale.ItemsProducts.FirstOrDefault(i => i.Id == idxExist);

                int quantity = 0;
                int.TryParse(row.Cells["colQuantity"].Value?.ToString(), out quantity);

                try
                {
                    checked
                    {
                        item.Amount = quantity;
                    }
                    row.Cells["colPrice"].Value = "$ " + item.Product.Price;
                    row.Cells["colQuantity"].Value = item.Amount;
                    row.Cells["colSubtotal"].Value = "$ " + item.Subtotal;
                    BLL_Sale.CurrentSale.CalculateTotal();
                    UpdateDetailsCart();
                    RefreshDgvProductsStock(item.Product, item.Amount);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.TargetSite.ToString());
                }
            }
        }

        private Point _dragStartPoint;
        private int _dragRowIndex = -1;

        private void DgvProducts_MouseDown(object sender, MouseEventArgs e)
        {
            _dragStartPoint = e.Location;
            _dragRowIndex = -1;

            var hit = dgvProducts.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.Cell && hit.RowIndex >= 0)
            {
                _dragRowIndex = hit.RowIndex;
                dgvProducts.ClearSelection();
                dgvProducts.Rows[_dragRowIndex].Selected = true;
            }
        }
        private void DgvProducts_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (_dragRowIndex < 0) return;

            var dragRect = new Rectangle(
                _dragStartPoint.X - SystemInformation.DragSize.Width / 2,
                _dragStartPoint.Y - SystemInformation.DragSize.Height / 2,
                SystemInformation.DragSize.Height,
                SystemInformation.DragSize.Height
            );
            if (dragRect.Contains(e.Location)) return;

            var row = dgvProducts.Rows[_dragRowIndex];
            if (row.IsNewRow) return;

            if (!int.TryParse(row.Cells[0].Value?.ToString(), out int id)) return;

            //BE_Item item = BLL_Sale.CurrentSale.ItemsProducts.FirstOrDefault(i => i.Product.Id == id);

            //var product = _listProducts?.FirstOrDefault(p => p.Id == id);
            //if (product == null) return;

            //var data = new DataObject();
            //data.SetData(typeof(BE_Product), product);
            //data.SetData(PRODUCT_FORMAT, product);
            //dgvProducts.DoDragDrop(data, DragDropEffects.Copy);

            int productId = _listProducts.FirstOrDefault(p => p.Id == id).Id;

            var data = new DataObject();
            data.SetData(typeof(int), productId);
            //data.SetData(PRODUCT_FORMAT, productId);
            dgvProducts.DoDragDrop(data, DragDropEffects.Copy);

        }

        private void DgvProductsCart_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(typeof(BE_Product)) || e.Data.GetDataPresent(PRODUCT_FORMAT))
            //    e.Effect = DragDropEffects.Copy;
            //else
            //    e.Effect = DragDropEffects.None;
            if (e.Data.GetDataPresent(typeof(int)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void DgvProductsCart_DragDrop(object sender, DragEventArgs e)
        {
            int productId = 0;
            if (e.Data.GetDataPresent(typeof(int)))
                productId = (int)e.Data.GetData(typeof(int));
            BE_Item itemCart = BLL_Sale.CurrentSale.ItemsProducts.FirstOrDefault(item => item.Product.Id == productId);
            if (itemCart != null)
            {
                try
                {
                    checked
                    {
                        itemCart.Amount = itemCart.Amount + 1;
                    }
                    RefreshDgvProductsStock(itemCart.Product, itemCart.Amount);

                    var row = dgvProductsCart.Rows[itemCart.Id - 1];
                    row.Cells["colPrice"].Value = "$ " + itemCart.Product.Price;
                    row.Cells["colQuantity"].Value = itemCart.Amount;
                    row.Cells["colSubtotal"].Value = "$ " + itemCart.Subtotal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo actualizar la cantidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            try
            {
                BE_Product product = _listProducts.FirstOrDefault(p => p.Id == productId);
                var added = BLL_Sale.AddItem(product, 1);
                RefreshDgvProductsStock(product, added.Amount);

                dgvProductsCart.Rows.Add(
                    added.Id,
                    ImageLoader.LoadSafe(added.Product.ImagePath) ?? Properties.Resources.img_icon,
                    added.Product.Name,
                    "$ " + added.Product.Price,
                    "$ " + added.Subtotal,
                    added.Amount
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo agregar el producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            BLL_Sale.CurrentSale.CalculateTotal();
            UpdateDetailsCart();
        }
        private void RefreshDgvProductsStock(BE_Product product, int quantity)
        {
            foreach (DataGridViewRow r in dgvProducts.Rows)
            {
                if (int.TryParse(r.Cells["IDProduct"].Value?.ToString(), out var idValue) && idValue == product.Id)
                {
                    r.Cells["stockProduct"].Value = product.Stock - quantity;
                }
            }
        }
        private void LoadProducts(List<BE_Product> prdts)
        {
            dgvProducts.Rows.Clear();
            if (prdts is null) MessageBox.Show("lista null");

            BindingList<BE_Product> p = new BindingList<BE_Product>(prdts);
            foreach (BE_Product item in p)
            {
                dgvProducts.Rows.Add(
                    item.Id,
                    ImageLoader.LoadSafe(item.ImagePath) ?? Properties.Resources.img_icon,
                    item.Brand.NameBrand,
                    item.Name,
                    item.Stock,
                    "$ " + item.Price
                    );
            }
        }
        #endregion

        //Se Muestra el panel de confirmacion de venta
        private void buttonCerrarVenta_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito. No se puede cerrar.");

            }
            else
            {
                //panelFinVenta.Visible = true;
                //panelFinVenta.BringToFront();
                //cBTypesInvoice.DataSource = BLL_Invoice.GetTypesInvoice();
                //cBTypesInvoice.DisplayMember = "tipo";
                //cBTypesInvoice.ValueMember = "id_Tipo";
                //RecolatePanel();
                //foreach (Control control in this.Controls)
                //{
                //    if (control != panelFinVenta && control.Parent != panelFinVenta)
                //    {
                //        control.Enabled = false;
                //    }
                //}
                FormFinalizeSale fm = new FormFinalizeSale();
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.FormBorderStyle = FormBorderStyle.None;
                fm.ShowDialog(this);
            }

        }
        private void dgvProducts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
        private DataGridViewRow previousSelectedRow;
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            //if (previousSelectedRow != null)
            //{
            //    previousSelectedRow.Cells["colQuantity"].Value = "";
            //}
            //if (dgvProducts.SelectedRows.Count > 0)
            //{
            //    previousSelectedRow = dgvProducts.SelectedRows[0];
            //}
            //else
            //{
            //    previousSelectedRow = null;
            //}
        }
        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (dgvProducts.Columns[e.ColumnIndex].Name == "Amount")
            //{
            //    int? amount = e.Value as int?;
            //    if (amount.HasValue && amount.Value == 0)
            //    {
            //        e.Value = "";
            //        e.FormattingApplied = true;
            //    }
            //}
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
            double totalCartValue = BLL_Sale.CurrentSale.Total;
            lblTotal.Text = "$ " + totalCartValue.ToString();
            lblItemsTotal.Text = (dgvProductsCart.RowCount).ToString();
            if (dgvProductsCart.RowCount == 0)
            {
                buttonCerrarVenta.Enabled = false;
            }
            else { buttonCerrarVenta.Enabled = true; }
        }

        private void txtFilterName_TextChanged(object sender, EventArgs e)
        {

            if (txtFilterName.Text != "")
            {
                var prdtsFiltered = new List<BE_Product>();

                string name = txtFilterName.Text;
                prdtsFiltered = _listProducts.Where(p => p.Name.ToLower().Contains(name.ToLower()) ||
                                           p.Brand.NameBrand.Contains(name.ToLower())).ToList();
                LoadProducts(prdtsFiltered);
            }
            else
            {
                LoadProducts(_listProducts);
            }
        }

        private void cBTipoProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((DataRowView)cBTipoProductos.SelectedItem)["nombreCategoria"].ToString() == "Todos")
            {
                LoadProducts(_listProducts);
            }
            else
            {
                var prdtsFiltered = new List<BE_Product>();
                string selectedCategory = ((DataRowView)cBTipoProductos.SelectedItem)["nombreCategoria"].ToString();
                prdtsFiltered = _listProducts.Where(p => p.Category == selectedCategory).ToList();
                LoadProducts(prdtsFiltered);
            }

        }

        #region "Funcionales del Panel Cerrar Venta"
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
                var client = BLL_Sale.AddClient(dni);
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
        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            BLL_Sale.CurrentSale.TypeInvoice = cBTypesInvoice.GetItemText(cBTypesInvoice.SelectedItem)[0];
            BLL_Sale.CurrentSale.Status = checkBoxPaid.Checked;
            BLL_Sale.CurrentOrder.DeliveryDate = DPEntrega.Date;
            try
            {
                try
                {
                    BLL_Sale.SaveInvoice();
                    DialogResult r = MessageBox.Show("Factura guardada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK) this.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la factura:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        public void Update(BE_Language language)
        {
            UITranslator.ApplyTranslations(this, SessionManager.translations[language][this.Name]);
        }

        private void FormCreateSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            LanguageManager.Detach(this);
        }

        private void dgvProductsCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProductsCart.Columns[e.ColumnIndex].Name == "colQuantity")
            {
                dgvProductsCart.BeginEdit(true);
            }
        }

        private void dgvProductsCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProductsCart.Columns["btnDeleteCol"].Index)
            {
                var result = MessageBox.Show("¿Eliminar este producto del carrito?",
                                             "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (result == DialogResult.Yes)
                    {
                        dgvProductsCart.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
        private void dgvProductsCart_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            var col = dgvProductsCart.Columns[e.ColumnIndex].Name;
            var cell = dgvProductsCart.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var val = cell?.Value;
            var tipo = val?.GetType().Name ?? "null";

            MessageBox.Show($"DataError en columna '{col}'. Tipo valor: {tipo}. Valor: {val}\n\n{e.Exception.Message}");
            e.ThrowException = false; // evita que salga el cuadro de error por defecto
        }

    }
}
