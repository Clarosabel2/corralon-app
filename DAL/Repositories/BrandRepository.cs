using BDE;
using DAL.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BrandRepository : IBrandRepository
    { 

        public bool Delete(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            var cnn = new DbConnectionFactory();
            DataTable dt = new DataTable();
            List<Brand> brands = new List<Brand>();

            using (var connection = cnn.OpenConnection())
            {
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Marcas", connection);
                ad.Fill(dt);
            }

            foreach (DataRow r in dt.Rows)
            {
                brands.Add(new Brand
                {
                    Id = Convert.ToInt32(r[0]),
                    NameBrand = r[1].ToString(),
                    Description = r[2].ToString()
                });
            }
            return brands;
        }

        public List<Brand> GetBrandsBySupplier(int supplierId)
        {
            var cnn = new DbConnectionFactory();
            var dt = new DataTable();

            try
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cnn.OpenConnection();
                    cmd.CommandText = @"
                                        SELECT m.id_Marca, m.NombreMarca, m.Descripcion
                                        FROM Marcas m
                                        INNER JOIN ProveedorMarca pm ON m.id_Marca = pm.id_Marca
                                        WHERE pm.id_proveedor = @p_id_supplier";

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@p_id_supplier", supplierId);

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }

                return dt.AsEnumerable()
                         .Select(r => new Brand
                         {
                             Id = Convert.ToInt32(r[0]),
                             NameBrand = r[1].ToString(),
                             Description = r[2].ToString()
                         })
                         .ToList();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error retrieving brands by supplier ID: " + ex.Message);
            }
            finally
            {
                cnn.CloseConnection();
            }
        }


        public void Save(Brand brand)
        {
            var cnn = new DbConnectionFactory();
            using (var connection = cnn.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Marcas (marca) VALUES (@p_nombreMarca)", connection);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@p_nombreMarca", brand.NameBrand);

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
