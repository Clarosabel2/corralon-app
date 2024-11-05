using BDE;
using BDE.Composite;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormManageProfile : Form
    {
        private BE_Family profile;
        public FormManageProfile()
        {
            InitializeComponent();
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
                treeViewPermissions.Nodes.Add(rootNode);
                LoadNodes(rootNode, family);
            }
            tv.ExpandAll();
        }
        private void LoadAllPermissions()
        {
            LoadNodesInTreeView(treeViewPermissions, BLL_Permission.GetAllPermissions(true));
        }

        private ToolTip toolTip = new ToolTip();
        private TreeNode lastNode = null;
        private void ShowToolTip(TreeView treeView, TreeNode currentNode)
        {
            if (currentNode != lastNode)
            {
                toolTip.Hide(treeView);
                lastNode = currentNode;

                if (currentNode.Tag is BE_Permission p)
                {
                    toolTip.SetToolTip(treeView, p.Description);

                    Rectangle nodeBounds = currentNode.Bounds;
                    int x = nodeBounds.Right + 5;
                    int y = nodeBounds.Top;

                    toolTip.Show(p.Description, treeView, x, y);
                }
            }
        }
        private void treeView_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            ShowToolTip(sender as TreeView, e.Node);
        }

        private void treeViewPermissions_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeViewProfile_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != null && e.Node.Parent != null)
            {
                e.Node.Remove();
                profile.removeChild((BE_Permission)e.Node.Tag);
            }
        }
        private bool NodeExists(TreeNodeCollection nodes, string nodeText)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text == nodeText)
                {
                    return true;
                }
                if (NodeExists(node.Nodes, nodeText))
                {
                    return true;
                }
            }
            return false;
        }
        private void treeViewProfile_DragDrop(object sender, DragEventArgs e)
        {
            TreeView targetTreeView = sender as TreeView;
            TreeNode newNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            if (newNode != null)
            {
                profile.addChild((BE_Permission)newNode.Tag);
                if (!NodeExists(targetTreeView.Nodes, newNode.Text))
                {
                    if (targetTreeView.SelectedNode != null)
                    {
                        targetTreeView.SelectedNode.Nodes.Add((TreeNode)newNode.Clone());
                        targetTreeView.SelectedNode.Expand();
                    }
                    else
                    {
                        targetTreeView.Nodes.Add((TreeNode)newNode.Clone());
                    }
                }
            }
        }

        private void treeviewProfile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private bool isLeave = true;
        private void treeView_MouseLeave(object sender, EventArgs e)
        {
            toolTip.Hide(sender as TreeView);
        }

        private void ButtonAddFamily_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
            if (!string.IsNullOrEmpty(txtNameFamily.Text) && !string.IsNullOrEmpty(txtDescripcionFamily.Text))
            {
                groupBoxTreeViews.Enabled = true;
                TreeNode node = new TreeNode(txtNameFamily.Text);
                node.Tag = txtDescripcionFamily.Text;

                profile = new BE_Family(node.Text, node.Tag.ToString());

                treeViewProfile.Nodes.Add(node);
                treeViewProfile.SelectedNode = node;
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ButtonSaveFamily_Click(object sender, EventArgs e)
        {
            BLL_Permission.SaveProfile(profile);
            this.Dispose();
        }
    }
}
