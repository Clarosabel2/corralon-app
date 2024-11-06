using BDE.Language;
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
        private bool status;
        private BE_Employee emp;
        private BE_Language language;
        private BE_Profile profile;

        public BE_User(SqlDataReader dr)
        {
            this.Username = dr.GetString(dr.GetOrdinal("username"));
            this.Status = dr.GetBoolean(dr.GetOrdinal("estado"));
            this.Rol = dr.GetString(dr.GetOrdinal("rol"));
            this.Emp = new BE_Employee(dr);
            this.Password = dr.GetString(dr.GetOrdinal("password"));
            this.Language = new BE_Language();
        }

        public BE_User() { }

        public BE_User(string name, string lastname, string email)
        {
            this.Emp = new BE_Employee(name, lastname, email);
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Rol { get => rol; set => rol = value; }
        public BE_Employee Emp { get => emp; set => emp = value; }
        public bool Status { get => status; set => status = value; }
        public BE_Language Language { get => language; set => language = value; }
    }
}
