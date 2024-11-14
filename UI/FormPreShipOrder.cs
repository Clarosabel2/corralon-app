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

namespace UI
{
    public partial class FormPreShipOrder : Form
    {
        private int _id_invoice;
        public FormPreShipOrder(int idInvoice)
        {
            InitializeComponent();
            _id_invoice = idInvoice;
            dgvDetailsOrder.DataSource = BLL_Sale.GetProductsByIdInvoice(idInvoice);
            BLL_Employee.GetEmployeesByArea("Reparto")
                .ForEach(e => cBDealers.Items.Add(new KeyValuePair<BE_Employee, string>(e, $"{e.Lastname}, {e.Name}")));
            cBDealers.DisplayMember = "Value";
            cBDealers.ValueMember = "Key";
        }

        private void buttonDispatchOrder_Click(object sender, EventArgs e)
        {
            var slt = (KeyValuePair<BE_Employee, string>)cBDealers.SelectedItem;
            try
            {
                BLL_Order.DepatchOrder(_id_invoice, slt.Key);
                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
