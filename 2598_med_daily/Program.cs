Console.WriteLine(new Solution().FindSmallestInteger([1, -10, 7, 13, 6, 8], 7));

public class Solution
{
    private int SmallestNonNeg(int n, int k)
    {
        if (n < 0)
            return (n % k + k) % k;
        else
            return n % k;
    }
    public int FindSmallestInteger(int[] nums, int value)
    {
        Dictionary<int, int> found = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (num >= 0)
            { 
                if (!found.ContainsKey(num))
                    found[num] = 0; 
                found[num]++;
            }
            else
            {
                int smallest = SmallestNonNeg(num, value);
                if (!found.ContainsKey(smallest))
                    found[smallest] = 0;
                found[smallest]++;
            }
        }
        int result = 0;
        bool stop = false;
        while (!stop)
        {
            stop = true;
            if (!found.ContainsKey(result))
            {
                foreach (var pair in found)
                {
                    if ([pair.Value > 1 && pair.Key % value == 0 && Math.Abs(result - pair.Key) <= value)
                    {
                        stop = false;
                        found[pair.Key]--;
                        break;
                    }
                }
                if (!stop)
                    found[result] = 1;
            }
        }
    }
}