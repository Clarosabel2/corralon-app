using BDE;
using DAL;
using SVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_Sale
    {
        public static BE_Order CurrentOrder { get; private set; }
        public static BE_Sale CurrentSale { get; private set; }
        private static int _nextItemId;

        public static void CreateSale()
        {
            CurrentSale = new BE_Sale
            {
                Saleman = SessionManager.GetInstance.user?.Emp
                          ?? throw new InvalidOperationException("No hay vendedor en sesión")
            };

            CurrentOrder = new BE_Order();
            _nextItemId = 1;
        }
        public static BE_Item AddItem(BE_Product product, int quantity)
        {
            if (CurrentSale is null) throw new InvalidOperationException("No hay venta activa");
            if (product is null) throw new ArgumentNullException(nameof(product));
            if (quantity <= 0) throw new ArgumentOutOfRangeException(nameof(quantity), "La cantidad debe ser > 0");

            var item = new BE_Item(_nextItemId, product, quantity);
            CurrentSale.AddItem(item);
            _nextItemId++;

            return item;
        }

        public static BE_Item RemoveItem(int idItem)
        {
            var item = CurrentSale.ItemsProducts.FirstOrDefault(i => i.Id == idItem);
            CurrentSale.RemoveItem(CurrentSale.ItemsProducts.FirstOrDefault(i => i.Id == idItem));
            _nextItemId--;
            return item;
        }
        public static BE_Client AddClient(string dniClient)
        {
            CurrentSale.Client = BLL_Client.GetClientByDNI(dniClient);
            return CurrentSale.Client;
        }
        public static void SaveInvoice()
        {
            if (CurrentOrder.DeliveryDate < DateTime.Today)
            {
                throw new Exception("La fecha de entrega no puede ser menor al actual");
            }
            CurrentOrder.Invoice = CurrentSale;
            //Actualiza el stock de los productos por cada item de la venta
            CurrentSale.ItemsProducts.ForEach(i => BLL_Product.UpdateStockById(i.Product.Id, i.Amount));
            DAL_Sale.SaveSale(CurrentOrder);
            CurrentSale = null;
        }
        public static DataTable GetProductsByIdInvoice(int idInvoice)
        {
            return DAL_Sale.GetProductsByIdInvoice(idInvoice);
        }
    }
}
