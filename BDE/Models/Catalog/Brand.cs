using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class Brand
    {
        private int id;
        private string nameBrand;
        private List<Product> products;
        private string description;

        public Brand(string nombre)
        {
            this.NameBrand = nombre;
        }
        public Brand() { }

        public int Id { get => id; set => id = value; }
        public string NameBrand { get => nameBrand; set => nameBrand = value; }
        public List<Product> Products { get => products; set => products = value; }
        public string Description { get => description; set => description = value; }
    }
}
