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
            col1.ReadOnly= true;

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Marca";
            col2.Name = "productBrand";
            col2.DataPropertyName = "Brand";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col2.ReadOnly = true;

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Nombre del Producto";
            col3.Name = "product";
            col3.DataPropertyName = "Name";
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col3.ReadOnly = true;

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Precio";
            col4.Name = "productPrice";
            col4.DataPropertyName = "Price";
            col4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Stock";
            col5.Name = "productStock";
            col5.DataPropertyName = "Stock";
            col5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvProducts.Columns.Add(col1);
            dgvProducts.Columns.Add(col2);
            dgvProducts.Columns.Add(col3);
            dgvProducts.Columns.Add(col4);
            dgvProducts.Columns.Add(col5);

            BLL_Product.GetProducts().ForEach(p => dgvProducts.Rows.Add(p.Id, p.Brand, p.Name, p.Price, p.Stock));
        }
        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUpdateProducts_Click(object sender, EventArgs e)
        {
            DataTable dt = dgvProducts.DataSource as DataTable;
            var f = BLL_Product.UpdateProducts(dt);
        }
    }
}
