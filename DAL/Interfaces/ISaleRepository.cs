using BDE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ISaleRepository
    {
        Sale GetById(int idSale);
        void Save(Sale sale, out int saleId);
        void SaveWithDelivery(Delivery delivery);
        List<Item> GetItemsBySaleId(int saleId);
        DataTable GetTypes();
    }
}
