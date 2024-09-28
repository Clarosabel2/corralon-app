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
            if (amount <= 0)
            {
                throw new ArgumentException("La cantidad debe ser vamor a cero");
            }
            Id = id;
            Product = product;
            Amount = amount;
            Subtotal = CalculateSubtotal();
            if (CheckAvailability())
            {
                throw new Exception("No hay Stock para la cantidad requerida");
            }
        }

        public BE_Item() { }

        public BE_Product Product { get => product; set => product = value; }
        public int Amount { get => amount; set => amount = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public int Id { get => id; set => id = value; }

        private double CalculateSubtotal()
        {
            return this.Amount * this.Product.Price;
        }
        public bool CheckAvailability()
        {
            if (this.amount > this.Product.Stock)
            {
                return true;
            }
            return false;
        }
    }
}
