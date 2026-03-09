using BDE;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public bool Save(Client client)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public Client GetByDNI(string dni)
        {
            throw new NotImplementedException();
        }

        public Client GetById(string idClient)
        {
            throw new NotImplementedException();
        }
    }
}
