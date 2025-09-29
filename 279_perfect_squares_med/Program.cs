Console.WriteLine(new Solution().NumSquares(12));

public class Solution
{
    public int NumSquares(int n)
    {
        int[] numNeeded = new int[n + 1];
        Array.Fill(numNeeded, Int32.MaxValue);
        for (int i = 1; i <= n; i++)
        {
            if (Math.Sqrt(i) % 1 == 0)
            {
                numNeeded[i] = 1;
            }
            else
            {
                for (int j = i - 1; j >= 1; j--)
                {
                    if (Math.Sqrt(j) % 1 == 0)
                    {
                        numNeeded[i] = Math.Min(numNeeded[i], 1 + numNeeded[i - j]);
                    }
                }
            }
        }
        for (int i = 0; i <= n; i++) Console.WriteLine(i + ": " + numNeeded[i]);
        return numNeeded[n];
    }
}