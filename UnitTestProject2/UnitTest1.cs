using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RAB2;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodLn() 
        {
            int x = 0;
            Assert.AreEqual(Math.Round(Math.Log(1 - x), 0), Math.Round(RAB2.funks.funks.Ln(x), 0));
        }
    }
}
