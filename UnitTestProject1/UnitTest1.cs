using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RAB2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void TestMethod1() 
            {
                Assert.AreEqual(Math.Round(Math.Sin(60 * Math.PI / 180), 4), Math.Round(RAB2.funks.funks.Sin(60 * Math.PI / 180), 4));
            }

            [TestMethod]
            public void TestMethod2() 
            {
                Assert.AreEqual(Math.Round(Math.Cos(60 * Math.PI / 180), 4), Math.Round(RAB2.funks.funks.Cos(60 * Math.PI / 180), 4));
            }

            [TestMethod]
            public void TestMethod3() 
            {
                Assert.AreEqual(Math.Abs(-90), RAB2.funks.funks.Abs(-90));
            }

            [TestMethod]
            public void TestMethod4() 
            {
                Assert.AreEqual(Math.Pow(5, 2), RAB2.funks.funks.Power(5, 2));
            }

            [TestMethod]
            public void TestMethod5() 
            {
                Assert.AreEqual(Math.Round(Math.Tan(60 * Math.PI / 180), 4), Math.Round(RAB2.funks.funks.Tan(60 * Math.PI / 180), 4));
            }

            [TestMethod]
            public void TestMethod6() 
            {
                Assert.AreEqual(Math.Round(1 / Math.Tan(60 * Math.PI / 180), 4), Math.Round(RAB2.funks.funks.Ctan(60 * Math.PI / 180), 4));
            }

            [TestMethod]
            public void TestMethod7() 
            {
                Assert.AreEqual(120, RAB2.funks.funks.Factorial(5));
            }

            [TestMethod]
            public void TestMethod8() 
            {
                Assert.AreEqual(Math.Round(1 / Math.Cos(60 * Math.PI / 180), 4), Math.Round(RAB2.funks.funks.sec(60 * Math.PI / 180), 4));
            }
    }
}
