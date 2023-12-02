using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Utils
{
    public class HashHeper
    {
        public static string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool Verify(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}