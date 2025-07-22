Console.WriteLine(new Solution().MaximumUniqueSubarray([5, 2, 1, 2, 5, 2, 1, 2, 5]));

public class Solution
{
    public int MaximumUniqueSubarray(int[] nums)
    {
        Dictionary<int, int> numOccurs = new Dictionary<int, int>();
        foreach (int i in nums) { numOccurs[i] = 0; }
        int result = 0;
        int l = 0, r = 0;
        int tempSum = 0;
        while (l < nums.Length && r < nums.Length)
        {
            while (r < nums.Length && numOccurs[nums[r]] == 0)
            {
                tempSum += nums[r];
                numOccurs[nums[r]]++;
                r++;
            }
            result = Math.Max(result, tempSum);
            while (r < nums.Length && nums[l] != nums[r])
            {
                numOccurs[nums[l]]--;
                tempSum -= nums[l];
                l++;
            }
            numOccurs[nums[l]]--;
            tempSum -= nums[l];
            l++;
            if (r < nums.Length)
            {
                numOccurs[nums[r]] = 0;
            }
        }
        return result;
    }
}