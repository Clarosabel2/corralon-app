using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_Language
    {
        public static List<string> GetLanguages()
        {
            return DAL_Language.GetLanguages()
                .Select(l => char.ToUpper(l[0]) + l.Substring(1).ToLower()).ToList();
        }
        public static Dictionary<string, string> GetTraductions(string frmName,string language) {
            return DAL_Language.GetTraductions(frmName,language.ToLower());
        }
    }
}
