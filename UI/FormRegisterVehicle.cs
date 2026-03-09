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
    public partial class FormRegisterVehicle : Form
    {
        private readonly IVehicleService _vehicleService;
        public FormRegisterVehicle(IVehicleService vehicleService)
        {
            InitializeComponent();
            _vehicleService = vehicleService;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //public BE_Vehicle(
            //string patent,
            //string brand,
            //string model,
            //int year)
            var data = new Vehicle(
                txtLicensePlate.Text,
                txtBrand.Text,
                txtModel.Text,
                (int)numYear.Value,
                (int)numAxles.Value,
                (int)numLoadCapacity.Value);
            if (_vehicleService.Save(data))
            {
                
                MessageBox.Show("El vehículo se registró correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el vehículo. Verifique si la patente ya existe.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
