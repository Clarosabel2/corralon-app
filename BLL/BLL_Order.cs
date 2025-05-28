using BDE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Order
    {
        public static void DepatchOrder(int id_invoice, BE_Employee key)
        {
            DAL_Order.DepatchOrder(id_invoice, key, DateTime.Now);
        }

        public static DataTable GetAllPendingOrders()
        {
            return DAL_Order.GetAllPendingOrders();
        }

        public static DataTable GetOrdersDispatched()
        {
            return DAL_Order.GetOrdersDispatched();
        }

        public static void MarkDeliveredOrder(int idInvoice)
        {
            DAL_Order.MarkDeliveredOrder(idInvoice);
        }

    }
}
