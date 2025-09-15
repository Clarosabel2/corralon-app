using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB
{
    public class DAL_Integrity
    {
        public static DataTable GetHashedTable(string tableToHash)
        {
            DataTable hashedTable = new DataTable();

            return hashedTable;
        }

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

        public static void RecalculateTables((string, string) tablePairs)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception($"Error recalculating tables {tablePairs.Item1} and {tablePairs.Item2}: {ex.Message}");
            }
        }

        public static void SaveDVHTable(string table, Dictionary<string, string> rowHashes)
        {
            DAL_Connection ocnn = new DAL_Connection();
            using (var conn = ocnn.Connection)
            {
                conn.Open();
                using (var deleteCmd = new SqlCommand("DELETE FROM tb_DVH WHERE [table] = @table", conn))
                {
                    deleteCmd.Parameters.AddWithValue("@table", table);
                    deleteCmd.ExecuteNonQuery();
                }
                
                foreach (var kvp in rowHashes)
                {
                    using (var insertCmd = new SqlCommand(
                        @"INSERT INTO tb_DVH ([table], id_reg, hash_dvh, updated_at)
                            VALUES (@table, @id_reg, @hash_dvh, @updated_at)", conn))
                    {
                        insertCmd.Parameters.AddWithValue("@table", table);
                        insertCmd.Parameters.AddWithValue("@id_reg", kvp.Key);
                        insertCmd.Parameters.AddWithValue("@hash_dvh", kvp.Value);
                        insertCmd.Parameters.AddWithValue("@updated_at", DateTime.UtcNow);

                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
        }

    }
}
