using BDE;
using BDE.Composite;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class FormProfiles : Form
    {
        public FormProfiles()
        {
            InitializeComponent();

        }
        private void FormProfiles_Load(object sender, EventArgs e)
        {
            
        }

        private void createNewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManageProfile f = new FormManageProfile();
            f.TopLevel = false;
            this.Controls.Add(f);
            f.BringToFront();
            f.FormBorderStyle= FormBorderStyle.None;
            f.StartPosition= FormStartPosition.CenterScreen;
            f.Location = new Point((this.ClientSize.Width - f.Width) / 2, (this.ClientSize.Height - f.Height) / 2);
            f.Show();
        }
    }
}
