using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class Client : Person
    {
        private List<Sale> invoices;
        private string level;
        public Client(int id, int dni, string nombre, string apellido, string domicilio, string email, int telefono) 
            : base(id, dni, nombre, apellido, domicilio, email, telefono)
        {
            this.Invoices = null;

        }
        public Client():base(){}
        public List<Sale> Invoices { get => invoices; set => invoices = value; }
        public string Level { get => level; set => level = value; }
    }
}
