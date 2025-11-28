using BDE;
using DAL;
using DAL.DB;
using SVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_DV_DB
    {
        public static bool IsDVInconsistent { get; private set; } = false;
        public static List<DvMismatch> LastMismatches { get; set; } = new List<DvMismatch>();

        public static bool CheckDatabaseIntegrity()
        {
            try
            {
                
                IsDVInconsistent = !VerifyIntegrityDVH() && !VerifyIntegrityDVV();
                return IsDVInconsistent;
            }
            catch (Exception ex)
            {
                throw new Exception("Error checking database integrity: " + ex.Message, ex);
            }
        }

        private static bool VerifyIntegrityDVV()
        {
            LastMismatches.RemoveAll(m => m.DvKind == DvKind.DVV);
            return true;
        }
        #region DVH

        /// <summary>
        /// Verifica la integridad horizontal (DVH) de las tablas auditadas que poseen clave primaria (PK).
        /// Para cada tabla, recalcula el DVH de cada fila y lo compara contra el valor almacenado en tb_DVH,
        /// detectando filas sin registro de DVH, diferencias de hash y registros huérfanos en tb_DVH.
        /// </summary>
        /// <returns>
        /// true si no se detectan discrepancias de DVH; false si existe al menos una inconsistencia.
        /// </returns>
        /// <remarks>
        /// Requiere que la tabla de control tb_DVH contenga las columnas: table, id_reg y hash_dvh.
        /// Solo se consideran tablas con PK para poder identificar unívocamente cada fila.
        /// </remarks>
        private static bool VerifyIntegrityDVH()
        {
            LastMismatches.RemoveAll(m => m.DvKind == DvKind.DVH);
            var dvhTable = DAL_Utility.GetDataTable("tb_DVH");
            foreach (var table in DAL_Utility
                     .GetTablesExistingDB())
            {
                var recalculated = GetValuesDVHForDataTable(DAL_Utility.GetDataTable(table));

                var storedForTable = dvhTable.Rows
                    .Cast<DataRow>()
                    .Where(
                        r => string.Equals(Convert.ToString(r["table"]), table, StringComparison.OrdinalIgnoreCase))
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

                    // Si NO existe el id_reg en tb_DVH -> falta registrar el DVH (inserción sin auditoría)
                    if (!storedForTable.TryGetValue(rowKey, out storedDvh))
                    {
                        LastMismatches.Add(new DvMismatch(
                            table,
                            rowKey,
                            DvErrorKind.MISSING_HASH,
                            DvKind.DVH
                        ));
                    }
                    // Si existe, pero el hash no coincide -> datos alterados sin actualizar DVH
                    else if (!string.Equals(storedDvh, recalcDvh, StringComparison.OrdinalIgnoreCase))
                    {
                        LastMismatches.Add(new DvMismatch(
                            table,
                            rowKey,
                            DvErrorKind.DIFF_HASH,
                            DvKind.DVH
                        ));
                    }
                }
                // --- CRUCE 2: Detectar DVH “huérfanos” (están en tb_DVH pero no existen ya en la tabla real) ---
                foreach (var stored in storedForTable)
                {
                    // Si una clave de tb_DVH no se encontró en el recalculado -> no existe la fila real
                    if (!recalculated.ContainsKey(stored.Key))
                    {
                        LastMismatches.Add(new DvMismatch(
                            table,
                            null,
                            DvErrorKind.ORPHAN_HASH,
                            DvKind.DVH
                        ));
                    }
                }
            }
            return LastMismatches.Count == 0;
        }

        public static void CalculateDVHDatabase()
        {
            foreach (var table in DAL_Utility
                .GetTablesExistingDB()
                .ToList())
            {
                DataTable dt = DAL_Utility.GetDataTable(table);
                DAL_Integrity.SaveDVHTable(table, GetValuesDVHForDataTable(dt));
            }
        }

        /// <summary>
        /// Esta funcion permite obtener los hashes de una tabla
        /// </summary>
        /// <param name="table"></param>
        /// <returns>Retorna los Hashes DVH de una DataTable otorgada.</returns>
        private static Dictionary<string, string> GetValuesDVHForDataTable(DataTable table)
        {
            var rowHashes = new Dictionary<string, string>();

            foreach (DataRow row in table.Rows)
            {
                string regToHashed = "";

                for (int i = 0; i < table.Columns.Count; i++)
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

        public static void RecalculateDV()
        {
            var dvhMismatches = new List<DvMismatch>();
            var dvvMismatches = new List<DvMismatch>();

            foreach (var m in LastMismatches ?? Enumerable.Empty<DvMismatch>())
            {
                if (m.DvKind == DvKind.DVH) dvhMismatches.Add(m);
                else if (m.DvKind == DvKind.DVV) dvvMismatches.Add(m);
            }

            if (dvhMismatches.Count > 0)
            {
                foreach (DvMismatch m in dvhMismatches)
                {
                    DataRow r = DAL_Utility.GetRowById(m.TableName, m.RowKey);
                    string hashRecalculated = SHAHashHelper.HashValue(ConcatDataRow(r));
                    try
                    {
                        switch (m.KindError)
                        {
                            case DvErrorKind.DIFF_HASH:
                                DAL_Integrity.UpdateRowHashInDvhTable(m.TableName, m.RowKey, hashRecalculated);
                                break;
                            case DvErrorKind.MISSING_HASH:
                                break;
                            case DvErrorKind.ORPHAN_HASH:
                                break;
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

            if (dvvMismatches.Count > 0)
            {

            }
            CheckDatabaseIntegrity();
        }
        private static string ConcatDataRow(DataRow r)
        {
            string regSum = string.Empty;
            for (int i = 0; i < r.Table.Columns.Count; i++)
            {
                if (r[i] != DBNull.Value)
                {
                    regSum += r[i].ToString();
                }
                else
                {
                    regSum += "<NULL>";
                }
            }
            return regSum;
        }
        #endregion
        #region DVV

        #endregion
    }
}
