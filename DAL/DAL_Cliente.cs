using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE;
using SVC;

namespace DAL
{
    public static class DAL_Cliente
    {
        public static BE_Cliente VerificarCliente(string dni)
        {
            var cnn = new DAL_Conexion();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "sp_GetClientByDNI";
            cmd.Parameters.AddWithValue("@p_dni_client", dni);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows && dr.Read())
            {
                return new BE_Cliente(dr);
            }
            return null;
        }
    }
}
