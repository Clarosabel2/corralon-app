using BDE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.common.Utils;

namespace UI
{
    public partial class FormOrderDetail : Form
    {
        public FormOrderDetail(Delivery currentOrder)
        {
            InitializeComponent();
            ConfigureForm(currentOrder);
        }

        private void ConfigureForm(Delivery order)
        {
            txtNumOrder.Text = order.Sale.Id.ToString();
            txtDateIssue.Text = order.Sale.IssueDate.ToShortDateString();
            txtStatusOrder.Text = order.Status ? "Completed" : "Pending";

            txtDNIClient.Text = order.Sale.Client.Dni.ToString();
            txtFullnameClient.Text = order.Sale.Client.Name;
            txtAddressClient.Text = order.Sale.Client.Address;
            txtNumPhoneClient.Text = order.Sale.Client.NumPhone.ToString();
            txtEmailClient.Text = order.Sale.Client.Email;

            txtFullnameSeller.Text = order.Sale.Saleman.Lastname + ", " + order.Sale.Saleman.Name;
            txtFullnameDealer.Text = order.Dealer.Lastname + ", " + order.Dealer.Name;

            txtDateDelivery.Text = order.DeliveryDate.ToShortDateString();
            txtHourDeparture.Text = order.DepartureDate.ToShortTimeString();
            txtHourArrival.Text = order.ArrivalDate.ToShortTimeString();

            int i = 0;
            order.Sale.ItemsProducts.ForEach(item =>
            {
                i++;
                dgvProductsOrder.Rows.Add(new object[]
                {
                    i,
                    ImageLoader.LoadSafe(item.Product.ImagePath),
                    item.Product.Name,
                    item.Amount,
                    item.Product.Price,
                    item.Subtotal,
                });
            });
        }

    }
}
