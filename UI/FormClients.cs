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
using UI.common.Styles;

namespace UI
{
    public partial class FormClients : Form
    {
        private readonly IClientService _clientService;
        public FormClients(
            IClientService clientService)
        {
            InitializeComponent();
            _clientService = clientService;
            ApplyStyleCommon.DGVStyle(this.dgvClients);
            LoadClients();
        }
        public void LoadClients()
        {
            DataGridViewTextBoxColumn colObject = new DataGridViewTextBoxColumn
            {
                Name = "colObject",
                Visible = false
            };
            dgvClients.Columns.Add(colObject);
            dgvClients.Columns.Add("colID", "ID");
            dgvClients.Columns.Add("colDNI", "DNI");
            dgvClients.Columns.Add("colName", "Nombre");
            dgvClients.Columns.Add("colLastname", "Apellido");
            dgvClients.Columns.Add("colAddress", "Domicilio");
            dgvClients.Columns.Add("colEmail", "Email");
            dgvClients.Columns.Add("colPhone", "Telefono");

            foreach (Client e in _clientService.GetAll())
            {
                dgvClients.Rows.Add(e, e.Id, e.Dni, e.Name, e.Lastname, e.Address, e.Email, e.NumPhone);
            }
        }
    }
}
