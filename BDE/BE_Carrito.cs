using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Carrito
    {
        private List<BE_Producto> productos;
        private double montoTotal;

        public BE_Carrito()
        {
            Productos = new List<BE_Producto>();
        }

        public List<BE_Producto> Productos { get => productos; set => productos = value; }
        public double MontoTotal { get => montoTotal; set => montoTotal = value; }

        public void AgregarProducto(BE_Producto p)
        {
            this.MontoTotal += p.PrecioTotal;
            this.Productos.Add(p);
        }
        public void RemoverProducto(BE_Producto p)
        {
            this.MontoTotal -= p.PrecioTotal;
            this.Productos.Remove(p);
        }
    }
}
