using BDE;
using SVC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Usuario
    {
        public static bool ValidUser(string username, string password)
        {
            var cnn = new DAL_Conexion();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "sp_ValidUser";
            cmd.Parameters.AddWithValue("@p_username", username);
            cmd.Parameters.AddWithValue("@p_password", EncodeManager.HashValue(password));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SessionManager.Login(new BE_Usuario(dr));
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
