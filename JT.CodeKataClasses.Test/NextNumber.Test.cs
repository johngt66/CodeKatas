using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JT.CodeKataClasses.Test
{
     [TestClass]
    public class NextBiggerNumber_Test
    {
        [TestMethod]
        public void NextBiggerNumber_OnSuccessReturnsNextBiggerNumber()
        {
            long num = 513;
            long  expected = 531;
            long actual = NextNumber.NextBiggerNumber(num);
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void NextBiggerNumber_Test2()
        {
            long num = 1234567890;
            long expected = 1234567908;
            long actual = NextNumber.NextBiggerNumber(num);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void NextBiggerNumber_Test3()
        {
            long num =      59884848459853;
            long expected = 59884848483559;
            long actual = NextNumber.NextBiggerNumber(num);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void NextBiggerNumber_Test4()
        {
            long num =      9876543210;
            long expected = -1;
            long actual = NextNumber.NextBiggerNumber(num);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void NextBiggerNumber_Test5()
        {
            long num =      1892771465;
            long expected = 1892771546;
            long actual = NextNumber.NextBiggerNumber(num);
            Assert.AreEqual(expected,actual);
        }
    }
}
