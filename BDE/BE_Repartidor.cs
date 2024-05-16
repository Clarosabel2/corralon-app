using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    internal class BE_Repartidor : BE_Empleado
    {
        public BE_Repartidor(int id, int dni, string nombre, string apellido, string domicilio, string email, int telefono, string area, double salario, string username, string password)
            : base(id, dni, nombre, apellido, domicilio, email, telefono, area, salario, username, password)
        {

        }
    }
}
