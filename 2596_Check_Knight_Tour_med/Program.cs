if (new Solution().CheckValidGrid([[0,  11, 16, 5,    20],
                               [17, 4,  19, 10,   15],
                               [12, 1,  8,  21,    6],
                               [3,  18, 23, 14,    9],
                               [24, 13, 2,  7,    22]])) Console.WriteLine("True");
else Console.WriteLine("False");

public class Solution
{
    //Clockwise possible directions starting by going up two, right one
    public int[][] Directions = [[-2, 1], [-1, 2], [1, 2], [2, 1], [2, -1], [1, -2], [-1, -2], [-2, -1]];
    public bool CheckValidGrid(int[][] grid)
    {
        int i = 0, j = 0;
        while (grid[i][j] < grid.Length * grid.Length - 1)
        {
            bool found = false;
            foreach (var arr in Directions)
            {
                int iCandidate = i + arr[0];
                int jCandidate = j + arr[1];
                if (iCandidate < grid.Length && iCandidate >= 0 &&
                    jCandidate < grid.Length && jCandidate >= 0)
                {
                    if (grid[iCandidate][jCandidate] == grid[i][j] + 1)
                    {
                        i = iCandidate;
                        j = jCandidate;
                        found = true;
                        break;
                    }
                }
            }
            if (!found)
                return false;
        }
        return true;
    }
}