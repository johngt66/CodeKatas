using Microsoft.VisualStudio.TestTools.UnitTesting;
using JT.NextNumber;

namespace JT.NextNumber.Test
{
    [TestClass]
    public class NextNumber_Test
    {
        [TestMethod]
        public void NextNumber_OnSuccessReturnsNextNumber()
        {
            long num = 513;
            long  expected = 531;
            long actual = Program.NextNumber(num);
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void NextNumber_Test2()
        {
            long num = 1234567890;
            long expected = 1234567908;
            long actual = Program.NextNumber(num);
            Assert.AreEqual(expected,actual);
        }
        
        [TestMethod]
        public void NextNumber_Test3()
        {
            long num = 59884848489553;
            long expected = 59884848483559;
            long other =    59884848493558;
            long actual = Program.NextNumber(num);
            Assert.AreEqual(expected,actual);
        }
    }
} 
