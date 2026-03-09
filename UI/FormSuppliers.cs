using BDE;
using BLL;
using BLL.Interfaces;
using BLL.Inventory;
using BLL.Purchases;
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
using UI.FormsRegister;

namespace UI.FormsViewData
{
    public partial class FormSuppliers : Form
    {
        private readonly ISupplierService _supplierService;
        private readonly IBrandService _brandService;
        private List<Supplier> Suppliers { get; set; }
        public FormSuppliers(ISupplierService supplierService, IBrandService brandService)
        {
            InitializeComponent();
            _supplierService = supplierService;
            _brandService = brandService;

            Suppliers = _supplierService.GetAll();

            ApplyStyleCommon.DGVStyle(this.dgvSuppliers);
            ApplyStyleCommon.DGVStyle(this.dgvBrands);
            //ResxExporter.ExportControlsFormToResx(this);
        }

        private void SetupSupplierColumns()
        {
            dgvSuppliers.Columns.Clear();

            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdSupplier",
                HeaderText = "ID",
                DataPropertyName = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });
            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CompanyName",
                HeaderText = "Company Name",
                DataPropertyName = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ContactName",
                HeaderText = "Contact Name",
                DataPropertyName = "ContactName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "Email",
                DataPropertyName = "ContactEmail",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                HeaderText = "Phone",
                DataPropertyName = "ContactPhone",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Address",
                HeaderText = "Address",
                DataPropertyName = "Address",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }
        private void SetupBrandColumns()
        {
            dgvBrands.Columns.Clear();

            dgvBrands.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id", // Asegurate de que BE_Brand tenga esta propiedad
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dgvBrands.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NameBrand",
                HeaderText = "Brand Name",
                DataPropertyName = "NameBrand", // Asegurate que la propiedad se llame así
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }
        private void LoadSuppliers()
        {
            Suppliers.ForEach(s => dgvSuppliers.Rows.Add(s.Id, s.Name, s.ContactName, s.ContactEmail, s.ContactPhone, s.Address));
        }

        private void btnRegisterSupplier_Click(object sender, EventArgs e)
        {
            FormRegisterSupplier fm = new FormRegisterSupplier(_brandService, _supplierService);
            fm.StartPosition = FormStartPosition.CenterParent;
            fm.FormBorderStyle = FormBorderStyle.FixedDialog;
            fm.ShowDialog();
        }

        private void FormSuppliers_Load(object sender, EventArgs e)
        {
            SetupSupplierColumns();
            SetupBrandColumns();
            LoadSuppliers();
        }

        private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSuppliers.CurrentRow != null)
            {
                int supplierId = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells["IdSupplier"].Value);
                List<Brand> brandsAssociated = Suppliers.FirstOrDefault(s => s.Id == supplierId)?.BrandsAssociated;
                dgvBrands.Rows.Clear();
                brandsAssociated?.ForEach(b => dgvBrands.Rows.Add(b.Id, b.NameBrand));
            }
        }
    }
}
