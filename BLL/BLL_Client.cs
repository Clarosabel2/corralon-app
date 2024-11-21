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

        public static BE_Client GetClientByDNI(string dni)
        {
            return DAL_Client.GetClientByDNI(dni);
        }

        public static BE_Client GetClientById(string idClient)
        {
            return DAL_Client.GetClientById(idClient);
        }

        public static IEnumerable<BE_Client> GetAllClients()
        {
            return DAL_Client.GetAllClients();
        }
    }
}
