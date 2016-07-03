namespace Algorithms.Recursion
{
    public class RatInAMaze
    {
        /// <summary>
        /// Gets or sets the <see cref="System.String"/> with the specified [ERROR: invalid expression Parameters.First.Name.Words.All].
        /// </summary>
        /// <value>
        /// The <see cref="System.String"/>.
        /// </value>
        /// <returns></returns>
        public int[,] SolveRatInAMaze(int[,] maze)
        {
            return SolveMaze(maze);
        }

        private static bool IsSafe(int[,] maze, int x, int y)
        {
            return x >= 0 && x < maze.GetLength(0) && y >= 0 && y < maze.GetLength(1) && maze[x, y] == 1;
        }

        private int[,] SolveMaze(int[,] maze)
        {
            int[,] sol = new int[maze.GetLength(0), maze.GetLength(1)];

            SolveMazeUntil(maze, 0, 0, sol);

            return sol;
        }

        private bool SolveMazeUntil(int[,] maze, int x, int y, int[,] sol)
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
