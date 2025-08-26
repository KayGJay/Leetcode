public class Solution
{
    public int FindPairs(int[] nums, int k)
    {
        int result = 0;
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int i in nums)
        {
            if (!counts.ContainsKey(i))
                counts[i] = 0;
            counts[i]++;
        }
        foreach (int key in counts.Keys)
        {
            if (k == 0)
            {
                if (counts[key] > 1)
                {
                    result++;
                }
            }
            else
            {
                if (counts.ContainsKey(key + k))
                {
                    if (counts[key + k] != 0)
                    {
                        result++;
                    }
                }
                if (counts.ContainsKey(key - k))
                {
                    if (counts[key - k] != 0)
                    {
                        result++;
                    }
                }
                counts[key] = 0;
            }
        }
        return result;
    }
}