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

        private void FormProducts_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = BLL_Product.GetProducts();
            dgvProducts.ColumnHeadersVisible = true;
            foreach (DataGridViewColumn columna in dgvProducts.Columns)
            {
                columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnUpdateProducts_Click(object sender, EventArgs e)
        {
            DataTable dt = dgvProducts.DataSource as DataTable;
            var f = BLL_Product.UpdateProducts(dt);
        }
    }
}
