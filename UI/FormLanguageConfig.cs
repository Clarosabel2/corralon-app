using BDE;
using BDE.Language;
using BLL;
using Microsoft.VisualBasic;
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
using UI.common.Styles;

namespace UI
{
    public partial class FormLanguageConfig : Form
    {
        public FormLanguageConfig()
        {
            InitializeComponent();
            ApplyStyleCommon.DGVStyle(dgvTranslation);
            LoadAllForms();
            dgvTranslation.DataSource = GetContolsWithTranslations();
        }
        private void LoadLanguageInComboBox()
        {
            cBLanguages.Items.Clear();
            BLL_Language.GetLanguages().ForEach(l => cBLanguages.Items.Add(new KeyValuePair<BE_Language, string>(l, l.Name)));
            cBLanguages.DisplayMember = "Value";
            cBLanguages.ValueMember = "Key";

            comboBoxLanguages.Items.Clear();
            var len = BLL_Language.GetLanguages();
            len.ForEach(l => comboBoxLanguages.Items.Add(l.Name));
            comboBoxLanguages.SelectedIndex = comboBoxLanguages.FindString(len.FirstOrDefault(l => l.IsDefault).Name);
        }
        public void LoadAllForms()
        {
            using (ResXResourceReader fileResx = new ResXResourceReader
                (@"../../Resources/ResourceForms.resx"))
            {
                foreach (DictionaryEntry f in fileResx)
                {
                    cBForms.Items.Add(f.Key.ToString());
                }
            }

            LoadLanguageInComboBox();

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

            if (!len.Equals(default(KeyValuePair<BE_Language, Dictionary<string, Dictionary<string, string>>>)))
            {

                if (SessionManager.translations.ContainsKey(len.Key) &&
                    SessionManager.translations[len.Key].ContainsKey(cBForms.Text))
                {
                    lens = SessionManager.translations[len.Key][cBForms.Text];
                }
            }

            List<KeyValuePair<string, string>> resxData = new List<KeyValuePair<string, string>>();
            using (ResXResourceReader resxReader = new ResXResourceReader
                (@"../../Resources/Resource1.resx"))
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

            // IDIOMA SELECCIONADO, FORMULARIO ACTUAL, DATATABLE CON TRADUCCIONES
            try
            {
                if (BLL_Language.UpdateTranslations(translations))
                {
                    MessageBox.Show("Se actualizo correctamente la traducción");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateNewLanguage_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox("Ingrese el idioma:", "Entrada requerida", "");

            if (!string.IsNullOrEmpty(userInput))
            {
                if (BLL_Language.CreateLanguage(userInput))
                {
                    LoadLanguageInComboBox();
                    cBLanguages.SelectedItem = cBLanguages.Items[cBLanguages.Items.Count - 1];
                }
            }
        }
    }
}
