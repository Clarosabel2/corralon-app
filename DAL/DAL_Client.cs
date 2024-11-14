using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE;
using SVC;
using System.Net;

namespace DAL
{
    public static class DAL_Client
    {
        public static bool SaveClient(BE_Client client)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            try
            {
                cmd.Connection = cnn.OpenConnection();
                cmd.CommandText = "sp_SaveClient";
                cmd.Parameters.AddWithValue("@dni", client.Dni);
                cmd.Parameters.AddWithValue("@name", client.Name);
                cmd.Parameters.AddWithValue("@lastname", client.Lastname);
                cmd.Parameters.AddWithValue("@address ", client.Address);
                cmd.Parameters.AddWithValue("@numphone", client.NumPhone);
                cmd.Parameters.AddWithValue("@email", client.Email);
                cmd.CommandType = CommandType.StoredProcedure;
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnn.CloseConnection();
            }

        }

        public static BE_Client GetClientByDNI(string dni)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "sp_GetClientByDNI";
            cmd.Parameters.AddWithValue("@p_dni_client", dni);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows && dr.Read())
            {
                return new BE_Client(dr);
            }
            return null;
        }

        public static BE_Client GetClientById(string idClient)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "SELECT * FROM Personas p WHERE p.id_Persona=@p_id_client;";
            cmd.Parameters.AddWithValue("@p_id_client", idClient);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows && dr.Read())
            {
                return new BE_Client(dr);
            }
            return null;
        }
    }
}
