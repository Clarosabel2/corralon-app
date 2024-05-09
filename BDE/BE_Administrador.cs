using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BDE_Administrador : BDE_Persona
    {
        public BDE_Administrador(int dni, string name, string surname, string email, string password) : base(dni, name, surname, email, password)
        {

        }
    }
}
