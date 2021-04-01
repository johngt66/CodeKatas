using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JT.CodeKataClasses.Test
{
    [TestClass]
    public class TheElderTests
    {
        [DataTestMethod]
        // [DataRow(5, 8, 5, 1, 100)]
        // [DataRow(224, 8, 8, 0, 100007)]
        // [DataRow(11925, 25, 31, 0, 100007)]
        // [DataRow(4323, 5, 45, 3, 1000007)]
        // [DataRow(1586, 31, 39, 7, 2345)]
        // [DataRow(808451, 545, 435, 342, 1000007)]
        // You need to run this test very quickly before attempting the actual tests :)
         [DataRow(5456283, 28827050410, 35165045587, 7109602, 13719506)]
        public void ElderAge_ReturnsSum(long expected, long n, long m, long k, long newp)
        {
            var actual = TheElder.ElderAge(n,m,k,newp);
            Assert.AreEqual(expected, actual, $" R:{n}, C:{m}");
        }
    }
}
