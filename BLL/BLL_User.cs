﻿using BDE;
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

        public static bool CreateUser(BE_User newUser)
        {
            newUser.Password = EncodeManager.HashValue(newUser.Password);
            return DAL_User.CreateUser(newUser);
        }

        public static bool ExistUserById(int id)
        {
            return DAL_User.ExistUser(id);
        }

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
