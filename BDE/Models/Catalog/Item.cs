using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class Item
    {
        private int id;
        private Product product;
        private int amount;
        private double subtotal;

        public Item(int id, Product product, int amount)
        {
            this.Id = id++;
            this.Product = product ?? throw new ArgumentNullException(nameof(product));
            this.Amount = amount;
        }

        public Item() { }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public Product Product
        {
            get => product;
            set => product = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Amount
        {
            get => amount;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "La cantidad debe ser mayor a cero");

                if (Product == null)
                    throw new InvalidOperationException("Debe asignar un producto antes de la cantidad");

                if (value > Product.Stock)
                    throw new InvalidOperationException("No hay stock suficiente para la cantidad requerida.");

                amount = value;
                subtotal = Product.Price * amount;
            }
        }
        public double Subtotal => subtotal;
    }
}
