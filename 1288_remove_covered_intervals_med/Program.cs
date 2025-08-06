Console.WriteLine(new Solution().RemoveCoveredIntervals([[1, 4], [4, 7], [3, 6]]));

public class Solution
{
    public int RemoveCoveredIntervals(int[][] intervals)
    {
        HashSet<int> exists = new HashSet<int>();
        int result = 0;
        intervals = intervals.OrderBy(x => x[0]).ThenBy(x => -x[1]).ToArray();
        foreach (var pair in intervals)
        {
            if (exists.Contains(pair[0]) && exists.Contains(pair[1] - 1))
            {
                result++;
            }
            else
            {
                int idx = pair[0];
                while (idx < pair[1])
                {
                    exists.Add(idx);
                    idx++;
                }
            }
        }
        foreach (var elem in exists) Console.WriteLine(elem);
        Console.WriteLine();
        return intervals.Length - result;
    }
}