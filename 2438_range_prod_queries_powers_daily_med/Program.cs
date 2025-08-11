foreach (int i in new Solution().ProductQueries(15, [[0, 1], [2, 2], [0, 3]])) Console.WriteLine(i);

public class Solution
{
    public int MOD = (int)Math.Pow(10, 9) + 7;
    public int[] ProductQueries(int n, int[][] queries)
    {
        int highPow = (int)Math.Floor(Math.Log2(n));
        int[] result = new int[queries.Length];
        List<int> powers = new List<int>();
        while (n > 0)
        {
            powers.Insert(0, (int)Math.Pow(2, highPow));
            n -= powers[0];
            highPow = (int)Math.Floor(Math.Log2(n));
        }
        for (int i = 0; i < result.Length; i++)
        {
            int[] query = queries[i];
            long answer = 1;
            for (int j = query[0]; j <= query[1]; j++)
            {
                answer = (answer * powers[j]) % MOD;
            }
            result[i] = (int)answer;
        }
        return result;
    }
}