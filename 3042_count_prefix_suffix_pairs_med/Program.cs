Console.WriteLine(new Solution().CountPrefixSuffixPairs(["a", "aba", "ababa", "aa"]));

public class Solution
{
    private bool IsPrefixAndSuffix(string toMatch, string toCheck)
    {
        int len = toMatch.Length;
        if (toCheck.Length < len)
            return false;
        Console.WriteLine(toCheck.Substring(0, len) + " & " + toCheck.Substring(toCheck.Length - len, len) + " checked against " + toMatch);
        if (toCheck.Substring(0, len) == toMatch && toCheck.Substring(toCheck.Length - len, len) == toMatch)
            return true;
        return false;
    }
    public int CountPrefixSuffixPairs(string[] words)
    {
        int result = 0;
        for (int i = 0; i < words.Length; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                if (IsPrefixAndSuffix(words[i], words[j]) || IsPrefixAndSuffix(words[j], words[i]))
                    result++;
            }
        }
        return result;
    }
}