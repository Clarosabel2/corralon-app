using BDE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class UserMapper
    {
        private static bool HasColumn(SqlDataReader dr, string columnName)
        {
            for (int i = 0; i < dr.FieldCount; i++)
            {
                if (dr.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        public static User Map(SqlDataReader dr)
        {
            var user = new User(
                dr.GetString(dr.GetOrdinal("username")),
                dr.IsDBNull(dr.GetOrdinal("estado")) ? false : dr.GetBoolean(dr.GetOrdinal("estado")),
                (BE_TypeUser)Enum.Parse(typeof(BE_TypeUser), dr.GetString(dr.GetOrdinal("rol"))),
                dr.GetString(dr.GetOrdinal("password")),
                new Employee(
                        dr.GetInt32(dr.GetOrdinal("id_Persona")),
                        dr.GetInt32(dr.GetOrdinal("DNI")),
                        dr.GetString(dr.GetOrdinal("nombre")),
                        dr.GetString(dr.GetOrdinal("apellido")),
                        dr.IsDBNull(dr.GetOrdinal("domicilio")) ? null : dr.GetString(dr.GetOrdinal("domicilio")),
                        dr.IsDBNull(dr.GetOrdinal("email")) ? null : dr.GetString(dr.GetOrdinal("email")),
                        dr.IsDBNull(dr.GetOrdinal("telefono")) ? 0 : dr.GetInt32(dr.GetOrdinal("telefono")),
                        0.0,
                        HasColumn(dr, "nombreArea") && !dr.IsDBNull(dr.GetOrdinal("nombreArea")) ? dr.GetString(dr.GetOrdinal("nombreArea")) : null
                    )

            );
             
            if (HasColumn(dr, "nombreIdioma"))
            {
                user.Language = LanguageRepository.GetLanguage(
                    dr.GetString(dr.GetOrdinal("nombreIdioma"))
                );
            }

            return user;
        }

        public static User Map(DataRow row)
        {
            var user = new User(
                row["username"].ToString(),
                Convert.ToBoolean(row["estado"]),
                (BE_TypeUser)Enum.Parse(typeof(BE_TypeUser), row["rol"].ToString()),
                row["password"].ToString(),
                new Employee(
                    Convert.ToInt32(row["id_Persona"]),
                    Convert.ToInt32(row["DNI"]),
                    row["nombre"].ToString(),
                    row["apellido"].ToString(),
                    row["domicilio"].ToString(),
                    row["email"].ToString(),
                    Convert.ToInt32(row["telefono"]),
                    0.0,
                    row.Table.Columns.Contains("nombreArea") && row["nombreArea"] != DBNull.Value ? row["nombreArea"].ToString() : null
                )
            );

            user.Language = LanguageRepository.GetLanguage(row["nombreIdioma"].ToString());

            return user;
        }
    }
}
