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
        private FormProfiles pForm;
        private bool isModifyProfile = false;
        public FormManageProfile(BE_Family p = null, FormProfiles previousForm = null)
        {
            InitializeComponent();
            cBTypePermission.SelectedIndex = 0;
            if (p != null)
            {
                pForm = previousForm;
                profile = p;
                isModifyProfile = true;
                ButtonCreateFamily.Visible = false;
                txtNameFamily.Text = p.Id;
                txtDescripcionFamily.Text = p.Description;
                txtNameFamily.ReadOnly = true;
                txtDescripcionFamily.ReadOnly = true;
                groupBoxTreeViews.Enabled = true;
                treeViewProfile.Nodes.Add(CreateNode(p));
            }
        }
        private void LoadNodesInTreeView(TreeView tv, List<BE_Family> p)
        {
            tv.Nodes.Clear();
            p.ForEach(per => tv.Nodes.Add(CreateNode(per)));
            tv.ExpandAll();
        }
        private TreeNode CreateNode(BE_Permission p)
        {
            TreeNode rootNode = new TreeNode(p.Id);
            rootNode.Tag = p;

            if (p.Children != null && p.Children.Count > 0)
            {
                foreach (var child in p.Children)
                {
                    TreeNode childNode = CreateNode(child);
                    rootNode.Nodes.Add(childNode);
                }
            }
            rootNode.ExpandAll();
            return rootNode;
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
                BE_Permission permissionToAdd = (BE_Permission)newNode.Tag;


                if (BLL_Permission.IsAncestor(permissionToAdd, profile))
                {
                    MessageBox.Show("No se puede agregar un nodo padre como hijo, ya que esto generaría una relación circular.",
                        "Operación no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (NodeExists(targetTreeView.Nodes, newNode.Text))
                {
                    MessageBox.Show("El Permiso ya está agregado.");
                    return;
                }


                if (targetTreeView.SelectedNode != null)
                {

                    BE_Permission parentPermission = (BE_Permission)targetTreeView.SelectedNode.Tag;


                    parentPermission.addChild(permissionToAdd);


                    targetTreeView.SelectedNode.Nodes.Add((TreeNode)newNode.Clone());
                    targetTreeView.SelectedNode.Expand();
                }
                else
                {

                    profile.addChild(permissionToAdd);

                    targetTreeView.Nodes.Add((TreeNode)newNode.Clone());
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

        private void ButtonSaveFamily_Click(object sender, EventArgs e)
        {
            PrintFamilyHierarchy(profile);

            if (isModifyProfile)
            {
                MessageBox.Show(profile.Children.Count.ToString());
                BLL_Permission.UpdateProfile(profile);
            }
            else
            {
                BLL_Permission.SaveProfile(profile);
            }
            pForm?.LoadAllPermissions();
            this.Close();
        }
        private void PrintFamilyHierarchy(BE_Family family, string indent = "")
        {
            if (family == null) return;

            Console.WriteLine($"{indent}- {family.Description} (ID: {family.Id})");


            if (family.Children != null && family.Children.Count > 0)
            {
                foreach (var child in family.Children)
                {

                    PrintFamilyHierarchy((BE_Family)child, indent + "  ");
                }
            }
        }

        private void FormManageProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            pForm?.LoadAllPermissions();
        }

        private void cBTypePermission_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == 0)
            {
                LoadNodesInTreeView(treeViewPermissions, BLL_Permission.GetAllPermissionsSystem());
            }
            else
            {
                var profiles = BLL_Permission.GetAllProfiles();
                if (profile != null)
                {
                    profiles.Remove(profiles.FirstOrDefault(p => p.Id == profile.Id));
                }
                LoadNodesInTreeView(treeViewPermissions, profiles);
            }
        }
    }
}
