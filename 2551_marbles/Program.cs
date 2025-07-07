Solution sol = new Solution();

Console.WriteLine(sol.PutMarbles([1, 4, 2, 5, 2], 3));

public class Solution
{
    public long PutMarbles(int[] weights, int k)
    {
        if (weights.Length == k)
        {
            return 0;
        }
        long score = weights[0] + weights[weights.Length - 1];
        long[] costOfIdx = new long[weights.Length - 1];
        for (int i = 0; i < costOfIdx.Length; i++)
        {
            costOfIdx[i] = weights[i] + weights[i + 1];
        }
        Array.Sort(costOfIdx);
        long maxScore = score;
        long minScore = score;
        int idx = 0;
        int j = costOfIdx.Length - 1;
        while (idx < k - 1)
        {
            minScore += costOfIdx[idx];
            maxScore += costOfIdx[j];
            idx++;
            j--;
        }
        return maxScore - minScore;
    }
}