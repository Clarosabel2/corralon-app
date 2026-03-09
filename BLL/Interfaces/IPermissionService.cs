using BDE;
using BDE.Permissions;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IPermissionService
    {
        bool IsAncestor(BE_Permission child, BE_Permission parent);
        List<BE_Family> GetAllPermissionsSystem();
        List<BE_Family> GetAllProfiles();
        List<BE_Permission> GetAllPermissionsByFamily(int familyId);
        List<BE_Family> GetAllProfilesNames();
        BE_Family GetFamilyById(int id);

        void SaveProfile(BE_Family fm);
        void SavePermission(BE_Permission permission);
        void UpdateProfile(BE_Family profile);

        void DeletePermission(BE_Permission permission);
        void DeleteProfile(BE_Family fm);
    }
}
