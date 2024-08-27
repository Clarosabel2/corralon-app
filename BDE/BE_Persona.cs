using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public abstract class BE_Persona
    {
        private int id;
        private int dni;
        private string nombre;
        private string apellido;
        private string email;
        private int telefono;
        private string domicilio;

        public BE_Persona(int id, int dni, string nombre, string apellido, string email, int telefono, string domicilio)
        {
            this.Id = id;
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Telefono = telefono;
            this.Domicilio = domicilio;
        }
        public BE_Persona(SqlDataReader dr) {
            this.Id = dr.GetInt32(dr.GetOrdinal("id_Persona"));
            this.Dni = dr.GetInt32(dr.GetOrdinal("DNI"));
            this.Nombre = dr.GetString(dr.GetOrdinal("nombre"));
            this.Apellido = dr.GetString(dr.GetOrdinal("apellido"));
            this.Email = dr.GetString(dr.GetOrdinal("email"));
            this.Telefono = dr.GetInt32(dr.GetOrdinal("telefono"));
            this.Domicilio = dr.GetString(dr.GetOrdinal("domicilio"));
        }
        public BE_Persona() { }

        public int Id { get => id; set => id = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
