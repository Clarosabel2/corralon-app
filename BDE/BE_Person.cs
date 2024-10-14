using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public abstract class BE_Person
    {
        private int id;
        private int dni;
        private string name;
        private string lastaname;
        private string email;
        private int numPhone;
        private string address;

        public BE_Person(int id, int dni, string nombre, string apellido, string email, int telefono, string domicilio)
        {
            this.Id = id;
            this.Dni = dni;
            this.Name = nombre;
            this.Lastname = apellido;
            this.Email = email;
            this.NumPhone = telefono;
            this.Address = domicilio;
        }
        public BE_Person(SqlDataReader dr)
        {
            this.Id = dr.GetInt32(dr.GetOrdinal("id_Persona"));
            this.Dni = dr.GetInt32(dr.GetOrdinal("DNI"));
            this.Name = dr.GetString(dr.GetOrdinal("nombre"));
            this.Lastname = dr.GetString(dr.GetOrdinal("apellido"));
            this.Email = dr.GetString(dr.GetOrdinal("email"));
            this.NumPhone = dr.GetInt32(dr.GetOrdinal("telefono"));
            this.Address = dr.GetString(dr.GetOrdinal("domicilio"));
        }
        public BE_Person() { }

        protected BE_Person(string name, string lastname, string email)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.Email = email;
        }

        public int Id { get => id; set => id = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastaname; set => lastaname = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public int NumPhone { get => numPhone; set => numPhone = value; }
    }
}
