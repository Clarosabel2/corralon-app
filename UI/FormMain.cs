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
                case 6:
                    flp = subMenuProfiles;
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
            var forms = panelInterface.Controls.OfType<MyForm>();
            Form frm = forms.FirstOrDefault();
            if (frm != null)
            {
                frm.Close();
            }
            frm = new MyForm();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.AutoSize = true;
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
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
            if (Application.OpenForms["FormCrearVenta"] == null)
            {
                btnCrearVenta.BackColor = Color.FromArgb(4, 41, 68);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblName.Text = SessionManager.GetInstance.usuario.Emp.Nombre;
            lblPosition.Text = SessionManager.GetInstance.usuario.Rol;
            lblEmail.Text = SessionManager.GetInstance.usuario.Emp.Email;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
            this.Close();
        }


    }
}
