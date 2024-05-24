using SVC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            timer1.Start();
        }
        #region "Funcionalidades Window"
        bool menuExpand = false;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuVentas.Height += 10;
                if (menuVentas.Height >= 178)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuVentas.Height -= 10;
                if (menuVentas.Height <= 65)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }



        #endregion

        private void lnkMyProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkMyProfile.LinkVisited = true;
            OpenForms<FormUserProfile>();
        }
        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            OpenForms<FormCrearVenta>();
        }
        private void OpenForms<MyForm>() where MyForm : Form, new()
        {
            Form frm;
            frm = panelInterface.Controls.OfType<MyForm>().FirstOrDefault();
            if (frm == null)
            {
                frm = new MyForm();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                panelInterface.Controls.Add(frm);
                panelInterface.Tag = frm;
                frm.Show();
                frm.BringToFront();
                frm.FormClosed += new FormClosedEventHandler(CloseForms);
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FormUserProfile"] == null)
            {
                lnkMyProfile.LinkVisited = false;
            }
            if (Application.OpenForms["FormCrearVenta"] == null)
            {
                btnCrearVenta.BackColor = Color.FromArgb(4, 41, 68);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblName.Text = SessionManager.GetInstance.usuario.Nombre;
            lblPosition.Text = SessionManager.GetInstance.usuario.Area;
            lblEmail.Text = SessionManager.GetInstance.usuario.Email;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
            this.Close();
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
    }
}
