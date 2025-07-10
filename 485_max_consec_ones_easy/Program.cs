public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int ones = 0, maxOnes = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            ones = nums[i] == 1 ? ones + 1 : 0;
            if (ones > maxOnes)
            {
                maxOnes = ones;
            }
        }
        return maxOnes;
    }
}