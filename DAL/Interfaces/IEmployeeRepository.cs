using BDE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployeesWithoutUser();
        List<Employee> GetAllEmployees();
        List<Employee> GetEmployeesByArea(string area);
        bool Save(Employee employee);
        bool Update(Employee empEdit);
        Employee GetById(int idEmp);
        bool ExistsByDNI(int dni);
    }
}
