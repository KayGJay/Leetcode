Solution sol = new Solution();

//Console.WriteLine(sol.MaxFreeTime(99, 1, [7, 21, 25], [13, 25, 78]));
Console.WriteLine(sol.MaxFreeTime(5, 1, [1, 3], [2, 5]));

public class Solution
{
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
    {
        int maxGap = 0, tempGap = 0;
        for (int i = 0; i <= startTime.Length; i++)
        {
            int lastEnd = i == 0 ? 0 : endTime[i - 1];
            int nextAdd = i != startTime.Length ? startTime[i] - lastEnd : eventTime - endTime[endTime.Length - 1];
            tempGap += nextAdd;
            if (i > k)
            {
                if (i == k + 1)
                {
                    tempGap -= startTime[0];
                }
                else
                {
                    tempGap -= startTime[i - (k + 1)] - endTime[i - (k + 1) - 1];
                }
            }
            maxGap = Math.Max(maxGap, tempGap);
        }
        return maxGap;
    }
}