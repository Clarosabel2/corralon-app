using BDE;
using BDE.Language;
using DAL;
using SVC;
using SVC.LanguageManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_User
    {
        public static List<BE_User> GetAllUser()
        {
            List<BE_User> users = new List<BE_User>();
            foreach (DataRow r in DAL_User.GetAllUsers().Rows)
            {
                users.Add(new BE_User
                {
                    Emp = new BE_Employee
                    {
                        Id = Convert.ToInt32(r[0]),
                        Dni = Convert.ToInt32(r[4].ToString()),
                        Email = r[1].ToString(),
                        Name = r[5].ToString(),
                        Lastname = r[6].ToString(),
                    },
                    Username = r[2].ToString(),
                    Rol = (BE_TypeUser)Enum.Parse(typeof(BE_TypeUser), r[7].ToString()),
                });
            }
            return users;
        }

        public static bool UpdateUserData(BE_User user)
        {
            if (DAL_User.UpdateUserData(user))
            {
                SessionManager.GetInstance.user.Emp.Name = user.Emp.Name;
                SessionManager.GetInstance.user.Emp.Lastname = user.Emp.Lastname;
                SessionManager.GetInstance.user.Emp.Email = user.Emp.Email;
                return true;
            }
            return false;
        }

        public static void UpdateUserPassword(string password)
        {
            string newPassword = EncodeManager.HashValue(password);
            if (DAL_User.UpdateUserPasswordByIdUser(newPassword, SessionManager.GetInstance.user.Emp.Id))
            {
                SessionManager.GetInstance.user.Password = newPassword;
            }
        }
        public static bool CreateUser(BE_User newUser)
        {
            newUser.Password = EncodeManager.HashValue(newUser.Password);
            return DAL_User.CreateUser(newUser);
        }
        public static void BlockUserByUsername(string username)
        {
            DAL_User.BlockUserByUsername(username);
        }

        public static void ChangeLanguageUser(BE_Language language)
        {
            SessionManager.GetInstance.user.Language = language;
            DAL_User.ChangeLanguageUser(language, SessionManager.GetInstance.user.Emp.Id);
        }

        public static bool ExistUserById(int id)
        {
            return DAL_User.ExistUser(id);
        }

        public static bool ValidUser(string username, string password)
        {
            BE_User userLogin = DAL_User.ValidUser(username, EncodeManager.HashValue(password));
            SessionManager.Login(userLogin);
            //LanguageManager.CurrentLanguage = userLogin.Language;
            SessionManager.GetInstance.user.Language = SessionManager.translations.FirstOrDefault(l => l.Key.Name == userLogin.Language.Name).Key;
            return true;
        }

        public static bool CheckStatusUser(int idUser)
        {
            if (DAL_User.CheckStatusUser(idUser))
            {
                return true;
            }
            return false;
        }

        public static bool BlockUserById(int id)
        {
            return DAL_User.BlockUserById(id);
        }

        public static bool UnlockUserById(int id)
        {
            return DAL_User.UnlockUserById(id);
        }
    }
}
