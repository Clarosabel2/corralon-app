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
    public partial class FormVehicles : Form
    {
        private readonly IVehicleService _vehicleService;
        private string _vehicle;
        private string _patent;
        public FormVehicles(IVehicleService vehicleService)
        {
            InitializeComponent();
            _vehicleService = vehicleService;
            LoadVehicles();
        }

        private void LoadVehicles()
        {
            _vehicleService.GetAll().ForEach(v =>
            {
                dgvMaintenance.Rows.Add(v.Patent, v.Brand, "Nunca", "", "");
            });
        }

        private void btnRegisterNewVehicle_Click(object sender, EventArgs e)
        {
            FormRegisterVehicle frm = new FormRegisterVehicle(_vehicleService);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }

        private void dgvMaintenance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // 2. Obtenemos la fila completa donde se hizo clic
            DataGridViewRow fila = dgvMaintenance.Rows[e.RowIndex];

            // 3. Capturamos los valores (RECUERDA: .Cells[0] es la primera columna)
            // Usamos ?.ToString() para evitar error si la celda está vacía (null)
            _patent = fila.Cells[0].Value?.ToString();
            _vehicle = fila.Cells[1].Value?.ToString();
            lblVehicleSlt.Text = $"{_vehicle} - {_patent}";
        }
    }
}
