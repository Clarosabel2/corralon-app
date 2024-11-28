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
        private List<BE_Family> profiles = new List<BE_Family>();
        private string idProfile;
        public FormProfiles()
        {
            InitializeComponent();
        }
        private void FormProfiles_Load(object sender, EventArgs e)
        {
            LoadAllPermissions();
        }

        public void LoadAllPermissions()
        {
            profiles = BLL_Permission.GetAllProfiles();
            cBProfiles.Items.Clear();
            cBProfiles.Items.Add(new KeyValuePair<string, string>("", "All"));
            profiles.ForEach(f => cBProfiles.Items.Add(new KeyValuePair<string, string>(f.Description, f.Id)));
            cBProfiles.DisplayMember = "Value";
            cBProfiles.ValueMember = "Key";
            cBProfiles.SelectedIndex = 0;
            //dgvUsers.DataSource = BLL_User.GetUsersByProfile();
        }

        private TreeNode CreateNode(BE_Permission p)
        {
            TreeNode rootNode = new TreeNode(p.Id);
            rootNode.Tag = p.Description;

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

        private void cBProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPair = (KeyValuePair<string, string>)cBProfiles.SelectedItem;
            idProfile = selectedPair.Value;
            treeView1.Nodes.Clear();
            if ((sender as ComboBox).SelectedIndex != 0)
            {
                btnConfigureProfile.Enabled = true;
                treeView1.Nodes.Add(CreateNode(profiles.FirstOrDefault(f => f.Id == idProfile)));
            }
            else
            {
                btnConfigureProfile.Enabled = false;
                profiles.ForEach(f => treeView1.Nodes.Add(CreateNode(f)));
            }
        }

        private void btnConfigureProfile_Click(object sender, EventArgs e)
        {
            BE_Family fm = new BE_Family();
            fm = profiles.FirstOrDefault(p => p.Id == idProfile);
            FormManageProfile f = new FormManageProfile(fm, this);
            f.BringToFront();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            FormManageProfile f = new FormManageProfile(null, this);
            f.BringToFront();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btnDeleteFamily_Click(object sender, EventArgs e)
        {
            BE_Family fm = new BE_Family();
            fm = profiles.FirstOrDefault(p => p.Id == idProfile);
            BLL_Permission.DeleteProfile(fm);
            LoadAllPermissions();
        }
    }
}
