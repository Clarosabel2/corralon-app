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
        public BE_Client(int id, int dni, string nombre, string apellido, string email, int telefono, string domicilio) 
            : base(id, dni, nombre, apellido, email, telefono, domicilio)
        {
            this.Invoices = null;
        }
        public BE_Client(SqlDataReader c)
            : base(c)
        {
            this.Invoices = null;
        }
        public BE_Client():base(){}
        public List<BE_Sale> Invoices { get => invoices; set => invoices = value; }
        public string Level { get => level; set => level = value; }
    }
}
