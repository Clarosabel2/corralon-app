using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Vendedor : BE_Empleado
    {
        
        public BE_Vendedor(int dni, string name, string surname, string email, string password, string area, double salary) : base(dni, name, surname, email, password, area, salary)
        {

        }
    }
}
