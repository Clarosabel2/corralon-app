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
    public static class BLL_Brand
    {
        public static List<BE_Brand> GetAllBrands()
        {
            List<BE_Brand> brands = new List<BE_Brand>();
            foreach (DataRow r in DAL_Brand.GetAllBrands().Rows)
            {
                brands.Add(new BE_Brand
                {
                    Id = Convert.ToInt32(r[0]),
                    NameBrand = r[1].ToString(),
                    Description = r[2].ToString()
                });
            }
            return brands;
        }

        public static void SaveBrand(BE_Brand b)
        {
            DAL_Brand.SaveBrand(b);
        }

        internal static List<BE_Brand> GetBrandsBySupplierId(int id)
        {
            return DAL_Brand.GetBrandsBySupplierId(id)
                .AsEnumerable()
                .Select(r => new BE_Brand
            {
                Id = Convert.ToInt32(r[0]),
                NameBrand = r[1].ToString(),
                Description = r[2].ToString()
            }).ToList();
        }
    }
}
