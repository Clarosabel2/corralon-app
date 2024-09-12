using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_User
    {
        private string username;
        private string password;
        private string rol;
        private BE_Employee emp;
        private List<BE_Permisson> permissones;
        private string language;
        private BE_Profile profile;

        public BE_User(SqlDataReader dr)
        {
            this.Username = dr.GetString(1);
            this.Rol= dr.GetString(8);
            this.Emp = new BE_Employee(dr);
        }
        public BE_User() { }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Rol { get => rol; set => rol = value; }
        public BE_Employee Emp { get => emp; set => emp = value; }
    }
}
