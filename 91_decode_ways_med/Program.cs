Console.WriteLine(new Solution().NumDecodings("120121"));

public class Solution
{
    public int NumDecodings(string s)
    {
        if (s[0] == '0') return 0;
        if (s.Length >= 2 && s[s.Length - 1] == '0' && (s[s.Length - 2] != '1' && s[s.Length - 2] != '2')) return 0;
        string secondDigOne = "0123456789";
        string secondDigTwo = "0123456";
        int[] dp = new int[s.Length + 1];
        dp[dp.Length - 1] = 1;
        dp[dp.Length - 2] = 1;
        for (int i = s.Length - 2; i >= 0; i--)
        {
            if (s[i] == '0')
            {
                if((s[i - 1] != '2' && s[i - 1] != '1'))
                {
                    return 0;
                }
                else
                {
                    dp[i] = dp[i + 1];
                }
            }
            else
            {
                if ((s[i] == '1' && secondDigOne.Contains(s[i + 1]) || (s[i] == '2' && secondDigTwo.Contains(s[i + 1]))))
                {
                    dp[i] = dp[i + 1] + dp[i + 2];
                }
                else
                {
                    dp[i] = dp[i + 1];
                }
            }
        }
        return dp[0];
    }
}