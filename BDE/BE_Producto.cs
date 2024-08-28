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
        private string marca;
        private string nombre;
        private string descripcion;
        private string categoria;
        private double precio;
        private int peso;
        private int stock;

        public BE_Producto(int id, string marca, string descripcion, string categoria, double precio, int stock)
        {
            this.Id = id;
            this.Marca = marca;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Categoria = categoria;
            this.Stock = stock;
        }
        public BE_Producto(DataRow r)
        {
            this.Id = r.Field<int>("id_Producto");
            this.Marca = r.Field<string>("marca");
            this.Nombre= r.Field<string>("nombre");
            this.Precio = r.Field<double>("precio");
            this.Categoria = r.Field<string>("nombreCategoria");
            this.Stock = r.Field<int>("stock");
        }
        public BE_Producto() { }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Peso { get => peso; set => peso = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
