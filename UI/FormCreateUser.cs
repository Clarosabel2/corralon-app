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
        public FormCreateUser()
        {
            InitializeComponent();
            //ResxExporter.ExportControlsToResx(this, @"D:\Proyectos\UAI\3ER AÑO\IS\Proyecto Aplicacion\corralon-app\UI\Resources\ResourceControlsLanguage.resx");
            LoadData();
        }

        private void LoadData()
        {
            BLL_Employee.GetAllEmployeesWithoutUser().ForEach(e => 
                comboBoxEmployees.Items.Add(new KeyValuePair<BE_Employee, string>(e, $"{e.Lastname}, {e.Name}")));

            comboBoxEmployees.DisplayMember = "Value";
            comboBoxEmployees.ValueMember = "Key";
            comboBoxEmployees.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxEmployees.AutoCompleteSource = AutoCompleteSource.ListItems;

            foreach (var item in Enum.GetValues(typeof(BE_TypeUser)))
            {
                comboBoxRols.Items.Add(item);
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            
        }
    }
}
