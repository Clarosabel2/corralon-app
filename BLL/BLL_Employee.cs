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
        public  static List<BE_Employee> GetAllEmployeesWithoutUser()
        {
            return DAL_Employee.GetAllEmployeesWithoutUser();
        }

        public static List<BE_Employee> GetAllEmployees()
        {

            return DAL_Employee.GetAllEmployees();
        }

        public static List<BE_Employee> GetEmployeesByArea(string area)
        {
            return DAL_Employee.GetEmployeesByArea(area);
        }

        public static bool SaveEmployee(BE_Employee bE_Employee)
        {
            return DAL_Employee.SaveEmployee(bE_Employee);
        }
    }
}
