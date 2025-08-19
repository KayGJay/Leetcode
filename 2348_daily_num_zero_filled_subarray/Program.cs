public class Solution
{
    public long ZeroFilledSubarray(int[] nums)
    {
        long result = 0;
        long numZeroes = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                numZeroes++;
            }
            else
            {
                if (numZeroes != 0)
                {
                    result += (numZeroes * (numZeroes + 1)) / 2;
                }
                numZeroes = 0;
            }
        }
        result += numZeroes == 0 ? 0 : (numZeroes * (numZeroes + 1)) / 2;
        return result;
    }
}