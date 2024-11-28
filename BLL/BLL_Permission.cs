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
        public static bool IsAncestor(BE_Permission child, BE_Permission parent)
        {
            if (child == null || parent == null)
                return false;

            foreach (var childNode in child.Children)
            {
                if (childNode.Id == parent.Id || IsAncestor(childNode, parent))
                {
                    return true; // Encontrado en la jerarquía
                }
            }
            return false; // No encontrado
        }

        public static void DeleteProfile(BE_Family fm)
        {
            DAL_Permission.DeleteFamily(fm);
        }

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

            /*
            List<BE_Family> toRemove = new List<BE_Family>();

            foreach (BE_Family f in families) // permiso hijo
            {
                foreach (BE_Family f1 in families) // permiso padre
                {
                    if (f.Id != f1.Id)
                    {
                        foreach (BE_Permission fc in f1.Children)
                        {
                            if (fc.Id == f.Id && fc is BE_Family)
                            {
                                if (!toRemove.Contains(f))
                                {
                                    toRemove.Add(f); // Agrega a la lista de eliminaciones
                                }
                            }
                        }
                    }
                }
            }

            // Elimina los elementos después de la enumeración
            families.RemoveAll(f => toRemove.Contains(f));*/

            return families;
        }



        public static List<BE_Family> GetAllProfilesNames()
        {
            return DAL_Permission.GetAllFamiliesByType(isSystem: false);
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
