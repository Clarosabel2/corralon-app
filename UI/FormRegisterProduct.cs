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
        FormProducts fm;
        List<BE_Brand> brands = new List<BE_Brand>();
        bool isEdit = false;
        public FormRegisterProduct(int idprdt = 0, FormProducts fmPrdts = null)
        {
            InitializeComponent();
            ApplyModernStyle();
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

        private void ApplyModernStyle()
        {
            // ===== Paleta
            Color Primary = ColorTranslator.FromHtml("#06406A");
            Color PrimaryMid = ColorTranslator.FromHtml("#0A5C99");
            Color BgForm = ColorTranslator.FromHtml("#F5F7FA");
            Color TextPrimary = ColorTranslator.FromHtml("#1F2937");
            Color TextMuted = ColorTranslator.FromHtml("#6B7280");
            Color LineColor = ColorTranslator.FromHtml("#D9E2EC");

            // ===== Form
            this.BackColor = BgForm;
            this.Font = new Font("Century Gothic", 10.5f, FontStyle.Regular);

            // ===== Labels (alineación y color)
            Label[] labels = { lblBrand, lblCategory, lblNameProduct, lblDescriptionProduct, lblPrice, lblStockAvailable };
            foreach (var lb in labels)
            {
                lb.ForeColor = TextPrimary;
                lb.Font = new Font("Century Gothic", 10.5f, FontStyle.Regular);
            }

            // ===== ComboBoxes
            ComboBox[] combos = { cbBrands, cbCategoryProduct };
            foreach (var cb in combos)
            {
                cb.FlatStyle = FlatStyle.Flat;
                cb.BackColor = Color.White;
                cb.ForeColor = TextPrimary;
                cb.Font = new Font("Century Gothic", 10.5f, FontStyle.Regular);
                cb.IntegralHeight = false;
                cb.MaxDropDownItems = 8;
            }

            // ===== TextBoxes con estilo "subrayado"
            TextBox[] tbs = { txtNameProduct, txtDescriptionProduct, txtPriceProduct, txtStockAvailibleProduct };
            foreach (var tb in tbs)
            {
                tb.BorderStyle = BorderStyle.None;          // sin borde
                tb.BackColor = Color.White;
                tb.ForeColor = TextPrimary;
                tb.Font = new Font("Century Gothic", 10.5f, FontStyle.Regular);
                tb.Multiline = false;
                tb.Height = 24;

                // Línea inferior (como Material Design)
                var underline = new Panel
                {
                    Height = 1,
                    Dock = DockStyle.Bottom,
                    BackColor = LineColor
                };
                tb.Parent.Controls.Add(underline);
                underline.BringToFront();

                // Hover/focus: línea azul
                tb.Enter += (s, e) => underline.BackColor = PrimaryMid;
                tb.Leave += (s, e) => underline.BackColor = LineColor;
            }

            // ===== Botón primario moderno
            btnSaveProduct.FlatStyle = FlatStyle.Flat;
            btnSaveProduct.FlatAppearance.BorderSize = 0;
            btnSaveProduct.BackColor = Primary;
            btnSaveProduct.ForeColor = Color.White;
            btnSaveProduct.Font = new Font("Century Gothic", 10.5f, FontStyle.Bold);
            btnSaveProduct.Height = 44;
            btnSaveProduct.Width = 180;
            btnSaveProduct.Text = "Guardar";
            btnSaveProduct.Cursor = Cursors.Hand;
            btnSaveProduct.FlatAppearance.MouseOverBackColor = PrimaryMid;

            // Ubicación más lógica (centro inferior)
            btnSaveProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveProduct.Location = new Point(this.ClientSize.Width - btnSaveProduct.Width - 24,
                                                this.ClientSize.Height - btnSaveProduct.Height - 24);

            // ===== Sugerencia de layout (opcional, pero ayuda mucho):
            // Usa un TableLayoutPanel de 2 columnas (labels/inputs) con Padding=24 y RowPadding=10
            // para que todo quede alineado y responsivo al redimensionar.
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
