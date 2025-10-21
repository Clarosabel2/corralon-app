using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Sale
    {
        private int id;
        private char typeInvoice;
        private DateTime issueDate;
        private BE_Client client;
        private BE_Employee saleman;
        private List<BE_Item> itemsProducts;
        private double total;
        private bool status;
        public BE_Sale(int id, char tipo)
        {
            this.Id = id;
            this.TypeInvoice = tipo;
            this.IssueDate = DateTime.Now;
            this.ItemsProducts = new List<BE_Item>();
        }

        
        public BE_Sale()
        {
            this.IssueDate = DateTime.Now;
            this.ItemsProducts = new List<BE_Item>();
        }

        public BE_Sale(
            int id,
            char typeInvoice,
            DateTime issueDate,
            BE_Client client,
            BE_Employee saleman,
            List<BE_Item> itemsProducts,
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
        public BE_Client Client { get => client; set => client = value; }
        public double Total { get => total; set => total = value; }
        public BE_Employee Saleman { get => saleman; set => saleman = value; }
        public List<BE_Item> ItemsProducts { get => itemsProducts; set => itemsProducts = value; }
        public bool Status { get => status; set => status = value; }

        public void AddItem(BE_Item i)
        {
            this.ItemsProducts.Add(i);
            CalculateTotal();
        }
        public void RemoveItem(BE_Item item)
        {
            this.ItemsProducts.Remove(item);
            CalculateTotal();
        }
        public void CalculateTotal()
        {
            this.Total = this.ItemsProducts.Sum(p => p.Subtotal);
        }

    }
}
