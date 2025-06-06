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

        public static DataTable GetDVHTable(string table)
        {
            DataTable DVHTable = new DataTable();
            
            return DVHTable;
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
    }
}
