Console.WriteLine(new Solution().CountPairs([3, 1, 2, 2, 2, 1, 3], 2));

public class Solution
{
    public int CountPairs(int[] nums, int k)
    {
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i * j % k == 0)
                    {
                        result++;
                    }
                }
            }
        }
        return result;
    }
}