foreach (int num in new Solution().GrayCode(2)) Console.WriteLine(num);

public class Solution
{
    public IList<int> GrayCode(int n)
    {
        if (n == 1)
        {
            return new List<int>() { 0, 1 };
        }
        else
        {
            List<int> result = new List<int>();
            List<int> prev = GrayCode(n - 1).ToList();
            foreach (int num in prev)
            {
                Console.WriteLine(num);
                result.Add(num);
            }
            prev.Reverse();
            foreach (int num in prev)
            {
                Console.WriteLine(num);
                result.Add(num + (int)Math.Pow(2, n - 1));
            }
            return result;
        }
    }
}