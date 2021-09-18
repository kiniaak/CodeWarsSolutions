using Jenny_s_secret_message;
using NUnit.Framework;

namespace JennysGreeting
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public static void ShouldGreetJaneNormally()
        {
            Assert.AreEqual("Hello, Jane!", Kata.greet("Jane"));
        }
        [Test]
        public static void ShouldGreetSimonNormally()
        {
            Assert.AreEqual("Hello, Simon!", Kata.greet("Simon"));
        }

        [Test]
        public static void ShouldGreetJohnnySpecially()
        {
            Assert.AreEqual("Hello, my love!", Kata.greet("Johnny"));
        }
    }
}