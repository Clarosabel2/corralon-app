using BDE;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IVehicleService
    {
        bool Save(Vehicle v);
        List<Vehicle> GetAll();
    }
}
