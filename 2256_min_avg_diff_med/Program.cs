Solution sol = new Solution();

sol.MinimumAverageDifference([2, 5, 3, 9, 5, 3]);

public class Solution
{
    public int MinimumAverageDifference(int[] nums)
    {
        long leftSum = 0, rightSum = nums.Sum(), minAvgDiff = -1, avgDiff = 0;
        int minIdx = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            leftSum += nums[i];
            rightSum -= nums[i];
            Console.WriteLine($"i + 1: {i + 1}, n - i - 1: {nums.Length - i - 1}, leftSum: {leftSum}, rightSum: {rightSum}");
            if (i < nums.Length - 1)
            {
                avgDiff = Math.Abs((leftSum / (i + 1)) - (rightSum / (nums.Length - i - 1)));
            }
            else
            {
                avgDiff = leftSum / (i + 1);
            }
            if (avgDiff == 0)
            {
                return i;
            }
            if (avgDiff < minAvgDiff || minAvgDiff == -1)
            {
                minAvgDiff = avgDiff;
                minIdx = i;
            }
        }
        return minIdx;
    }
}