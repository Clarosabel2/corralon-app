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
    public partial class FormEmployeeDetails : Form
    {
        public BE_Employee empCurrent { get; set; }
        public FormEmployeesPhoto form { get; set; }
        public FormEmployeeDetails(BE_Employee emp)
        {
            InitializeComponent();
            empCurrent = emp;
            LoadDataEmployee(empCurrent);
        }
        public void LoadDataEmployee(BE_Employee e)
        {
            guna2CirclePictureBox1.Image = Properties.Resources.user_photo_profile;
            bigLabelFullname.Text = $"{e.Name} {e.Lastname}";
            LabelDNI.Text = $"<b>DNI:</b> {e.Dni}";
            LabelAddress.Text = $"<b>Dirección:</b> {e.Address}";
            LabelArea.Text = $"<b>Área:</b> {e.Area}";
            LabelEmail.Text = $"<b>Email:</b> {e.Email} <a href=\"mailto:{e.Email}\">\r\n  Enviar correo\r\n</a>";
            LabelPhone.Text = $"<b>Teléfono:</b> {e.NumPhone} <a href=\"https://wa.me/{e.NumPhone}\" target=\"_blank\">\r\n  Contactar\r\n</a>";
            LabelDateAdmission.Text = $"<b>Fecha de Ingreso:</b> 12/05/2024";
            LabelStatus.Text = $"<b>Estado:</b> Activo";
            if (BLL_User.ExistUserById(e.Id))
            {
                btnCreateUser.Enabled = false;
                btnCreateUser.Text = "Empleado tiene acceso al sistema";
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            FormCreateUser f = new FormCreateUser(empCurrent);
            f.BringToFront();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar el empleado?", "Eliminar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                form.LoadData(BLL_Employee.GetAllEmployees());
                this.Close();
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            FormCreateEmployee f = new FormCreateEmployee(empCurrent);
            f.formEmpDatails = this;
            f.BringToFront();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void FormEmployeeDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.LoadData(BLL_Employee.GetAllEmployees());
        }
    }
}
