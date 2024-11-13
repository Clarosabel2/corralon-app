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
            LoadAllPermissions();
        }

        private void LoadNodes(TreeNode parentNode, BE_Permission family)
        {
            if (family.Children != null)
            {
                foreach (var child in family.Children)
                {
                    TreeNode childNode = new TreeNode(child.Id);
                    childNode.Tag = child;
                    parentNode.Nodes.Add(childNode);
                    LoadNodes(childNode, child);
                }
            }
        }
        private void LoadNodesInTreeView(TreeView tv, List<BE_Family> p)
        {
            tv.Nodes.Clear();
            foreach (var family in p)
            {
                TreeNode rootNode = new TreeNode(family.Id);
                rootNode.Tag = family;
                tv.Nodes.Add(rootNode);
                LoadNodes(rootNode, family);
            }
            tv.ExpandAll();
        }
        private void LoadAllPermissions()
        {
            LoadNodesInTreeView(treeView1, BLL_Permission.GetAllPermissions(false));
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
