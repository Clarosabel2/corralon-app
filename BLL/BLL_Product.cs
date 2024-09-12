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
        public static DataTable GetCaterogyProducts()
        {
            return DAL_Product.GetCateogyProducts();
        }

        public static List<BE_Product> GetProducts()
        {
            return DAL_Product.GetProducts().AsEnumerable()
                .Select(p => new BE_Product(p)).ToList();
        }
        public static bool UpdateProducts(DataTable dt)
        {
            return DAL_Product.UpdateProducts(dt);
        }
    }
}
