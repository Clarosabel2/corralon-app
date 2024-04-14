using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    internal class BDE_Client : BDE_Person
    {
        private String _adress;
        public BDE_Client(int dni, string name, string surname, string email, string password, string adress) : base(dni, name, surname, email, password)
        {
            this._adress = adress;
        }

        public string Adress { get => _adress; set => _adress = value; }
    }
}
