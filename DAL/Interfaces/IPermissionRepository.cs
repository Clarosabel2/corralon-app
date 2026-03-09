using BDE;
using BDE.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IPermissionRepository
    {
        void Save(BE_Family profile);
        void Update(BE_Family profile);
        void Delete(BE_Family profile);
        List<BE_Family> GetAllByType(bool isSystem);
        List<BE_Permission> GetAllByFamily(string idFamily);
    }
}
