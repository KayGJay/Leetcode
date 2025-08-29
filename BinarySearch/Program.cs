new Solution().Search([-1, 0, 3, 5, 9, 12], 9);

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1, mid = right / 2;
        while (left < right)
        {
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
                right = mid;
            }
            else
            {
                left = mid;
            }
            mid = (right + left) / 2;
        }
        return nums[mid] == target ? mid : -1;
    }
}