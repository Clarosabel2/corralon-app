using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Invoice
    {
        public static DataTable GetTypesInvoice()
        {
            return DAL_Invoice.GetTypesInvoice();
        }
    }
}
