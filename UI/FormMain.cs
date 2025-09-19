using BDE.Language;
using BLL;
using SVC;
using SVC.LanguageManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.FormsViewData;

namespace UI
{
    public partial class FormMain : Form, IObserver
    {
        private BLL_DV_DB bll_dv_db;
        public FormMain()
        {
            InitializeComponent();
            EnableControls();
            timerDateHour.Start();
            LanguageManager.CurrentLanguage = SessionManager.GetInstance.user.Language;
            LanguageManager.Attach(this);
            this.bll_dv_db = new BLL_DV_DB();
            CheckIntegrityDatabase();
        }

        private void CheckIntegrityDatabase()
        {
            if (bll_dv_db.IsDVInconsistent)
            {
                OpenForms<FormDatabaseMaintenance>(bll_dv_db);
            }
        }

        private void EnableControls()
        {
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
                    /*btnProducts.Visible = false;
                    btnOrders.Visible = false;
                    btnCreateSale.Visible = false;*/
                    break;
                case BDE.BE_TypeUser.SALESMAN:
                    btnProducts.Visible = false;
                    btnOrders.Visible = false;
                    break;
                case BDE.BE_TypeUser.LOGISTICMAN:
                    btnCreateSale.Visible = false;
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
        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flp.Height += 10;
                if (flp.Height >= flp.MaximumSize.Height)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flp.Height -= 10;
                if (flp.Height <= flp.MinimumSize.Height)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }
        bool menuExpand = false;
        FlowLayoutPanel flp;
        FlowLayoutPanel currentFlp;
        private void btnMenu_Click(object sender, EventArgs e)
        {
            int btn = ((Button)sender).TabIndex;
            switch (btn)
            {
                case 1:
                    flp = menuVentas;
                    break;
                case 2:
                    flp = menuOperador;
                    break;
                case 3:
                    flp = menuReportes;
                    break;
                case 4:
                    flp = menuUsuario;
                    break;
                case 5:
                    flp = menuAdmin;
                    break;
                default:
                    MessageBox.Show("opcion incorrecta");
                    break;
            }

            if (flp == currentFlp && menuExpand)
            {
                // Close the menu if it's already open
                menuTransition.Stop();
                while (flp.Height > flp.MinimumSize.Height)
                {
                    flp.Height -= 10;
                    Application.DoEvents();
                }
                menuExpand = false;
            }
            else
            {
                if (currentFlp != null)
                {
                    menuTransition.Stop();
                    while (currentFlp.Height > currentFlp.MinimumSize.Height)
                    {
                        currentFlp.Height -= 10;
                        Application.DoEvents();
                    }
                    currentFlp = null;
                }

                menuExpand = false;
                flp.Height = flp.MinimumSize.Height;
                menuTransition.Start();
                currentFlp = flp;
            }
        }*/
        #endregion
        private void OpenForms<TForm>(params object[] args) where TForm : Form
        {
            foreach (Form openForm in panelInterface.Controls.OfType<Form>())
            {
                openForm.Close();
                panelInterface.Controls.Remove(openForm);
            }

            var frm = (Form)Activator.CreateInstance(typeof(TForm), args);

            frm.TopLevel = false;
            frm.MinimizeBox = false;
            frm.MaximizeBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

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
                BLL_User.Logout();
                this.Close();
                FormLogin frmLogin = new FormLogin();
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
            OpenForms<FormDatabaseMaintenance>("Hola");
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
        #endregion
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //BLL_User.Logout();
        }
        public void Update(BE_Language language)
        {
            UITranslator.ApplyTranslations(this, SessionManager.translations[language][this.Name]);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        
    }
}
