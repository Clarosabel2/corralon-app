using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            dgvOrders.DataSource = BLL_Order.GetAllPendingOrders();
            dgvOrdersShipped.DataSource = BLL_Order.GetOrdersDispatched();
        }

        private void btnDispatchOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                FormPreShipOrder frm = new FormPreShipOrder(Convert.ToInt32(dgvOrders.SelectedRows[0].Cells[0].Value.ToString()));
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila antes de continuar.");
            }
        }

        private void btnMarkDelivered_Click(object sender, EventArgs e)
        {
            var idInvoice = Convert.ToInt32(dgvOrdersShipped.SelectedRows[0].Cells[0].Value.ToString());
            try
            {
                BLL_Order.MarkDeliveredOrder(idInvoice);
                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
