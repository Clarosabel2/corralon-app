using BDE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public class ProductMapper
    {
        public static BE_Product FromDataRow(DataRow r)
        {
            return new BE_Product
            {
                Id = r.Field<int>("id_Producto"),
                Name = r.Field<string>("nombre"),
                Description = r.Field<string>("descripcion")??"",
                Price = r.Field<double>("precio"),
                Stock = r.Field<int>("stock"),
                Brand = new BE_Brand(r.Field<string>("marca")),
                Category = r.Field<string>("nombreCategoria"),
                MinStock = r.Field<int>("stock_minimo"),
                ImagePath = r.Field<string>("img_path") ?? ""
            };
        }
    }
}
