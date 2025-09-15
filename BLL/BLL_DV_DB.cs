using BDE;
using DAL.DB;
using SVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DV_DB
    {
        public bool IsDVInconsistent { get; private set; } = false;
        public List<DvhMismatch> LastMismatches { get; private set; } = new List<DvhMismatch>();
        public BLL_DV_DB()
        {
            CheckDatabaseIntegrity();
        }
        public bool CheckDatabaseIntegrity()
        {
            try
            {
                List<DvhMismatch> mismatches;
                var ok = VerifyIntegrityDVH(out mismatches);
                this.LastMismatches = mismatches;
                if (ok)
                {
                    return this.IsDVInconsistent = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking database integrity: " + ex.Message, ex);
            }
            return this.IsDVInconsistent = true;
        }

        public bool VerifyIntegrityDVH(out List<DvhMismatch> mismatches)
        {
            mismatches = new List<DvhMismatch>();
            var dvhTable = DAL_Integrity.GetDataTable("tb_DVH");

            foreach (var table in DAL_Integrity
                     .GetTablesExistingDB())
            {

                var recalculated = GetValuesDVHForTable(table);
                var storedForTable = dvhTable.Rows
                    .Cast<DataRow>()
                    .Where(r => string.Equals(Convert.ToString(r["table"]), table, StringComparison.OrdinalIgnoreCase))
                    .ToDictionary(
                        r => Convert.ToString(r["id_reg"]),
                        r => Convert.ToString(r["hash_dvh"]),
                        StringComparer.Ordinal
                    );

                foreach (var kvp in recalculated)
                {
                    var rowKey = kvp.Key;
                    var recalcDvh = kvp.Value;

                    string storedDvh;
                    if (!storedForTable.TryGetValue(rowKey, out storedDvh))
                    {
                        mismatches.Add(new DvhMismatch(
                            table,
                            rowKey,
                            "MISSING_IN_DVH"
                        ));
                    }
                    else if (!string.Equals(storedDvh, recalcDvh, StringComparison.OrdinalIgnoreCase))
                    {
                        mismatches.Add(new DvhMismatch(
                            table,
                            rowKey,
                            "DIFF"
                        ));
                    }
                }
                foreach (var stored in storedForTable)
                {
                    if (!recalculated.ContainsKey(stored.Key))
                    {
                        mismatches.Add(new DvhMismatch(
                            table,
                            null,
                            "ORPHAN_IN_DVH"
                        ));
                    }
                }
            }
            
            return mismatches.Count == 0;
        }


        public void CalculateAllDVH()
        {
            foreach (var table in DAL_Integrity
                .GetTablesExistingDB()
                .ToList())
            {
                DAL_Integrity.SaveDVHTable(table, GetValuesDVHForTable(table));
            }
        }

        private Dictionary<string, string> GetValuesDVHForTable(string table)
        {
            DataTable dt = DAL_Integrity.GetDataTable(table);
            var rowHashes = new Dictionary<string, string>();

            foreach (DataRow row in dt.Rows)
            {
                string regToHashed = "";

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        regToHashed += row[i].ToString();
                    }
                    else
                    {
                        regToHashed += "<NULL>";
                    }
                }

                string rowKey = row[0].ToString();
                string dvh = SHAHashHelper.HashValue(regToHashed);
                rowHashes[rowKey] = dvh;
            }
            return rowHashes;
        }
    }
}
