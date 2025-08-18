foreach (var arr in new Solution().Merge([[1, 4], [4, 5]])) Console.WriteLine(arr[0] + ", " + arr[1]);

public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        intervals = intervals.OrderBy(x => x[0]).ToArray();
        List<List<int>> result = new List<List<int>>();
        int start = intervals[0][0];
        int end = intervals[0][1];
        foreach (var arr in intervals)
        {
            if (arr[0] <= end)
            {
                end = Math.Max(arr[1], end);
            }
            else
            {
                result.Add([start, end]);
                start = arr[0];
                end = arr[1];
            }
        }
        result.Add([start, end]);
        int[][] resultArr = new int[result.Count][];
        for (int i = 0; i < result.Count; i++)
        {
            resultArr[i] = result[i].ToArray();
        }
        return resultArr;
    }
}