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
            DAL_Language.LoadTraductions();
        }

        public static void SetDefaultLanguage(string selectedItem)
        {
            DAL_Language.SetDefaultLanguage(selectedItem);
        }

        public static bool UpdateTranslations(Tuple<string, string, DataTable> translations)
        {
            
            if (DAL_Language.UpdateTranslations(translations))
            {
                LoadTranslations();
                LanguageManager.CurrentLanguage = SessionManager.translations.FirstOrDefault(i => i.Key.Name == SessionManager.GetInstance.user.Language.Name).Key;
                return true;
            }
            return false;
        }
    }
}
