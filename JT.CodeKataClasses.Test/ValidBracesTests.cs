using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JT.CodeKataClasses.Test
{
    [TestClass]
    public class ValidBracesTests
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(true, ValidBraces.validBraces("()"));
        }
        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(true, ValidBraces.validBraces("{()}"));
        }
        [TestMethod]
        public void Test2()
        {

            Assert.AreEqual(false, ValidBraces.validBraces("[(])"));
        }
    }
}