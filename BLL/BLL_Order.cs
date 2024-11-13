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
    }
}
