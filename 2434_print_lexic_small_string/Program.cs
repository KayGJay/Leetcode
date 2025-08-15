Console.WriteLine(new Solution().RobotWithString("bac"));

public class Solution
{
    public string RobotWithString(string s)
    {
        Dictionary<char, int> occurs = new Dictionary<char, int>();
        string t = "", result = "";
        char minChar = 'z';
        foreach (char c in s)
        {
            if (!occurs.ContainsKey(c))
            {
                occurs[c] = 0;
            }
            occurs[c]++;
        }
        minChar = occurs.Keys.Min();
        if (s[0] == minChar)
        {
            result += minChar;
        }
        else
        {
            t += s[0];
        }
        occurs[s[0]]--;
        s = s.Substring(1, s.Length - 1);
        if (occurs[s[0]] == 0)
            occurs.Remove(s[0]);
        while (s != "" || t != "")
        {
            if (s == "")
            {
                result += t[t.Length - 1];
                t = t.Substring(0, t.Length - 1);
            }
            else if (s[0] == minChar)
            {
                result += s[0];
                occurs[s[0]]--;
                if (occurs[s[0]] == 0)
                    occurs.Remove(s[0]);
                if (occurs.Count() != 0)
                    minChar = occurs.Keys.Min();
                s = s.Substring(1, s.Length - 1);
            }
            else
            {
                t += s[0];
                occurs[s[0]]--;
                if (occurs[s[0]] == 0)
                    occurs.Remove(s[0]);
                s = s.Substring(1, s.Length - 1);
            }
        }
        return result;
    }
}