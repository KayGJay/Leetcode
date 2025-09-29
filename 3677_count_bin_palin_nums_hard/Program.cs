//Getting there, I thing the palindrome function just needs optimized (would comparing
//prefix and suffix of binary rep in a different way work?)

public class Solution
{
    public int CountBinaryPalindromes(long n)
    {
        int addPow = 0;
        int result = 1;
        int recentPow = (int)Math.Log2(n);
        for (int i = 1; Math.Pow(2, i - 1) < Math.Pow(2, recentPow); i++)
        {
            result += (int)Math.Pow(2, addPow);
            if (i % 2 == 0)
                addPow++;
        }
        for (int i = (int)Math.Pow(2, recentPow); i <= n; i++)
        {
            if (i % 2 != 0)
            {
                if (IsPalindrome(i))
                    result++;
            }
        }
        return result;
    }
    public bool IsPalindrome(long num)
    {
        string numString = Convert.ToString(num, 2);
        for (int i = 0, j = numString.Length - 1; i < j; i++, j--)
        {
            if (numString[i] != numString[j])
            {
                return false;
            }
        }
        return true;
    }
}