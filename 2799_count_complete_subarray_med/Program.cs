Console.WriteLine(new Solution().CountCompleteSubarrays([459, 459, 962, 1579, 1435, 756, 1872, 1597]));

public class Solution
{
    public int CountCompleteSubarrays(int[] nums)
    {
        int distinct = nums.Distinct().Count();
        int result = 0;
        Dictionary<int, int> numOccurs = new Dictionary<int, int>();
        int i = 0, j = 0;
        while (j < nums.Length)
        {
            if (!numOccurs.ContainsKey(nums[j]))
            {
                numOccurs[nums[j]] = 0;
            }
            numOccurs[nums[j]]++;
            while (numOccurs.Count == distinct && i <= j && i < nums.Length)
            {
                result += nums.Length - j;
                numOccurs[nums[i]]--;
                if (numOccurs[nums[i]] == 0)
                {
                    numOccurs.Remove(nums[i]);
                }
                i++;
            }
            j++;
        }
        return result;
    }
}