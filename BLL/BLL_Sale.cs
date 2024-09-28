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

        public static void SaveInvoice(BE_Sale newSale)
        {
            DAL_Sale.SaveInvoice(newSale);
        }
    }
}
