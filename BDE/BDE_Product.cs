using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BDE_Product
    {
        private int _id;
        private string _brand;
        private string _description;
        private double _price;
        private int _stock;

        public BDE_Product(int id, string description, string brand, double price, int stock)
        {
            this._id = id;
            this._description = description;
            this._brand = brand;
            this._price = price;
            this._stock = stock;
        }

        public int Id { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public string Brand { get => _brand; set => _brand = value; }
        public double Price { get => _price; set => _price = value; }
        public int Stock { get => _stock; set => _stock = value; }
    }
}
