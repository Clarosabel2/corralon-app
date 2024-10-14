using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_Language
    {
        public static List<string> GetLanguages() {
            return DAL_Language.GetLanguages();
        }
    }
}
