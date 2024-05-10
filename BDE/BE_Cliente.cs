using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    internal class BE_Cliente : BE_Persona
    {
        private String _adress;
        private List<BE_Factura> _invoices;
        public BE_Cliente(int dni, string name, string surname, string email, string password, string adress) : base(dni, name, surname, email, password)
        {
            this._adress = adress;
            this._invoices = null;
        }

        public string Adress { get => _adress; set => _adress = value; }
    }
}
