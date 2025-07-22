Solution sol = new Solution();

string[] strArr = sol.DivideString("ctoyjrwtngqwt", 8, 'x');
foreach (string str in strArr) { Console.WriteLine(str); }

public class Solution
{
    public string[] DivideString(string s, int k, char fill)
    {
        string[] result = s.Length % k == 0 ? new string[s.Length / k] : new string[s.Length / k + 1];
        for (int i = 0; i < s.Length; i += k)
        {
            if (i + (k - 1) >= s.Length)
            {
                result[i / k] = s.Substring(i, s.Length - i).PadRight(k, fill);
            }
            else
            { 
                result[i / k] = s.Substring(i, k);
            }       
        }
        return result;
    }
}