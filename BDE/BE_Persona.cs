using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public abstract class BDE_Persona
    {

        private int _dni;
        private String _nombre;
        private String _apellido;
        private String _email;
        private String _password;

        public BDE_Persona(int dni, string nombre, string apellido, String email, string password)
        {
            this._dni = dni;
            this._nombre = nombre;
            this._apellido = apellido;
            this._email = email;
            this._password = password;
        }

    }
}
