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
        [DataRow(5,5)]
        [DataRow(10,10)]
        [DataRow(20,20)]
        public void BuildMagicRectangle_ReturnsMatrix(int r, int c)
        {
            var actual = TheElder.BuildMagicRectangle(r,c);
            Assert.IsNotNull( actual, $" R:{r}, C:{c}");
        }
    }
}
