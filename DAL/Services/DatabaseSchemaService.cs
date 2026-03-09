using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class DatabaseSchemaService
    {
        public DataTable GetDataTable(string table)
        {
            DbConnectionFactory ocnn = new DbConnectionFactory();
            DataTable dt = new DataTable();

            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM {table}", ocnn.Connection))
            {
                sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                sqlDataAdapter.Fill(dt);
            }
            return dt;
        }

        public List<string> GetTablesExistingDB()
        {
            DbConnectionFactory ocnn = new DbConnectionFactory();
            DataTable dt = new DataTable();

            string query = @"
                SELECT name 
                FROM sys.tables 
                WHERE name NOT IN ('sysdiagrams', 'tb_DVV', 'tb_DVH','tb_AuditChanges','tb_EventLog','tb_EventLogActivity')";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, ocnn.Connection);
            sqlDataAdapter.Fill(dt);

            List<string> tables = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                tables.Add(row["name"].ToString());
            }

            return tables;
        }
        public List<string> GetPrimaryKeyTable(string table)
        {
            if (string.IsNullOrWhiteSpace(table))
                throw new ArgumentException("El nombre de la tabla no puede ser vacío.", nameof(table));

            var pkColumns = new List<string>();

            DbConnectionFactory ocnn = new DbConnectionFactory();
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

        public DataRow GetRowById(string table, string idRow)
        {
            DbConnectionFactory ocnn = new DbConnectionFactory();
            try
            {
                string pkTable = GetPrimaryKeyTable(table)[0];
                string query = $@"
                                SELECT TOP 1 *
                                FROM [{table}] 
                                WHERE [{pkTable}] = @IdRow";

                using (var cmd = new SqlCommand(query, ocnn.Connection))
                {
                    cmd.Parameters.AddWithValue("@IdRow", idRow);
                    ocnn.Connection.Open();

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            return dataTable.Rows[0];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving row: {ex.Message}");
            }
            finally
            {
                if (ocnn.Connection.State == ConnectionState.Open)
                {
                    ocnn.Connection.Close();
                }
            }

            return null;
        }

    }
}
