using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

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

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.Text = "";
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            txtUser.Text = "Username";    
        }

        private void txtPsswrd_Enter(object sender, EventArgs e)
        {
            txtPsswrd.Text="";
        }

        private void txtPsswrd_Leave(object sender, EventArgs e)
        {
            txtPsswrd.Text="Password";
        }
        #endregion
    }
}
