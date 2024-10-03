using BDE;
using BDE.Composite;
using BLL;
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
    public partial class FormProfiles : Form
    {
        public FormProfiles()
        {
            InitializeComponent();
        }

        private void LoadAllPermissions()
        {
            var p = BLL_Permission.GetAllPermissions();
            foreach (var per in p)
            {
                TreeNode t = new TreeNode(per.Id);
                t.Tag = per;

                foreach (var item in per.Children)
                {
                    if (item.GetType() == typeof(BE_Family))
                    {
                        var t2 = new TreeNode(item.Id);
                        t.Nodes.Add(t2);

                        foreach (var item1 in item.Children)
                        {
                            TreeNode patentNode1 = new TreeNode(item1.Id);
                            patentNode1.Tag = item1;
                            t2.Nodes.Add(patentNode1); 
                        }
                    }
                    else
                    {
                        // Nodo hijo de t (patentNode)
                        TreeNode patentNode = new TreeNode(item.Id);
                        patentNode.Tag = item;
                        t.Nodes.Add(patentNode);
                    }
                }
                treeView1.Nodes.Add(t);
            }
        }

        private void FormProfiles_Load(object sender, EventArgs e)
        {
            LoadAllPermissions();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            string nodeId = selectedNode.Text; 

            if (selectedNode.Tag is BE_Permission permission)
            {
                label1.Text = "ID Permiso: "+ permission.Id;
                label2.Text = "Descripción: " + permission.Description;
            }
        }
    }
}
