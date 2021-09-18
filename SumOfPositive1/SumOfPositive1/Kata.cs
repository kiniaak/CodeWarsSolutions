using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPositive1
{
   public class Kata
    {
        public static int PositiveSum(int[] arr) => arr.Where(x => x > 0).Sum();
    }
}
