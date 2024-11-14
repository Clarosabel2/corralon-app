using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Brand
    {
        private int id;
        private string nameBrand;
        private List<BE_Product> products;
        private string description;

        public BE_Brand(string nombre)
        {
            this.NameBrand = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string NameBrand { get => nameBrand; set => nameBrand = value; }
        public List<BE_Product> Products { get => products; set => products = value; }
        public string Description { get => description; set => description = value; }
    }
}
