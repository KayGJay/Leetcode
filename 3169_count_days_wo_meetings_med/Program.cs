// See https://aka.ms/new-console-template for more information
Console.WriteLine(new Solution().CountDays(57, [[3, 49], [23, 44], [21, 56], [26, 55], [23, 52], [2, 9], [1, 48], [3, 31]]));
public class Solution
{
    public int CountDays(int days, int[][] meetings)
    {
        int result = 0;
        meetings = meetings.OrderBy(x => x[0]).ToArray();
        foreach (var arr in meetings) { Console.WriteLine(arr[0] + ", " + arr[1]); }
        result += meetings[0][0] - 1;
        int prevStart = meetings[0][0];
        int latest = meetings[0][1];
        foreach (var meeting in meetings)
        {
            if (meeting[0] != prevStart)
            {
                result += latest < meeting[0] ? meeting[0] - (latest + 1) : 0;
                latest = Math.Max(latest, meeting[1]);
                prevStart = meeting[0];
            }
            else
            {
                latest = Math.Max(latest, meeting[1]);
            }
        }
        result += days - latest;
        return result;
    }
}