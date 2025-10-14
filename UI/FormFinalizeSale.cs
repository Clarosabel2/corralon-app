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
using UI.common;
using UI.common.Styles;
using UI.common.Utils;

namespace UI
{
    public partial class FormFinalizeSale : Form
    {
        public FormFinalizeSale()
        {
            InitializeComponent();
            ApplyStyleForm();
            ConfigForm();
            LoadDataSale();
        }

        private void ConfigForm()
        {
            dtpDeliveryDate.MinDate = DateTime.Now.Hour > 18 ? DateTime.Today.AddDays(1) : DateTime.Today;
            cBTypesInvoice.DataSource = BLL_Invoice.GetTypesInvoice();
            cBTypesInvoice.DisplayMember = "tipo";
            cBTypesInvoice.ValueMember = "id_Tipo";
        }

        private void LoadDataSale()
        {
            foreach (BE_Item item in BLL_Sale.CurrentSale.ItemsProducts)
            {
                dgvCartSummary.Rows.Add(
                    ImageLoader.LoadSafe(item.Product.ImagePath) ?? Properties.Resources.img_icon,
                    item.Product.Name,
                    item.Amount);
            }
            lblTotalValue.Text = BLL_Sale.CurrentSale.Total.ToString();
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
            txtDireccionEntrega.ReadOnly = true;
            var dni = txtDNIClient.Text;
            txtDNIClient.BackColor = SystemColors.Window;
            if (txtDNIClient.Text.Length >= 8)
            {
                var client = BLL_Sale.AddClient(dni);
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
                        FormRegisterClient f = new FormRegisterClient();
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
    }
}
