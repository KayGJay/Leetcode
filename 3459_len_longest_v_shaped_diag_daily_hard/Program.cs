Console.WriteLine(new Solution().LenOfVDiagonal([[1]]));

public class Solution
{
    //Down-Right, Down-Left, Up-Left, Up-Right
    int[][] Direction = [[1, 1], [1, -1], [-1, -1], [-1, 1]];
    public int LenOfVDiagonal(int[][] grid)
    {
        int result = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    result = result == 0 ? 1 : result;
                    int downRight = LongestV(i + 1, j + 1, 1, grid, 0, false);
                    int downLeft = LongestV(i + 1, j - 1, 1, grid, 1, false);
                    int upLeft = LongestV(i - 1, j - 1, 1, grid, 2, false);
                    int upRight = LongestV(i - 1, j + 1, 1, grid, 3, false);
                    int max = Math.Max(downRight, downLeft);
                    max = Math.Max(max, upLeft);
                    max = Math.Max(max, upRight);
                    result = Math.Max(1 + max, result);
                }
            }
        }
        return result;
    }

    public int LongestV(int i, int j, int preVal, int[][] grid, int dir, bool switched)
    {
        int goStraight = 0;
        int turn = 0;
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length) return 0;
        if ((preVal == 1 && grid[i][j] != 2) || (preVal == 2 && grid[i][j] != 0) || (preVal == 0 && grid[i][j] != 2))
        {
            return 0;
        }
        else
        {
            int newDir = (dir + 1) % 4;
            goStraight = LongestV(i + Direction[dir][0], j + Direction[dir][1], grid[i][j], grid, dir, switched);
            turn = switched ? 0 : LongestV(i + Direction[newDir][0], j + Direction[newDir][1], grid[i][j], grid, newDir, true);
            return 1 + Math.Max(goStraight, turn);
        }
    }
}