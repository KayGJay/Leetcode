//Not solved, unsure how to tell if zero is original or altered

int[][] testMatrix = [[1, 1, 1], [1, 0, 1], [1, 1, 1]];
new Solution().SetZeroes(testMatrix);
foreach (int[] arr in testMatrix)
{
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    if (matrix[0][j] != 0)
                    {
                        int i2 = 0;
                        while (i2 < matrix[i].Length)
                        {
                            matrix[i2][j] = 0;
                            i2++;
                        }
                    }
                    if (matrix[i][0] != 0)
                    {
                        int j2 = 0;
                        while (j2 < matrix[i].Length)
                        {
                            matrix[i][j2] = 0;
                            j2++;
                        }
                    }
                    break;
                }
            }
        }
    }
}