using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Cart
    {
        private List<BE_Product> products;
        private double totalMount;

        public BE_Cart()
        {
            Products = new List<BE_Product>();
        }

        public List<BE_Product> Products { get => products; set => products = value; }
        public double TotalMount { get => totalMount; set => totalMount = value; }

        public void AddProduct(BE_Product p)
        {
            this.TotalMount += p.TotalPrice;
            this.Products.Add(p);
        }
        public void RemoveProduct(BE_Product p)
        {
            this.TotalMount -= p.TotalPrice;
            this.Products.Remove(p);
        }
    }
}
