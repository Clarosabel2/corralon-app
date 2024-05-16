using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public abstract class BE_Persona
    {
        private int _id;
        private int _dni;
        private string _nombre;
        private string _apellido;
        private string _domicilio;
        private string _email;
        private int _telefono;

        public BE_Persona(int id,int dni, string nombre, string apellido, string domicilio, string email, int telefono)
        {
            this.Id=id;
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Domicilio = domicilio;
            this.Email = email;
            this.Telefono = telefono;
        }

        public int Id { get => _id; set => _id = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Domicilio { get => _domicilio; set => _domicilio = value; }
        public string Email { get => _email; set => _email = value; }
        public int Telefono { get => _telefono; set => _telefono = value; }
    }
}
