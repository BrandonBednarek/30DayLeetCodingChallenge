using System;

/* Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
 * You may assume all four edges of the grid are all surrounded by water.
 */

namespace Number_of_Islands
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] grid =
            {
                new char[] { '1', '1', '1', '1', '0' },
                new char[] { '1', '1', '0', '1', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' }
            };
            Console.WriteLine(NumIslands(grid));
        }

        public static int NumIslands(char[][] grid)
        {
            int count = 0;
            for (int x = 0; x < grid.Length; x++)
                for (int y = 0; y < grid[0].Length; y++)
                    if (grid[x][y] == '1')
                    {
                        count += 1;
                        DFS(grid, x, y);
                    }
            return count;
        }

        private static void DFS(char[][] grid, int x, int y)
        {
            if (x < 0 || x == grid.Length || y < 0 || y == grid[0].Length || grid[x][y] != '1')
                return;

            grid[x][y] = '0';
            DFS(grid, x + 1, y);
            DFS(grid, x - 1, y);
            DFS(grid, x, y + 1);
            DFS(grid, x, y - 1);
        }
    }
}
