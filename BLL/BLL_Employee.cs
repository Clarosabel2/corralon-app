using BDE;
using DAL;
using SVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Employee
    {
        public static List<BE_Employee> GetAllEmployeesWithoutUser()
        {
            return DAL_Employee.GetAllEmployeesWithoutUser();
        }

        public static List<BE_Employee> GetAllEmployees()
        {
            List<BE_Employee> emps = DAL_Employee.GetAllEmployees();
            //Elimina el empleado que esta logeado
            emps.Remove(emps.FirstOrDefault(e => e.Id == SessionManager.GetInstance.user.Emp.Id));

            return emps;
        }

        public static List<BE_Employee> GetEmployeesByArea(string area)
        {
            return DAL_Employee.GetEmployeesByArea(area);
        }

        public static bool SaveEmployee(BE_Employee bE_Employee)
        {
            return DAL_Employee.SaveEmployee(bE_Employee);
        }

        public static bool UpdateEmployee(BE_Employee empEdit)
        {
            return DAL_Employee.UpdateEmployee(empEdit);
        }

        public static BE_Employee GetEmployeeById(int idEmp)
        {
            return DAL_Employee.GetEmployeeById(idEmp);
        }
    }
}
