using BDE;
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
    public partial class FormRegisterProduct : Form
    {
        BE_Product product = new BE_Product();
        bool isEdit = false;
        public FormRegisterProduct(int idprdt = 0)
        {
            InitializeComponent();
            LoadData();
            if (idprdt != 0)
            {
                isEdit = true;
                LoadProductToEdit(idprdt);
            }
        }

        private void LoadProductToEdit(int id)
        {
            product = BLL_Product.GetProductById(id);
            txtNameProduct.Text = product.Name;
            txtDescriptionProduct.Text = product.Description;
            txtPriceProduct.Text = product.Price.ToString();
            txtStockAvailibleProduct.Text = product.Stock.ToString();

            cbBrands.SelectedIndex = cbBrands.FindStringExact(product.Brand.NameBrand);
            cbCategoryProduct.SelectedIndex = cbCategoryProduct.FindStringExact(product.Category);

        }
        private void LoadData()
        {
            DataTable dtCategorias = BLL_Product.GetCaterogyProducts();
            DataRow rowTodos = dtCategorias.NewRow();

            cbCategoryProduct.DataSource = dtCategorias;
            cbCategoryProduct.DisplayMember = "nombreCategoria";
            cbCategoryProduct.ValueMember = "id_Categoria";

            List<BE_Brand> brands = BLL_Brand.GetAllBrands();
            cbBrands.DataSource = brands;
            cbBrands.DisplayMember = "NameBrand";
            cbBrands.ValueMember = "Id";
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            var b = new BE_Brand();
            b.Id = int.Parse(cbBrands.SelectedValue.ToString());
            b.NameBrand = cbBrands.SelectedText;

            product = new BE_Product(
                (isEdit) ? product.Id : 0,
                b,
                txtNameProduct.Text,
                txtDescriptionProduct.Text,
                cbCategoryProduct.SelectedValue.ToString(),
                double.Parse(txtPriceProduct.Text),
                int.Parse(txtStockAvailibleProduct.Text));

            if (!isEdit)
            {
                BLL_Product.SaveProduct(product);
            }
            else
            {
                BLL_Product.UpdateProduct(product);
            }

        }
    }
}
