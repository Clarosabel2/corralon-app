using BLL;
using SVC;
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
    public partial class FormLanguageConfig : Form
    {
        public FormLanguageConfig()
        {
            InitializeComponent();
        }

        private void FormLanguageConfig_Load(object sender, EventArgs e)
        {
            var len = BLL_Language.GetLanguages();
            len.ForEach(l => comboBoxLanguages.Items.Add(l.Name));
            comboBoxLanguages.SelectedIndex = comboBoxLanguages.FindString(len.FirstOrDefault(l => l.IsDefault).Name);
        }

        private void btnSetDefaultLanguage_Click(object sender, EventArgs e)
        {
            BLL_Language.SetDefaultLanguage(comboBoxLanguages.SelectedItem.ToString());
        }
    }
}
