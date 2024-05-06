using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    internal class BDE_Factura
    {
        private int _id;
        private char _tipo;
        private DateTime _fecha;
        private BDE_Cliente _cliente;
        private BDE_Producto[] _productos;
        private double _total;

        public BDE_Factura(int id, char type, BDE_Cliente client, BDE_Producto[] products, double total)
        {
            this._id = id;
            this._tipo = type;
            this._fecha = DateTime.Now;
            this._cliente = client;
            this._productos = products;
            this._total = total;
        }

        public int Id { get => _id; set => _id = value; }
        public char Type { get => _tipo; set => _tipo = value; }
        public double Total { get => _total; set => _total = value; }
        public BDE_Cliente Client { get => _cliente; set => _cliente = value; }
        public BDE_Producto[] Products { get => _productos; set => _productos = value; }
    }
}
