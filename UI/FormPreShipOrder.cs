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
using UI.common.Utils;
using BLL.Interfaces;

namespace UI
{
    public partial class FormPreShipOrder : Form
    {
        private readonly IEmployeeService _employeeService;
        private readonly ISaleService _saleService;
        private readonly IDeliveryService _deliveryService;
        private int _id_invoice;
        private FormOrders frmOrders;
        public FormPreShipOrder(IEmployeeService employeeService, ISaleService saleService, IDeliveryService deliveryService, int idInvoice, FormOrders f)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _saleService = saleService;
            _deliveryService = deliveryService;
            frmOrders = f;
            ConfigForm(idInvoice);
        }
        private void LoadDealers()
        {
            _employeeService.GetByArea(BE_Area.DELIVERY.ToString())
                .ForEach(e => lstDealers.Items.Add(new KeyValuePair<Employee, string>(e, $"{e.Lastname}, {e.Name}")));
            lstDealers.DisplayMember = "Value";
            lstDealers.ValueMember = "Key";
        }

        private void ConfigForm(int idInvoice)
        {
            ApplyStyleCommon.DGVStyle(dgvItems);
            _id_invoice = idInvoice;
            List<Item> itemsSale = _saleService.GetItemsBySaleId(idInvoice);
            foreach (var item in itemsSale)
            {
                dgvItems.Rows.Add(new object[]
                {
                    item.Id,
                    ImageLoader.LoadSafe(item.Product.ImagePath),
                    item.Product.Name,
                    item.Amount,
                    ""
                });
            }
            dgvItems.DefaultCellStyle.Font = new Font("Century Gothic", 9F, FontStyle.Regular);
            dgvItems.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 9.5F, FontStyle.Bold);
            dgvItems.RowTemplate.Height = 30;
            LoadDealers();

            Sale sale = _saleService.GetSaleById(idInvoice);
            Client client = sale.Client;

            txtFullName.Text = $"{client.Lastname}, {client.Name}";
            txtAddress.Text = client.Address;
            txtPhone.Text = client.NumPhone.ToString();

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (txtAssignedDealer.Text != "")
            {
                MessageBox.Show("Ya hay un repartidor asignado. Primero quite el asignado.", "Error al asignar repartidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lstDealers.SelectedItem is KeyValuePair<Employee, string> kv)
            {
                txtAssignedDealer.Text = kv.Value;
                txtAssignedDealer.Tag = kv.Key;

                lstDealers.Items.Remove(lstDealers.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un repartidor de la lista.");
            }
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            if (txtAssignedDealer.Tag is Employee emp)
            {
                lstDealers.Items.Clear();
                LoadDealers();
                txtAssignedDealer.Clear();
                txtAssignedDealer.Tag = null;
            }
            else
            {
                MessageBox.Show("No hay repartidor asignado para quitar.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var assignedDealer = txtAssignedDealer.Tag as Employee;
            try
            {
                _deliveryService.Dispatch(_id_invoice, assignedDealer);
                frmOrders.LoadDataInDG();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
