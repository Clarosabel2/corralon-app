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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = BLL_User.GetAllUser();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            FormCreateUser f = new FormCreateUser();
            f.BringToFront();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }
    }
}
