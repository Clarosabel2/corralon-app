using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVC.LanguageManager
{
    public interface IObserver
    {
        void Update(string language);
    }
}
