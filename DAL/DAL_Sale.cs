using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE;

namespace DAL
{
    public class DAL_Sale : DAL_Connection
    {
        public static bool SaveSale(BE_Sale newSale)
        {
            try
            {
                var cnn = new DAL_Connection();

                using (var cmd = new SqlCommand("sp_SaveInvoice", cnn.OpenConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idCliente", newSale.Client.Id);
                    cmd.Parameters.AddWithValue("@idEmpleado", newSale.Saleman.Id);
                    cmd.Parameters.AddWithValue("@TipoFactura", newSale.TypeInvoice);
                    cmd.Parameters.AddWithValue("@total", newSale.Total);
                    cmd.Parameters.AddWithValue("@estadoFactura", newSale.Status);
                    cmd.Parameters.AddWithValue("@fechaEmision", newSale.Date);

                    SqlParameter outputIdParam = new SqlParameter("@newInvoiceID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(outputIdParam);
                    cmd.ExecuteNonQuery();
                    newSale.Id = (int)outputIdParam.Value;
                }

                foreach (var item in newSale.ItemsProducts)
                {
                    using (var itemCmd = new SqlCommand("sp_SaveItemsInvoice", cnn.OpenConnection()))
                    {
                        itemCmd.CommandType = CommandType.StoredProcedure;
                        itemCmd.Parameters.AddWithValue("@idProducto", item.Product.Id);
                        itemCmd.Parameters.AddWithValue("@idFactura", newSale.Id);
                        itemCmd.Parameters.AddWithValue("@cantidad", item.Amount);
                        itemCmd.Parameters.AddWithValue("@precio_unitario", item.Product.Price);
                        itemCmd.ExecuteNonQuery();
                    }
                }
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
