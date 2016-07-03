using Algorithms.Recursion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Algorithms.Tests
{
    [TestClass()]
    public class RecursionTests
    {
        [TestMethod()]
        public void PrintAllPermutationsOfStringTest()
        {
            Assert.AreEqual(6, new StringPermutations().PrintAllPermutationsOfString("ABC").Count());
        }

        [TestMethod()]
        public void RateInAMazeTest()
        {
            int[,] maze = new[,] { { 1, 0, 0, 0 }, { 1, 1, 0, 1 }, { 0, 1, 0, 0 }, { 1, 1, 1, 1 } };
            var sol = new RatInAMaze().SolveRatInAMaze(maze);
            int[] oneDimension = new int[sol.Length];
            var i = 0;
            foreach (var item in sol)
            {
                oneDimension[i++] = item;
            }
            Assert.AreEqual("1,0,0,0,1,1,0,0,0,1,0,0,0,1,1,1", String.Join(",", oneDimension));
        }
    }
}