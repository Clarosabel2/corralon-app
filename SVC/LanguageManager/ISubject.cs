using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVC.LanguageManager
{
    internal interface ISubject
    {
        void Attach(IObserver ob);
        void Detach(IObserver ob);
        void NotifyObservers();
    }
}
