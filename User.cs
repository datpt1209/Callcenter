using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSystem.Security.Cryptography;

namespace WinFormsApp2
{
    public class User
    {
        public string id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public string phone { get; set; }

        private static string error;

        public static bool IsEqual(User user1, User user2)
        {
            if(user1 == null || user2 == null)
            {
                return false;
            }
            if (user1.username != user2.username)
            {
                error = "User not exist !";
                return false;
            }
            else if(user1.password != user2.password)
            {
                error = "Password Front";
                return false;

            }
            return true;
            

        }

    }
}
