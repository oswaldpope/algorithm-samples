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
    public class RecursionTests
    {
        [TestMethod()]
        public void PrintAllPermutationsOfStringTest()
        {
            Assert.AreEqual(6, Recursion.PrintAllPermutationsOfString("ABC").Count());
        }

        [TestMethod()]
        public void RateInAMazeTest()
        {
            int[,] maze = new[,] { { 1, 0, 0, 0 }, { 1, 1, 0, 1 }, { 0, 1, 0, 0 }, { 1, 1, 1, 1 } };
            var sol = Recursion.RateInAMaze(maze);
            Assert.Fail();
        }
    }
}