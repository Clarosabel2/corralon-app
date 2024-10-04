using BDE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_Sale
    {
        public static DataTable GetTypesInvoice()
        {
            return DAL_Sale.GetTypesInvoice();
        }

        public static bool SaveInvoice(BE_Sale newSale)
        {
            if (newSale.DeliveryDate < DateTime.Now.Date)
            {
                throw new Exception("La fecha de entrega no puede ser anterior a la fecha actual.");
            }
            return DAL_Sale.SaveSale(newSale);
        }
    }
}
