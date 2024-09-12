using BDE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_Client
    {
        public static bool SaveClient(BE_Client client)
        {
            try
            {
                return DAL_Client.SaveClient(client);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static BE_Client VerificarCliente(string dni)
        {
            return DAL_Client.VerifyClient(dni);
        }
    }
}
