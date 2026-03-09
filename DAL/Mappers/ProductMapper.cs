using BDE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public static class ProductMapper
    {
        public static Product Map(SqlDataReader dr)
        {
            var product = new Product
            {
                Id = dr.GetInt32(dr.GetOrdinal("id_Producto")),
                Name = dr.GetString(dr.GetOrdinal("nombre")),
                Description = dr.GetString(dr.GetOrdinal("descripcion")),
                Price = Convert.ToDouble(dr["precio"]),
                Stock = dr.GetInt32(dr.GetOrdinal("stock")),
                Brand = new Brand(dr.GetString(dr.GetOrdinal("marca"))),
                Category = dr.GetString(dr.GetOrdinal("nombreCategoria")),
                MinStock = dr.GetInt32(dr.GetOrdinal("stock_minimo")),
                ImagePath = dr["img_path"] == DBNull.Value
                            ? ""
                            : dr.GetString(dr.GetOrdinal("img_path"))
            };

            return product;
        }

        public static Product Map(DataRow r)
        {
            return new Product
            {
                Id = r.Field<int>("id_Producto"),
                Name = r.Field<string>("nombre"),
                Description = r.Field<string>("descripcion"),
                Price = r.Field<double>("precio"),
                Stock = r.Field<int>("stock"),
                Brand = new Brand(r.Field<string>("marca")),
                Category = r.Field<string>("nombreCategoria"),
                MinStock = r.Field<int>("stock_minimo"),
                ImagePath = r.Field<string>("img_path") ?? ""
            };
        }
    }
}
