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
    public static class BLL_Producto
    {
        public static DataTable ObtenerCategoriasProducto()
        {
            return DAL_Producto.ObtenerCategoriasProducto();
        }

        public static List<BE_Producto> ObtenerProductos()
        {
            return DAL_Producto.ObtenerProductos().AsEnumerable()
                .Select(p => new BE_Producto(p)).ToList();
        }
    }
}
