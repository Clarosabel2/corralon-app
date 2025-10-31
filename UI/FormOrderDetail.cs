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
        public FormOrderDetail(BE_Order currentOrder)
        {
            InitializeComponent();
            ConfigureForm(currentOrder);
        }

        private void ConfigureForm(BE_Order order)
        {
            txtNumOrder.Text = order.Invoice.Id.ToString();
            txtDateIssue.Text = order.Invoice.IssueDate.ToShortDateString();
            txtStatusOrder.Text = order.Status ? "Completed" : "Pending";

            txtDNIClient.Text = order.Invoice.Client.Dni.ToString();
            txtFullnameClient.Text = order.Invoice.Client.Name;
            txtAddressClient.Text = order.Invoice.Client.Address;
            txtNumPhoneClient.Text = order.Invoice.Client.NumPhone.ToString();
            txtEmailClient.Text = order.Invoice.Client.Email;

            txtFullnameSeller.Text = order.Invoice.Saleman.Lastname + ", " + order.Invoice.Saleman.Name;
            txtFullnameDealer.Text = order.Dealer.Lastname + ", " + order.Dealer.Name;

            txtDateDelivery.Text = order.DeliveryDate.ToShortDateString();
            txtHourDeparture.Text = order.DepartureDate.ToShortTimeString();
            txtHourArrival.Text = order.ArrivalDate.ToShortTimeString();

            int i = 0;
            order.Invoice.ItemsProducts.ForEach(item =>
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
