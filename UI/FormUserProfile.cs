using SVC;
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
    public partial class FormUserProfile : Form
    {
        public FormUserProfile()
        {
            InitializeComponent();
            LoadMyData();
        }

        private void LoadMyData()
        {
            lblUser.Text = SessionManager.GetInstance.usuario.Username;
            lblFirstName.Text = SessionManager.GetInstance.usuario.Emp.Nombre;
            lblLastName.Text = SessionManager.GetInstance.usuario.Emp.Apellido;
            lblEmail.Text = SessionManager.GetInstance.usuario.Emp.Email;
            lblPosition.Text = SessionManager.GetInstance.usuario.Rol;
        }

        private void lnkEditProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelEditProfile.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelEditProfile.Visible=false;
        }
    }
}
