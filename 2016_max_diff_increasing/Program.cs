Solution sol = new Solution();

Console.WriteLine(sol.MaximumDifference([7, 1, 5, 4]));

public class Solution
{
    public int MaximumDifference(int[] nums)
    {
        int min = nums[0], maxDiff = -1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > min)
            {
                maxDiff = Math.Max(maxDiff, nums[i] - min);
            }
            else
            {
                min = nums[i];
            }
        }
        return maxDiff;
    }
}