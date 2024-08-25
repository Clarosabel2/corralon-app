using BDE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVC
{
    public class SessionManager
    {
        public BE_Usuario usuario { get; set; }
        
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
        public static void Login(BE_Usuario usuario) {
            if (_session == null)
            {
                _session = new SessionManager();
                _session.usuario = usuario;
            }
            else { throw new Exception("Sesion no iniciada"); }
        }
        public static void Logout() { if (_session != null) _session = null; else throw new Exception("Session Iniciada"); }

    }
}
