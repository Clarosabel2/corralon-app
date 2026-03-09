using BDE;
using BLL;
using BLL.Interfaces;
using BLL.Inventory;
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
        private readonly IProductService _productService;
        private readonly IBrandService _brandService;

        Product product = new Product();
        FormProducts fm;
        List<Brand> brands = new List<Brand>();
        bool isEdit = false;
        
        public FormRegisterProduct(IProductService productService, IBrandService brandService, int idprdt = 0, FormProducts fmPrdts = null)
        {
            InitializeComponent();

            _productService = productService;
            _brandService = brandService;
            this.fm = fmPrdts;
            brands = _brandService.GetAll();

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
            product = _productService.GetProductById(id);
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
            DataTable dtCategorias = _productService.GetCaterogyProducts();
            DataRow rowTodos = dtCategorias.NewRow();

            cbCategoryProduct.DataSource = dtCategorias;
            cbCategoryProduct.DisplayMember = "nombreCategoria";
            cbCategoryProduct.ValueMember = "id_Categoria";

            brands.ForEach(b => cbBrands.Items.Add(new KeyValuePair<Brand, string>(b, $"{b.NameBrand}")));
            cbBrands.DisplayMember = "Value";
            cbBrands.ValueMember = "Key";
            cbBrands.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbBrands.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnSaveProduct_Click_1(object sender, EventArgs e)
        {
            string inputBrand = cbBrands.Text.Trim();
            Product currentProduct = new Product();

            /*var existingBrand = (cbBrands.DataSource as List<BE_Brand>)
                .FirstOrDefault(brand => brand.NameBrand.Equals(inputBrand, 
                    StringComparison.OrdinalIgnoreCase));*/

            Brand brandSelected = brands.FirstOrDefault(b =>
                b.NameBrand.Equals(inputBrand, StringComparison.OrdinalIgnoreCase));


            if (brandSelected == null)
            {
                brandSelected = new Brand();
                brandSelected.NameBrand = inputBrand;
                _brandService.Save(brandSelected);
            }
            try
            {

                currentProduct = new Product(
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
                    _productService.SaveProduct(currentProduct, (pictureBoxImgProduct.ImageLocation != product.ImagePath));
                }
                else
                {
                    _productService.UpdateProduct(currentProduct, (pictureBoxImgProduct.ImageLocation != product.ImagePath));
                }
                fm.LoadProductsIntoDGV(_productService.GetProducts());
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
