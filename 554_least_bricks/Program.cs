Solution sol = new Solution();

Console.WriteLine(sol.LeastBricks([[1, 2, 2, 1], [3, 1, 2], [1, 3, 2], [2, 4], [3, 1, 2], [1, 3, 1, 1]]));

public class Solution
{
    public int LeastBricks(IList<IList<int>> wall)
    {
        if (wall.Count == 1) return 0;
        bool allOne = true;
        Dictionary<int, int> sums = new Dictionary<int, int>();
        for (int i = 0; i < wall.Count; i++)
        {
            int sum = 0;
            if (i > 0)
            {
                if (allOne && wall[i].Count != 1)
                {
                    allOne = false;
                }
            }
            for (int j = 0; j < wall[i].Count - 1; j++)
            {
                sum += wall[i][j];
                if (!sums.ContainsKey(sum))
                {
                    sums[sum] = 0;
                } 
                sums[sum]++;
            }
        }
        if (allOne)
        {
            return wall.Count();
        }
        int maxVal = sums.Values.Max();
        return wall.Count - maxVal;
    }
}