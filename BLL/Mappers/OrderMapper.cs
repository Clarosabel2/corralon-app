using BDE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class OrderMapper
    {
        public static BE_Order FromDataRow(DataRow r)
        {
            return new BE_Order
            {
                DeliveryDate = r.Field<DateTime>("fecha_entrega"),
                Status = r.Field<bool>("estado"),
                DepartureDate = r.Field<DateTime?>("hora_salida") ?? default(DateTime),
                ArrivalDate = r.Field<DateTime?>("hora_llegada") ?? default(DateTime),
                Dealer = BLL_Employee.GetEmployeeById(r.Field<int>("id_Empleado")) ?? throw new Exception("id empleado null"),
                Invoice = BLL_Sale.GetInvoiceById(r.Field<int>("id_Factura"))
            };
        }
    }
}
