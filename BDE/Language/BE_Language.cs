using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE.Language
{
    public class BE_Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string, Dictionary<string, string>> Traductions { get; set; }
    }
}
