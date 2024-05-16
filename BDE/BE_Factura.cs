using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    internal class BE_Factura
    {
        private int _id { get; set; }
        private char _tipo { get; set; }
        private DateTime _fecha { get; set; }
        private BE_Cliente _cliente { get; set; }
        private BE_Producto[] _productos { get; set; }
        private double _total { get; set; }

        public BE_Factura(int id, char type, BE_Cliente client, BE_Producto[] products, double total)
        {
            this._id = id;
            this._tipo = type;
            this._fecha = DateTime.Now;
            this._cliente = client;
            this._productos = products;
            this._total = total;
        }

    }
}
