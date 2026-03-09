using BDE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class ClientMapper
    {
        public static Client Map(SqlDataReader dr)
        {
            return new Client(
                dr.GetInt32(dr.GetOrdinal("id_Persona")),
                dr.GetInt32(dr.GetOrdinal("DNI")),
                dr.GetString(dr.GetOrdinal("nombre")),
                dr.GetString(dr.GetOrdinal("apellido")),
                dr.GetString(dr.GetOrdinal("domicilio")),
                dr.GetString(dr.GetOrdinal("email")),
                dr.GetInt32(dr.GetOrdinal("telefono"))
            );
        }
    }

}
