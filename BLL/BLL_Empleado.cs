using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Empleado
    {
        DAL_Empleado DLEmpleado = new DAL_Empleado();
        public bool validUser(string username,string password) {
            return DLEmpleado._validUser(username, password);
        }
    }
}
