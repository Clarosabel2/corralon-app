using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB
{
    public static class DAL_Backup
    {
        public static void Backup(string backupFilePath)
        {
            string backupFileName = $"corralondb_{DateTime.Now:yyyyMMdd}.bak";
            backupFilePath = Path.Combine(backupFilePath, backupFileName);
            try
            {
                string backupQuery = $@"BACKUP DATABASE [corralondb] TO  DISK = N'{backupFilePath}' WITH NOFORMAT, NOINIT,  NAME = N'corralondb-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";


                Console.WriteLine("Backup path: " + backupFilePath);
                var cnn = new DAL_Connection();
                using (var connection = cnn.OpenConnection())
                using (var cmd = new SqlCommand(backupQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error creating backup: " + ex.Message);
            }
        }
        public static void Restore(string backupFilePath)
        {
            try
            {
                string restoreQuery = $@"
                    RESTORE DATABASE [corralondb] 
                    FROM DISK = '{backupFilePath}' 
                    WITH 
                        REPLACE, 
                        STATS = 10";
                var cnn = new DAL_Connection();
                using (var connection = cnn.OpenConnection())
                using (var cmd = new SqlCommand(restoreQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error restoring backup: " + ex.Message);
            }
        }
    }
}
