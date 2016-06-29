using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{
    [TestClass()]
    public class GeneralTests
    {
        [TestMethod()]
        public void FibonacciTest()
        {
            var results = General.Fibonacci(20).ToArray();
            Assert.AreEqual("0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987", results);
        }

        [TestMethod()]
        public void IsFibonacciNumberTest()
        {
            Assert.IsTrue(General.IsFibonacciNumber(8));
        }
    }
}