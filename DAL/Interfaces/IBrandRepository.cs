using BDE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Inventory
{
    public interface IBrandRepository
    {
        List<Brand> GetAll();
        List<Brand> GetBrandsBySupplier(int supplierId);

        void Save(Brand brand);
        bool Delete(int brandId);
        void Update(Brand brand);

    }
}
