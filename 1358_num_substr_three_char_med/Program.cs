Console.WriteLine(new Solution().NumberOfSubstrings("abc"));

//Not exactly optimal but optimal is also O(n)
public class Solution
{
    public int NumberOfSubstrings(string s)
    {
        Dictionary<char, int> lets = new Dictionary<char, int>() { { 'a', 0 }, { 'b', 0 }, { 'c', 0 } };
        int left = 0, right = 0, result = 0;
        while (left < s.Length && right < s.Length)
        {
            lets[s[right]]++;
            while (left < s.Length && lets['a'] > 0 && lets['b'] > 0 && lets['c'] > 0)
            {
                result += s.Length - right;
                lets[s[left]]--;
                left++;
            }
            right++;
        }
        return result;
    }
}