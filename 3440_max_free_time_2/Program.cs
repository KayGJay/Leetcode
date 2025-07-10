using System.Xml;

Solution sol = new Solution();

Console.WriteLine(sol.MaxFreeTime(10, [0, 3, 7, 9], [1, 4, 8, 10]));

public class Solution
{
    //This one works but gets TLE for large test cases
    public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime)
    {
        int[] gaps = new int[startTime.Length + 1];
        int[] combGaps = new int[startTime.Length];
        gaps[0] = startTime[0];
        for (int i = 1; i < startTime.Length; i++)
        {
            gaps[i] = startTime[i] - endTime[i - 1];
            combGaps[i - 1] = gaps[i - 1] + gaps[i];
        }
        gaps[gaps.Length - 1] = eventTime - endTime[endTime.Length - 1];
        combGaps[combGaps.Length - 1] = gaps[gaps.Length - 2] + gaps[gaps.Length - 1];
        foreach (int i in gaps) { Console.WriteLine(i); }
        Console.WriteLine();
        foreach (int i in combGaps) { Console.WriteLine(i); }
        Console.WriteLine();

        int maxGap = 0;
        for (int i = 0; i < startTime.Length; i++)
        {
            int ithDuration = endTime[i] - startTime[i];
            if (combGaps[i] + ithDuration > maxGap && (gaps.Take(i).Any(x => x >= ithDuration) || gaps.Skip(i + 2).Any(x => x >= ithDuration)))
            {
                maxGap = combGaps[i] + ithDuration;
            }
            else if (combGaps[i] > maxGap)
            {
                maxGap = combGaps[i];
            }
        }
        return maxGap;
    }
    
    //Given solution, involves traversing the array from both sides and using a bool
    //array to mark whether meetings can be moved to a different time slot rather than sliding

    //public int MaxFreeTime2(int eventTime, int[] startTime, int[] endTime)
    //{
    //    int n = startTime.Length;
    //    bool[] q = new bool[n];
    //    int t1 = 0, t2 = 0;
    //    for (int i = 0; i < n; i++)
    //    {
    //        if (endTime[i] - startTime[i] <= t1)
    //        {
    //            q[i] = true;
    //        }
    //        t1 = Math.Max(t1, startTime[i] - (i == 0 ? 0 : endTime[i - 1]));

    //        if (endTime[n - i - 1] - startTime[n - i - 1] <= t2)
    //        {
    //            q[n - i - 1] = true;
    //        }
    //        t2 = Math.Max(t2, (i == 0 ? eventTime : startTime[n - i]) -
    //                              endTime[n - i - 1]);
    //    }

    //    int res = 0;
    //    for (int i = 0; i < n; i++)
    //    {
    //        int left = i == 0 ? 0 : endTime[i - 1];
    //        int right = i == n - 1 ? eventTime : startTime[i + 1];
    //        if (q[i])
    //        {
    //            res = Math.Max(res, right - left);
    //        }
    //        else
    //        {
    //            res = Math.Max(res, right - left - (endTime[i] - startTime[i]));
    //        }
    //    }
    //    return res;
    //}
}