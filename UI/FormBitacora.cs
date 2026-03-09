using BDE;
using BLL;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
        private readonly IEventlogService _eventlogService;
        DateTime from = new DateTime();
        DateTime until = new DateTime();
        DataTable _dtBitacora;
        public FormBitacora(IEventlogService eventlogService)
        {
            InitializeComponent();
            _eventlogService = eventlogService;
            ApplyStyleCommon.DGVStyle(this.dgvBitacora);
        }

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private void SetPlaceholder(TextBox tb, string text)
        {
            if (tb == null || tb.IsDisposed) return;
            SendMessage(tb.Handle, EM_SETCUEBANNER, (IntPtr)1, text);
        }
        #region Configs
        private void ConfigDataPickers()
        {
            dtpFrom.Value = GetFirstDateTimeBitacora;
            dtpUntil.Value = DateTime.Now.Date;

            dtpFrom.MinDate = dtpFrom.Value;
            dtpUntil.MaxDate = DateTime.Now.Date;

            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.CustomFormat = "dd/MM/yyyy";

            dtpUntil.Format = DateTimePickerFormat.Custom;
            dtpUntil.CustomFormat = "dd/MM/yyyy";
        }
        private void ConfigComboBoxes()
        {
            BE_EventType[] eventTypes = (BE_EventType[])Enum.GetValues(typeof(BE_EventType));
            cbEvents.DataSource = eventTypes.ToList();

        }
        
        private DateTime GetFirstDateTimeBitacora => _dtBitacora.AsEnumerable()
            .Min(r => r.Field<DateTime>("eventDate"));

        #endregion

        private void FormBitacora_Load(object sender, EventArgs e)
        {   
            this._dtBitacora = _eventlogService.GetLogs();
            this.dgvBitacora.DataSource = _dtBitacora;
            ConfigDataPickers();
            ConfigComboBoxes();

            // UX enhancements: show placeholder in search box and leave events unselected to mean "All"
            try
            {
                SetPlaceholder(txtSearchUsername, "Buscar usuario...");
            }
            catch { }

            try { cbEvents.SelectedIndex = -1; } catch { }
        }

        private static string ToUSDate(DateTime d) => d.ToString("MM'/'dd'/'yyyy", CultureInfo.InvariantCulture);
        

        private void FilterBitacora() 
        {
            if (_dtBitacora == null) return;

            
            DateTime fromDate = dtpFrom.Value.Date;
            DateTime untilExclusive = dtpUntil.Value.Date.AddDays(1);

            string typedUser = (txtSearchUsername?.Text ?? "").Trim();
            
            var conditions = new List<string>
            {
                $"eventDate >= #{ToUSDate(fromDate)}#",
                $"eventDate < #{ToUSDate(untilExclusive)}#"
            };

            if (!string.IsNullOrWhiteSpace(typedUser))
            {
                string safe = typedUser.Replace("'", "''");
                conditions.Add($"username LIKE '%{safe}%'");
            }
            string query = string.Join(" AND ", conditions);

            DataRow[] rows = _dtBitacora.Select(query);

            DataTable dtFiltrado = _dtBitacora.Clone();
            foreach (DataRow r in rows) dtFiltrado.ImportRow(r);

            dgvBitacora.DataSource = dtFiltrado;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            FilterBitacora();
        }

        private void dtpUntil_ValueChanged(object sender, EventArgs e)
        {
            FilterBitacora();
        }

        private void cbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSeachUsername_TextChanged(object sender, EventArgs e)
        {
            FilterBitacora();
        }

        private void btnFilterBitacora_Click(object sender, EventArgs e)
        {

        }
    }
}
