using BDE;
using BLL.Mappers;
using DAL;
using SVC;
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
        public static BE_Client GetClientByIdInvoice(int idInvoice)
        {
            DataRow row = DAL_Invoice.GetClientByIdInvoice(idInvoice);
            return ClientMapper.FromDataRow(row);
        }

        public static DataTable GetTypesInvoice()
        {
            return DAL_Invoice.GetTypesInvoice();
        }
    }
}
