public class Solution
{
    public int MaxDifference(string s)
    {
        int maxOdd = 0, minOdd = Int32.MaxValue, maxEven = 0, minEven = Int32.MaxValue;
        Dictionary<char, int> occurs = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (!occurs.ContainsKey(c))
            {
                occurs[c] = 0;
            }
            occurs[c]++;
        }
        foreach (var pair in occurs)
        {
            if (pair.Value % 2 == 1)
            {
                maxOdd = Math.Max(maxOdd, pair.Value);
            }
            else
            {
                minEven = Math.Min(minEven, pair.Value);
            }
        }
        return maxOdd - minEven;
    }
}