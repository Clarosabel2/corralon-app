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
using BDE.Permissions;

namespace BDE
{
    public class User
    {
        private string username;
        private string password;
        private bool status;
        private Employee emp;
        private Language.Language language;
        private BE_Permission profile;
        private BE_TypeUser rol;

        public User() { }

        public User(string name, string lastname, string email)
        {
            this.Emp = new Employee(name, lastname, email);
        }
        public User(string username, bool status, BE_TypeUser typeUser, string password, Employee emp)
        {
            this.Username = username;
            this.Status = status;
            this.Rol = typeUser;
            this.Password = password;
            this.Emp = emp;
            this.Language = new Language.Language();
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public BE_TypeUser Rol { get => rol; set => rol = value; }
        public Employee Emp { get => emp; set => emp = value; }
        public bool Status { get => status; set => status = value; }
        public Language.Language Language { get => language; set => language = value; }
    }
}
