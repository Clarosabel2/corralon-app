using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Sale
    {
        private int id;
        private char typeInvoice;
        private DateTime date;
        private DateTime deliveryDate;
        private BE_Client client;
        private BE_Employee saleman;
        private BE_Cart cart;
        private double total;

        public BE_Sale(int id, char tipo, BE_Cart carrito, double total)
        {
            this.Id = id;
            this.TypeInvoice = tipo;
            this.Date = DateTime.Now;
            this.Cart = carrito;
            this.Total = total;
        }
        public BE_Sale() { 
            this.Date = DateTime.Now;
        }

        public int Id { get => id; set => id = value; }
        public char TypeInvoice { get => typeInvoice; set => typeInvoice = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public BE_Client Client { get => client; set => client = value; }
        public BE_Cart Cart { get => cart; set => cart = value; }
        public double Total { get => total; set => total = value; }
        public BE_Employee Saleman { get => saleman; set => saleman = value; }
    }
}
