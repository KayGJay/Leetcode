Console.WriteLine(new Solution().SmallestEquivalentString("leetcode", "programs", "sourcecode"));

public class Solution
{
    public string SmallestEquivalentString(string s1, string s2, string baseStr)
    {
        Dictionary<char, char> parent = new Dictionary<char, char>();
        for (int i = 0; i < s1.Length; i++)
        {
            char parChar = s1[i] < s2[i] ? s1[i] : s2[i];
            if (parent.ContainsKey(parChar))
            {
                if (parent.ContainsKey(s1[i]))
                {
                    parent[parent[s1[i]]] = parent[parChar];
                }
                if (parent.ContainsKey(s2[i]))
                {
                    parent[parent[s2[i]]] = parent[parChar];
                }
                parent[s1[i]] = parent[parChar];
                parent[s2[i]] = parent[parChar];
            }
            else
            {
                parent[parChar] = parChar;
                if (parent.ContainsKey(s1[i]))
                {
                    parent[parent[s1[i]]] = parent[parChar];
                }
                if (parent.ContainsKey(s2[i]))
                {
                    parent[parent[s2[i]]] = parent[parChar];
                }
                parent[s1[i]] = parChar;
                parent[s2[i]] = parChar;
            }
        }
        foreach (var pair in parent) Console.WriteLine(pair.Key + ": " + pair.Value);
        string result = "";
        foreach (char ch in baseStr)
        {
            result += parent.ContainsKey(ch) ? parent[ch] : ch;
        }
        return result;
    }
}