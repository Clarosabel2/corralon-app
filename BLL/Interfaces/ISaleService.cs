using BDE;
using System.Collections.Generic;
using System.Data;

namespace BLL.Interfaces
{
    public interface ISaleService
    {
        void Save(Sale sale);
        void SaveWithDelivery(Delivery delivery);
        Sale GetSaleById(int id);
        List<Sale> GetByClient(int idClient);
        List<Item> GetItemsBySaleId(int saleId);
        DataTable GetTypes();
    }
}
