using BDE;
using BDE.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVC
{
    public class SessionManager
    {
        public BE_User user { get; set; }
        public static Dictionary<BE_Language, Dictionary<string, Dictionary<string, string>>> translations { get; set; }

        private static SessionManager _session = null;
        protected SessionManager() { }
        public static SessionManager GetInstance
        {
            get
            {
                if (_session == null) _session = new SessionManager();
                return _session;
            }
        }
        public static void Login(BE_User user) {
            if (_session == null)
            {
                _session = new SessionManager();
                _session.user = user;
            }
            else { throw new Exception("Sesion no iniciada"); }
        }
        public static void Logout() { 
            if (_session != null) _session = null; else throw new Exception("Session Iniciada");
        }
    }
}
