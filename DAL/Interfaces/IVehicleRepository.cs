using BDE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IVehicleRepository
    {
        bool Save(Vehicle vehicle);
        List<Vehicle> GetAll();
    }
}
