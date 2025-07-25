Console.WriteLine(new Solution().CountSubarrays([2, 1, 4, 3, 5], 10));

//Unfinished. Can easily find first subarray, but haven't yet figured out how do find the ones beyond that without counting the ones
//I already found
public class Solution
{
    public long CountSubarrays(int[] nums, long k)
    {
        long[] sumArray = new long[nums.Length];
        sumArray[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            sumArray[i] = sumArray[i - 1] + nums[i];
        }
        foreach (int i in sumArray) { Console.WriteLine(i); }
        int l = 0, r = 0;
        long result = 0;
        while (l < sumArray.Length && r < sumArray.Length)
        {
            long earlyNum = l == 0 ? 0 : sumArray[l - 1];
            while (r < sumArray.Length && (sumArray[r] - earlyNum) * (r - l + 1) < k)
            {
                Console.WriteLine("(sumArray[r] - sumArray[l]) * (r - l + 1)");
                Console.WriteLine($"({sumArray[r]} - {sumArray[l]}) * ({r} - {l} + 1)");
                Console.WriteLine();
                r++;
            }
            result += ((r - l + 1) * (r - l + 1 + 1) / 2);
        }
        return result;
    }
}