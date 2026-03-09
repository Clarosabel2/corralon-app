using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE.Language
{
    public class Language
    {
        public string Name { get; set; }
        public string LanguageCode { get; set; }
        public bool IsDefault { get; set; }

        public Language() { }

        public Language(string name, string languageCode, bool isDefault)
        {
            Name = name;
            LanguageCode = languageCode;
            IsDefault = isDefault;
        }
    }
}
