Console.WriteLine(new Solution().ThreeSumClosest([-4, -1, 1, 2], 1));

public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        int result = 0;
        result += (nums[0] + nums[1] + nums[2]);
        int i = 3;
        while (result < target && i < nums.Length)
        {
            int newResult = result - nums[i - 3] + nums[i];
            if (newResult < target)
            {
                result = newResult;
            }
            else
            {
                result = Math.Abs(target - result) < Math.Abs(target - newResult) ? result : newResult;
                break;
            }
        }
        return result;
    }
}