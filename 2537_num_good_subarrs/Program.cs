using System.Security.AccessControl;

Solution sol = new Solution();

Console.WriteLine(sol.CountGood([2, 1, 3, 1, 2, 2, 3, 3, 2, 2, 1, 1, 1, 3, 1], 11));

public class Solution
{
    public long CountGood(int[] nums, int k)
    {
        long numPairs = 0;
        long numSubArrays = 0;
        Dictionary<int, int> numOccur = new Dictionary<int, int>();
        int j = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            while (numPairs < k && j + 1 < nums.Length)
            {
                j++;
                if (!numOccur.ContainsKey(nums[j]))
                {
                    numOccur[nums[j]] = 0;
                }
                numOccur[nums[j]]++;
                numPairs += numOccur[nums[j]] - 1;
            }
            if (numPairs >= k)
            {
                numSubArrays += nums.Length - j;
            }
            numOccur[nums[i]]--;
            numPairs -= numOccur[nums[i]];
        }
        return numSubArrays;
    }
}