using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Empleado : BE_Persona
    {
        private string _username;
        private string _password;
        private string _area;
        private double _salario;
        private List<BE_Permiso> _listaPermisos { get; set; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Area { get => _area; set => _area = value; }
        public double Salario { get => _salario; set => _salario = value; }

        public BE_Empleado(int id, int dni, string nombre, string apellido, string domicilio, string email, int telefono, string area, double salario, string username, string password)
            : base(id, dni, nombre, apellido, domicilio, email, telefono)
        {
            this.Username= username;
            this.Password = password;
            this.Area = area;
            this.Salario = salario;
        }
       

    }
}
