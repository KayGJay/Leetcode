Solution sol = new Solution();

Console.WriteLine(sol.MinOperations([[2, 4], [6, 8]], 2));

public class Solution {
    public int MinOperations(int[][] grid, int x) {
        int n = grid.Length;
        int m = grid[0].Length;
        int operations = 0;
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
        for (int i = 0; i < flatGrid.Length; i++)
        {
            if (flatGrid[i] % x != median % x)
            {
                return -1;
            }
            while (flatGrid[i] != median)
            {
                if (flatGrid[i] < median)
                {
                    flatGrid[i] += x;
                    operations++;
                }
                else
                {
                    flatGrid[i] -= x;
                    operations++;
                }
            }
        }
        return operations;
    }
}