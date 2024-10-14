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
        public static bool SaveOrder(BE_Order newOrder)
        {
            try
            {
                var cnn = new DAL_Connection();
                using (var cmd = new SqlCommand("INSERT INTO Pedidos (id_Factura,estado,fecha_entrega) VALUES (@idFactura,@est,@fecha)", cnn.OpenConnection()))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@idFactura", newOrder.Invoice.Id);
                    cmd.Parameters.AddWithValue("@est", newOrder.Status);
                    cmd.Parameters.AddWithValue("@fecha", newOrder.DeliveryDate);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
