using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BDE_Producto
    {
        private int _id;
        private string _marca;
        private string _descripcion;
        private double _precio;
        private int _stock;

        public BDE_Producto(int id, string description, string brand, double price, int stock)
        {
            this._id = id;
            this._descripcion = description;
            this._marca = brand;
            this._precio = price;
            this._stock = stock;
        }

        public int Id { get => _id; set => _id = value; }
        public string Description { get => _descripcion; set => _descripcion = value; }
        public string Brand { get => _marca; set => _marca = value; }
        public double Price { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
    }
}
