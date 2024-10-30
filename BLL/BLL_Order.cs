using BDE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Order
    {
        private static BE_Order newOrder;
        public static void CreateOrder(DateTime deliveryDate, BE_Sale sale)
        {
            newOrder = new BE_Order(deliveryDate, sale);
        }
        public static bool SaveOrder()
        {
            if (newOrder.DeliveryDate < DateTime.Now.Date) throw new Exception("La fecha de entrega no puede ser anterior a la fecha actual.");


            if (BLL_Sale.SaveInvoice(out int idInvoice))
            {
                newOrder.Invoice.Id = idInvoice;
            }
            else
            {
                throw new Exception("Error al guardar la factura");
            }

            return DAL_Order.SaveOrder(newOrder);

        }
    }
}
