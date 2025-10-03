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
        private static string appRoot = AppDomain.CurrentDomain.BaseDirectory;
        private static string backupFolder = Path.Combine(appRoot, "Backups");
        private static void CheckDirectoryBackups()
        {
            if (!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
            }
        }
        public static void Backup()
        {
            CheckDirectoryBackups();

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string backupFileName = $"corralondb_full_{timestamp}.bak";
            string backupFilePath = Path.Combine(backupFolder, backupFileName);
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
                System.Diagnostics.Process.Start("explorer.exe", backupFolder);

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
