using BDE;
using BLL.Interfaces;
using DAL.Services;
using SVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DbMaintenanceService : IDbMaintenanceService
    {
        private readonly DatabaseBackupService _backupService;
        private readonly DataIntegrityService _dataIntegrityService;
        private readonly DatabaseSchemaService _dbSchemaService;
        public bool IsDVInconsistent { get; private set; } = false;
        public List<DvMismatch> LastMismatches { get; set; } = new List<DvMismatch>();

        public DbMaintenanceService()
        {
            _backupService = new DatabaseBackupService();
            _dataIntegrityService = new DataIntegrityService();
            _dbSchemaService = new DatabaseSchemaService();
        }

        public void BackupDatabase(string backupPath)
        {
            if (string.IsNullOrWhiteSpace(backupPath))
                throw new ArgumentException("Backup path cannot be empty.");

            try
            {
                _backupService.Backup(backupPath);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while creating database backup.", ex);
            }
        }

        public void RestoreDatabase(string backupFilePath)
        {
            if (string.IsNullOrWhiteSpace(backupFilePath))
                throw new ArgumentException("Backup file path cannot be empty.");

            try
            {
                _backupService.Restore(backupFilePath);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while restoring database.", ex);
            }
        }

        public bool CheckIntegrity()
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

        public void RecalculateDV()
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
                    DataRow r = _dbSchemaService.GetRowById(m.TableName, m.RowKey);
                    string hashRecalculated = SHAHashHelper.HashValue(ConcatDataRow(r));
                    try
                    {
                        switch (m.KindError)
                        {
                            case DvErrorKind.DIFF_HASH:
                                _dataIntegrityService.UpdateRowHashInDvhTable(m.TableName, m.RowKey, hashRecalculated);
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
            CheckIntegrity();
        }

        private bool VerifyIntegrityDVH()
        {
            LastMismatches.RemoveAll(m => m.DvKind == DvKind.DVH);
            var dvhTable = _dbSchemaService.GetDataTable("tb_DVH");
            foreach (var table in _dbSchemaService
                     .GetTablesExistingDB())
            {
                var recalculated = GetValuesDVHForDataTable(_dbSchemaService.GetDataTable(table));

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

        public void CalculateDVHDatabase()
        {
            foreach (var table in _dbSchemaService
                .GetTablesExistingDB()
                .ToList())
            {
                DataTable dt = _dbSchemaService.GetDataTable(table);
                _dataIntegrityService.SaveDVHTable(table, GetValuesDVHForDataTable(dt));
            }
        }

        private bool VerifyIntegrityDVV()
        {
            LastMismatches.RemoveAll(m => m.DvKind == DvKind.DVV);
            return true;
        }
    }
}
