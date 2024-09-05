using BDE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_Cliente
    {
        public static BE_Cliente VerificarCliente(string dni) {
            return DAL_Cliente.VerificarCliente(dni);
        }
    }
}
