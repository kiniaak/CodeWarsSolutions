using System.Collections.Generic;

namespace FakeBinary
{
   public class Kata
    {
        public static string FakeBin(string x)
        {

            char[] dig = x.ToCharArray();
            List<char> columns = new List<char>(x.Length);

            for (int i = 0; i < x.Length; i++)
            {
                if (dig[i] < '5')
                {
                    columns.Add((char)('0'));
                }
                else if (dig[i] >= '5')
                {
                    columns.Add((char)('1'));
                }
            }
            var myString = string.Join("", columns);
            return myString;

        }
    }
}
