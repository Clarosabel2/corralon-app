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
using System.Net.Sockets;

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
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", client.Dni);
                cmd.Parameters.AddWithValue("@name", client.Name);
                cmd.Parameters.AddWithValue("@lastname", client.Lastname);
                cmd.Parameters.AddWithValue("@address ", client.Address);
                cmd.Parameters.AddWithValue("@numphone", client.NumPhone);
                cmd.Parameters.AddWithValue("@email", client.Email);
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
                return InstanceClient(dr);
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
                return InstanceClient(dr);
            }
            return null;
        }

        public static IEnumerable<BE_Client> GetAllClients()
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            List<BE_Client> clients = new List<BE_Client>();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "select * from Personas p inner join Clientes c on c.id_Cliente=p.id_Persona";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clients.Add(InstanceClient(dr));
            }
            return clients;
        }

        private static BE_Client InstanceClient(SqlDataReader dr)
        {
            return new BE_Client(
                        dr.GetInt32(dr.GetOrdinal("id_Persona")),
                        dr.GetInt32(dr.GetOrdinal("DNI")),
                        dr.GetString(dr.GetOrdinal("nombre")),
                        dr.GetString(dr.GetOrdinal("apellido")),
                        dr.GetString(dr.GetOrdinal("domicilio")),
                        dr.GetString(dr.GetOrdinal("email")),
                        dr.GetInt32(dr.GetOrdinal("telefono")));
        }
    }
}
