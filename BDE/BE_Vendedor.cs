using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    internal class BDE_Vendedor : BDE_Empleado
    {
        public BDE_Vendedor(int dni, string name, string surname, string email, string password, string area, double salary) : base(dni, name, surname, email, password, area, salary)
        {

        }
    }
}
