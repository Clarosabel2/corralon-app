using BDE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVC;
using BDE.Composite;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Collections;
using System.Configuration;

namespace DAL
{
    public static class DAL_Permission
    {
        public static List<BE_Family> GetAllFamiliesByType(bool isSystem)
        {
            List<BE_Family> listF = new List<BE_Family>();
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"select * from Permisos p where p.tipo=1 AND p.isGeneral=@p_type;";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_type", isSystem);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listF.Add(new BE_Family(dr.GetString(dr.GetOrdinal("id_Permiso")), dr.GetString(dr.GetOrdinal("descripcion"))));
            }
            return listF;
        }
        public static List<BE_Permission> GetAllPermissionsByFamily(string idFamily)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"sp_GetChildsByFamilyPermissions";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_idFamily", idFamily);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();

            List<BE_Permission> list = new List<BE_Permission>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string id_permissionFather = "";
                    if (dr["id_PermisoCompuesto"] != DBNull.Value)
                    {
                        id_permissionFather = dr.GetString(dr.GetOrdinal("id_PermisoCompuesto"));
                    }
                    string id = dr.GetString(dr.GetOrdinal("id_Permiso"));
                    string description = dr.GetString(dr.GetOrdinal("descripcion")).ToString();
                    var type = dr.GetBoolean(dr.GetOrdinal("tipo"));
                    var permission = string.Empty;

                    BE_Permission p;
                    if (type)
                    {
                        p = new BE_Family(id, description);
                    }
                    else
                    {
                        p = new BE_Patent(id, description);
                    }
                    var father = GetComponent(id_permissionFather, list);
                    if (father == null)
                    {
                        list.Add(p);
                    }
                    else
                    {
                        father.addChild(p);
                    }
                }
            }
            dr.Close();
            cmd.Connection = cnn.CloseConnection();
            return list;
        }
        private static BE_Permission GetComponent(string id, IList<BE_Permission> list)
        {
            BE_Permission p = list != null ? list.Where(i => i.Id.Equals(id)).FirstOrDefault() : null;
            if (p == null && list != null)
            {
                foreach (var c in list)
                {
                    var l = GetComponent(id, c.Children);
                    if (l != null && l.Id == id) return l;
                    else
                    if (l != null)
                        return GetComponent(id, l.Children);
                }
            }
            return p;
        }

        public static void SaveProfile(BE_Family profile)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"INSERT INTO Permisos (id_Permiso,tipo, descripcion,isGeneral) VALUES (@id_permiso,@type,@description,0)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id_permiso", profile.Id);
            cmd.Parameters.AddWithValue("@type", 1);
            cmd.Parameters.AddWithValue("@description", profile.Description);
            cmd.ExecuteNonQuery();
            if (profile.Children != null && profile.Children.Count != 0)
            {
                var query = @"INSERT INTO RelacionPermiso (id_PermisoCompuesto, id_PermisoSimple) VALUES";
                foreach (var child in profile.Children)
                {
                    query += $"('{profile.Id}','{child.Id}'),";
                }
                query = query.Substring(0, query.Length - 1) + ";";
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            cmd.Connection = cnn.CloseConnection();
        }

        public static void UpdateProfile(BE_Family profile)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"DELETE FROM RelacionPermiso WHERE id_PermisoCompuesto=@id_profile";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id_profile", profile.Id);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            if (profile.Children != null && profile.Children.Count > 0)
            {
                InsertChildrenRecursively(cmd, profile.Id, profile.Children);
            }

            cmd.Connection = cnn.CloseConnection();
        }
        private static void InsertChildrenRecursively(SqlCommand cmd, string parentId, IList<BE_Permission> children)
        {
            foreach (var child in children)
            {
                // Insertar la relación padre-hijo
                cmd.CommandText = @"INSERT INTO RelacionPermiso (id_PermisoCompuesto, id_PermisoSimple) VALUES (@parentId, @childId)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@parentId", parentId);
                cmd.Parameters.AddWithValue("@childId", child.Id);
                cmd.ExecuteNonQuery();

                // Insertar las relaciones de los hijos del hijo recursivamente
                if (child.Children != null && child.Children.Count > 0)
                {
                    InsertChildrenRecursively(cmd, child.Id, child.Children);
                }
            }
        }
        public static void DeleteFamily(BE_Family profile)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();

            cmd.CommandText = @"
                                DELETE FROM RelacionPermiso WHERE id_PermisoCompuesto = @id_profile;
                                DELETE FROM Permisos WHERE id_Permiso = @id_profile;";
            cmd.Parameters.AddWithValue("@id_profile", profile.Id);

            cmd.ExecuteNonQuery();
            cnn.CloseConnection();
        }
    }
}
