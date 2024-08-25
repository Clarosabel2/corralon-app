using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    internal class BE_Cliente : BE_Persona
    {
        private string _domicilio { get; set; }
        private List<BE_Factura> _facturas { get; set; }
        public BE_Cliente(int id, int dni, string nombre, string apellido, string email, int telefono, string domicilio) 
            : base(id, dni, nombre, apellido, email, telefono, domicilio)
        {
            this._domicilio = domicilio;
            this._facturas = null;
        }

    }
}
