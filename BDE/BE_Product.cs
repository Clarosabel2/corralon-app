using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Product
    {
        private int id;
        private BE_Brand brand;
        private string name;
        private string description;
        private string category;
        private int weight;
        private int stock;
        private double price;

        public BE_Product(int id, BE_Brand marca, string descripcion, string categoria, double precio, int stock)
        {
            this.Id = id;
            this.brand = marca;
            this.description = descripcion;
            this.Price = precio;
            this.Category = categoria;
            this.Stock = stock;
        }
        public BE_Product(DataRow r)
        {
            this.Id = r.Field<int>("id_Producto");
            this.brand = new BE_Brand(r.Field<string>("marca"));
            this.Name = r.Field<string>("nombre");
            this.Price = r.Field<double>("precio");
            this.Category = r.Field<string>("nombreCategoria");
            this.Stock = r.Field<int>("stock");
        }
        public BE_Product() { }

        public int Id { get => id; set => id = value; }
        public string Category { get => category; set => category = value; }
        public string Brand { get => brand.NameBrand; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }

    }
}
