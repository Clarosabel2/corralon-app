using BDE;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IClientService
    {
        bool Save(Client client);

        IEnumerable<Client> GetAll();
        Client GetByDNI(string dni);
        Client GetById(string idClient);
    }
}
