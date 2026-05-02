namespace LeetCodeTests.Easy;

public class FloodFill
{
    [Fact]
    public void Test1()
    {
    }

    //O(n × m) O(n × m)
    public int[][] FloodFillDFS(int[][] image, int sr, int sc, int color)
    {
        var orginalColor = image[sr][sc];

        if (orginalColor == color)
            return image;

        void DFS(int[][] image, int row, int col, int color, int newColor)
        {
            if (row < 0 || row > image.Length - 1 || col < 0 || col > image[0].Length - 1 || image[row][col] != color)
                return;

            image[row][col] = newColor;

            DFS(image, row - 1, col, color, newColor);
            DFS(image, row + 1, col, color, newColor);
            DFS(image, row, col - 1, color, newColor);
            DFS(image, row, col + 1, color, newColor);
        }

        DFS(image, sr, sc, orginalColor, color);

        return image;
    }

    //O(n × m) O(n × m)
    public int[][] FloodFillBFS(int[][] image, int sr, int sc, int color)
    {
        var originalColor = image[sr][sc];

        if (originalColor == color)
            return image;

        var queue = new Queue<(int, int)>();

        queue.Enqueue((sr, sc));

        while (queue.Count > 0)
        {
            var (row, col) = queue.Dequeue();

            if (row < 0 || row > image.Length - 1 || col < 0 || col > image[0].Length - 1 || image[row][col] != originalColor)
                continue;

            image[row][col] = color;

            queue.Enqueue((row - 1, col));
            queue.Enqueue((row + 1, col));
            queue.Enqueue((row, col - 1));
            queue.Enqueue((row, col + 1));
        }

        return image;
    }
}
