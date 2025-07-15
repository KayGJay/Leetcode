Console.WriteLine(new Solution().NumberOfAlternatingGroups([0, 1, 0, 1], 3));

public class Solution
{
    public int NumberOfAlternatingGroups(int[] colors, int k)
    {
        int i = 0;
        int start = 0;
        int numAlter = 1;
        while (colors[i % colors.Length] != colors[(i + 1) % colors.Length] && numAlter <= colors.Length)
        {
            numAlter++;
            i++;
        }
        start = i % colors.Length;
        if (start % colors.Length == 0 && numAlter >= k)
        {
            return numAlter - 1;
        }
        int end = start;
        start = (start + 1) % colors.Length;
        numAlter = 1;
        int result = 0;
        while (start % colors.Length != end)
        {
            if (colors[start % colors.Length] != colors[(start + 1) % colors.Length])
            {
                numAlter++;
            }
            else
            {
                numAlter = 1;
            }
            if (numAlter >= k)
            {
                result++;
            }
            start++;
        }
        return result;
    }
}