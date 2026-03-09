using BDE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class EmployeeMapper
    {
        public static Employee Map(SqlDataReader dr)
        {
            string nombreArea = ColumnExists(dr, "nombreArea") &&
                                !dr.IsDBNull(dr.GetOrdinal("nombreArea"))
                ? dr.GetString(dr.GetOrdinal("nombreArea"))
                : string.Empty;

            return new Employee(
                dr.GetInt32(dr.GetOrdinal("id_Persona")),
                dr.GetInt32(dr.GetOrdinal("DNI")),
                dr.GetString(dr.GetOrdinal("nombre")),
                dr.GetString(dr.GetOrdinal("apellido")),
                dr.GetString(dr.GetOrdinal("domicilio")),
                dr.GetString(dr.GetOrdinal("email")),
                dr.GetInt32(dr.GetOrdinal("telefono")),
                0.0,
                nombreArea
            );
        }

        private static bool ColumnExists(SqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}
