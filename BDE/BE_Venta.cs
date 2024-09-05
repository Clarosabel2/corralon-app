using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Venta
    {
        private int id;
        private char tipo;
        private DateTime fecha;
        private DateTime fechaEntrega;
        private BE_Cliente cliente;
        private BE_Empleado vendedor;
        private BE_Carrito carrito;
        private double total;

        public BE_Venta(int id, char tipo, BE_Carrito carrito, double total)
        {
            this.Id = id;
            this.Tipo = tipo;
            this.Fecha = DateTime.Now;
            this.Carrito = carrito;
            this.Total = total;
        }
        public BE_Venta() { 
            this.Fecha = DateTime.Now;
        }

        public int Id { get => id; set => id = value; }
        public char Tipo { get => tipo; set => tipo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public BE_Cliente Cliente { get => cliente; set => cliente = value; }
        public BE_Carrito Carrito { get => carrito; set => carrito = value; }
        public double Total { get => total; set => total = value; }
        public BE_Empleado Vendedor { get => vendedor; set => vendedor = value; }
    }
}
