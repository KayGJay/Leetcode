Solution sol = new Solution();

//Console.WriteLine(sol.LCM(252, 15));

//int a = 899, b = 23;

//Console.WriteLine($"GCD({a},{b}): {sol.GCD(a, b)}, LCM: {sol.LCM(a, b)}");

foreach (int i in sol.ReplaceNonCoprimes([12, 3, 2, 7, 6, 2])) Console.WriteLine(i);

public class Solution
{
    public int LCM(int a, int b)
    {
        long product = (long)a * (long)b;

        return (int)(product / GCD(a, b));
    }
    public int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public IList<int> ReplaceNonCoprimes(int[] nums)
    {
        Stack<int> merge = new Stack<int>();
        List<int> result = new List<int>();
        int lengthChange = -1;
        while (lengthChange != 0)
        {
            merge.Push(nums[nums.Length - 1]);
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (GCD(merge.Peek(), nums[i]) > 1)
                {
                    merge.Push(LCM(merge.Pop(), nums[i]));
                }
                else
                {
                    merge.Push(nums[i]);
                }
            }
            int nextNum = merge.Pop();
            while (merge.Count > 0)
            {
                if (GCD(nextNum, merge.Peek()) > 1)
                {
                    nextNum = LCM(nextNum, merge.Pop());
                }
                else
                {
                    result.Add(nextNum);
                    merge.TryPop(out nextNum);
                }
            }
            result.Add(nextNum);
            lengthChange = result.Count - nums.Length;
            nums = result.ToArray();
            if (lengthChange != 0)
                result.Clear();
        }
        return result;
    }
}