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
            if (BLL_User.ExistUserById(e.Id))
            {
                var user = BLL_User.GetUserById(e.Id);

                btnResetPassword.Visible = true;
                lblRolTitle.Visible = true;
                lblRol.Visible = true;
                lblUsernameTitle.Visible = true;
                lblUsername.Visible = true;

                lblRol.Text = user.Rol.ToString();
                lblUsername.Text = user.Username.ToString();
                if (BLL_User.CheckStatusUser(e.Id))
                {
                    LabelStatus.Visible = true;
                    LabelStatus.Text = $"<b>Estado: </b> {(BLL_User.CheckStatusUser(e.Id) ? "Activo" : "Bloqueado")}";
                    btnCreateUser.Tag = "BlockAccess";
                    btnCreateUser.Text = "Bloquear usuario";
                }
                else
                {
                    LabelStatus.Visible = true;
                    LabelStatus.Text = $"<b>Estado: </b> {(BLL_User.CheckStatusUser(e.Id) ? "Activo" : "Bloqueado")}";
                    btnCreateUser.Tag = "UnlockAccess";
                    btnCreateUser.Text = "Desbloquear usuario";
                }
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string outputMsg = string.Empty;
            if (btnCreateUser.Tag?.ToString() == "BlockAccess")
            {

                DialogResult r = MessageBox.Show("¿Está seguro de bloquear el acceso al empleado?", "Quitar acceso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (r == DialogResult.Yes)
                {
                    bool result = BLL_User.BlockUserById(empCurrent.Id);

                    outputMsg = result
                        ? "Se bloqueó el usuario correctamente"
                        : "Hubo un error al bloquear el usuario";
                }
            }
            else if (btnCreateUser.Tag?.ToString() == "UnlockAccess")
            {
                DialogResult r = MessageBox.Show("¿Está seguro de desbloquear el acceso al empleado?", "Quitar acceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    bool result = BLL_User.UnlockUserById(empCurrent.Id);

                    outputMsg = result
                        ? "Se desbloqueó el usuario correctamente"
                        : "Hubo un error al desbloquear el usuario";
                }
            }
            else
            {
                FormCreateUser f = new FormCreateUser(empCurrent);
                f.BringToFront();
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog();

                outputMsg = f.result
                    ? "Se creó el usuario correctamente"
                    : "Hubo un error al crear el usuario";

            }

            MessageBox.Show(outputMsg);
            this.Close();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar el empleado?", "Eliminar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                form.ShowEmployees(BLL_Employee.GetAllEmployees());
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
            form.ShowEmployees(BLL_Employee.GetAllEmployees());
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_User.ResetPasswordUserById(empCurrent.Id);
                MessageBox.Show("La contraseña se ha reestablecido correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
