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
    }
}
