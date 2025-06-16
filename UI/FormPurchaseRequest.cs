using BDE;
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
    public partial class FormPurchaseRequest : Form
    {
        public FormPurchaseRequest(List<BE_Product> productsWithLowStock)
        {
            InitializeComponent();
            LoadProductsIntoDGV(productsWithLowStock);
        }

        private void LoadProductsIntoDGV(List<BE_Product> products)
        {
            dgvLowStockProducts.AutoGenerateColumns = false;
            dgvLowStockProducts.Columns.Clear();

            dgvLowStockProducts.Columns.Add("Brand", "Brand");
            dgvLowStockProducts.Columns.Add("Name", "Product Name");
            dgvLowStockProducts.Columns.Add("Stock", "Stock");

            dgvLowStockProducts.Rows.Clear();
            foreach (var p in products)
            {
                dgvLowStockProducts.Rows.Add(p.Brand.NameBrand, p.Name, p.Stock);
            }
        }
    }
}
