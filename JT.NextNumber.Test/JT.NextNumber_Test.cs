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
            string num = "513";
            string expected = "531";
            string actual = Program.NextNumber(num);
            Assert.AreEqual(expected,actual);
        }
    }
} 
