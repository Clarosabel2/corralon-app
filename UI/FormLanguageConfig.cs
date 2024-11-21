using BDE;
using BDE.Language;
using BLL;
using SVC;
using SVC.LanguageManager;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.Remoting.Messaging;
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
            LoadAllForms();
            dgvTranslation.DataSource = GetContolsWithTranslations();
        }
        public void LoadAllForms()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            var formTypes = assembly.GetTypes()
                                .Where(t => t.IsSubclassOf(typeof(Form)) && !t.IsAbstract)
                                .ToList();

            foreach (var formType in formTypes)
            {
                cBForms.Items.Add(formType.Name);
            }
            BLL_Language.GetLanguages().ForEach(l => cBLanguages.Items.Add(new KeyValuePair<BE_Language, string>(l, l.Name)));
            cBLanguages.DisplayMember = "Value";
            cBLanguages.ValueMember = "Key";

            cBLanguages.SelectedIndex = 0;
            cBForms.SelectedIndex = 0;
        }
        private DataTable GetContolsWithTranslations()
        {
            DataTable dt = new DataTable("ControlsTranslations");
            dt.Columns.Add("Controles", typeof(string));
            dt.Columns.Add("Traducción", typeof(string));
            var len = SessionManager.translations.FirstOrDefault(l => l.Key.Name == cBLanguages.Text);
            Dictionary<string, string> lens = null;

            if (SessionManager.translations.ContainsKey(len.Key) &&
                SessionManager.translations[len.Key].ContainsKey(cBForms.Text))
            {
                lens = SessionManager.translations[len.Key][cBForms.Text];
            }

            List<KeyValuePair<string, string>> resxData = new List<KeyValuePair<string, string>>();

            using (ResXResourceReader resxReader = new ResXResourceReader(@"D:\Proyectos\UAI\3ER AÑO\IS\Proyecto Aplicacion\corralon-app\UI\Resources\ResourceControlsLanguage.resx"))
            {
                foreach (DictionaryEntry entry in resxReader)
                {
                    if (cBForms.Text != null && entry.Key.ToString().StartsWith(cBForms.Text + ":"))
                    {
                        string controlName = entry.Key.ToString().Substring(cBForms.Text.Length + 1);
                        resxData.Add(new KeyValuePair<string, string>(controlName, entry.Value.ToString()));
                    }
                }
            }
            foreach (var data in resxData)
            {
                string translation = "";

                if (lens != null && lens.ContainsKey(data.Key))
                {
                    translation = lens[data.Key];
                }
                dt.Rows.Add(data.Key, translation);
            }
            return dt;
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

        private void cBForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTranslation.DataSource = GetContolsWithTranslations();
        }

        private void cBLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTranslation.DataSource = GetContolsWithTranslations();
        }

        private void btnUpdateTranlationsControls_Click(object sender, EventArgs e)
        {
            Tuple<string, string, DataTable> translations
                = new Tuple<string, string, DataTable>
                (cBLanguages.Text, cBForms.Text, dgvTranslation.DataSource as DataTable);
            if (BLL_Language.UpdateTranslations(translations))
            {
                BLL_Language.LoadTranslations();
                LanguageManager.CurrentLanguage = SessionManager.translations.FirstOrDefault(i => i.Key.Name == SessionManager.GetInstance.user.Language.Name).Key;
                MessageBox.Show("Se actualizo correctamente la traducción");
            }
        }
    }
}
