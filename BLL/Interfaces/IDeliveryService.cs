using BDE;
using System.Collections.Generic;
using System.Data;

namespace BLL.Interfaces
{
    public interface IDeliveryService
    {
        void Dispatch(int idInvoice, Employee dealer);
        DataTable GetAllPending();
        DataTable GetDispatched();
        List<Delivery> GetDelivered();
        void MarkAsDelivered(int invoiceId);
        void Save(Delivery delivery);
    }
}
