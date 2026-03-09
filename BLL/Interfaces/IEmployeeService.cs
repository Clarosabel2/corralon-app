using BDE;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetAllWithoutUser();
        List<Employee> GetAll();
        List<Employee> GetByArea(string area);
        Employee GetById(int idEmp);
        bool Save(Employee emp);
        bool Update(Employee empEdit);
        bool ExistsByDNI(int dni, out Client client);
    }
}
