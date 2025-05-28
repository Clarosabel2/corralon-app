using BDE.Language;
using DAL;
using SVC;
using SVC.LanguageManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_Language
    {
        public static bool CreateLanguage(string userInput)
        {
            return DAL_Language.CreateLanguage(userInput);
        }

        public static List<BE_Language> GetLanguages()
        {
            return DAL_Language.GetLanguages()/*
                .Select(l => char.ToUpper(l[0]) + l.Substring(1).ToLower())*/.ToList();
        }
        

        public static void LoadTranslations()
        {
            DataTable dt = DAL_Language.GetTranslationsDataTable();
            List<BE_Language> languages = DAL_Language.GetLanguages();

            languages.ForEach(l => Console.WriteLine($"{l.Name} {(l.IsDefault ? "true" : "false")}"));

            SessionManager.translations = new Dictionary<BE_Language, Dictionary<string, Dictionary<string, string>>>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string languageName = dr["nombreIdioma"].ToString();
                    string formName = dr["nombreForm"].ToString();
                    string crtl = dr["nombreControl"].ToString();
                    string translation = dr["traduccion"].ToString();

                    var language = languages.FirstOrDefault(x => x.Name.Equals(languageName, StringComparison.OrdinalIgnoreCase));

                    if (language == null)
                    {
                        throw new Exception("Error en encontrar idioma");
                    }

                    if (!SessionManager.translations.ContainsKey(language))
                    {
                        SessionManager.translations[language] = new Dictionary<string, Dictionary<string, string>>();
                    }

                    if (!SessionManager.translations[language].ContainsKey(formName))
                    {
                        SessionManager.translations[language][formName] = new Dictionary<string, string>();
                    }
                    SessionManager.translations[language][formName][crtl] = translation;
                }
            }
            else
            {
                throw new Exception("No se encontraron traducciones en la base de datos.");
            }

            LanguageManager.CurrentLanguage = languages.FirstOrDefault(l => l.IsDefault);

        }

        public static void SetDefaultLanguage(string selectedItem)
        {
            DAL_Language.SetDefaultLanguage(selectedItem);
        }

        public static bool UpdateTranslations(Tuple<string, string, DataTable> translations)
        {
            var entry = SessionManager.translations.FirstOrDefault(i => i.Key.Name == translations.Item1);
            BE_Language len = entry.Key;
            bool anyChanges = false;
            string languageName = translations.Item1;
            string formName = translations.Item2;
            foreach (DataRow row in translations.Item3.Rows)
            {
                if (row[1].ToString() != "")
                {
                    string controlName = row[0].ToString();
                    string translationValue = row[1].ToString();

                    // Primero verificamos si se necesita hacer una actualización
                    if (len != null && SessionManager.translations.ContainsKey(len) &&
                        SessionManager.translations[len].ContainsKey(translations.Item2) &&
                        SessionManager.translations[len][translations.Item2].ContainsKey(controlName) &&
                        SessionManager.translations[len][translations.Item2][controlName] != translationValue)
                    {
                        // IDIOMA SELECCIONADO, FORMULARIO ACTUAL, DATATABLE CON TRADUCCIONES
                        DAL_Language.UpdateTranslation(languageName, formName, controlName, translationValue);
                        anyChanges = true;
                    }
                    else
                    {
                        // IDIOMA SELECCIONADO, FORMULARIO ACTUAL, DATATABLE CON TRADUCCIONES
                        DAL_Language.InsertTranslation(languageName, formName, controlName, translationValue);
                        anyChanges = true;
                    }
                    Console.WriteLine($"{translations.Item1}, {translations.Item2}, {controlName}, {translationValue}");
                }
            }
            return anyChanges;
        }
    }
}
