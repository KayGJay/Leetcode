Console.WriteLine(new Solution().MaximalSquare([['1','0','1','0','0'], ['1','0','1','1','1'], ['1','1','1','1','1'], ['1','0','0','1','0']]));

public class Solution
{
    public int MaximalSquare(char[][] matrix)
    {
        int[][] intMatrix = new int[matrix.Length][];
        int result = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            intMatrix[i] = new int[matrix[i].Length];
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == '1')
                {
                    if (i == 0 || j == 0)
                    {
                        intMatrix[i][j] = 1;
                        result = Math.Max(1, result);
                    }
                    else
                    {
                        intMatrix[i][j] = Math.Min(Math.Min(intMatrix[i - 1][j - 1], intMatrix[i][j - 1]), intMatrix[i - 1][j]) + 1;
                        result = Math.Max(intMatrix[i][j] * intMatrix[i][j], result);
                    }
                }
            }
        }
        return result;
    }
}