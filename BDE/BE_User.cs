using BDE.Language;
using BDE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BDE
{
    public class BE_User
    {
        private string username;
        private string password;
        private bool status;
        private BE_Employee emp;
        private BE_Language language;
        private BE_Permission profile;
        private BE_TypeUser rol;

        public BE_User() { }

        public BE_User(string name, string lastname, string email)
        {
            this.Emp = new BE_Employee(name, lastname, email);
        }
        public BE_User(string username, bool status, BE_TypeUser typeUser, string password, BE_Employee emp)
        {
            this.Username = username;
            this.Status = status;
            this.Rol = typeUser;
            this.Password = password;
            this.Emp = emp;
            this.Language = new BE_Language();
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public BE_TypeUser Rol { get => rol; set => rol = value; }
        public BE_Employee Emp { get => emp; set => emp = value; }
        public bool Status { get => status; set => status = value; }
        public BE_Language Language { get => language; set => language = value; }
    }
}
