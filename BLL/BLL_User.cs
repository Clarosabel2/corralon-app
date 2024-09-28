﻿using DAL;
using System;
using System.Collections.Generic;
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

        public static bool ValidUser(string username, string password)
        {
            return DAL_User.ValidUser(username, password);
        }
    }
}
