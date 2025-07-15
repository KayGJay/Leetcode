//This is a lot. Binary search? But maybe unnecessary? Try again later

Console.WriteLine(new Solution().MinZeroArray([2, 0, 2], [[0, 2, 1], [0, 2, 1], [1, 1, 3]]));

public class Solution
{
    public int MinZeroArray(int[] nums, int[][] queries)
    {
        int k = 0;
        int max = nums.Max();
        int satisfied = 0;
        if (max == 0)
        {
            return 0;
        }
        int[] idxVals = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                satisfied++;
            }
            idxVals[i] = 0;
        }
        while (k < queries.Length && satisfied < nums.Length)
        {
            for (int i = queries[k][0]; i <= queries[k][1]; i++)
            {
               if (idxVals[i] > 0)
               {
                   idxVals[i] -= queries[k][2];
                   if (idxVals[i] <= 0)
                   {
                       satisfied++;
                   }
               }
            }
            k++;
        }
        return satisfied == nums.Length ? k : -1;
    }
}