using DAL.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SVC
{
    

    public class DatabaseService
    {
        public void DoBackup(string backupFilePath)
        {
            try
            {
                DAL_Backup.Backup(backupFilePath);
            }
            catch (Exception ex)
            {
                throw new Exception("Error during database backup: " + ex.Message);
            }
        }
        public void DoRestore(string backupFilePath)
        {
            try
            {
                DAL_Backup.Restore(backupFilePath);
            }
            catch (Exception ex)
            {
                throw new Exception("Error during database restore: " + ex.Message);
            }
        }
        

    }
}
