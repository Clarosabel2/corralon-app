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
        public static List<BE_Family> GetAllPermissions(bool type) {
            return DAL_Permission.GetAllPermissions(type);
        }

        public static void SaveProfile(BE_Family profile)
        {
            DAL_Permission.SaveProfile(profile);
        }
    }
}
