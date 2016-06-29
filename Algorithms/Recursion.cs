using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Recursion
    {
        public static IEnumerable<string> PrintAllPermutationsOfString(string input)
        {
            return Permutate(input.ToArray(), 0, input.Length - 1);
        }

        private static IEnumerable<string> Permutate(char[] input, int startIndex, int endIndex)
        {
            if (startIndex == endIndex) {
                yield return string.Concat(input);
            } else {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    var hold = input[startIndex];
                    input[startIndex] = input[i];
                    input[i] = hold;
                    foreach (var item in Permutate(input, startIndex + 1, endIndex))
                    {
                        yield return item;
                    }
                    hold = input[i];
                    input[i] = input[startIndex];
                    input[startIndex] = hold;
                }
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="System.String"/> with the specified [ERROR: invalid expression Parameters.First.Name.Words.All].
        /// 
        /// /*
        ///          Following is the solution matrix(output of program) for the above input matrx.
        ///         
        ///                  {1, 0, 0, 0}
        ///                  {1, 1, 0, 0}
        ///                  {0, 1, 0, 0}
        ///                  {0, 1, 1, 1}
        ///   All enteries in solution path are marked as 1.
        ///  Naive Algorithm
        ///  The Naive Algorithm is to generate all paths from source to destination and one by one check if the generated path satisfies the constraints.
        ///  
        ///  while there are untried paths
        ///  {
        ///              generate the next path
        ///     if this path has all blocks as 1
        ///     {
        ///                  print this path;
        ///              }
        ///          }
        ///          Backtrackng Algorithm
        ///  
        ///  If destination is reached
        ///      print the solution matrix
        ///  Else
        ///     a) Mark current cell in solution matrix as 1. 
        ///     b) Move forward in horizontal direction and recursively check if this 
        ///         move leads to a solution.
        ///     c) If the move chosen in the above step doesn't lead to a solution
        ///         then move down and check if  this move leads to a solution.
        ///     d) If none of the above solutions work then unmark this cell as 0 
        ///         (BACKTRACK) and return false.
        /// */
        /// </summary>
        /// <value>
        /// The <see cref="System.String"/>.
        /// </value>
        /// <returns></returns>
        public static int[,] RateInAMaze(int[,] maze)
        {
            return SolveMaze(maze);
        }

        private static bool IsSafe(int[,] maze, int x, int y)
        {
            return x >= 0 && x < maze.GetLength(0) && y >= 0 && y < maze.GetLength(1) && maze[x, y] == 1;
        }

        private static int[,] SolveMaze(int[,] maze)
        {
            int[,] sol = new int[maze.GetLength(0), maze.GetLength(1)];

            SolveMazeUntil(maze, 0, 0, sol);

            return sol;
        }

        private static bool SolveMazeUntil(int[,] maze, int x, int y, int[,] sol)
        {
            // if (x,y is goal) return true
            if (x == maze.GetLength(0) - 1 && y == maze.GetLength(1) - 1)
            {
                sol[x, y] = 1;
                return true;
            }

            // Check if maze[x, y] is valid
            if (IsSafe(maze, x, y))
            {
                // mark x,y as part of solution path
                sol[x, y] = 1;

                /* Move forward in x direction */
                if (SolveMazeUntil(maze, x + 1, y, sol)) return true;

                /* If moving in x direction doesn't give solution then  Move down in y direction */
                if (SolveMazeUntil(maze, x, y + 1, sol)) return true;

                /* If none of the above movements work then BACKTRACK: unmark x,y as part of solution path */
                sol[x, y] = 0;
                return false;
            }

            return false;
        }
    }
}
