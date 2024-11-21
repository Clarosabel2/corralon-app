using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Client : BE_Person
    {
        private List<BE_Sale> invoices;
        private string level;
        public BE_Client(int id, int dni, string nombre, string apellido, string domicilio, string email, int telefono) 
            : base(id, dni, nombre, apellido, domicilio, email, telefono)
        {
            this.Invoices = null;

        }
        public BE_Client():base(){}
        public List<BE_Sale> Invoices { get => invoices; set => invoices = value; }
        public string Level { get => level; set => level = value; }
    }
}
