
new Solution().SetZeroes([[0, 1, 2, 0], [3, 4, 5, 2], [1, 3, 1, 5]]);
public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        HashSet<int> rows = new HashSet<int>();
        HashSet<int> columns = new HashSet<int>();
        int rowLen = matrix.Length;
        int colLen = matrix[0].Length;
        for (int i = 0; i < rowLen; i++)
        {
            for (int j = 0; j < colLen; j++)
            {
                if (matrix[i][j] == 0)
                {
                    rows.Add(i);
                    columns.Add(j);
                }
            }
        }
        foreach (var row in rows)
        {
            for (int j = 0; j < colLen; j++)
            {
                matrix[row][j] = 0;
            }
        }
        foreach (var column in columns)
        {
            for (int i = 0; i < rowLen; i++)
            {
                matrix[i][column] = 0;
            }
        }
        foreach (var arr in matrix)
        {
            foreach (int j in arr)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}