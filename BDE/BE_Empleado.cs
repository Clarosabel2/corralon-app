using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Empleado : BE_Persona
    {
        private String _area;
        private double _salary;

        public BE_Empleado(int dni, string name, string surname, string email, string password,String area, double salary) : base(dni, name, surname, email, password)
        {
            this._area= area;
            this._salary = salary;
        }

        public string Area { get => _area; set => _area = value; }
        public double Salary { get => _salary; set => _salary = value; }
    }
}
