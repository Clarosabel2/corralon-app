using BDE;
using DAL;
using SVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Employee
    {
        public static List<BE_Employee> GetEmployeesByArea(string area)
        {
            return DAL_Employee.GetEmployeesByArea(area);
        }
    }
}
