foreach (int i in new Solution().FindDiagonalOrder([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16]])) Console.WriteLine(i);

public class Solution
{
    public int[] FindDiagonalOrder(int[][] mat)
    {
        Dictionary<int, List<int>> idxSums = new Dictionary<int, List<int>>();
        int[] result = new int[mat.Length * mat[0].Length];
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (!idxSums.ContainsKey(i + j))
                {
                    idxSums[i + j] = new List<int>();
                }
                idxSums[i + j].Add(mat[i][j]);
            }
        }
        foreach (var pair in idxSums) 
        {
            Console.Write(pair.Key + ": ");
            foreach (int i in pair.Value)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        int resultIdx = 0;
        foreach (int i in idxSums.Keys)
        {
            if (i % 2 == 0)
            {
                for (int j = idxSums[i].Count - 1; j >= 0; j--)
                {
                    result[resultIdx++] = idxSums[i][j];
                }
            }
            else
            {
                for (int j = 0; j < idxSums[i].Count; j++)
                {
                    result[resultIdx++] = idxSums[i][j];
                }
            }
        }
        return result;
    }
}