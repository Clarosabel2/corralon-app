using BDE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDeliveryRepository
    {
        void Dispatch(int idInvoice, Employee dealer, DateTime departureTime);
        DataTable GetAllPending();
        DataTable GetDispatched();
        List<Delivery> GetDelivered();
        void MarkAsDelivered(int invoiceId);
        void Save(Delivery delivery);
    }
}
