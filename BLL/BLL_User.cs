using BDE;
using BDE.Language;
using DAL;
using SVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_User
    {
        public static void BlockUser(string username)
        {
            DAL_User.BlockUser(username);
        }

        public static void ChangeLanguageUser(BE_Language language)
        {
            SessionManager.GetInstance.user.Language = language;
            DAL_User.ChangeLanguageUser(language);
        }

        public static DataTable GetAllUser()
        {
            return DAL_User.GetAllUsers();
        }

        public static DataTable GetUsersByProfile()
        {
            return DAL_User.GetUserByProfile();
        }

        public static bool UpdateUserData(BE_User user)
        {
            return DAL_User.UpdateUserData(user);
        }

        public static void UpdateUserPassword(string password)
        {
            DAL_User.UpdateUserPasswordById(EncodeManager.HashValue(password));
        }

        public static bool ValidUser(string username, string password)
        {
            return DAL_User.ValidUser(username, password);
        }
    }
}
