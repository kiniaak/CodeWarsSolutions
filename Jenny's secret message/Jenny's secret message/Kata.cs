using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenny_s_secret_message
{
    public static class Kata
    {
        public static string greet(string name)
        {
            if (name == "Johnny")
                return ("Hello, my love!");
            else
                return ("Hello, " + name + "!");

        }
    }
}
