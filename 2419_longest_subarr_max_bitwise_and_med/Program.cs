Console.WriteLine(new Solution().LongestSubarray([3, 3, 3]));

public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        int max = nums.Max();
        int result = 1;
        int tempLen = 1;
        for (int i = 1; i < nums.Length; i++)
        { 
            if (nums[i] == max && nums[i - 1] == max)
            {
                tempLen++;
            }
            else
            {
                result = Math.Max(result, tempLen);
                tempLen = 1;
            }
        }
        result = Math.Max(result, tempLen);
        return result;
    }
}