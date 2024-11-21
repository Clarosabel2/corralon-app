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
    public partial class FormAssignProfile : Form
    {
        public FormAssignProfile()
        {
            InitializeComponent();
            //dgvUsers.DataSource = BLL_User.GetAllUser();
            //dgvUsers.Rows[0].Selected = true;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsers.SelectedRows.Count > 0)
            {
                txtUser.Text = dgvUsers.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {

        }
    }
}
