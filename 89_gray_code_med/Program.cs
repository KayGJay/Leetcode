foreach (int num in new Solution().GrayCode(4)) Console.WriteLine(num);

Console.WriteLine(1 >> 1);
Console.WriteLine(1 << 1);
public class Solution
{
    //public IList<int> GrayCode(int n)
    //{
    //    if (n == 1)
    //    {
    //        return new List<int>() { 0, 1 };
    //    }
    //    else
    //    {
    //        List<int> result = new List<int>();
    //        List<int> prev = GrayCode(n - 1).ToList();
    //        foreach (int num in prev)
    //        {
    //            Console.WriteLine(num);
    //            result.Add(num);
    //        }
    //        prev.Reverse();
    //        foreach (int num in prev)
    //        {
    //            Console.WriteLine(num);
    //            result.Add(num + (int)Math.Pow(2, n - 1));
    //        }
    //        return result;
    //    }
    //}
    public IList<int> GrayCode(int n)
    {
        int size = 1 << n;
        List<int> result = new List<int>();
        for (int i = 0; i < size; i++)
        {
            result.Add(i ^ (i >> 1));
        }
        return result;
    }
}