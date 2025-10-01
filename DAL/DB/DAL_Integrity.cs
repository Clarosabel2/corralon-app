using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB
{
    public class DAL_Integrity
    {
        

        #region "DVH"
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

        public static bool UpdateRowHashedFromTable(string table, string rowId, string hash)
        {
            DAL_Connection ocnn = new DAL_Connection();
            using (var conn = ocnn.Connection)
            {
                conn.Open();
                using (var updateCmd = new SqlCommand("UPDATE tb_DVH SET hash_dvh = @hash WHERE [table] = @table AND id_reg = @idRow", conn))
                {
                    updateCmd.Parameters.AddWithValue("@table", table);
                    updateCmd.Parameters.AddWithValue("@idRow", rowId);
                    updateCmd.Parameters.AddWithValue("@hash", hash);

                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        #endregion

        #region "DVV"
        public static Dictionary<string, string> GetDVVColumn()
        {

            return null;
        }
        public static void CalculateDVV(string table = "")
        {
            if (table != string.Empty)
            {
                // Calculate DVV for specific table
                return;
            }
            // Calculate DVV for all tables
            List<string> tables = DAL_Utility.GetTablesExistingDB().ToList();
            foreach (string tbl in tables)
            {
                DataTable currentTbData = DAL_Utility.GetDataTable(tbl);
                List<string> pkColumns = DAL_Utility.GetPrimaryKeyTable(tbl);

            }


        }
        #endregion


    }
}
