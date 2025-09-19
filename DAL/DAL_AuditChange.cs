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
    public static class DAL_AuditChange
    {
        public static DataTable GetAuditChanges()
        {
            var cnn = new DAL_Connection();
            DataTable dt = new DataTable();
            using (var connection = cnn.OpenConnection())
            {
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM tb_AuditChanges", connection);
                ad.Fill(dt);
            }
            return dt;
        }

        public static bool RestoreValue(BE_AuditChange audit)
        {
            var cnn = new DAL_Connection();
            try
            {
                using (var cmd = new SqlCommand("dbo.sp_AuditRestore_Simple_ByAuditID", cnn.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                        
                    cmd.Parameters.AddWithValue("@AuditID", audit.AuditID);
                    cmd.Parameters.AddWithValue("@TableName", audit.TableName);
                    cmd.Parameters.AddWithValue("@ColumnName", audit.ColumnName);
                    cmd.Parameters.AddWithValue("@RowId", audit.RowKey ?? (object)DBNull.Value);

                    cnn.Connection.Open();
                    using (var rdr = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (rdr.Read())
                        {
                            var rows = rdr["RowsAffected"] != DBNull.Value ? Convert.ToInt32(rdr["RowsAffected"]) : 0;
                            return rows > 0;
                        }
                    }

                    return false;
                }
            }
            catch
            {
                // opcional: loguear el error
                return false;
            }
        }
    }
}
