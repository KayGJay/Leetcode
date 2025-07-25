string[] test = ["dd", "aa", "bb", "dd", "aa", "dd", "bb", "dd", "aa", "cc", "bb", "cc", "dd", "cc"];
Console.WriteLine(new Solution().LongestPalindrome(test));

public class Solution
{
    public int LongestPalindrome(string[] words)
    {
        Dictionary<string, int> occurs = new Dictionary<string, int>();
        int result = 0;
        foreach (string s in words)
        {
            if (!occurs.ContainsKey(s))
            {
                occurs[s] = 0;
                occurs[$"{s[1]}{s[0]}"] = 0;
            }
            occurs[s]++;
        }
        foreach (var pair in occurs) { Console.WriteLine(pair.Key + " " + pair.Value); }
        bool middleFound = false;
        foreach (var key in occurs.Keys)
        {
            if (key[0] == key[1])
            {
                if (occurs[key] % 2 == 1 && !middleFound)
                {
                    result += 2;
                    middleFound = true;
                }
                result += (occurs[key] - occurs[key] % 2) * 2;
            }
            else
            {
                result += 2 * Math.Min(occurs[key], occurs[$"{key[1]}{key[0]}"]);
            }
        }
        return result;
    }
}