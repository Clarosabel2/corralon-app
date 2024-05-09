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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }
        #region "botones ventana"
        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro de que quiere cerrar la aplicacion?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnMaximized.Visible = true; btnReset.Visible = false;
            this.WindowState= FormWindowState.Normal;
            
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            btnMaximized.Visible = false; btnReset.Visible = true;
            this.WindowState= FormWindowState.Maximized;

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
            if (Application.OpenForms["FormCrearVenta"] == null) {
                btnCrearVenta.BackColor = Color.FromArgb(4, 41, 68);
            }
        }

    }
}
