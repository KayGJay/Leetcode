Console.WriteLine(new Solution().Candy([1, 6, 10, 8, 7, 3, 2]));

public class Solution
{
    public int Candy(int[] ratings)
    {
        int[] numCandies = new int[ratings.Length];
        Array.Fill(numCandies, 1);
        int result = 0;
        for (int i = 0; i < ratings.Length; i++)
        {
            int leftNeigh = i == 0 ? 0 : i - 1;
            int rightNeigh = i == ratings.Length - 1 ? ratings.Length - 1 : i + 1;
            if (ratings[i] > ratings[leftNeigh] && numCandies[i] <= numCandies[leftNeigh])
            {
                numCandies[i] = numCandies[leftNeigh] + 1;
            }
            if (ratings[i] > ratings[rightNeigh] && numCandies[i] <= numCandies[rightNeigh])
            {
                numCandies[i] = numCandies[rightNeigh] + 1;
            }
        }
        for (int i = ratings.Length - 1; i >= 0; i--)
        {
            int leftNeigh = i == 0 ? 0 : i - 1;
            int rightNeigh = i == ratings.Length - 1 ? ratings.Length - 1 : i + 1;
            if (ratings[i] > ratings[rightNeigh] && numCandies[i] <= numCandies[rightNeigh])
            {
                numCandies[i] = numCandies[rightNeigh] + 1;
            }
            if (ratings[i] > ratings[leftNeigh] && numCandies[i] <= numCandies[leftNeigh])
            {
                numCandies[i] = numCandies[leftNeigh] + 1;
            }
            result += numCandies[i];
        }
        return result;
    }
}