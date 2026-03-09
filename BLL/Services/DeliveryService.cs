using BDE;
using BLL.Interfaces;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class DeliveryService : IDeliveryService
    {
        private readonly IDeliveryRepository _deliveryRepository;

        public DeliveryService(IDeliveryRepository deliveryRepository)
        {
            _deliveryRepository = deliveryRepository;
        }

        public void Dispatch(int id_invoice, Employee key)
        {
            _deliveryRepository.Dispatch(id_invoice, key, DateTime.Now);
        }

        public DataTable GetAllPending()
        {
            return _deliveryRepository.GetAllPending();
        }

        public DataTable GetDispatched()
        {
            return _deliveryRepository.GetDispatched();
        }

        public void MarkAsDelivered(int idInvoice)
        {
            _deliveryRepository.MarkAsDelivered(idInvoice);
        }

        public List<Delivery> GetDelivered()
        {
            return _deliveryRepository.GetDelivered();
        }

        public void Save(Delivery delivery)
        {
            _deliveryRepository.Save(delivery);
        }
    }
}
