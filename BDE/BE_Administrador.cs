using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Administrador : BE_Persona
    {
        public BE_Administrador(int dni, string name, string surname, string email, string password) : base(dni, name, surname, email, password)
        {

        }
    }
}
