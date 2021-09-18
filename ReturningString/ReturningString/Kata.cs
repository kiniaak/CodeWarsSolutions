using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningString
{
    public class Kata
    {
        public static string Greet(string name)
        {
            if (name == null)
                throw new NotImplementedException("Greet is not implemented.");
           else return "Hello," + " " + name + " " + "how are you doing today?";
           
        }
    }
}
