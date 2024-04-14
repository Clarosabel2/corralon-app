using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public abstract class BDE_Person
    {

        private int _dni;
        private String _name;
        private String _surname;
        private String _email;
        private String _password;

        public BDE_Person(int dni, string name, string surname, String email, string password)
        {
            this._dni = dni;
            this._name = name;
            this._surname = surname;
            this._email = email;
            this._password = password;
        }

        public int Dni { get => _dni; set => _dni = value; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
