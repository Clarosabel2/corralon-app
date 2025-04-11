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
        BE_User newUser = new BE_User();
        public FormCreateUser(BE_Employee emp = null)
        {
            InitializeComponent();
            newUser.Emp = emp;
            LoadDataEmployee(emp);
        }

        private void LoadDataEmployee(BE_Employee e)
        {
            foreach (var item in Enum.GetValues(typeof(BE_TypeUser)))
            {
                comboBoxRols.Items.Add(item);
            }
            txtEmployee.Text = $"{e.Name} {e.Lastname}";
            txtUsername.Text = e.Dni.ToString();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            newUser.Username = txtUsername.Text;
            newUser.Password = txtPassword.Text;
            newUser.Rol = (BE_TypeUser)comboBoxRols.SelectedItem;

            if (BLL_User.CreateUser(newUser))
            {
                DialogResult r = MessageBox.Show("User created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (r == DialogResult.OK) this.Close();
            }

        }
    }
}
