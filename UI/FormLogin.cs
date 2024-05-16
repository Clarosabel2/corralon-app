using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using SVC;

namespace UI
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }
        
        #region "Funcionalidades Visuales"
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
            }
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Username";
            }

        }

        private void txtPsswrd_Enter(object sender, EventArgs e)
        {
            if (txtPsswrd.Text == "Password")
            {
                txtPsswrd.Text = "";
                txtPsswrd.PasswordChar = '*';
            }
        }

        private void txtPsswrd_Leave(object sender, EventArgs e)
        {
            if (txtPsswrd.Text == "")
            {
                txtPsswrd.PasswordChar = '\0';
                txtPsswrd.Text = "Password";
            }
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPsswrd.Text != "Password")
            {
                if (checkBoxShowPassword.Checked)
                {
                    txtPsswrd.PasswordChar = '\0';
                }
                else
                {
                    txtPsswrd.PasswordChar = '*';
                }
            }

        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BLL_Empleado bLL_Empleado = new BLL_Empleado();
            if (bLL_Empleado.validUser(txtUser.Text, txtPsswrd.Text))
            {
                FormMain frmMain = new FormMain();
                frmMain.Show();
                this.Hide();
                
            }
            else {
                MessageBox.Show("Usuario/Contraseña incorrecta");
            }
            
        }

        
    }
}
