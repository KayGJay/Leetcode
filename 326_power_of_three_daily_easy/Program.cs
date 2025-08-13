// Alternate solution, return 1162261467 % n, largest power of 3 that fits in 32 bit int

public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        if (n % 3 != 0)
        {
            return n == 1;
        }
        while (n > 1)
        {
            if (n % 3 != 0)
            {
                return false;
            }
            n /= 3;
        }
        return n == 1;
    }
}