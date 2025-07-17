public class Solution
{
    public int MaximumLength(int[] nums, int k)
    {
        int[][] remainders = new int[k][];
        for (int i = 0; i < k; i++)
        {
            remainders[i] = new int[k];
        }
        int result = 0;
        foreach (int num in nums)
        {
            for (int prev = 0; prev < k; prev++)
            {
                remainders[prev][num % k] = remainders[num % k][prev] + 1;
                result = Math.Max(result, remainders[prev][num % k]);
            }
        }
        return result;
    }
}