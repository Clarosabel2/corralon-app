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
        public static BE_Order newOrder = new BE_Order();
        public static BE_Sale newSale { get; set; }
        private static int _idItem = 1;

        public static void CreateSale()
        {
            newSale = new BE_Sale();
            newSale.Saleman = SessionManager.GetInstance.user.Emp;
        }
        public static void AddItem(BE_Product product, int quantity)
        {
            var item = new BE_Item(_idItem, product, quantity);
            newSale.AddItem(item);
            _idItem++;
        }
        public static BE_Item RemoveItem(int idItem)
        {
            var item = newSale.ItemsProducts.FirstOrDefault(i => i.Id == idItem);
            newSale.RemoveItem(newSale.ItemsProducts.FirstOrDefault(i => i.Id == idItem));
            _idItem--;
            return item;
        }
        public static BE_Client AddClient(string dniClient)
        {
            newSale.Client = BLL_Client.GetClientByDNI(dniClient);
            return newSale.Client;
        }
        public static void SaveInvoice()
        {
            if (newOrder.DeliveryDate < DateTime.Today)
            {
                throw new Exception("La fecha de entrega no puede ser menor al actual");
            }
            
            newOrder.Invoice = newSale;
            DAL_Sale.SaveSale(newOrder);
        }

        public static DataTable GetProductsByIdInvoice(int idInvoice)
        {
            return DAL_Sale.GetProductsByIdInvoice(idInvoice);
        }
    }
}
