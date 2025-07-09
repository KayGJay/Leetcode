//omg this sucked

Solution sol = new Solution();

bool[] test = sol.Sieve(4);

for (int i = 0; i < test.Length; i++)
{
    if (test[i])
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine();

foreach (var list in sol.FindPrimePairs(6)) foreach (var num in list) { Console.WriteLine(num); }

public class Solution
{
    public IList<IList<int>> FindPrimePairs(int n)
    {
        if (n < 4)
            return [];
        bool[] primes = Sieve(n - 2);
        IList<IList<int>> result = [];
        int i = 2;
        while (i <= n / 2)
        {
            if (primes[i] && primes[n - i])
            {
                result.Add([i, n - i]);
            }
            i++;
        }
        return result;
    }
    public bool[] Sieve(int n)
    {
        bool[] primes = new bool[n + 1];
        Array.Fill(primes, true);
        primes[0] = false;
        primes[1] = false;
        for (int i = 2; i * i <= n; i++)
        {
            for (int j = i * i; j <= n; j += i)
            {
                primes[j] = false;
            }
        }
        return primes;
    }
}