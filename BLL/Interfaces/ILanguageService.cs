using BDE.Language;
using System.Collections.Generic;
using System.Data;
using System;

namespace BLL.Interfaces
{
    public interface ILanguageService
    {
        bool CreateLanguage(string userInput);
        List<Language> GetLanguages();
        void LoadTranslations();
        void SetDefaultLanguage(string selectedItem);
        bool UpdateTranslations(Tuple<string, string, DataTable> translations);
    }
}
