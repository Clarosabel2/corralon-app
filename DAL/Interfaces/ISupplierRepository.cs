using BDE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Purchases
{
    public interface ISupplierRepository
    {
        List<Supplier> GetAll();
        bool Save(Supplier supplier);
        bool Delete(int supplierId);
        void Update(Supplier supplier);
    }
}
