using BDE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Order
    {
        public static void DepatchOrder(int id_invoice, BE_Employee dealer, DateTime departureTime)
        {
            try
            {
                var cnn = new DAL_Connection();
                var cmd = new SqlCommand
                {
                    Connection = cnn.OpenConnection(),
                    CommandText = "UPDATE Pedidos SET id_Empleado=@p_idEmployee, hora_salida=@p_departuraTime  where id_Factura=@p_idInvoice",
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@p_idInvoice", id_invoice);
                cmd.Parameters.AddWithValue("@p_idEmployee", dealer.Id);
                cmd.Parameters.AddWithValue("@p_departuraTime", departureTime);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable GetAllPendingOrders()
        {
            var cnn = new DAL_Connection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("sp_GetAllPendingOrder", cnn.Connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(table);
            return table;
        }

        public static DataTable GetOrdersDispatched()
        {
            var cnn = new DAL_Connection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("sp_GetOrdersDepatched"
                , cnn.Connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@status", 0);
            adapter.Fill(table);
            return table;
        }

        public static void MarkDeliveredOrder(int idInvoice)
        {
            try
            {
                var cnn = new DAL_Connection();
                var cmd = new SqlCommand
                {
                    Connection = cnn.OpenConnection(),
                    CommandText = "UPDATE Pedidos SET estado = 1, hora_llegada = @hora_llegada WHERE id_Factura = @p_idInvoice",
                    CommandType = CommandType.Text
                };

                cmd.Parameters.AddWithValue("@hora_llegada", DateTime.Now);
                cmd.Parameters.AddWithValue("@p_idInvoice", idInvoice);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
