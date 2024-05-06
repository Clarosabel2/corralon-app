using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Conexion
    {
        private readonly string connectionString;
        public DAL_Conexion()
        {
            connectionString = "Server=ABEL_\\SQLEXPRESS;DataBase=corralondb;Integrated Security=true";
        }
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
