using BDE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class ClientMapper
    {
        public static BE_Client FromDataRow(DataRow row)
        {
            if (row == null)
                return null;
            return new BE_Client(
                Convert.ToInt32(row["id_Persona"]),
                Convert.ToInt32(row["DNI"]),
                row["nombre"].ToString(),
                row["apellido"].ToString(),
                row["domicilio"].ToString(),
                row["email"].ToString(),
                Convert.ToInt32(row["telefono"])
            );
        }
    }
}
