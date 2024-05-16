using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Producto
    {
        private int _id { get; set; }
        private string _marca { get; set; }
        private string _descripcion { get; set; }
        private double _precio { get; set; }
        private int _stock { get; set; }

        public BE_Producto(int id, string description, string brand, double price, int stock)
        {
            this._id = id;
            this._descripcion = description;
            this._marca = brand;
            this._precio = price;
            this._stock = stock;
        }

    }
}
