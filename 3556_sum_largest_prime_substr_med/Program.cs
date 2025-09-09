foreach (int i in new Solution().Sieve(100)) Console.WriteLine(i);

Console.WriteLine();

Console.WriteLine(new Solution().SumOfLargestPrimes("12234"));

public class Solution
{
    public bool IsPrime(int n)
    {
        for (int i = 0; i < Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    public long SumOfLargestPrimes(string s)
    {
        Prime = Sieve(int.Parse(s));
        int[] resultArr = new int[3];
        int i = 0, idx = 0;
        while (i < Prime.Length && idx < 3)
        {
            if (s.Contains(Prime[i].ToString()))
            {
                resultArr[idx++] = Prime[i];
            }
            i++;
        }
        long result = resultArr.Sum();
        return result;
    }
}