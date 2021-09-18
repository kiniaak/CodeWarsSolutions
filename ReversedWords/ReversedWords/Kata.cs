using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedWords
{
   public class Kata
    {
        public static string ReverseWords(string str)
        {
            return str = String.Join(" ", str.Split(' ').Reverse().ToArray());
        }
    }
}
