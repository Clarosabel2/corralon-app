using BDE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormCreateEmployee : Form
    {
        private bool flagValidation = false;
        FormEmployees form = new FormEmployees();
        public FormCreateEmployee(FormEmployees fp = null)
        {
            InitializeComponent();
            LoadData();
            if (fp != null)
            {
                form = fp;
            }
        }
        private void LoadData()
        {
            foreach (var item in Enum.GetValues(typeof(BE_Area)))
            {
                cBAreas.Items.Add(item);
            }
        }
        #region "Validaciones"
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if ((sender as TextBox).Text.Length >= 8 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

            string email = (sender as TextBox).Text;
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if ((sender as TextBox).Text != "")
            {
                if (!Regex.IsMatch(email, pattern))
                {
                    MessageBox.Show("Correo electrónico no válido");
                    flagValidation = false;

                }
                else
                {
                    flagValidation = true;
                }
            }
            ValidFields();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ValidFields();
        }

        private void ValidFields()
        {
            if (string.IsNullOrEmpty(txtDni.Text) || string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) || !flagValidation)
            {
                btnSaveEmployee.Enabled = false;
            }
            else
            {
                btnSaveEmployee.Enabled = true;
            }
        }
        #endregion

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            BE_Employee emp = new BE_Employee(
                0,
                int.Parse(txtDni.Text),
                txtNombre.Text,
                txtApellido.Text, txtDomicilio.Text, txtEmail.Text, int.Parse(txtTelefono.Text), 0.0, cBAreas.Text);

            if (BLL_Employee.SaveEmployee(emp))
            {
                DialogResult r = MessageBox.Show("Se guardó el nuevo empleado exitosamente", "Aviso");
                if (r == DialogResult.OK)
                {
                    form.LoadData();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar el empleado", "Aviso");
            }
        }
    }
}
