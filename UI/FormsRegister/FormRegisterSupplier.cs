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

namespace UI.FormsRegister
{
    public partial class FormRegisterSupplier : Form
    {
        public FormRegisterSupplier()
        {
            InitializeComponent();
        }
        private void FormRegisterSupplier_Load(object sender, EventArgs e)
        {
            var brands = BLL_Brand.GetAllBrands();
            foreach (var brand in brands)
            {
                checkedListBoxBrands.Items.Add(brand, false); // Agregás el objeto completo
            }

            checkedListBoxBrands.DisplayMember = "NameBrand";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string validationError = ValidateSupplierFields();
            if (validationError != null)
            {
                MessageBox.Show(validationError, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BE_Supplier newSup = new BE_Supplier(
                txtCompanyName.Text.Trim(),
                txtContactName.Text.Trim(),
                txtEmail.Text.Trim(),
                txtPhone.Text.Trim(),
                txtAddress.Text.Trim()
                );

            var selectedBrands = new List<BE_Brand>();
            foreach (var item in checkedListBoxBrands.CheckedItems)
            {
                selectedBrands.Add((BE_Brand)item);
            }

            newSup.BrandsAssociated = selectedBrands;

            if (selectedBrands.Count == 0)
            {
                MessageBox.Show("Please select at least one brand.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BLL_Supplier.RegisterSupplier(newSup))
            {
                MessageBox.Show("Supplier registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to register supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidateSupplierFields()
        {
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
                return "Company name is required.";
            if (string.IsNullOrWhiteSpace(txtContactName.Text))
                return "Contact name is required.";
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                return "Email is required.";
            if (!txtEmail.Text.Contains("@"))
                return "Invalid email format.";
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
                return "Phone number is required.";
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
                return "Address is required.";

            return null; // Todo válido
        }

    }
}
