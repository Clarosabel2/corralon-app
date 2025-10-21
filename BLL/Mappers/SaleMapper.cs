using BDE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    internal static class SaleMapper
    {
        public static BE_Sale FromDataRow(DataRow r)
        {
            return new BE_Sale(
                r.Field<int>("id_Factura"),
                'A',
                r.Field<DateTime>("fecha"),
                BLL_Client.GetClientById((r.Field<int>("id_Cliente")).ToString()),
                BLL_Employee.GetEmployeeById(r.Field<int>("id_Empleado")),
                BLL_Sale.GetProductsByIdInvoice(r.Field<int>("id_Factura")),
                Convert.ToDouble(r.Field<double?>("total") ?? 0.0),
                /*r.Field<bool?>("estado") ??*/ false
                );
        }
    }
}
