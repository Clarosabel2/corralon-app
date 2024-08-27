using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Cliente : BE_Persona
    {
        private List<BE_Venta> facturas;
        public BE_Cliente(int id, int dni, string nombre, string apellido, string email, int telefono, string domicilio) 
            : base(id, dni, nombre, apellido, email, telefono, domicilio)
        {
            this.Facturas = null;
        }
        public List<BE_Venta> Facturas { get => facturas; set => facturas = value; }
    }
}
