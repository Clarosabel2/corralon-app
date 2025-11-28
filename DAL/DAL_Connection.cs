using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Connection
    {
        //private readonly SqlConnection _connection = 
        //    new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=corralondb;Integrated Security=True;TrustServerCertificate=True");
        private readonly SqlConnection _connection =
            new SqlConnection(ConfigurationManager.ConnectionStrings["currentInstanceSQL"].ConnectionString);
    
        public SqlConnection Connection => _connection;
        public SqlConnection OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            return Connection;
        }

        public SqlConnection CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
            return Connection;
        }
    }
}
