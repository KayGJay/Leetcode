using System.Text;

public class Solution
{
    public string MakeFancyString(string s)
    {
        StringBuilder result = new StringBuilder("");
        int reps = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i == 0 || s[i] == s[i - 1])
            {
                reps++;
            }
            else
            {
                reps = 1;
            }
            if (reps < 3)
            {
                result.Append(s[i]);
            }
        }
        return result.ToString();
    }
}