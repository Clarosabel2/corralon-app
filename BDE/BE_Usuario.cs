using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Usuario
    {
        private string username;
        private string password;
        private string rol;
        private BE_Empleado emp;

        public BE_Usuario(SqlDataReader dr)
        {
            this.Username = dr.GetString(1);
            this.Rol= dr.GetString(8);
            this.Emp = new BE_Empleado(dr);
        }
        public BE_Usuario() { }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Rol { get => rol; set => rol = value; }
        public BE_Empleado Emp { get => emp; set => emp = value; }
    }
}
