using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Algorithms.Tests
{
    [TestClass()]
    public class GeneralTests
    {
        [TestMethod()]
        public void FibonacciTest()
        {
            Assert.AreEqual("0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987", String.Join(",", General.Fibonacci(20).ToArray()));
        }

        [TestMethod()]
        public void IsFibonacciNumberTest()
        {
            Assert.IsTrue(General.IsFibonacciNumber(8));
            Assert.IsFalse(General.IsFibonacciNumber(7));
        }
    }
}