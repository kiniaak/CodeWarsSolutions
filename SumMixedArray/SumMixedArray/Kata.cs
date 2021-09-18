using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMixedArray
{
    public class Kata
    {
        public static int SumMix(object[] x)
        {
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += Convert.ToInt32(x[i]);
            }
            return sum;
        }
    }
}
