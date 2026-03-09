using BDE;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IAuditService
    {
        bool RestoreValue(Audit audit);
        List<Audit> GetChanges();
    }
}
