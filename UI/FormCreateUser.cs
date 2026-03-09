using BDE;
using BLL;
using BLL.Interfaces;
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
        private readonly IUserService _userService;
        Employee currentEmp = new Employee();
        public bool result { get; set; }
        public FormCreateUser(
            IUserService userService,
            Employee emp = null)
        {
            InitializeComponent();
            _userService = userService;
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
            User newUser = new User();
            newUser.Emp = currentEmp;
            newUser.Username = currentEmp.Dni.ToString();
            newUser.Password = currentEmp.Dni.ToString();
            newUser.Rol = (BE_TypeUser)comboBoxRols.SelectedItem;

            if (_userService.Save(newUser))
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
