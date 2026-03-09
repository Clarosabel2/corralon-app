using BDE;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using SVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IClientService _clientService;

        public EmployeeService(
            IEmployeeRepository employeeRepository, 
            IClientService clientService)
        {
            _employeeRepository = employeeRepository;
            _clientService = clientService;
        }

        public List<Employee> GetAllWithoutUser()
        {
            return _employeeRepository.GetAllEmployeesWithoutUser();
        }

        public List<Employee> GetAll()
        {
            List<Employee> emps = _employeeRepository.GetAllEmployees();
            //Elimina el empleado que esta logeado
            emps.Remove(emps.FirstOrDefault(e => e.Id == SessionManager.GetInstance.user.Emp.Id));

            return emps;
        }

        public List<Employee> GetByArea(string area)
        {
            return _employeeRepository.GetEmployeesByArea(area);
        }

        public bool Save(Employee emp)
        {
            return _employeeRepository.Save(emp);
        }

        public bool Update(Employee empEdit)
        {
            return _employeeRepository.Update(empEdit);
        }

        public Employee GetById(int idEmp)
        {
            return _employeeRepository.GetById(idEmp);
        }

        public bool ExistsByDNI(int dni , out Client client)
        {
            client = _clientService.GetByDNI(dni.ToString());
            return _employeeRepository.ExistsByDNI(dni);
        }
    }
}
