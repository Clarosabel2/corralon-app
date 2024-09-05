using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Producto
    {
        private int id;
        private BE_Marca marca;
        private string nombre;
        private string descripcion;
        private string categoria;
        private int peso;
        private int stock;
        private int cantidad;
        private double precio;
        private double precioTotal;

        public BE_Producto(int id, BE_Marca marca, string descripcion, string categoria, double precio, int stock)
        {
            this.Id = id;
            this.marca = marca;
            this.descripcion = descripcion;
            this.Precio = precio;
            this.Categoria = categoria;
            this.Stock = stock;
        }
        public BE_Producto(DataRow r)
        {
            this.Id = r.Field<int>("id_Producto");
            this.marca = new BE_Marca(r.Field<string>("marca"));
            this.Nombre = r.Field<string>("nombre");
            this.Precio = r.Field<double>("precio");
            this.Categoria = r.Field<string>("nombreCategoria");
            this.Stock = r.Field<int>("stock");
        }
        public BE_Producto() { }

        public int Id { get => id; set => id = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Marca { get => marca.NombreMarca; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Cantidad { set => cantidad = value; get => cantidad; }
        public double PrecioTotal { set => precioTotal = value; get => precioTotal; }
        
        public bool VerificarDisponibilidad() {
            return this.cantidad <= this.Stock;
        }
        public double CalcularPrecioTotal() {
            return this.precioTotal = this.Cantidad * this.Precio;
        }
    }
}
