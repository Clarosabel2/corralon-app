using BDE;
using DAL.Interfaces;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public bool Save(Client client)
        {
            var cnn = new DbConnectionFactory();
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

        public Client GetByDNI(string dni)
        {
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "sp_GetClientByDNI";
            cmd.Parameters.AddWithValue("@p_dni_client", dni);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows && dr.Read())
            {
                return ClientMapper.Map(dr);
            }
            return null;
        }

        public Client GetById(int idClient)
        {
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "SELECT * FROM Personas p WHERE p.id_Persona=@p_id_client;";
            cmd.Parameters.AddWithValue("@p_id_client", idClient);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows && dr.Read())
            {
                return ClientMapper.Map(dr);
            }
            return null;
        }

        public IEnumerable<Client> GetAll()
        {
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            List<Client> clients = new List<Client>();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "select * from Personas p inner join Clientes c on c.id_Cliente=p.id_Persona";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clients.Add(ClientMapper.Map(dr));
            }
            return clients;
        }

        public Client GetBySale(int idSale)
        {
            var cnn = new DbConnectionFactory();

            using (var connection = cnn.OpenConnection())
            {
                string query = @"
            SELECT p.*
            FROM Personas p
            INNER JOIN Facturas f ON f.id_Cliente = p.id_Persona
            WHERE f.id_Factura = @idFactura";

                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idFactura", idSale);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return ClientMapper.Map(reader);
                        }
                    }
                }
            }

            return null;
        }
    }
}
