Console.WriteLine(new Solution().NonSpecialCount(5, 7));
public class Solution
{
    public int NonSpecialCount(int l, int r)
    {
        int result = 0;
        HashSet<int> sieve = Sieve(r);
        for (int i = l; i <= r; i++)
        {
            double sqrt = Math.Sqrt(i);
            if (sqrt != (int)sqrt || !sieve.Contains((int)sqrt))
                result++;
        }
        return result;
    }
    public HashSet<int> Sieve(int num)
    {
        Dictionary<int, bool> primes = new Dictionary<int, bool>();
        primes[2] = true;
        for (int i = 3; i < num; i++)
        {
            primes[i] = true;
        }
        int start = 2;
        int curNum = start;
        while (start <= num / 2)
        {
            while (curNum <= num)
            {
                curNum += start;
                primes[curNum] = false;
            }
            start++;
            curNum = start;
        }
        int[] result = primes.Where(x => x.Value == true).Select(x => x.Key).ToArray();
        return result.ToHashSet<int>();
    }
}