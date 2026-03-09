using BDE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IClientRepository
    {
        bool Save(Client client);

        IEnumerable<Client> GetAll();
        Client GetByDNI(string dni);
        Client GetById(int idClient);
        Client GetBySale(int idSale);
    }
}
