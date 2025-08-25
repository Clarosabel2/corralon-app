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
            LoadColumns();
            LoadDataInDG();
        }

        private void LoadColumns()
        {
            dgvOrders.Columns.Clear();

            dgvOrders.Columns.Add("id", "ID Pedido");
            dgvOrders.Columns.Add("dateDelivery", "Fecha de Entrega");
            dgvOrders.Columns.Add("client", "Cliente");
            dgvOrders.Columns.Add("clienteAddress", "Domicilio");
            dgvOrders.Columns.Add("phoneNumber", "Teléfono");
            dgvOrders.Columns.Add("items", "Cantidad de Ítems");
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvOrdersShipped.Columns.Clear();

            dgvOrdersShipped.Columns.Add("idInvoice", "ID Pedido");
            dgvOrdersShipped.Columns.Add("Dealer", "Repartidor");
            dgvOrdersShipped.Columns.Add("client", "Cliente");
            dgvOrdersShipped.Columns.Add("address", "Domicilio");
            dgvOrdersShipped.Columns.Add("phone", "Telefono");
            dgvOrdersShipped.Columns.Add("departureTime", "Horario de Salida");

            dgvOrdersShipped.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        public void LoadDataInDG()
        {
            dgvOrders.Rows.Clear();
            dgvOrdersShipped.Rows.Clear();
            foreach (DataRow r in BLL_Order.GetAllPendingOrders().Rows)
            {
                string dateDelivery = Convert.ToDateTime(r[1]).ToString("dd/MM/yyyy");
                dgvOrders.Rows.Add(r[0], dateDelivery, r[2], r[3], r[4], r[5]);
            }

            foreach (DataRow r in BLL_Order.GetOrdersDispatched().Rows)
            {
                dgvOrdersShipped.Rows.Add(r[0], r[1], r[2], r[3], r[4], Convert.ToDateTime(r[5]).ToString("HH:mm:ss"));
            }
        }

        private void btnDispatchOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                FormPreShipOrder frm = new FormPreShipOrder(Convert.ToInt32(dgvOrders.SelectedRows[0].Cells[0].Value.ToString()), this);
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
                DialogResult r = MessageBox.Show("Estas seguro que quieres Marcar el pedido como 'Entregado'?", "Pedidos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    BLL_Order.MarkDeliveredOrder(idInvoice);
                    LoadDataInDG();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
