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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            this.Load += FormSettings_Load;
            this.btnSave.Click += BtnSave_Click;
            this.btnCancel.Click += (s, e) => this.Close();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            // Cargar estado de tema
            cmbTheme.SelectedIndex = UI.common.Styles.ThemeManager.IsDarkMode ? 1 : 0;
            
            // Aplicar tema actual a sí mismo
            UI.common.Styles.ThemeManager.ApplyTheme(this.Controls);
            this.BackColor = UI.common.DefaultColors.BgPanel;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Guardar preferencias
            UI.common.Styles.ThemeManager.IsDarkMode = cmbTheme.SelectedIndex == 1;
            
            MessageBox.Show("Configuración guardada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
