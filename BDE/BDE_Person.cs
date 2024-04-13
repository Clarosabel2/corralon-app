using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public abstract class BDE_Person
    {
        private int id;
        private String name;
        private String surname;
        private String email;
        private String password;

        public BDE_Person() { }
        public BDE_Person(int id, string name, string surname, String email, string password)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
