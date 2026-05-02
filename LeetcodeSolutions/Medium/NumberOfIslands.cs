namespace LeetcodeSolutions.Medium;

public class NumberOfIslands
{
    [Fact]
    public void Test1()
    {
    }

    //O(n × m) O(n × m)
    public int NumIslandsDFS(char[][] grid)
    {
        var count = 0;

        var I = '1';
        var W = '0';

        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == I)
                {
                    count++;
                    DFS(grid, i, j);
                }
            }

        void DFS(char[][] grid, int row, int col)
        {
            if (row < 0 || row > grid.Length - 1 || col < 0 || col > grid[0].Length - 1 || grid[row][col] == W)
                return;

            grid[row][col] = W;

            DFS(grid, row + 1, col);
            DFS(grid, row - 1, col);
            DFS(grid, row, col + 1);
            DFS(grid, row, col - 1);
        }

        return count;
    }

    //O(n × m) O(n × m)
    public int NumIslandsBSF(char[][] grid)
    {
        var count = 0;

        var I = '1';
        var W = '0';

        var q = new Queue<(int, int)>();

        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == I)
                {
                    count++;

                    q.Enqueue((i, j));

                    while (q.Count > 0)
                    {
                        var (row, col) = q.Dequeue();

                        if (row < 0 || row > grid.Length - 1 || col < 0 || col > grid[0].Length - 1 || grid[row][col] == W)
                            continue;

                        grid[row][col] = W;

                        q.Enqueue((row + 1, col));
                        q.Enqueue((row - 1, col));
                        q.Enqueue((row, col + 1));
                        q.Enqueue((row, col - 1));
                    }
                }
            }

        return count;
    }
}
