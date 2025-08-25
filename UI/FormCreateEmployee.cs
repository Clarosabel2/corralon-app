using BDE;
using BLL;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UI
{
    public partial class FormCreateEmployee : Form
    {
        private bool flagValidation = false;
        bool isEdit = false;
        public FormEmployeesPhoto formPre { get; set; }
        public FormEmployeeDetails formEmpDatails { get; set; }

        BE_Employee empEdit = new BE_Employee();
        public FormCreateEmployee(BE_Employee emp = null)
        {
            InitializeComponent();
            LoadData(emp);
            if (emp != null)
            {
                empEdit = emp;
                isEdit = true;
                btnSaveEmployee.Enabled = true;
                btnSaveEmployee.Text = "Modificar";
            }
        }
        private void LoadData(BE_Employee emp)
        {
            foreach (var item in Enum.GetValues(typeof(BE_Area)))
            {
                cBAreas.Items.Add(item);
            }
            if (emp != null)
            {
                txtDni.Text = emp.Dni.ToString();
                txtNombre.Text = emp.Name;
                txtApellido.Text = emp.Lastname;
                txtDomicilio.Text = emp.Address;
                txtEmail.Text = emp.Email;
                txtTelefono.Text = emp.NumPhone.ToString();
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
                isEdit ? empEdit.Id : 0,
                int.Parse(txtDni.Text),
                txtNombre.Text,
                txtApellido.Text,
                txtDomicilio.Text,
                txtEmail.Text,
                int.Parse(txtTelefono.Text),
                0.0,
                cBAreas.SelectedItem.ToString());

            if (!isEdit)
            {
                if (BLL_Employee.SaveEmployee(emp))
                {
                    DialogResult r = MessageBox.Show("Se guardó el nuevo empleado exitosamente", "Aviso");
                    if (r == DialogResult.OK)
                    {
                        formPre.ShowEmployees(BLL_Employee.GetAllEmployees());
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar el empleado", "Aviso");
                }
            }
            else
            {
                if (BLL_Employee.UpdateEmployee(emp))
                {
                    DialogResult r = MessageBox.Show("Se modificaron los datos del empleado exitosamente", "Aviso");
                    if (r == DialogResult.OK)
                    {
                        formEmpDatails.Refresh();
                        formEmpDatails.LoadDataEmployee(emp);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al modificar el empleado", "Aviso");
                }
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnTakePhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
