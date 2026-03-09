using BDE;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IDbMaintenanceService
    {
        bool IsDVInconsistent { get; }
        List<DvMismatch> LastMismatches { get; }
        void BackupDatabase(string backupPath);
        void RestoreDatabase(string backupFilePath);
        bool CheckIntegrity();
        void RecalculateDV();
        void CalculateDVHDatabase();
    }
}
