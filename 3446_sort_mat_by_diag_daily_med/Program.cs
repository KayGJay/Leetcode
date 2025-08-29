public class Solution
{
    public int[][] SortMatrix(int[][] grid)
    {
        int[][] result = new int[grid.Length][];
        int iOuter = grid.Length - 1;
        int jOuter = 0;
        while (iOuter >= 0 && jOuter < grid[0].Length)
        {
            List<int> tempList = new List<int>();
            int i = iOuter, j = jOuter;
            while (i >= 0 && i < grid.Length && j >= 0 && j < grid[i].Length)
            {
                tempList.Add(grid[i][j]);
                i++;
                j++;
            }
            if (iOuter >= 0 && jOuter == 0)
                tempList = tempList.OrderByDescending(x => x).ToList();
            else
                tempList = tempList.OrderBy(x => x).ToList();
            i = iOuter;
            j = jOuter;
            int tempIdx = 0;
            while (i >= 0 && i < grid.Length && j >= 0 && j < grid[i].Length)
            {
                grid[i][j] = tempList[tempIdx];
                tempIdx++;
                i++;
                j++;
            }
            if (iOuter > 0)
                iOuter--;
            else
                jOuter++;
        }
        return grid;
    }
}