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
using UI.common.Styles;
using UI.common.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            dgvProductsCart.CellMouseEnter += dgvProductsCart_CellMouseEnter;
            dgvProductsCart.EditMode = DataGridViewEditMode.EditOnEnter;

            //DataGridViewImageColumn btnDeleteCol = new DataGridViewImageColumn();
            //btnDeleteCol.HeaderText = "";
            ////btnDeleteCol.Text = "Eliminar";
            //btnDeleteCol.Image = Properties.Resources.delete_icon_circle;
            //btnDeleteCol.Name = "btnDelete";
            //btnDeleteCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //btnDeleteCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //btnDeleteCol.DefaultCellStyle.NullValue = null;

            //if (dgvProductsCart.Columns.Count == 0)
            //{
            //    int idx = dgvProductsCart.Columns.Add("colId", "Id");
            //    var col = dgvProductsCart.Columns[idx];
            //    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //    col.Width = 60;
            //    dgvProductsCart.Columns.Add("colImg", " ");
            //    dgvProductsCart.Columns.Add("colName", "Nombre");
            //    dgvProductsCart.Columns.Add("colPrice", "Precio unitario");
            //    dgvProductsCart.Columns.Add("colSubtotal", "Subtotal");
            //    dgvProductsCart.Columns.Add("colQuantity", "Cantidad");
            //    dgvProductsCart.Columns.Add(btnDeleteCol);

            //    dgvProductsCart.Columns["colPrice"].ReadOnly = true;
            //    dgvProductsCart.Columns["colSubtotal"].ReadOnly = true;
            //    dgvProductsCart.Columns["colId"].ReadOnly = true;
            //    dgvProductsCart.Columns["colName"].ReadOnly = true;
            //    dgvProductsCart.Columns["colPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //    dgvProductsCart.Columns["colSubtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //    dgvProductsCart.Columns["colId"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //    dgvProductsCart.Columns["colName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //    dgvProductsCart.Columns["colImg"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //    dgvProductsCart.Columns["colImg"].Width = 60;
            //}
        }

        private void dgvProductsCart_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvProductsCart_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

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

            // umbral estándar
            var dragRect = new Rectangle(
                _dragStartPoint.X - SystemInformation.DragSize.Width / 2,
                _dragStartPoint.Y - SystemInformation.DragSize.Height / 2,
                SystemInformation.DragSize.Height, // ancho alto del rectángulo
                SystemInformation.DragSize.Height
            );
            if (dragRect.Contains(e.Location)) return;

            var row = dgvProducts.Rows[_dragRowIndex];
            if (row.IsNewRow) return;

            // Mapeo: Id(0), Name(1), Brand(2), Category(3), Stock(4), Price(5)
            if (!int.TryParse(row.Cells[0].Value?.ToString(), out int id)) return;

            // Si querés leer campos visibles (opcional, solo informativos aquí)
            string nombre = row.Cells[1].Value?.ToString() ?? string.Empty; // Name está en 1
            decimal precio = 0m;
            decimal.TryParse(row.Cells[5].Value?.ToString(),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.CurrentCulture, out precio);

            // Buscar el BE_Product original por Id
            var product = _listProducts?.FirstOrDefault(p => p.Id == id);
            if (product == null) return;

            // Si tu BE_Product ya tiene ImagePath, no lo saques de la grilla
            // string imgPath = product.ImagePath;

            // Preparar el payload del drag: enviamos el BE_Product completo
            var data = new DataObject();
            data.SetData(typeof(BE_Product), product);  // formato fuerte por tipo
            data.SetData(PRODUCT_FORMAT, product);      // tu formato custom, por compatibilidad

            dgvProducts.DoDragDrop(data, DragDropEffects.Copy);
        }

        private void DgvProductsCart_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(BE_Product)) || e.Data.GetDataPresent(PRODUCT_FORMAT))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void DgvProductsCart_DragDrop(object sender, DragEventArgs e)
        {
            BE_Product product = null;

            if (e.Data.GetDataPresent(typeof(BE_Product)))
                product = e.Data.GetData(typeof(BE_Product)) as BE_Product;

            else if (e.Data.GetDataPresent(PRODUCT_FORMAT))
                product = e.Data.GetData(PRODUCT_FORMAT) as BE_Product;

            if (product == null) return;

            int id = product.Id;
            string nombre = product.Name;              // ajusta si tu propiedad se llama distinto (e.g. ProductName)
            double precio = product.Price;        // ajusta si tu propiedad se llama distinto (e.g. Price)
            string imgPath = product.ImagePath;        // ajusta si tu propiedad se llama distinto (o si tienes Image en memoria)

            // 2) Si ya existe en el carrito -> sumar cantidad
            int? idxExist = null;
            for (int i = 0; i < dgvProductsCart.Rows.Count; i++)
            {
                var r = dgvProductsCart.Rows[i];
                if (r.IsNewRow) continue;

                if (int.TryParse(r.Cells["colId"].Value?.ToString(), out int idExist) && idExist == id)
                {
                    idxExist = i;
                    break;
                }
            }

            if (idxExist.HasValue)
            {
                var r = dgvProductsCart.Rows[idxExist.Value];

                int cant = 0;
                int.TryParse(r.Cells["colQuantity"].Value?.ToString(), out cant);
                cant = Math.Max(0, cant) + 1;

                r.Cells["colPrice"].Value = precio; // por si el precio puede variar
                r.Cells["colSubtotal"].Value = precio * cant;
                r.Cells["colQuantity"].Value = cant;
            }
            else
            {
                //int idx = dgvProductsCart.Rows.Add();
                //var r = dgvProductsCart.Rows[idx];
                //r.Cells["colId"].Value = id;
                //r.Cells["colImg"].Value = ImageLoader.LoadSafe(imgPath);
                //r.Cells["colName"].Value = nombre;
                //r.Cells["colPrice"].Value = precio;
                //r.Cells["colQuantity"].Value = 1;
                //r.Cells["colSubtotal"].Value = precio * 1;
                //dgvProductsCart.Rows.Add();
                // colDelete: ya lo agregaste manualmente (no hace falta setear aquí)
                dgvProductsCart.Rows.Add(
                    product.Id,                                        // colId
                    ImageLoader.LoadSafe(product.ImagePath) ?? Properties.Resources.img_icon, // colImg
                    product.Name,                                    // colName
                    product.Price,                                    // colPrice
                    product.Price * 1                       ,          // colSubtotal
                    1                                        // colQuantity
                                                               // colDelete ya está como botón, no lo seteás
                );
            }

            // (Opcional) Si tenés un cálculo de total general:
            // RecalcCartTotals();
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
                    item.Price);
            }

            //if (!dgvProducts.Columns.Contains("Amount"))
            //{
            //    DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            //    amountColumn.Name = "Amount";
            //    amountColumn.HeaderText = "Amount";
            //    amountColumn.ReadOnly = false;
            //    amountColumn.ValueType = typeof(int);
            //    dgvProducts.Columns.Add(amountColumn);
            //}
            //FillCellsDGV(dgvProducts);
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
        #endregion
        //Ya no estaria en uso
        //private void btnAgregarCarrito_Click(object sender, EventArgs e)
        //{
        //    if (dgvProducts.SelectedRows.Count > 0)
        //    {
        //        DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];

        //        BE_Product productSelected = _listProducts.Find(x => x.Id == int.Parse(selectedRow.Cells["IDProduct"].Value.ToString()));
        //        //var product = selectedRow.DataBoundItem as BE_Product;
        //        int cantidad = int.Parse(selectedRow.Cells["Amount"].Value?.ToString());
        //        dgvProducts.SelectedRows[0].Cells["Amount"].Value = "";

        //        try
        //        {
        //            BLL_Sale.AddItem(productSelected, cantidad);
        //            dgvCart.Rows.Clear();
        //            BLL_Sale.newSale.ItemsProducts.ForEach(i => dgvCart.Rows.Add(i.Id, i.Product.Name, i.Amount, i.Subtotal));
        //            selectedRow.Cells["stockProduct"].Value = productSelected.Stock - cantidad;
        //            EnableRow(selectedRow);
        //            FillCellsDGV(dgvCart);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message.ToString());
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Debes Seleccionar un Producto.");
        //    }
        //}
        //private void btnRemoveItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (dgvCart.SelectedRows.Count > 0)
        //        {
        //            try
        //            {
        //                int row = dgvCart.CurrentRow.Index;
        //                int itemID = int.Parse(dgvCart.Rows[row].Cells["IDProduct"].Value.ToString());
        //                var item = BLL_Sale.RemoveItem(itemID);

        //                foreach (DataGridViewRow dr in dgvProducts.Rows)
        //                {
        //                    if (dr.Cells[1]?.Value?.ToString() == item.Product.Id.ToString())
        //                    {
        //                        int currentStock = int.Parse(dr.Cells["stockProduct"].Value.ToString());
        //                        dr.Cells["stockProduct"].Value = currentStock + item.Amount;
        //                        EnableRow(dr);
        //                        break;
        //                    }

        //                }

        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("No hay productos para eliminar");
        //            }

        //            dgvCart.Rows.Clear();

        //            foreach (var i in BLL_Sale.newSale.ItemsProducts)
        //            {
        //                dgvCart.Rows.Add(i.Id, i.Product.Name, i.Amount, i.Subtotal);
        //            }

        //            FillCellsDGV(dgvCart);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Seleccione un producto para eliminar.");
        //        }

        //    }
        //    catch (Exception ex) { }
        //}

        private void EnableRow(DataGridViewRow row)
        {
            bool isRowReadOnly = true;
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (!cell.ReadOnly)
                {
                    isRowReadOnly = false;
                    break;
                }
            }

            if (!isRowReadOnly)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.ReadOnly = true;
                    cell.Style.BackColor = Color.LightGray;
                }
            }
            else
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.ReadOnly = false;
                    cell.Style.BackColor = Color.White;
                }

            }
        }

        //Se Muestra el panel de confirmacion de venta
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
        private void dgvProducts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
        private DataGridViewRow previousSelectedRow;
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            //if (previousSelectedRow != null)
            //{
            //    previousSelectedRow.Cells["Amount"].Value = "";
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
            BLL_Sale.newSale.TypeInvoice = cBTypesInvoice.GetItemText(cBTypesInvoice.SelectedItem)[0];
            BLL_Sale.newSale.Status = checkBoxPaid.Checked;
            BLL_Sale.newOrder.DeliveryDate = DPEntrega.Date;
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
