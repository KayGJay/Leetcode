Solution sol = new Solution();

Console.WriteLine(sol.MinOperations([[2, 4], [6, 8]], 2));

public class Solution {
    public int MinOperations(int[][] grid, int x) {
        int n = grid.Length;
        int m = grid[0].Length;
        //int operations = 0;
        int[] flatGrid = new int[n * m];
        int flatIdx = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                flatGrid[flatIdx] = grid[i][j];
                flatIdx++;
            }
        }
        Array.Sort(flatGrid);
        int median = flatGrid[flatGrid.Length / 2];
        int diffSum = 0;
        foreach (int i in flatGrid)
        {
            if (i % x != median % x)
            {
                return -1;
            }
            diffSum += Math.Abs(median - i);
        }
        return diffSum / x;
    }
}