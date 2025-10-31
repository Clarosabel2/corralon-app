using BDE;
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
using UI.common.Styles;

namespace UI
{
    public partial class FormOrders : Form
    {
        private List<BE_Order> ordersFinalized;
        public FormOrders()
        {
            InitializeComponent();
            ordersFinalized = new List<BE_Order>();
            ApplyStyleCommon.DGVStyle(this.dgvOrders);
            ApplyStyleCommon.DGVStyle(this.dgvOrdersShipped);
            ApplyStyleCommon.DGVStyle(this.dgvOrdersHistory);
            LoadColumns();
            LoadDataInDG();
        }

        private void LoadColumns()
        {
            dgvOrders.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14f, FontStyle.Bold);
            dgvOrders.DefaultCellStyle.Font = new Font("Century Gothic", 11f, FontStyle.Regular);


            dgvOrdersShipped.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14f, FontStyle.Bold);
            dgvOrdersShipped.DefaultCellStyle.Font = new Font("Century Gothic", 11f, FontStyle.Regular);

            dgvOrdersHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14f, FontStyle.Bold);
            dgvOrdersHistory.DefaultCellStyle.Font = new Font("Century Gothic", 11f, FontStyle.Regular);

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

            ordersFinalized = BLL_Order.GetOrdersFinalized();
            ordersFinalized.ForEach(d =>
            {
                dgvOrdersHistory.Rows.Add(
                    d.Invoice.Id,
                    d.Invoice.Client.Lastname + ", " + d.Invoice.Client.Name,
                    d.Invoice.IssueDate.ToString("dd/MM/yyyy"),
                    d.DeliveryDate.ToString("dd/MM/yyyy"),
                    d.DepartureDate.ToString("HH:mm"),
                    d.ArrivalDate.ToString("HH:mm"),
                    d.Dealer.Lastname + ", " + d.Dealer.Name);
            });
        }


        private void btnDispatchOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                FormPreShipOrder frm = new FormPreShipOrder(Convert.ToInt32(dgvOrders.SelectedRows[0].Cells[0].Value.ToString()), this);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog(this);
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

        private void btnReportProblem_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrdersHistory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvOrdersHistory.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                dgvOrdersHistory.Cursor = Cursors.Hand;
            }
        }

        private void dgvOrdersHistory_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Restaurar el color original
                dgvOrdersHistory.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvOrdersHistory.Cursor = Cursors.Default;
            }
        }

        private void dgvOrdersHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvOrdersHistory.Rows[e.RowIndex];
            int idInvoice = Convert.ToInt32(row.Cells[0].Value.ToString());
            FormOrderDetail frm = new FormOrderDetail(ordersFinalized.FirstOrDefault(o => o.Invoice.Id == idInvoice));
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }
    }
}
