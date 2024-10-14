using BDE.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVC.LanguageManager
{
    public static class LanguageManager
    {
        private static List<IObserver> observers = new List<IObserver>();
        private static string currentLanguage;

        public static string CurrentLanguage
        {
            get => currentLanguage;
            set
            {
                currentLanguage = value;
                NotifyObservers();
            }
        }

        public static void Attach(IObserver ob)
        {
            observers.Add(ob);
        }

        public static void Detach(IObserver ob)
        {
            observers.Remove(ob);
        }

        public static void NotifyObservers()
        {
            observers.ForEach(o => o.Update(currentLanguage));
        }
    }
}
