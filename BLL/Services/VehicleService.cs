using BDE;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VehicleService: IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        public bool Save(Vehicle v)
        {
            return _vehicleRepository.Save(v);
        }
        public List<Vehicle> GetAll()
        {
            return _vehicleRepository.GetAll();
        }
    }
}
