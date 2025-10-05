using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.common;
using UI.common.Styles;

namespace UI
{
    public partial class FormBitacora : Form
    {
        DateTime from = new DateTime();
        DateTime until = new DateTime();
        DataTable _dtBitacora;
        public FormBitacora()
        {
            InitializeComponent();
            _dtBitacora = BLL_EventLog.LoadEventlogs();
            ApplyStyleCommon.DGVStyle(this.dgvBitacora);
        }
        private DateTime GetFirstDateTimeBitacora=> _dtBitacora.AsEnumerable()
            .Min(r => r.Field<DateTime>("eventDate"));
        private void FormBitacora_Load(object sender, EventArgs e)
        {
            this.dgvBitacora.DataSource = _dtBitacora;

            dtpFrom.Value = GetFirstDateTimeBitacora;
            dtpUntil.Value = DateTime.Now.Date;

            dtpFrom.MinDate = dtpFrom.Value;
            dtpUntil.MaxDate = DateTime.Now.Date;

            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.CustomFormat = "dd/MM/yyyy";

            dtpUntil.Format = DateTimePickerFormat.Custom;
            dtpUntil.CustomFormat = "dd/MM/yyyy";
        }

        private void btnFilterBitacora_Click(object sender, EventArgs e)
        {

        }
        private void FilterByDateTime(DateTime from, DateTime until)
        {
            this.from = from;
            this.until = until;
            dgvBitacora.DataSource = null;
            string query = $"eventDate >= #{this.from:yyyy-MM-dd}# AND eventDate <= #{this.until:yyyy-MM-dd}#";
            DataRow[] filasFiltradas = _dtBitacora.Select(
                query
            );
            DataTable dtFiltrado = _dtBitacora.Clone();
            foreach (DataRow row in filasFiltradas)
                dtFiltrado.ImportRow(row);
            dgvBitacora.DataSource = dtFiltrado;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            
            FilterByDateTime(dtpFrom.Value.Date, dtpUntil.Value.Date.AddDays(1).AddTicks(-1));
        }

        private void dtpUntil_ValueChanged(object sender, EventArgs e)
        {
            FilterByDateTime(dtpFrom.Value.Date, dtpUntil.Value.Date.AddDays(1).AddTicks(-1));
        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
