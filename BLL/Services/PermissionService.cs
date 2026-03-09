using BDE;
using BDE.Permissions;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;

        public PermissionService(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        public bool IsAncestor(BE_Permission child, BE_Permission parent)
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

        public void DeleteProfile(BE_Family fm)
        {
            _permissionRepository.Delete(fm);
        }

        public List<BE_Family> GetAllPermissionsSystem()
        {
            List<BE_Family> families = _permissionRepository.GetAllByType(isSystem: true);
            families
                .ForEach(f => _permissionRepository.GetAllByFamily(f.Id)
                    .ForEach(c => f.addChild(c)));
            return families;
        }

        public List<BE_Family> GetAllProfiles()
        {
            List<BE_Family> families = _permissionRepository.GetAllByType(isSystem: false);
            families
                .ForEach(f => _permissionRepository.GetAllByFamily(f.Id)
                    .ForEach(c => f.addChild(c)));

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

            //Elimina los elementos después de la enumeración
            families.RemoveAll(f => toRemove.Contains(f));

            return families;
        }

        public List<BE_Family> GetAllProfilesNames()
        {
            return _permissionRepository.GetAllByType(isSystem: false);
        }

        public void SaveProfile(BE_Family profile)
        {
            _permissionRepository.Save(profile);
        }

        public void UpdateProfile(BE_Family profile)
        {
            _permissionRepository.Update(profile);
        }

        public List<BE_Permission> GetAllPermissionsByFamily(int familyId)
        {
            throw new NotImplementedException();
        }

        public BE_Family GetFamilyById(int id)
        {
            throw new NotImplementedException();
        }

        public void SavePermission(BE_Permission permission)
        {
            throw new NotImplementedException();
        }

        public void DeletePermission(BE_Permission permission)
        {
            throw new NotImplementedException();
        }
    }
}
