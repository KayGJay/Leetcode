new Solution().MinimumDifference([7, 9, 5, 8, 1, 3]);

public class Solution
{
    public long MinimumDifference(int[] nums)
    {
        int n = nums.Length / 3;
        int[] sums = new int[nums.Length];
        int[] maxSum = new int[nums.Length];
        int[] minSum = new int[nums.Length];
        PriorityQueue<int, int> minNums = new PriorityQueue<int, int>();
        PriorityQueue<int, int> maxNums = new PriorityQueue<int, int>();
        for (int i = 0; i < n * 2; i++)
        {
            if (minNums.Count == n || maxNums.Count == n)
            {
                minNums.TryPeek(out _, out int minFront);
                maxNums.TryPeek(out _, out int maxFront);
                if (-minFront > nums[i])
                {
                    minNums.Dequeue();
                    minNums.Enqueue(i, -nums[i]);
                }
                if (maxFront < nums[nums.Length - 1 - i])
                {
                    maxNums.Dequeue();
                    maxNums.Enqueue(nums.Length - 1 - i, nums[nums.Length - 1 - i]);
                }
                minSum[i] = minSum[i - 1] + nums[i];
                maxSum[nums.Length - 1 - i] = nums[nums.Length - 1 - i] + maxSum[nums.Length - i];
            }
            else
            {
                minNums.Enqueue(i, -nums[i]);
                maxNums.Enqueue(nums.Length - 1 - i, nums[nums.Length - 1 - i]);
                minSum[i] = i == 0 ? nums[i] : nums[i] + minSum[i - 1];
                maxSum[nums.Length - 1 - i] = i == 0 ? nums[nums.Length - 1 - i] : nums[nums.Length - 1 - i] + maxSum[nums.Length - i];
            }
        }
        while (minNums.Count > 0) { Console.WriteLine(minNums.Peek() + ": " + nums[minNums.Dequeue()]); }
        Console.WriteLine();
        while (maxNums.Count > 0) { Console.Write(maxNums.Peek()); Console.WriteLine(": " + nums[maxNums.Dequeue()]); }
        Console.WriteLine();
        foreach (int i in minSum) { Console.WriteLine(i); }
        Console.WriteLine();
        foreach (int i in maxSum) { Console.WriteLine(i); }

        return 0;
    }
}