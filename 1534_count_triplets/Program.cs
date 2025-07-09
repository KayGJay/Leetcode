Solution sol = new Solution();

Console.WriteLine(sol.CountGoodTriplets([3, 0, 1, 1, 9, 7], 7, 2, 3));

public class Solution
{
    public int CountGoodTriplets(int[] arr, int a, int b, int c)
    {
        int result = 0;
        int i = 0;
        while (i < arr.Length - 2)
        {
            int j = i + 1;
            while (j < arr.Length - 1)
            {
                int k = j + 1;
                while (k < arr.Length)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= a
                        && Math.Abs(arr[j] - arr[k]) <= b
                        && Math.Abs(arr[i] - arr[k]) <= c
                        )
                    {
                        result++;
                    }
                    k++;
                }
                j++;
            }
            i++;
        }
        return result;
    }
}