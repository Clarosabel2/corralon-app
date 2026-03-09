using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class Product
    {
        private int id;
        private Brand brand;
        private string name;
        private string description;
        private string category;
        private int weight;
        private int stock;
        private double price;
        private bool isDelete;
        private int minStock;
        private string imagePath;

        public Product(int id, Brand marca, string nombre, string descripcion, string categoria, double precio, int stock)
        {
            this.Id = id;
            this.Brand = marca;
            this.Name = nombre;
            this.description = descripcion;
            this.Price = precio;
            this.Category = categoria;
            this.Stock = stock;
        }
        
        public Product() { }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Category { get => category; set => category = value; }
        public Brand Brand { get => brand; set => brand = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public int MinStock { get => minStock; set => minStock = value; }
    }
}
