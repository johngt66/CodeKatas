using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JT.CodeKataClasses.Test
{
    [TestClass]
    public class CarMileageTests
    {
        [DataTestMethod]
        [DataRow(12344321)]
        [DataRow(123454321)]
        [DataRow(1234)]
        [DataRow(43210)]
        [DataRow(67890)]
        [DataRow(44444)]
        [DataRow(40000)]
        [DataRow(100)]
        public void IsInteresting_OnInterestingReturns2(int num)
        {
            var expected = 2;
            var actual = CarMileage.IsInteresting(num, new List<int>());
            Assert.AreEqual(expected, actual, $"{num}");
        }
        [DataTestMethod]
        [DataRow(12344321)]
        [DataRow(123454321)]
        [DataRow(1234)]
        [DataRow(43210)]
        [DataRow(67890)]
        [DataRow(44444)]
        [DataRow(40000)]
        [DataRow(100)]
        public void IsInteresting_OnInterestingMinus1Returns1(int num)
        {
            num -= 1;
            var expected = 1;
            var actual = CarMileage.IsInteresting(num, new List<int>());
            Assert.AreEqual(expected, actual, $"{num}");
        }
        [DataTestMethod]
        [DataRow(12344321)]
        [DataRow(123454321)]
        [DataRow(1234)]
        [DataRow(43210)]
        [DataRow(67890)]
        [DataRow(44444)]
        [DataRow(40000)]
        [DataRow(100)]
        public void IsInteresting_OnInterestingMinus2Returns1(int num)
        {
            num -= 2;
            var expected = 1;
            var actual = CarMileage.IsInteresting(num, new List<int>());
            Assert.AreEqual(expected, actual, $"{num}");
        }

        [DataTestMethod]
        [DataRow(12344321)]
        [DataRow(123454321)]
        [DataRow(1234)]
        [DataRow(43210)]
        [DataRow(67890)]
        [DataRow(44444)]
        [DataRow(40000)]
        public void IsInteresting_OnNotInterestingReturns0(int num)
        {
            num -= 3;
            var expected = 0;
            var actual = CarMileage.IsInteresting(num, new List<int>());
            Assert.AreEqual(expected, actual, $"{num}");
        }
        [DataTestMethod]
        [DataRow(0, 2)]
        [DataRow(1, 1)]
        [DataRow(2, 1)]
        [DataRow(3, 0)]
        public void IsInteresting_OnListMatchReturns2(int dec, int expected)
        {
            var num = 23409 - dec;
            var list = new List<int> { 2344, 234243, 13123, 23409, 292929, 098098 };
            var actual = CarMileage.IsInteresting(num, list);
            Assert.AreEqual(expected, actual, $"{num}");
        }
    }
}
