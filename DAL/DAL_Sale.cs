using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE;
using System.Net;

namespace DAL
{
    public class DAL_Sale : DAL_Connection
    {
        public static DataRow GetInvoiceById(int idInvoice)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand
            {
                Connection = cnn.OpenConnection(),
                CommandText = "SELECT * FROM Facturas WHERE id_Factura = @p_idFactura",
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddWithValue("@p_idFactura", idInvoice);

            DataTable dataTable = new DataTable();

            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataTable.Load(reader);
                    }
                }

                if (dataTable.Rows.Count > 0)
                {
                    return dataTable.Rows[0];
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la factura por ID: " + ex.Message, ex);
            }
            finally
            {
                cnn.CloseConnection();
            }
        }


        public static DataTable GetProductsByIdInvoice(int idInvoice)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand
            {
                Connection = cnn.OpenConnection(),
                CommandText = "sp_GetProductsByInvoice",
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@p_idFactura", idInvoice);
            var dataTable = new DataTable();

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dataTable.Load(dr);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los productos por factura: " + ex.Message, ex);
            }
            finally
            {
                cnn.CloseConnection();
            }
            return dataTable;
        }

        public static void SaveSale(BE_Order order)
        {
            int idInvoice;
            try
            {
                var cnn = new DAL_Connection();

                using (var cmd = new SqlCommand("sp_SaveInvoice", cnn.OpenConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idCliente", order.Invoice.Client.Id);
                    cmd.Parameters.AddWithValue("@idEmpleado", order.Invoice.Saleman.Id);
                    cmd.Parameters.AddWithValue("@TipoFactura", order.Invoice.TypeInvoice);
                    cmd.Parameters.AddWithValue("@total", order.Invoice.Total);
                    cmd.Parameters.AddWithValue("@estadoFactura", order.Invoice.Status);
                    cmd.Parameters.AddWithValue("@fechaEmision", order.Invoice.IssueDate);
                    cmd.Parameters.AddWithValue("@fechaEntrega", order.DeliveryDate);
                    cmd.Parameters.AddWithValue("@domicilioEntrega", order.AddressDelivery);

                    SqlParameter outputIdParam = new SqlParameter("@@newInvoiceID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(outputIdParam);
                    cmd.ExecuteNonQuery();
                    idInvoice = (int)outputIdParam.Value;
                }

                foreach (var item in order.Invoice.ItemsProducts)
                {
                    using (var itemCmd = new SqlCommand("sp_SaveItemsInvoice", cnn.OpenConnection()))
                    {
                        itemCmd.CommandType = CommandType.StoredProcedure;
                        itemCmd.Parameters.AddWithValue("@idProducto", item.Product.Id);
                        itemCmd.Parameters.AddWithValue("@idFactura", idInvoice);
                        itemCmd.Parameters.AddWithValue("@cantidad", item.Amount);
                        itemCmd.Parameters.AddWithValue("@precio_unitario", item.Product.Price);
                        itemCmd.ExecuteNonQuery();
                    }
                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
