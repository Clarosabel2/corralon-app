using BDE;
using BDE.Language;
using BLL;
using BLL.Interfaces;
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

        private readonly IProductService _productService;
        private readonly ISaleService _saleService;
        private Sale _currentSale;

        private List<Product> _listProducts;
        private const string PRODUCT_FORMAT = "BE_Product";
        public FormCreateSale(
            IProductService productService,
            ISaleService saleService)
        {
            InitializeComponent();
            _productService = productService;
            _saleService = saleService;
            _currentSale = new Sale();

            _listProducts = _productService.GetProducts();
            ConfigFilters();
            ConfigDGVs();

            LoadProducts(_listProducts);
            LanguageManager.Attach(this);
        }


        #region "Funciones Carga de Datos a DGV"
        private void ConfigFilters()
        {
            DataTable dtCategorias = _productService.GetCaterogyProducts();

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

                var item = _currentSale.ItemsProducts.FirstOrDefault(i => i.Id == idxExist);

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
                    _currentSale.CalculateTotal();
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

            int productId = _listProducts.FirstOrDefault(p => p.Id == id).Id;

            var data = new DataObject();
            data.SetData(typeof(int), productId);
            dgvProducts.DoDragDrop(data, DragDropEffects.Copy);

        }

        private void DgvProductsCart_DragEnter(object sender, DragEventArgs e)
        {
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
            Item itemCart = _currentSale.ItemsProducts.FirstOrDefault(item => item.Product.Id == productId);
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
                Product product = _listProducts.FirstOrDefault(p => p.Id == productId);
                var item = new Item(_currentSale.ItemsProducts.Count, product, 1);
                _currentSale.AddItem(item);
                RefreshDgvProductsStock(product, item.Amount);

                dgvProductsCart.Rows.Add(
                    item.Id,
                    ImageLoader.LoadSafe(item.Product.ImagePath) ?? Properties.Resources.img_icon,
                    item.Product.Name,
                    "$ " + item.Product.Price,
                    "$ " + item.Subtotal,
                    item.Amount
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo agregar el producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            _currentSale.CalculateTotal();
            UpdateDetailsCart();
        }
        private void RefreshDgvProductsStock(Product product, int quantity)
        {
            foreach (DataGridViewRow r in dgvProducts.Rows)
            {
                if (int.TryParse(r.Cells["IDProduct"].Value?.ToString(), out var idValue) && idValue == product.Id)
                {
                    r.Cells["stockProduct"].Value = product.Stock - quantity;
                }
            }
        }
        private void LoadProducts(List<Product> prdts)
        {
            dgvProducts.Rows.Clear();
            if (prdts is null) MessageBox.Show("lista null");

            BindingList<Product> p = new BindingList<Product>(prdts);
            foreach (Product item in p)
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

        private void buttonCerrarVenta_Click(object sender, EventArgs e)
        {
            if (dgvProductsCart.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito. No se puede cerrar.");

            }
            else
            {
                FormFinalizeSale fm = new FormFinalizeSale(_saleService, _currentSale);
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

        private void UpdateDetailsCart()
        {
            double totalCartValue = _currentSale.Total;
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
                var prdtsFiltered = new List<Product>();

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
                var prdtsFiltered = new List<Product>();
                string selectedCategory = ((DataRowView)cBTipoProductos.SelectedItem)["nombreCategoria"].ToString();
                prdtsFiltered = _listProducts.Where(p => p.Category == selectedCategory).ToList();
                LoadProducts(prdtsFiltered);
            }

        }

        public void Update(Language language)
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
