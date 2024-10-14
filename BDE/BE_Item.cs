using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Item
    {
        private int id;
        private BE_Product product;
        private int amount;
        private double subtotal;

        public BE_Item(int id, BE_Product product, int amount)
        {
            this.Id = id;
            this.Product = product;
            this.Amount = amount;
            CheckAvailability();
        }

        public BE_Item() { }

        public int Id { get => id; set => id = value; }
        public BE_Product Product { get => product; set => product = value; }
        public int Amount
        {
            get => amount;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("La cantidad debe ser mayor a cero");
                }
                amount = value;

                this.subtotal = this.Amount * this.Product.Price;
            }
        }
        public double Subtotal { get => subtotal; set => subtotal = value;
        }

        public void CheckAvailability()
        {
            if (this.Amount > this.Product.Stock)
            {
                throw new InvalidOperationException("No hay stock suficiente para la cantidad requerida.");
            }
        }
    }
}
