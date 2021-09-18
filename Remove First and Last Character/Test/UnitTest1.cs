using NUnit.Framework;
using Remove_First_and_Last_Character;

namespace Test
{
    public class Tests
    {


        [TestFixture]
        public class Test
        {
            [Test]
            public void Test1()
            {
                StringAssert.AreEqualIgnoringCase("loquen", Kata.Remove_char("eloquent"));
                StringAssert.AreEqualIgnoringCase("ountr", Kata.Remove_char("country"));
                StringAssert.AreEqualIgnoringCase("erso", Kata.Remove_char("person"));
                StringAssert.AreEqualIgnoringCase("lac", Kata.Remove_char("place"));
                StringAssert.AreEqualIgnoringCase("", Kata.Remove_char("ok"));
            }
        }
    }
}