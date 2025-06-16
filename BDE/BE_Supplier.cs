using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Supplier
    {
        private int id;
        private string name;
        private string contactName;
        private string contactEmail;
        private string contactPhone;
        private string address;
        private List<BE_Brand> brandsAssociated;
        public BE_Supplier(
            string name,
            string contactName,
            string contactEmail,
            string contactPhone,
            string address)
        {
            this.Name = name;
            this.ContactName = contactName;
            this.ContactEmail = contactEmail;
            this.ContactPhone = contactPhone;
            this.Address = address;
            this.BrandsAssociated = new List<BE_Brand>();
        }
        public BE_Supplier() { }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string ContactEmail { get => contactEmail; set => contactEmail = value; }
        public string ContactPhone { get => contactPhone; set => contactPhone = value; }
        public string Address { get => address; set => address = value; }
        public List<BE_Brand> BrandsAssociated { get => brandsAssociated; set => brandsAssociated = value; }
    }
}
