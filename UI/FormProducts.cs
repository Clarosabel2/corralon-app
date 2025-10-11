using BDE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.common.Styles;
using UI.common.Utils;

namespace UI
{
    public partial class FormProducts : Form
    {
        List<BE_Product> products = new List<BE_Product>();
        bool isLowStock = false;
        public FormProducts()
        {
            InitializeComponent();
            ApplyStyleCommon.DGVStyle(this.dgvProducts);
            products = BLL_Product.GetProducts();
            //VerifyLowStock();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadProductsIntoDGV(products);
        }

        private void VerifyLowStock()
        {
            if (BLL_Product.isLowStock)
            {
                DialogResult result = MessageBox.Show(
                    "Hay productos con stock insuficiente. ¿Desea solicitar compra?",
                    "Stock Bajo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    FormPurchaseRequest request = new FormPurchaseRequest(products.Where(p => p.Stock <= 20).ToList());
                    request.StartPosition = FormStartPosition.CenterScreen;
                    request.FormBorderStyle = FormBorderStyle.FixedDialog;
                    request.ShowDialog();
                }
            }
        }

        void TuneImageColumn(DataGridView dgv, string imgColName, int size = 96)
        {
            // 1) Columna de imagen
            var col = (DataGridViewImageColumn)dgv.Columns[imgColName];
            col.ImageLayout = DataGridViewImageCellLayout.Zoom;
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // ancho fijo
            col.Width = size;                                // p.ej. 72/96/120

            // 2) Filas altas
            dgv.RowTemplate.Height = size;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            foreach (DataGridViewRow r in dgv.Rows) r.Height = size; // para las ya cargadas
        }


        public void LoadProductsIntoDGV(List<BE_Product> prdts = null)
        {
            dgvProducts.DataSource = null;
            dgvProducts.Columns.Clear();
            dgvProducts.Rows.Clear();
            if (prdts == null) prdts = products;
            DGVHelper.AddNewDGVColumnToDGV(new DataGridViewTextBoxColumn(),
                "ID", "productId",
                DataGridViewAutoSizeColumnMode.DisplayedCells, dgvProducts);

            DGVHelper.AddNewDGVColumnToDGV(
                new DataGridViewImageColumn(), "", "imgProduct",
                DataGridViewAutoSizeColumnMode.None, dgvProducts,
                null,
                DataGridViewImageCellLayout.Zoom,
                96);
            dgvProducts.RowTemplate.Height = 96;

            DGVHelper.AddNewDGVColumnToDGV(new DataGridViewTextBoxColumn(),
                "Categoria", "productCategory",
                DataGridViewAutoSizeColumnMode.DisplayedCells, dgvProducts);

            DGVHelper.AddNewDGVColumnToDGV(new DataGridViewTextBoxColumn(),
                "Marca", "productBrand",
                DataGridViewAutoSizeColumnMode.DisplayedCells, dgvProducts);

            DGVHelper.AddNewDGVColumnToDGV(new DataGridViewTextBoxColumn(),
                "Producto", "productName",
                DataGridViewAutoSizeColumnMode.Fill, dgvProducts);

            DGVHelper.AddNewDGVColumnToDGV(new DataGridViewTextBoxColumn(),
                "Precio", "productPrice",
                DataGridViewAutoSizeColumnMode.DisplayedCells, dgvProducts);

            DGVHelper.AddNewDGVColumnToDGV(new DataGridViewTextBoxColumn(),
                "Stock", "productStock",
                DataGridViewAutoSizeColumnMode.DisplayedCells, dgvProducts);

            DGVHelper.AddNewDGVColumnToDGV(
                new DataGridViewImageColumn(), "Acciones", "btnDelete",
                DataGridViewAutoSizeColumnMode.None, dgvProducts,
                staticImageIfImageCol: Properties.Resources.delete_icon_circle,
                layout: DataGridViewImageCellLayout.Zoom,
                fixedWidth: 70);

            DGVHelper.AddNewDGVColumnToDGV(
                new DataGridViewImageColumn(), "", "btnEdit",
                DataGridViewAutoSizeColumnMode.None, dgvProducts,
                staticImageIfImageCol: Properties.Resources.edit_icon_circle,
                layout: DataGridViewImageCellLayout.Zoom,
                fixedWidth: 70);

            #region
            //DataGridViewAutoSizeColumnMode.DisplayedCells, dgvProducts);
            //DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            //colId.HeaderText = "ID";
            //colId.Name = "productId";
            //colId.DataPropertyName = "Id";
            //colId.ReadOnly = true;
            //colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            //DataGridViewTextBoxColumn colCategory = new DataGridViewTextBoxColumn();
            //colCategory.HeaderText = "Categoria";
            //colCategory.Name = "productCategory";
            //colCategory.DataPropertyName = "Categoria";
            //colCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //colCategory.ReadOnly = true;

            //DataGridViewTextBoxColumn colBrand = new DataGridViewTextBoxColumn();
            //colBrand.HeaderText = "Marca";
            //colBrand.Name = "productBrand";
            //colBrand.DataPropertyName = "Brand";
            //colBrand.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //colBrand.ReadOnly = true;

            //DataGridViewTextBoxColumn colNameProducts = new DataGridViewTextBoxColumn();
            //colNameProducts.HeaderText = "Nombre del Producto";
            //colNameProducts.Name = "product";
            //colNameProducts.DataPropertyName = "Name";
            //colNameProducts.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //colNameProducts.ReadOnly = true;

            //DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn();
            //colPrice.HeaderText = "Precio";
            //colPrice.Name = "productPrice";
            //colPrice.DataPropertyName = "Price";
            //colPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //colPrice.ReadOnly = true;

            //DataGridViewTextBoxColumn colStock = new DataGridViewTextBoxColumn();
            //colStock.HeaderText = "Stock";
            //colStock.Name = "productStock";
            //colStock.DataPropertyName = "Stock";
            //colStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //colStock.ReadOnly = true;



            //DataGridViewImageColumn colProductImage = new DataGridViewImageColumn();
            //colProductImage.HeaderText = "Image";
            //colProductImage.Name = "imgProduct";
            //colProductImage.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //dgvProducts.Columns.Add(colId);
            //dgvProducts.Columns.Add(colProductImage);
            //dgvProducts.Columns.Add(colCategory);
            //dgvProducts.Columns.Add(colBrand);
            //dgvProducts.Columns.Add(colNameProducts);
            //dgvProducts.Columns.Add(colPrice);
            //dgvProducts.Columns.Add(colStock);

            //            Image imageIfImageCol = null,
            //DataGridViewImageCellLayout? dgvImageCellLayout = null,
            //DataGridViewImageColumn btnDeleteCol = new DataGridViewImageColumn();
            //ConfigButtonActionDGV(btnDeleteCol, Properties.Resources.delete_icon_circle, "btnDelete");

            //dgvProducts.Columns.Add(btnDeleteCol);

            //DataGridViewImageColumn btnEditCol = new DataGridViewImageColumn();
            //ConfigButtonActionDGV(btnEditCol, Properties.Resources.edit_icon_circle, "btnEdit");

            //dgvProducts.Columns.Add(btnEditCol);
            #endregion


            foreach (var p in prdts)
            {
             
                var img = ImageLoader.LoadSafe(p.ImagePath) ?? Properties.Resources.img_icon;
                int rowIndex = dgvProducts.Rows.Add(
                    p.Id,
                    img,
                    p.Category,
                    p.Brand.NameBrand,
                    p.Name,
                    p.Price,
                    p.Stock,
                    null,
                    null
                );
                if (p.Stock <= p.MinStock)
                {
                    DataGridViewRow row = dgvProducts.Rows[rowIndex];
                    row.DefaultCellStyle.BackColor = Color.DarkOrange;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
            TuneImageColumn(dgvProducts, "imgProduct", 96);
            lblCantProducts.Text = $"{(prdts.Count).ToString()}";
        }
        

        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            FormRegisterProduct fm = new FormRegisterProduct(0, this);
            fm.StartPosition = FormStartPosition.CenterScreen;
            fm.FormBorderStyle = FormBorderStyle.FixedDialog;
            fm.ShowDialog();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Evita errores si el usuario hace clic en el encabezado

            int productId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[0].Value);
            string productName = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();

            // Click en botón "Eliminar"
            if (e.ColumnIndex == dgvProducts.Columns["btnDelete"].Index)
            {
                var result = MessageBox.Show($"¿Eliminar el producto ID: {productId} - {productName}?",
                                             "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Llamar a la capa de negocio para eliminar el producto
                    BLL_Product.DeleteProductById(productId);

                    // Verificar si la fila aún existe antes de eliminar
                    if (e.RowIndex < dgvProducts.Rows.Count)
                    {
                        dgvProducts.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
            // Click en botón "Editar"
            else if (e.ColumnIndex == dgvProducts.Columns["btnEdit"].Index)
            {
                FormRegisterProduct fm = new FormRegisterProduct(productId, this);
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.ShowDialog();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string word = txtSearch.Text.Trim().ToLower();
            List<BE_Product> prdtsFiltered = products.Where(p =>
                p.Name.ToLower().Contains(word) ||
                p.Brand.NameBrand.ToLower().Contains(word) ||
                p.Category.ToLower().Contains(word)).ToList();
            LoadProductsIntoDGV(prdtsFiltered);
            if (word == String.Empty)
            {
                LoadProductsIntoDGV(products);
            }
        }
    }
}
