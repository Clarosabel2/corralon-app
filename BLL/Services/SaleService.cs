using BDE;
using BLL.Interfaces;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IProductService _productService;
        public List<Item> GetItemsBySaleId(int saleId)
        {
            return _saleRepository.GetItemsBySaleId(saleId);
        }

        internal Sale GetInvoiceById(int id)
        {
            return _saleRepository.GetById(id);
        }

        public void Save(Sale sale)
        {
            sale.ItemsProducts.ForEach(i => _productService.UpdateStockById(i.Product.Id, i.Amount));
            _saleRepository.Save(sale, out int saleId);
        }

        public void SaveWithDelivery(Delivery delivery)
        {
            if (delivery.DeliveryDate < DateTime.Today)
            {
                throw new Exception("La fecha de entrega no puede ser menor al actual");
            }
            delivery.Sale.ItemsProducts.ForEach(i => _productService.UpdateStockById(i.Product.Id, i.Amount));
            _saleRepository.SaveWithDelivery(delivery);
        }

        public Sale GetSaleById(int id)
        {
            return _saleRepository.GetById(id);
        }

        public List<Sale> GetByClient(int idClient)
        {
            throw new NotImplementedException();
        }

        public DataTable GetTypes()
        {
            return _saleRepository.GetTypes();
        }

    }
}
