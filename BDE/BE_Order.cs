using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Order
    {
        private BE_Sale invoice;
        private BE_Employee dealer;
        private bool status;
        private DateTime deliveryDate;

        public BE_Order(DateTime deliveryDate, BE_Sale invoice)
        {
            this.deliveryDate = deliveryDate;
            this.status = false;
            this.invoice = invoice;
        }
        public BE_Order(BE_Sale invoice)
        {
            this.invoice=invoice;
        }
        public BE_Order()
        {

        }
        public BE_Employee Dealer { get => dealer; set => dealer = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public bool Status { get => status; set => status = value; }
        public BE_Sale Invoice { get => invoice; set => invoice = value; }
    }
}
