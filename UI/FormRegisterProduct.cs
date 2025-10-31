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
using UI.common.Utils;

namespace UI
{
    public partial class FormRegisterProduct : Form
    {
        BE_Product product = new BE_Product();
        FormProducts fm;
        List<BE_Brand> brands = new List<BE_Brand>();
        bool isEdit = false;
        public FormRegisterProduct(int idprdt = 0, FormProducts fmPrdts = null)
        {
            InitializeComponent();
            this.fm = fmPrdts;
            brands = BLL_Brand.GetAllBrands();
            LoadData();
            if (idprdt != 0)
            {
                isEdit = true;
                this.Text = "Editar Producto";
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
            txtMinStock.Text = product.MinStock.ToString();

            cbBrands.SelectedIndex = cbBrands.FindStringExact(product.Brand.NameBrand);
            cbCategoryProduct.SelectedIndex = cbCategoryProduct.FindStringExact(product.Category);

            pictureBoxImgProduct.Image = ImageLoader.LoadSafe(product.ImagePath) ?? Properties.Resources.img_icon;
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

        private void btnSaveProduct_Click_1(object sender, EventArgs e)
        {
            string inputBrand = cbBrands.Text.Trim();
            BE_Product currentProduct = new BE_Product();

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
            try
            {

                currentProduct = new BE_Product(
                    (isEdit) ? product.Id : 0,
                    brandSelected,
                    txtNameProduct.Text,
                    txtDescriptionProduct.Text,
                    cbCategoryProduct.SelectedValue.ToString(),
                    double.Parse(txtPriceProduct.Text),
                    int.Parse(txtStockAvailibleProduct.Text));
                currentProduct.MinStock = int.Parse(txtMinStock.Text);
                currentProduct.ImagePath = _imagePath ?? product.ImagePath;


                if (!isEdit)
                {
                    BLL_Product.SaveProduct(currentProduct, (pictureBoxImgProduct.ImageLocation != product.ImagePath));
                }
                else
                {
                    BLL_Product.UpdateProduct(currentProduct, (pictureBoxImgProduct.ImageLocation != product.ImagePath));
                }
                fm.LoadProductsIntoDGV(BLL_Product.GetProducts());
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto. Verifique los datos ingresados. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string _imagePath = null;
        private void btnLoadImgProduct_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar imagen de producto";
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxImgProduct.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBoxImgProduct.Image = Image.FromFile(ofd.FileName);
                    _imagePath = ofd.FileName;
                }
                btnDeleteImgProduct.Enabled = true;
            }
        }

        private void btnDeleteImgProduct_Click(object sender, EventArgs e)
        {
            pictureBoxImgProduct.Image = Properties.Resources.img_icon;
            _imagePath = null;
            // Opcional: deshabilitar el botón hasta que carguen otra
            btnDeleteImgProduct.Enabled = false;
        }
    }
}
