using BDE;
using BLL.Inventory;
using DAL;
using DAL.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BrandService : IBrandService
    {
        private IBrandRepository _repository;

        public BrandService(IBrandRepository repository)
        {
            _repository = repository;
        }

        public List<Brand> GetAll()
        {
            return _repository.GetAll();
        }

        public void Save(Brand b)
        {
            _repository.Save(b);
        }

        public List<Brand> GetBrandsBySupplier(int id)
        {
            return _repository.GetBrandsBySupplier(id);
        }

        public bool Delete(int brandId)
        {
            throw new NotImplementedException();
        }
    }
}
