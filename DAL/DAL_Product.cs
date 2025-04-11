using BDE;
using SVC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Product
    {
        public static void UpdateStockById(int idProduct, int amount)
        {
            var cnn = new DAL_Connection();
            using (var connection = cnn.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateStockProduct", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_id_Product", idProduct);
                cmd.Parameters.AddWithValue("@p_amount", amount);
                cmd.ExecuteNonQuery();
            }
        }

        public static DataTable GetCateogyProducts()
        {
            var cnn = new DAL_Connection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT c.id_Categoria, c.nombreCategoria FROM Categorias c", cnn.Connection);
            adapter.SelectCommand.CommandType = CommandType.Text;
            adapter.Fill(table);
            return table;
        }

        public static DataTable GetProducts()
        {
            var cnn = new DAL_Connection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("sp_GetProducts", cnn.Connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(table);
            return table;

        }
        public static bool UpdateProducts(DataTable dt)
        {
            return true;
        }

        public static void DeleteProductById(int idProduct)
        {
            var cnn = new DAL_Connection();
            using (var connection = cnn.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Productos SET activo=0 WHERE id_Producto=@p_id_Product", connection);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p_id_Product", idProduct);
                cmd.ExecuteNonQuery();
            }
        }

        public static void SaveProduct(BE_Product p)
        {
            var cnn = new DAL_Connection();
            using (var connection = cnn.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_SaveProduct", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", p.Name);
                cmd.Parameters.AddWithValue("@description", "");
                cmd.Parameters.AddWithValue("@stock", p.Stock);
                cmd.Parameters.AddWithValue("@price", p.Price);
                cmd.Parameters.AddWithValue("@nombre_marca", p.Brand.NameBrand);
                cmd.Parameters.AddWithValue("@id_categoria", p.Category);

                cmd.ExecuteNonQuery();
            }
        }

        public static BE_Product GetProductById(int idprdt)
        {
            var cnn = new DAL_Connection();
            BE_Product p = new BE_Product();
            using (var connection = cnn.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_GetProductById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_id_product", idprdt);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new BE_Product()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Description = reader.GetString(2),
                            Price = reader.GetDouble(3),
                            Stock = reader.GetInt32(4),
                            Brand = new BE_Brand
                            {
                                Id = reader.GetInt32(5),
                                NameBrand = reader.GetString(6)
                            },
                            Category = reader.GetString(7)
                        };
                    }
                }
            }
            return p;
        }

        public static void UpdateProduct(BE_Product p)
        {
            var cnn = new DAL_Connection();
            using (var connection = cnn.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateProductById", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_id_producto", p.Id);
                cmd.Parameters.AddWithValue("@p_id_marca", p.Brand.Id);
                cmd.Parameters.AddWithValue("@p_categoria", int.Parse(p.Category));
                cmd.Parameters.AddWithValue("@p_nombre", p.Name);
                cmd.Parameters.AddWithValue("@p_descripcion", p.Description);
                cmd.Parameters.AddWithValue("@p_precio", p.Price);
                cmd.Parameters.AddWithValue("@p_stock", p.Stock);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
