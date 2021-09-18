namespace Watermelon
{
    public class Kata
    {
        public static bool Divide(int weight)
        {
            if ((weight % 2 == 0) && (weight > 2))
                return true;

            else
                return false;
        }
    }
}
