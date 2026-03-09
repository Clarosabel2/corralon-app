using BDE;
using BLL.Interfaces;
using BLL.Purchases;
using DAL;
using DAL.Purchases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _repository;
        private readonly IEventlogService _eventlogService;

        public SupplierService(ISupplierRepository repository, IEventlogService eventlogService)
        {
            _repository = repository;
            _eventlogService = eventlogService;
        }

        public List<Supplier> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Save(Supplier supplier)
        {
            bool isSaved = _repository.Save(supplier);
            if (isSaved)
            {
                _eventlogService.LogEvent($"Register a new Supplier",
                    BE_EventType.CREATE_SUPPLIER,
                    BDE.Enums.BE_ActivityLevel.SUCCESS);
                return true;
            }
            return false;
        }

        public bool Delete(int supplierId)
        {
            throw new NotImplementedException();
        }

        public void Update(Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
