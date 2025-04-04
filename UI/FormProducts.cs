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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "ID";
            col1.Name = "productId";
            col1.DataPropertyName = "Id";
            col1.ReadOnly = true;

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Categoria";
            col2.Name = "productCategory";
            col2.DataPropertyName = "Categoria";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col2.ReadOnly = true;

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Marca";
            col3.Name = "productBrand";
            col3.DataPropertyName = "Brand";
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col3.ReadOnly = true;

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Nombre del Producto";
            col4.Name = "product";
            col4.DataPropertyName = "Name";
            col4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col4.ReadOnly = true;

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Precio";
            col5.Name = "productPrice";
            col5.DataPropertyName = "Price";
            col5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col5.ReadOnly = true;

            DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
            col6.HeaderText = "Stock";
            col6.Name = "productStock";
            col6.DataPropertyName = "Stock";
            col6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col6.ReadOnly= true;

            DataGridViewImageColumn btnDeleteCol = new DataGridViewImageColumn();
            btnDeleteCol.HeaderText = "Acciones";
            //btnDeleteCol.Text = "Eliminar";
            btnDeleteCol.Image = Properties.Resources.delete_icon_circle;
            btnDeleteCol.Name = "btnDelete";
            btnDeleteCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn btnEditCol = new DataGridViewImageColumn();
            btnEditCol.HeaderText = " ";
            btnEditCol.Image = Properties.Resources.edit_icon_circle;
            btnEditCol.Name = "btnEdit";
            btnEditCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgvProducts.Columns.Add(col1);
            dgvProducts.Columns.Add(col2);
            dgvProducts.Columns.Add(col3);
            dgvProducts.Columns.Add(col4);
            dgvProducts.Columns.Add(col5);
            dgvProducts.Columns.Add(col6);
            dgvProducts.Columns.Add(btnDeleteCol);
            dgvProducts.Columns.Add(btnEditCol);

            BLL_Product.GetProducts().ForEach(p => dgvProducts.Rows.Add(p.Id, p.Category, p.Brand.NameBrand, p.Name, p.Price, p.Stock));
        }
        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            FormRegisterProduct fm = new FormRegisterProduct();
            fm.StartPosition = FormStartPosition.CenterScreen;
            fm.FormBorderStyle = FormBorderStyle.FixedDialog;
            fm.ShowDialog();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return; // Evita errores si el usuario hace clic en el encabezado

            int productId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[0].Value);
            string productName = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();

            // Clic en botón "Eliminar"
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
            // Clic en botón "Editar"
            else if (e.ColumnIndex == dgvProducts.Columns["btnEdit"].Index)
            {
                FormRegisterProduct fm = new FormRegisterProduct(productId);
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.ShowDialog();
            }
        }
    }
}
