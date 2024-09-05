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
    public static class BLL_Venta
    {
        public static DataTable GetTypesInvoice()
        {
            return DAL_Venta.GetTypesInvoice();
        }

        public static void SaveInvoice(BE_Venta newSale)
        {
            
        }
    }
}
