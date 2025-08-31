using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE.Language
{
    public class BE_Language
    {
        public string Name { get; set; }
        public string LanguageCode { get; set; }
        public bool IsDefault { get; set; }

        public BE_Language() { }

        public BE_Language(string name, string languageCode, bool isDefault)
        {
            Name = name;
            LanguageCode = languageCode;
            IsDefault = isDefault;
        }
    }
}
