using BDE;
using BLL.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;
using UI.common;
using UI.common.Styles;
using UI.common.Utils;

namespace UI
{
    public partial class FormFinalizeSale : Form
    {
        private ISaleService _saleService;
        private IClientService _clientService;
        private Sale _currentSale;
        public FormFinalizeSale(
            ISaleService saleService,
            Sale currentSale = null
            )
        {
            InitializeComponent();
            _saleService = saleService;
            _currentSale = currentSale;

            ApplyStyleForm();
            ConfigForm();
            LoadDataSale();
        }

        private void ConfigForm()
        {
            dtpDeliveryDate.MinDate = DateTime.Now.Hour > 18 ? DateTime.Today.AddDays(1) : DateTime.Today;
            cBTypesInvoice.DataSource = _saleService.GetTypes();
            cBTypesInvoice.DisplayMember = "tipo";
            cBTypesInvoice.ValueMember = "id_Tipo";
        }

        private void LoadDataSale()
        {
            foreach (Item item in _currentSale.ItemsProducts)
            {
                dgvCartSummary.Rows.Add(
                    ImageLoader.LoadSafe(item.Product.ImagePath) ?? Properties.Resources.img_icon,
                    item.Product.Name,
                    item.Amount);
            }
            lblTotalValue.Text = _currentSale.Total.ToString();
        }

        private void ApplyStyleForm()
        {
            lblHeader.BackColor = DefaultColors.Primary;
            lblHeader.ForeColor = Color.White;

            flpActions.BackColor = DefaultColors.Primary;
            pnlActions.BackColor = DefaultColors.Primary;

            btnConfirm.BackColor = SystemColors.Control;
            btnCancel.BackColor = SystemColors.Control;
            btnDraft.BackColor = SystemColors.Control;
            ApplyStyleCommon.DGVStyle(dgvCartSummary);
            dgvCartSummary.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12f, FontStyle.Bold);
            dgvCartSummary.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 0, 0, 0);
            dgvCartSummary.ColumnHeadersHeight = 40;
            dgvCartSummary.DefaultCellStyle.Font = new Font("Century Gothic", 7f, FontStyle.Regular);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtDNIClient_TextChanged(object sender, EventArgs e)
        {
            var dni = txtDNIClient.Text;
            txtDNIClient.BackColor = SystemColors.Window;
            if (txtDNIClient.Text.Length >= 8)
            {
                var client = _clientService.GetByDNI(dni);
                _currentSale.AddClient(client);
                if (client != null)
                {
                    btnConfirm.Enabled = true;
                    txtDNIClient.BackColor = Color.GreenYellow;
                    txtDireccionEntrega.Text = client.Address;
                    //lblEstadoCliente.Text = client.Name + " " + client.Lastname;
                }
                else
                {
                    txtDNIClient.BackColor = Color.Red;

                    DialogResult r =
                        MessageBox.Show($"El cliente con DNI {dni} no esta registrado. Desea registrar el cliente?", "Aviso"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        txtDNIClient.Text = "";
                        FormRegisterClient f = new FormRegisterClient(_clientService, this);
                        f.TopLevel = false;
                        this.Controls.Add(f);
                        f.BringToFront();
                        f.txtDni.Text = dni;
                        f.Show();
                    }
                }
            }
            else
            {
                //lblEstadoCliente.Text = "";
                btnConfirm.Enabled = false;
            }
        }

        private void rbRetiroLocal_CheckedChanged(object sender, EventArgs e)
        {
            flpNotifyChks.Enabled = false;
        }

        private void rbEnvioDomicilio_CheckedChanged(object sender, EventArgs e)
        {
            flpNotifyChks.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _currentSale.TypeInvoice = cBTypesInvoice.GetItemText(cBTypesInvoice.SelectedItem)[0];
            _currentSale.Status = true;

            var newDelivery = new Delivery();
            newDelivery.DeliveryDate = dtpDeliveryDate.Value;
            newDelivery.AddressDelivery = txtDireccionEntrega.Text;
            newDelivery.Sale = _currentSale;
            try
            {
                try
                {
                    _saleService.SaveWithDelivery(newDelivery);
                    DialogResult r = MessageBox.Show("Factura guardada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK) this.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la factura:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDNIClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
