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

namespace DAL
{
    public static class DAL_Permission
    {
        public static List<BE_Family> GetAllPermissions(bool type)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"SELECT * FROM Permisos WHERE IsGeneral=@Type AND tipo=1";
            cmd.Parameters.AddWithValue("@Type", type);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            var permissions = new List<BE_Family>();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    var f = new BE_Family(dr["id_Permiso"].ToString(), dr["descripcion"].ToString());

                    GetPatentsByFamily(f)
                        .ForEach(p => f.addChild(new BE_Patent(p.Id, p.Description)));

                    permissions.Add(f);
                }

            }

            return permissions;
        }

        public static void SaveProfile(BE_Family profile)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"sp_SaveProfile";
            cmd.CommandType= CommandType.StoredProcedure;
            Console.WriteLine(profile.Id);
            //CREACION FAMILIA
            foreach (var item in profile.Children)
            {
                //ASOCIACION DE LAS PATENES CON LA FAMILIA CREADA.
                //RECURSIVIDAD
                /*
                Console.WriteLine(item.Id.ToString());
                if (item.Children != null)
                {
                    foreach (var item1 in item.Children)
                    {
                        Console.WriteLine(item1.Id.ToString());
                    }
                }*/
            }
        }
        private static void sasda(SqlCommand cmd)
        {

        }

        private static List<BE_Patent> GetPatentsByFamily(BE_Family f)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"SELECT 
                                    p.id_Permiso,
                                    p.descripcion 
                                FROM 
                                    Permisos p
                                INNER JOIN 
                                    RelacionPermiso rp ON p.id_Permiso = rp.id_PermisoSimple
                                WHERE rp.id_PermisoCompuesto = @idFamily ;";

            cmd.Parameters.AddWithValue("@idFamily", f.Id);
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            var patents = new List<BE_Patent>();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    patents.Add(new BE_Patent(dr["id_Permiso"].ToString(), dr["descripcion"].ToString()));
                }

            }
            return patents;
        }
    }
}
