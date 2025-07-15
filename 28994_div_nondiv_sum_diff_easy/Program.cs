Console.WriteLine(new Solution().DifferenceOfSums(10, 3));

public class Solution
{
    public int DifferenceOfSums(int n, int m)
    {
        int sum = (int)((double)n / 2 * (1 + n));
        int i = n;
        int num2 = 0;
        while (i > 0)
        {
            if (i % m == 0)
            {
                num2 += i;
                i -= m;
            }
            else
            {
                i--;
            }
        }
        int num1 = sum - num2;
        return num1 - num2;
    }
}

//simple, less optimal
//public class Solution
//{
//    public int DifferenceOfSums(int n, int m)
//    {
//        int num1 = 0, num2 = 0, i = 1;
//        while (i <= n)
//        {
//            if (i % m == 0)
//            {
//                num2 += i;
//            }
//            else
//            {
//                num1 += i;
//            }
//            i++;
//        }
//        return num1 - num2;
//    }
//}

//Given solution from mathematical derivation
//public class Solution
//{
//    public int DifferenceOfSums(int n, int m)
//    {
//        int k = n / m;
//        return n * (n + 1) / 2 - k * (k + 1) * m;
//    }
//}