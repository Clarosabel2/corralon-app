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
        public string username { get; set; }
        public string password { get; set; }
        public string rol { get; set; }
        public BE_Empleado emp { get; set; }

        public BE_Usuario(SqlDataReader dr)
        {
            this.username = dr.GetString(1);
            this.rol= dr.GetString(8);
            this.emp = new BE_Empleado(dr);
        }
    }
}
