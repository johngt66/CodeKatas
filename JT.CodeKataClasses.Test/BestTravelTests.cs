using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SumOfKTests
{

    [TestMethod]
    public void Test1()
    {
        Console.WriteLine("****** Basic Tests");
        List<int> ts = new List<int> { 50, 55, 56, 57, 58 };
        int? n = SumOfK.chooseBestSum(163, 3, ts);
        Assert.AreEqual(163, n);
    }
    [TestMethod]
    public void Test2()
    {
        List<int> ts = new List<int> { 50 };
        int? n = SumOfK.chooseBestSum(163, 3, ts);
        Assert.AreEqual(null, n);
    }
    [TestMethod]
    public void Test3()
    {
        List<int> ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
        int? n = SumOfK.chooseBestSum(230, 3, ts);
        Assert.AreEqual(228, n);
    }
    [TestMethod]
    public void test0()
    {
        List<int> ls = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        ls = ls.Select((x, i) => check(x, i)).ToList();
        Assert.AreEqual(0,0);
    }

    private int check(int x, int i)
    {
        Console.WriteLine(i);
        return x;
    }
}