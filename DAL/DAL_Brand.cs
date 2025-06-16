using BDE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Brand
    {
        public static DataTable GetAllBrands()
        {
            var cnn = new DAL_Connection();
            DataTable dt = new DataTable();
            using (var connection = cnn.OpenConnection())
            {
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Marcas", connection);
                ad.Fill(dt);
            }
            return dt;
        }

        public static DataTable GetBrandsBySupplierId(int id)
        {
            var cnn = new DAL_Connection();
            var dt = new DataTable();

            try
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cnn.OpenConnection();
                    cmd.CommandText = @"
                                        SELECT m.*
                                        FROM Marcas m
                                        LEFT JOIN ProveedorMarca pm ON m.id_Marca = pm.id_Marca
                                        WHERE pm.id_proveedor = @p_id_supplier";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p_id_supplier", id);

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error retrieving brands by supplier ID: " + ex.Message);
            }
            finally
            {
                cnn.CloseConnection();
            }
        }   

        public static void SaveBrand(BE_Brand b)
        {
            var cnn = new DAL_Connection();
            using (var connection = cnn.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Marcas (marca) VALUES (@p_nombreMarca)", connection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@p_nombreMarca", b.NameBrand);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
