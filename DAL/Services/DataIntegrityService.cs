using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL.Services
{
    public class DataIntegrityService
    {
        private readonly DatabaseSchemaService _dbSchemaService;
        public DataIntegrityService()
        {
            _dbSchemaService = new DatabaseSchemaService();
        }
        #region "DVH"
        public void SaveDVHTable(string table, Dictionary<string, string> rowHashes)
        {
            DbConnectionFactory ocnn = new DbConnectionFactory();
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

        public bool UpdateRowHashInDvhTable(string table, string rowId, string hash)
        {
            DbConnectionFactory ocnn = new DbConnectionFactory();
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
        public Dictionary<string, string> GetDVVColumn()
        {

            return null;
        }
        public void CalculateDVV(string table = "")
        {
            if (table != string.Empty)
            {
                // Calculate DVV for specific table
                return;
            }
            // Calculate DVV for all tables
            List<string> tables = _dbSchemaService.GetTablesExistingDB().ToList();
            foreach (string tbl in tables)
            {
                DataTable currentTbData = _dbSchemaService.GetDataTable(tbl);
                List<string> pkColumns = _dbSchemaService.GetPrimaryKeyTable(tbl);

            }


        }
        #endregion


    }
}
