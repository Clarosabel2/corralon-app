﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BDE
{
    public class BE_Employee : BE_Person
    {
        private double salary;
        private string area;
        public BE_Employee(int id, int dni, string nombre, string apellido, string domicilio, string email, int telefono, double salario, string area)
            : base(id, dni, nombre, apellido,domicilio, email, telefono)
        {
            this.Area = area;
            this.salary = salario;
        }
        public BE_Employee(string name, string lastname, string email) : base(name, lastname, email) { }
        public BE_Employee() : base() { }

        public double Salario { get => salary; set => salary = value; }
        public string Area { get => area; set => area = value; }
    }
}
