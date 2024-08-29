using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Marca
    {
        private readonly int id;
        private string nombreMarca;
        private List<BE_Producto> productos;
        private string descripcion;

        public BE_Marca(string nombre)
        {
            this.NombreMarca = nombre;
        }

        public int Id { get => id;}
        public string NombreMarca { get => nombreMarca; set => nombreMarca = value; }
        public List<BE_Producto> Productos { get => productos; set => productos = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
