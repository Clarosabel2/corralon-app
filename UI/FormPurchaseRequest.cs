using BDE;
using BLL;
using SVC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.common.Styles;

namespace UI
{
    public partial class FormPurchaseRequest : Form
    {
        private List<BE_Supplier> _suppliers = BLL_Supplier.GetAllSuppliers();
        public FormPurchaseRequest(List<BE_Product> productsWithLowStock)
        {
            InitializeComponent();
            ApplyStyleCommon.DGVStyle(this.dgvLowStockProducts);
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

        private void btnRequestPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                EmailSender.SendEmail(lblEmail.Text, "StocK Request", "Please send stock...");
                MessageBox.Show("Purchase request sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send purchase request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void ClearSupplierDetails()
        {
            lblAddress.Text = "-";
            lblEmail.Text = "-";
            lblPhone.Text = "-";
        }
        private void dgvLowStockProducts_SelectionChanged(object sender, EventArgs e)
        {
            cbSuppliers.Items.Clear();
            ClearSupplierDetails();
            if (dgvLowStockProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dgvLowStockProducts.SelectedRows[0];
                var brandName = selectedRow.Cells["Brand"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(brandName)) return;

                var suppliers = _suppliers
                    .Where(s => s.BrandsAssociated.Any(b => b.NameBrand == brandName))
                    .ToList();

                foreach (var supplier in suppliers)
                {   
                    cbSuppliers.Items.Add(supplier.Name);
                }

                if (cbSuppliers.Items.Count > 0)
                    cbSuppliers.SelectedIndex = 0;
            }
        }

        private void cbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if (cbSuppliers.SelectedIndex >= 0)
            {
                var selectedSupplierName = cbSuppliers.SelectedItem.ToString();
                var selectedSupplier = _suppliers.FirstOrDefault(s => s.Name == selectedSupplierName);

                if (selectedSupplier != null)
                {
                    lblAddress.Text = selectedSupplier.Address;
                    lblEmail.Text = selectedSupplier.ContactEmail;
                    lblPhone.Text = selectedSupplier.ContactPhone;
                }
            }
        }
    }
}
