using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    internal class BDE_Invoice
    {
        private int _id;
        private char _type;
        private DateTime _dateTime;
        private BDE_Client _client;
        private BDE_Product[] _products;
        private double _total;

        public BDE_Invoice(int id, char type, BDE_Client client, BDE_Product[] products, double total)
        {
            this._id = id;
            this._type = type;
            this._dateTime = DateTime.Now;
            this._client = client;
            this._products = products;
            this._total = total;
        }

        public int Id { get => _id; set => _id = value; }
        public char Type { get => _type; set => _type = value; }
        public double Total { get => _total; set => _total = value; }
        public BDE_Client Client { get => _client; set => _client = value; }
        public BDE_Product[] Products { get => _products; set => _products = value; }
    }
}
