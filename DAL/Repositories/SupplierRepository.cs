using BDE;
using DAL.Purchases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        public bool Delete(int supplierId)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetAll()
        {
            var cnn = new DbConnectionFactory();
            var dt = new DataTable();

            try
            {
                using (var cmd = new SqlCommand("SELECT * FROM Proveedores", cnn.OpenConnection()))
                {
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }

                List<Supplier> suppliers = new List<Supplier>();
                foreach (DataRow row in dt.Rows)
                {
                    Supplier supplier = new Supplier
                    {
                        Id = Convert.ToInt32(row["id_proveedor"]),
                        Name = row["nombre"].ToString(),
                        ContactName = row["nombre_contacto"].ToString(),
                        ContactEmail = row["email"].ToString(),
                        Address = row["domicilio"].ToString(),
                        ContactPhone = row["telefono"].ToString()
                    };
                    //supplier.BrandsAssociated = BLL_Brand.GetBrandsBySupplierId(supplier.Id);
                    suppliers.Add(supplier);
                }
                return suppliers;
            }
            catch (SqlException ex)
            {
                throw new Exception("Error loading suppliers: " + ex.Message);
            }
            finally
            {
                cnn.CloseConnection();
            }
        }

        public bool Save(Supplier supplier)
        {
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            SqlTransaction transaction = null;

            try
            {
                cmd.Connection = cnn.OpenConnection();
                transaction = cmd.Connection.BeginTransaction();
                cmd.Transaction = transaction;
                cmd.CommandText = @"INSERT INTO Proveedores 
                                        (nombre, nombre_contacto, email, domicilio, telefono) 
                                    VALUES 
                                        (@p_name, @p_name_contact, @p_email, @p_address,@p_phone_supplier);
                                    SELECT SCOPE_IDENTITY();";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p_name", supplier.Name);
                cmd.Parameters.AddWithValue("@p_name_contact", supplier.ContactName);
                cmd.Parameters.AddWithValue("@p_email", supplier.ContactEmail);
                cmd.Parameters.AddWithValue("@p_address", supplier.Address);
                cmd.Parameters.AddWithValue("@p_phone_supplier", supplier.ContactPhone);

                int supplierId = Convert.ToInt32(cmd.ExecuteScalar());

                supplier.BrandsAssociated.ForEach(b =>
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO ProveedorMarca (id_proveedor, id_Marca) VALUES (@id_supplier, @id_brand)";
                    cmd.Parameters.AddWithValue("@id_supplier", supplierId);
                    cmd.Parameters.AddWithValue("@id_brand", b.Id);
                    cmd.ExecuteNonQuery();
                });
                transaction.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                transaction?.Rollback();
                throw new Exception("Error registering supplier: " + ex.Message);
            }
            finally
            {
                cnn.CloseConnection();
            }
        }

        public void Update(Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
