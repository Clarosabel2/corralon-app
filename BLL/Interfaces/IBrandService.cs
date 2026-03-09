using BDE;
using System.Collections.Generic;

namespace BLL.Inventory
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetBrandsBySupplier(int supplierId);
        void Save(Brand b);
        bool Delete(int brandId);
    }
}
