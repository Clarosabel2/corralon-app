using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BDE
{
    public class BE_Empleado : BE_Persona
    {
        private double salario;
        private string area;
        public BE_Empleado(int id, int dni, string nombre, string apellido, string domicilio, string email, int telefono, string rol, double salario, string username, string password, string area)
            : base(id, dni, nombre, apellido, email, telefono, domicilio)
        {
            this.Area = area;
            this.salario = salario;
        }
        public BE_Empleado(SqlDataReader dr)
            : base(dr)
        {
            this.area = dr.GetString(dr.GetOrdinal("nombreArea"));
            this.salario = 0.0;
        }
        public BE_Empleado() : base() { }

        public double Salario { get => salario; set => salario = value; }
        public string Area { get => area; set => area = value; }
    }
}
