using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class DatabaseBackupService
    {
        private static string appRoot = AppDomain.CurrentDomain.BaseDirectory;
        private static string backupFolder = Path.Combine(appRoot, "Backups");
        private void CheckDirectoryBackups()
        {
            if (!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
            }
        }
        public void Backup(string userSelectedPathOrNull)
        {
            CheckDirectoryBackups();
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string backupFileName = $"corralondb_full_{timestamp}.bak";

            
            string internalBackupFullPath = Path.Combine(backupFolder, backupFileName);

            try
            {
                string backupQuery = $@"
                                        BACKUP DATABASE [corralondb]
                                        TO DISK = N'{internalBackupFullPath.Replace("'", "''")}'
                                        WITH NOFORMAT, NOINIT,
                                             NAME = N'corralondb-Full Database Backup',
                                             SKIP, NOREWIND, NOUNLOAD, STATS = 10";

                var cnn = new DbConnectionFactory();
                using (var connection = cnn.OpenConnection())
                using (var cmd = new SqlCommand(backupQuery, connection))
                {
                    cmd.ExecuteNonQuery();
                }
                
                if (!string.IsNullOrWhiteSpace(userSelectedPathOrNull))
                {
                    string finalDestPath;

                    if (Directory.Exists(userSelectedPathOrNull))
                    {
                        finalDestPath = Path.Combine(userSelectedPathOrNull, backupFileName);
                    }
                    else
                    {
         
                        finalDestPath = userSelectedPathOrNull;
                    }

                    File.Copy(internalBackupFullPath, finalDestPath, overwrite: true);
                    string finalFolder = Path.GetDirectoryName(finalDestPath);
                    if (!string.IsNullOrEmpty(finalFolder))
                    {
                        System.Diagnostics.Process.Start("explorer.exe", finalFolder);
                    }
                }
                else
                {
                    System.Diagnostics.Process.Start("explorer.exe", backupFolder);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error creating backup: " + ex.Message, ex);
            }
        }
        public void Restore(string backupFilePath)
        {
            try
            {
                string restoreQuery = $@"
                    RESTORE DATABASE [corralondb] 
                    FROM DISK = '{backupFilePath}' 
                    WITH 
                        REPLACE, 
                        STATS = 10";
                var cnn = new DbConnectionFactory();
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
