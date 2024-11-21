using BDE;
using BDE.Composite;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_Permission
    {
        public static List<BE_Family> GetAllPermissionsSystem()
        {
            List<BE_Family> families = DAL_Permission.GetAllFamiliesByType(isSystem: true);
            families
                .ForEach(f => DAL_Permission.GetAllPermissionsByFamily(f.Id)
                    .ForEach(c => f.addChild(c)));
            return families;
        }

        public static List<BE_Family> GetAllProfiles()
        {
            List<BE_Family> families = DAL_Permission.GetAllFamiliesByType(isSystem: false);
            families
                .ForEach(f => DAL_Permission.GetAllPermissionsByFamily(f.Id)
                    .ForEach(c => f.addChild(c)));
            return families;
        }

        public static List<BE_Family> GetAllProfilesNames()
        {
            return DAL_Permission.GetAllFamiliesByType (isSystem: false);
        }

        public static void SaveProfile(BE_Family profile)
        {
            DAL_Permission.SaveProfile(profile);
        }

        public static void UpdateProfile(BE_Family profile)
        {
            DAL_Permission.UpdateProfile(profile);
        }
    }
}
