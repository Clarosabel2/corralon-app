using BDE.Language;
using BLL;
using BLL.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using SVC;
using SVC.LanguageManager;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UI.FormsViewData;

namespace UI
{
    public partial class FormMain : Form, IObserver
    {
        private readonly IDbMaintenanceService _dbMaintenaceService;
        private readonly IUserService _userService;
        public FormMain(
            IDbMaintenanceService dbMaintenaceService,
            IUserService userService
            )
        {
            InitializeComponent();
            EnableControls();
            _dbMaintenaceService = dbMaintenaceService;
            _userService = userService;

            timerDateHour.Start();
            LanguageManager.CurrentLanguage = SessionManager.GetInstance.user.Language;
            LanguageManager.Attach(this);
            CheckIntegrityDatabase();

            UI.common.Styles.ThemeManager.OnThemeChanged += ThemeManager_OnThemeChanged;
            ApplyGlobalTheme();
        }

        private void ThemeManager_OnThemeChanged(object sender, EventArgs e)
        {
            ApplyGlobalTheme();
        }

        private void ApplyGlobalTheme()
        {
            UI.common.Styles.ThemeManager.ApplyTheme(this.Controls);
            // Reapply form specifically
            this.BackColor = UI.common.DefaultColors.BgPanel;

            // Apply theme to currently opened form in panelInterface
            foreach (Control control in panelInterface.Controls)
            {
                if (control is Form frm)
                {
                    frm.BackColor = UI.common.DefaultColors.BgPanel;
                    UI.common.Styles.ThemeManager.ApplyTheme(frm.Controls);
                }
            }
        }

        private void CheckIntegrityDatabase()
        {
            if (_dbMaintenaceService.CheckIntegrity())
            {
                OpenForms<FormDatabaseMaintenance>();
            }
        }

        private void EnableControls()
        {
            //temporario
            btnVehicles.Visible = true;
            if (SessionManager.GetInstance.user.Rol != BDE.BE_TypeUser.ADMIN)
            {
                btnEmployees.Visible = false;
                btnProfiles.Visible = false;
                btnReports.Visible = false;
                btnManagerLanguages.Visible = false;
                btnUsers.Visible = false;
            }
            switch (SessionManager.GetInstance.user.Rol)
            {
                case BDE.BE_TypeUser.ADMIN:
                    //btnProducts.Visible = false;
                    //btnOrders.Visible = false;
                    //btnCreateSale.Visible = false;

                    btnManageDB.Visible = true;
                    btnManagerLanguages.Visible = true;
                    btnBitacora.Visible = true;
                    break;
                case BDE.BE_TypeUser.SALESMAN:
                    btnProducts.Visible = false;
                    btnOrders.Visible = false;
                    break;
                case BDE.BE_TypeUser.LOGISTICMAN:
                    btnCreateSale.Visible = false;
                    break;
                case BDE.BE_TypeUser.MECHANICMAN:
                    btnVehicles.Visible = true;
                    break;
            }
        }

        #region "Funcionalidades Window"

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void timerDateHour_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();

        }
        #endregion
        private void OpenForms<TForm>(params object[] args) where TForm : Form
        {
            foreach (Form openForm in panelInterface.Controls.OfType<Form>())
            {
                openForm.Close();
                panelInterface.Controls.Remove(openForm);
            }

            TForm frm;
            
            // Si el formulario requiere instanciarse con dependencias complejas, 
            // intentamos usar nuestro contenedor IoC. Si trae argumentos quemados, 
            // caemos en Activator.
            if (args != null && args.Length > 0)
            {
                frm = (TForm)Activator.CreateInstance(typeof(TForm), args);
            }
            else
            {
                try
                {
                    frm = Program.ServiceProvider.GetRequiredService<TForm>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error del IoC Container: " + ex.Message); // <-- Míralo aquí
                    frm = (TForm)Activator.CreateInstance(typeof(TForm));
                }
            }

            frm.TopLevel = false;
            frm.MinimizeBox = false;
            frm.MaximizeBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            
            // Appy theme globally to newly opened form
            frm.BackColor = UI.common.DefaultColors.BgPanel;
            UI.common.Styles.ThemeManager.ApplyTheme(frm.Controls);

            panelInterface.Controls.Add(frm);
            panelInterface.Tag = frm;

            frm.Show();
            frm.BringToFront();

            frm.FormClosed += new FormClosedEventHandler(CloseForms);
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FormUserProfile"] == null)
            {
                lnkMyProfile.LinkVisited = false;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadDataUser();
        }

        public void LoadDataUser()
        {
            lblName.Text = SessionManager.GetInstance.user.Emp.Name;
            lblPosition.Text = SessionManager.GetInstance.user.Rol.ToString();
            lblEmail.Text = SessionManager.GetInstance.user.Emp.Email;
        }

        private void lnkMyProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUserProfile.frmmain = this;
            lnkMyProfile.LinkVisited = true;
            OpenForms<FormUserProfile>();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult r =
                MessageBox.Show(SessionManager.translations[LanguageManager.CurrentLanguage][this.Name]["MsgLogout"], "Aviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                _userService.Logout();
                this.Close();
                FormLogin frmLogin = Program.ServiceProvider.GetRequiredService<FormLogin>();
                frmLogin.ShowDialog();
            }
        }

        #region "Menu"
        private void btnModifyProfiles_Click(object sender, EventArgs e)
        {
            OpenForms<FormProfiles>();
        }
        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            OpenForms<FormCreateSale>();
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenForms<FormProducts>();
        }

        private void btnProfiles_Click(object sender, EventArgs e)
        {
            OpenForms<FormProfiles>();
        }
        private void btnManagerLanguages_Click(object sender, EventArgs e)
        {
            OpenForms<FormLanguageConfig>();
        }
        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenForms<FormOrders>();
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenForms<FormUsers>();
        }
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            OpenForms<FormEmployeesPhoto>();
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            dropdownMenuReports.Show(btnReports, btnReports.Width, 0);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            OpenForms<FormClients>();
        }
        private void btnManageDB_Click(object sender, EventArgs e)
        {
            OpenForms<FormDatabaseMaintenance>();
        }
        private void btnBitacora_Click(object sender, EventArgs e)
        {
            OpenForms<FormBitacora>();
        }
        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            OpenForms<FormSuppliers>();
        }
        private void btnAuditChanges_Click(object sender, EventArgs e)
        {
            OpenForms<FormAuditChanges>();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            OpenForms<FormVehicles>();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenForms<FormSettings>();
        }
        #endregion
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        public void Update(Language language)
        {
            UITranslator.ApplyTranslations(this, SessionManager.translations[language][this.Name]);
        }

        
    }
}
