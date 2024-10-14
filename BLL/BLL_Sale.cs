using BDE;
using DAL;
using SVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_Sale
    {
        public static BE_Sale newSale { get; set; }

        public static void CreateSale()
        {
            newSale = new BE_Sale();
            newSale.Saleman = SessionManager.GetInstance.user.Emp;
        }

        public static bool SaveInvoice(out int idInvoice)
        {
            return DAL_Sale.SaveSale(newSale, out idInvoice);
        }
    }
}
