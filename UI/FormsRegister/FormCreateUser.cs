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
    public partial class FormCreateUser : Form
    {
        BE_Employee currentEmp = new BE_Employee();
        public bool result { get; set; }
        public FormCreateUser(BE_Employee emp = null)
        {
            InitializeComponent();
            LoadRols();
            currentEmp = emp;
        }

        private void LoadRols()
        {
            foreach (var item in Enum.GetValues(typeof(BE_TypeUser)))
            {
                comboBoxRols.Items.Add(item);
            }

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            BE_User newUser = new BE_User();
            newUser.Emp = currentEmp;
            newUser.Username = currentEmp.Dni.ToString();
            newUser.Password = currentEmp.Dni.ToString();
            newUser.Rol = (BE_TypeUser)comboBoxRols.SelectedItem;

            if (BLL_User.CreateUser(newUser))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            this.Close();
        }
    }
}
