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
        private List<BE_Permiso> _listaPermisos { get; set; }
        public double Salario { get => salario; set => salario = value; }


        public BE_Empleado(int id, int dni, string nombre, string apellido, string domicilio, string email, int telefono, string rol, double salario, string username, string password)
            : base(id, dni, nombre, apellido, email, telefono, domicilio)
        {
            this.salario = salario;
        }
        public BE_Empleado(SqlDataReader dr)
            : base(
                  dr.GetInt32(dr.GetOrdinal("id_Empleado")),
                  dr.GetInt32(dr.GetOrdinal("DNI")),
                  dr.GetString(dr.GetOrdinal("nombre")),
                  dr.GetString(dr.GetOrdinal("apellido")),
                  dr.GetString(dr.GetOrdinal("email")),
                  dr.GetInt32(dr.GetOrdinal("telefono")),
                  dr.GetString(dr.GetOrdinal("domicilio")))
        {
            this.salario = 0.0;
        }
    }
}
