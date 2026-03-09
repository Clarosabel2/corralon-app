using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class Sale
    {
        private int id;
        private char typeInvoice;
        private DateTime issueDate;
        private Client client;
        private Employee saleman;
        private List<Item> itemsProducts;
        private double total;
        private bool status;
        public Sale(int id, char tipo)
        {
            this.Id = id;
            this.TypeInvoice = tipo;
            this.IssueDate = DateTime.Now;
            this.ItemsProducts = new List<Item>();
        }

        
        public Sale()
        {
            this.IssueDate = DateTime.Now;
            this.ItemsProducts = new List<Item>();
        }

        public Sale(
            int id,
            char typeInvoice,
            DateTime issueDate,
            Client client,
            Employee saleman,
            List<Item> itemsProducts,
            double total,
            bool status
            )
        {
            this.Id = id;
            this.TypeInvoice = typeInvoice;
            this.IssueDate = issueDate;
            this.ItemsProducts = itemsProducts;
            this.Total = total;
            this.Status = status;
            this.Saleman = saleman;
            this.Client = client;

        }

        public int Id { get => id; set => id = value; }
        public char TypeInvoice { get => typeInvoice; set => typeInvoice = value; }
        public DateTime IssueDate { get => issueDate; set => issueDate = value; }
        public Client Client { get => client; set => client = value; }
        public double Total { get => total; set => total = value; }
        public Employee Saleman { get => saleman; set => saleman = value; }
        public List<Item> ItemsProducts { get => itemsProducts; set => itemsProducts = value; }
        public bool Status { get => status; set => status = value; }

        public void AddItem(Item i)
        {
            this.ItemsProducts.Add(i);
            CalculateTotal();
        }
        public void RemoveItem(Item item)
        {
            this.ItemsProducts.Remove(item);
            CalculateTotal();
        }
        public void AddClient(Client client)
        {
            this.Client = client;
        }
        public void CalculateTotal()
        {
            this.Total = this.ItemsProducts.Sum(p => p.Subtotal);
        }

    }
}
