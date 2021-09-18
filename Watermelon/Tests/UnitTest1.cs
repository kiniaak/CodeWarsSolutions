using NUnit.Framework;
using Watermelon;

namespace Tests
{
    public class Tests
    {


        [TestFixture]
        public class WaterMelonTest
        {
            [Test]
            public void Test1()
            {
                Assert.AreEqual(true, Kata.Divide(4));
            }

            [Test]
            public void Test2()
            {
                Assert.AreEqual(false, Kata.Divide(2));
            }

            [Test]
            public void Test3()
            {
                Assert.AreEqual(false, Kata.Divide(5));
            }

            [Test]
            public void Test4()
            {
                Assert.AreEqual(true, Kata.Divide(88));
            }

            [Test]
            public void Test5()
            {
                Assert.AreEqual(true, Kata.Divide(100));
            }

            [Test]
            public void Test6()
            {
                Assert.AreEqual(false, Kata.Divide(67));
            }

            [Test]
            public void Test7()
            {
                Assert.AreEqual(true, Kata.Divide(90));
            }

            [Test]
            public void Test8()
            {
                Assert.AreEqual(true, Kata.Divide(10));
            }

            [Test]
            public void Test9()
            {
                Assert.AreEqual(false, Kata.Divide(99));
            }

            [Test]
            public void Test10()
            {
                Assert.AreEqual(true, Kata.Divide(32));
            }
        }
    }
}