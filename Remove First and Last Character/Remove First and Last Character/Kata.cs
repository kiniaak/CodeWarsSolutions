using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_First_and_Last_Character
{
    public class Kata
    {
        public static string Remove_char(string s)
        {
            string result = null;
            return result = s.Substring(1, s.Length - 2);
        }
    }
}
