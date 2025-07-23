foreach (int i in new Solution().LargestDivisibleSubset([1, 2, 4, 8])) { Console.WriteLine(i); }

//Not finished
public class Solution
{
    public IList<int> LargestDivisibleSubset(int[] nums)
    {
        Array.Sort(nums);
        int[] pos = new int[nums.Length];
        Array.Fill(pos, 1);
        int largestEndIdx = 0, currLargest = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] % nums[i - 1] == 0)
            {
                pos[i] += pos[i - 1];
                if (pos[i] > currLargest)
                {
                    currLargest = pos[i];
                    largestEndIdx = i;
                }
            }
        }
        List<int> result = nums.ToList().Skip(largestEndIdx - (currLargest - 1)).Take(currLargest).ToList();
        return result;
    }
}