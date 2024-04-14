using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BDE_Admin : BDE_Person
    {
        public BDE_Admin(int dni, string name, string surname, string email, string password) : base(dni, name, surname, email, password)
        {

        }
    }
}
