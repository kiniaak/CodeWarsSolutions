using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleOfIndex
{
    public class Kata
    {
        public static List<int> MultipleOfIndex(List<int> xs)
        {
            var list = new List<int>();
            for (int i = 1; i < xs.Count(); i++)
            {
                if (xs[i] % i == 0)
                {

                    list.Add(xs[i]);
                }


            }
            return list;

        }
    }
}
