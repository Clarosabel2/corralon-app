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
