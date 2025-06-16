using BDE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Supplier
    {
        public static DataTable GetAllSuppliers()
        {
            var cnn = new DAL_Connection();
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
                return dt;
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

        public static bool RegisterSupplier(BE_Supplier newSup)
        {
            var cnn = new DAL_Connection();
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
                cmd.Parameters.AddWithValue("@p_name", newSup.Name);
                cmd.Parameters.AddWithValue("@p_name_contact", newSup.ContactName);
                cmd.Parameters.AddWithValue("@p_email", newSup.ContactEmail);
                cmd.Parameters.AddWithValue("@p_address", newSup.Address);
                cmd.Parameters.AddWithValue("@p_phone_supplier", newSup.ContactPhone);

                int supplierId = Convert.ToInt32(cmd.ExecuteScalar());

                newSup.BrandsAssociated.ForEach(b =>
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
    }
}
