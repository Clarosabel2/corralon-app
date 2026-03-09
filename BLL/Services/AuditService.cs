using BDE;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AuditService : IAuditService
    {
        private readonly IAuditRepository _auditRepository;
        public AuditService(IAuditRepository auditRepository)
        {
            this._auditRepository = auditRepository;
        }

        public bool RestoreValue(Audit audit)
        {
            return _auditRepository.RestoreValue(audit);
        }

        public List<Audit> GetChanges()
        {
            DataTable tableAuditChanges = _auditRepository.GetChanges();
            var list = new List<Audit>();

            foreach (DataRow row in tableAuditChanges.Rows)
            {
                var audit = new Audit
                {
                    AuditID = row.Field<int>("AuditID"),
                    TableName = row.Field<string>("TableName") ?? string.Empty,
                    ColumnName = row.Field<string>("ColumnName") ?? string.Empty,
                    Operation = MapOperation(row.Field<string>("Operation")),
                    RowKey = row.Field<string>("RowKey") ?? string.Empty,
                    OldValue = row.IsNull("OldValue") ? null : row["OldValue"].ToString(),
                    NewValue = row.IsNull("NewValue") ? null : row["NewValue"].ToString(),
                    ChangeDate = row.Field<DateTime>("ChangeDate"),
                    ChangedBy = row.IsNull("ChangedBy") ? null : row["ChangedBy"].ToString()
                };

                list.Add(audit);
            }

            return list;
        }

        private static string MapOperation(string raw)
        {
            if (raw == null) return string.Empty;

            switch (raw.Trim().ToUpperInvariant())
            {
                case "U":
                case "UPDATE":
                    return "UPDATE";

                case "C":
                case "I":
                case "INSERT":
                    return "CREATE";

                case "D":
                case "DELETE":
                    return "DELETE";

                default:
                    return raw;
            }
        }

    }
}
