//NOT FINISHED, hate this

Console.WriteLine(new Solution().ClearStars("de*"));

public class Solution
{
    public string ClearStars(string s)
    {
        PriorityQueue<char, int> letters = new PriorityQueue<char, int>();
        char[] result = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != '*')
            {
                letters.Enqueue(s[i], -i);
                result[i] = s[i];
            }
            else
            {
                result[i] = ' ';
                letters.TryDequeue(out char _, out int priority);
                result[-priority] = ' ';
            }
        }
        return String.Join("", result).Replace(" ", "");
    }
}