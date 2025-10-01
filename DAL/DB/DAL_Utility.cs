using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB
{
    public static class DAL_Utility
    {
        public static DataTable GetDataTable(string table)
        {
            DAL_Connection ocnn = new DAL_Connection();
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {table}", ocnn.Connection);
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        public static List<string> GetTablesExistingDB()
        {
            DAL_Connection ocnn = new DAL_Connection();
            DataTable dt = new DataTable();

            string query = @"
                SELECT name 
                FROM sys.tables 
                WHERE name NOT IN ('sysdiagrams', 'tb_DVV', 'tb_DVH')";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, ocnn.Connection);
            sqlDataAdapter.Fill(dt);

            List<string> tables = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                tables.Add(row["name"].ToString());
            }

            return tables;
        }
        public static List<string> GetPrimaryKeyTable(string table)
        {
            if (string.IsNullOrWhiteSpace(table))
                throw new ArgumentException("El nombre de la tabla no puede ser vacío.", nameof(table));

            var pkColumns = new List<string>();

            DAL_Connection ocnn = new DAL_Connection();
            using (var cmd = new SqlCommand("dbo.sp_GetPrimaryKeyTable", ocnn.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TableName", SqlDbType.NVarChar, 128).Value = table;

                ocnn.Connection.Open();
                try
                {
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            pkColumns.Add(reader["KeyColumn"].ToString());
                        }
                    }
                }
                catch (SqlException ex) when (ex.Number == 50010)
                {
                    throw new InvalidOperationException("La tabla indicada no existe en la base de datos.", ex);
                }
                catch (SqlException ex) when (ex.Number == 50011)
                {
                    throw new InvalidOperationException("La tabla no tiene clave primaria.", ex);
                }
                finally
                {
                    if (ocnn.Connection.State != ConnectionState.Closed)
                        ocnn.Connection.Close();
                }
            }
            return pkColumns;
        }
    }
}
