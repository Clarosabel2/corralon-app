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
        public static DataTable GetTypesInvoice()
        {
            var cnn = new DAL_Connection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT t.id_Tipo, t.tipo FROM TipoFactura t", cnn.Connection);
            adapter.SelectCommand.CommandType = CommandType.Text;
            adapter.Fill(table);
            return table;
        }

        public static bool SaveSale(BE_Sale newSale)
        {
            try
            {
                var cnn = new DAL_Connection();
                var cmd = new SqlCommand();
                cmd.Connection = cnn.OpenConnection();
                cmd.CommandText = @"sp_SaveInvoice";
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
        private static void CreateProofDelivery()
        {

        }
    }
}
