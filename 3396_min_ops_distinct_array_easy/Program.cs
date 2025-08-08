Console.WriteLine(new Solution().MinimumOperations([2, 7, 15, 1, 15]));

//took way too long lol
public class Solution
{
    public int MinimumOperations(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (!seen.Add(nums[i]))
            {
                return i / 3 + 1;
            }
        }
        return 0;
    }
}