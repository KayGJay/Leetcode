Console.WriteLine(new Solution().MinFlips([[1, 0, 0], [0, 0, 0], [0, 0, 1]]));

public class Solution
{
    public int MinFlips(int[][] grid)
    {
        int rowSum = 0, colSum = 0;
        int n = grid.Length;
        int m = grid[0].Length;
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (grid[i][j] != grid[n - 1 - i][j])
                    rowSum++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m / 2; j++)
            {
                if (grid[i][j] != grid[i][m - 1 - j])
                    colSum++;
            }
        }
        return Math.Min(colSum, rowSum);
    }
}