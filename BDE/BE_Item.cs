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
            this.Product = product ?? throw new ArgumentNullException(nameof(product));
            this.Amount = amount;
        }

        public BE_Item() { }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public BE_Product Product
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
