using BDE;
using System.Collections.Generic;

namespace BLL.Purchases
{
    public interface ISupplierService
    {
        List<Supplier> GetAll();
        bool Save(Supplier supplier);
        bool Delete(int supplierId);
        void Update(Supplier supplier);
    }
}
