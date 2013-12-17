using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassManagementSystem.UserInfo
{
    class User
    {
        private static string user_name = null;

        public static string UserName
        {
            get
            {
                return User.user_name;
            }
            set
            {
                User.user_name = value;
            }
        }

        private static string pass_word = null;

        public static string PassWord
        {
            get
            {
                return User.pass_word;
            }
            set
            {
                User.pass_word = value;
            }
        }

        private static bool is_admin = false;

        public static bool IsAdmin
        {
            get
            {
                return User.is_admin;
            }
            set
            {
                User.is_admin = value;
            }
        }
    }
}
