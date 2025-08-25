public class Solution
{
    public int MinimumArea(int[][] grid)
    {
        int recIMin = Int32.MaxValue, recJMin = Int32.MaxValue;
        int recIMax = 0, recJMax = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    recIMin = Math.Min(recIMin, i);
                    recJMin = Math.Min(recJMin, j);
                    recIMax = Math.Max(recIMax, i);
                    recJMax = Math.Max(recJMax, j);
                }
            }
        }
        return (recIMax - recIMin + 1) * (recJMax - recJMin + 1);
    }
}