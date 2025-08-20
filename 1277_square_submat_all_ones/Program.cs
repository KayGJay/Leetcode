Console.WriteLine(new Solution().CountSquares([[1, 0, 1], [1, 1, 0], [1, 1, 0]]));

public class Solution
{
    public int CountSquares(int[][] matrix)
    {
        int result = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (i == 0 || j == 0)
                {
                    result += matrix[i][j];
                }
                else
                {
                    if (matrix[i][j] == 1)
                    { 
                        matrix[i][j] = Math.Min(Math.Min(matrix[i][j - 1], matrix[i - 1][j]), matrix[i - 1][j - 1]) + 1;
                        result += matrix[i][j];
                    }
                }
            }
        }
        return result;
    }
}