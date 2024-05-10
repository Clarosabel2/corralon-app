using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    internal class BE_Factura
    {
        private int _id;
        private char _tipo;
        private DateTime _fecha;
        private BE_Cliente _cliente;
        private BE_Producto[] _productos;
        private double _total;

        public BE_Factura(int id, char type, BE_Cliente client, BE_Producto[] products, double total)
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
        public BE_Cliente Client { get => _cliente; set => _cliente = value; }
        public BE_Producto[] Products { get => _productos; set => _productos = value; }
    }
}
