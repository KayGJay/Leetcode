public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int sIdx = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (sIdx == s.Length)
                return true;
            if (t[i] == s[sIdx])
            {
                sIdx++;
            }
        }
        return sIdx == s.Length;
    }
}