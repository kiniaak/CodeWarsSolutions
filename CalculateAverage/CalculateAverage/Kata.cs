using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAverage
{
    public class Kata
    {
        public static double FindAverage(double[] array)
        {
            if (array.Length == 0)
                return 0;

            else
                return array.Average();
        }
    }
}
