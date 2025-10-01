using BDE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_Product
    {
        public static bool isLowStock = false;
        public static void DeleteProductById(int productId)
        {
            DAL_Product.DeleteProductById(productId);
        }

        public static DataTable GetCaterogyProducts()
        {
            return DAL_Product.GetCateogyProducts();
        }

        public static BE_Product GetProductById(int idprdt)
        {
            return DAL_Product.GetProductById(idprdt);
        }

        public static List<BE_Product> GetProducts()
        {
            List<BE_Product> products = DAL_Product.GetProducts().AsEnumerable()
                .Select(p => new BE_Product(p)).ToList();

            isLowStock = products.Any(p => p.Stock <= 20);
            return products;
        }

        public static void SaveProduct(BE_Product p)
        {
            DAL_Product.SaveProduct(p);
        }
        public static void UpdateProduct(BE_Product p)
        {
            DAL_Product.UpdateProduct(p);
        }
        public static void UpdateStockById(int idProduct, int amount)
        {
            DAL_Product.UpdateStockById(idProduct, amount);
        }
    }
}
