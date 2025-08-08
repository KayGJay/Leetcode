Console.WriteLine(new Solution().CountHillValley([6, 5, 10]));

public class Solution
{
    public int CountHillValley(int[] nums)
    {
        int result = 0, left = 0, right = 1;
        while (left < nums.Length && right < nums.Length)
        {
            while (right != nums.Length - 1 && nums[right] == nums[right + 1])
            {
                right++;
            }
            if (right + 1 < nums.Length && ((nums[right + 1] > nums[right] && nums[left] > nums[right])
                || (nums[left] < nums[right] && nums[right + 1] < nums[right])))
            {
                result++;
                left = right;
                right = left + 1;
            }
            else
            {
                left++;
                right = left + 1;
            }
        }
        return result;
    }
}