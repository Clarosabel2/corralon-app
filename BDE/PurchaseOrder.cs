using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string SupplierName { get; set; } // o una relación con una entidad Supplier
        public List<BE_Item> Items { get; set; }
        public string Observations { get; set; }
        public bool IsDelivered { get; set; }
    }
}
