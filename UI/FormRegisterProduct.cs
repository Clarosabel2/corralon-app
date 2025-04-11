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
        FormProducts fm = new FormProducts();
        List<BE_Brand> brands = new List<BE_Brand>();
        bool isEdit = false;
        public FormRegisterProduct(int idprdt = 0, FormProducts fmPrdts = null)
        {
            InitializeComponent();
            fm = fmPrdts;
            brands = BLL_Brand.GetAllBrands();
            if (idprdt != 0)
            {
                isEdit = true;
                LoadProductToEdit(idprdt);
            }
            LoadData();
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

            brands.ForEach(b => cbBrands.Items.Add(new KeyValuePair<BE_Brand, string>(b, $"{b.NameBrand}")));
            cbBrands.DisplayMember = "Value";
            cbBrands.ValueMember = "Key";
            cbBrands.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbBrands.AutoCompleteSource = AutoCompleteSource.ListItems;

            

        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            string inputBrand = cbBrands.Text.Trim();

            /*var existingBrand = (cbBrands.DataSource as List<BE_Brand>)
                .FirstOrDefault(brand => brand.NameBrand.Equals(inputBrand, 
                    StringComparison.OrdinalIgnoreCase));*/

            BE_Brand brandSelected = brands.FirstOrDefault(b =>
                b.NameBrand.Equals(inputBrand, StringComparison.OrdinalIgnoreCase));


            if (brandSelected == null)
            {
                brandSelected = new BE_Brand();
                brandSelected.NameBrand = inputBrand;
                BLL_Brand.SaveBrand(brandSelected);

            }

            product = new BE_Product(
                (isEdit) ? product.Id : 0,
                brandSelected,
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
            fm.LoadProductsIntoDGV();
            this.Close();
        }
    }
}
