using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Carrito
    {
        private BE_Cliente cliente;
        private BE_Empleado vendedor;
        private List<BE_Producto> productos;

        public BE_Carrito() { }
        public BE_Carrito(BE_Cliente cliente, BE_Empleado vendedor) { 
            this.Cliente = cliente;
            this.Vendedor = vendedor;
        }

        public BE_Empleado Vendedor { get => vendedor; set => vendedor = value; }
        public List<BE_Producto> Productos { get => productos; set => productos = value; }
        public BE_Cliente Cliente { get => cliente; set => cliente = value; }

        public void AgregarProducto(BE_Producto p) {
            this.productos.Add(p);    
        }
        public void RemoverProducto(BE_Producto p) { 
            this.productos.Remove(p);
        }
    }
}
