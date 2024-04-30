using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    internal class BDE_Cliente : BDE_Persona
    {
        private String _adress;
        private List<BDE_Invoice> _invoices;
        public BDE_Cliente(int dni, string name, string surname, string email, string password, string adress) : base(dni, name, surname, email, password)
        {
            this._adress = adress;
            this._invoices = null;
        }

        public string Adress { get => _adress; set => _adress = value; }
    }
}
