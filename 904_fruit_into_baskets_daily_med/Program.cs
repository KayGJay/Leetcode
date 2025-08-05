Console.WriteLine(new Solution().TotalFruit([0, 1, 6, 6, 4, 4, 6]));

public class Solution
{
    public int TotalFruit(int[] fruits)
    {
        int result = 0;
        int[] twoNums = [-1, -1];
        int[] twoNumsCount = [0, 0];
        int left = 0, right = 0;
        while (right < fruits.Length)
        {
            right = left;
            int currFruit = fruits[right];
            twoNums[0] = currFruit;
            while (right < fruits.Length && ((currFruit == twoNums[0] || currFruit == twoNums[1]) || twoNums[1] == -1))
            {
                if (twoNums[0] == -1)
                {
                    twoNums[0] = currFruit;
                }
                else if (twoNums[1] == -1 && currFruit != twoNums[0])
                {
                    twoNums[1] = currFruit;
                    left = right;
                }
                if (currFruit == twoNums[0])
                {
                    twoNumsCount[0]++;
                }
                if (currFruit == twoNums[1])
                {
                    twoNumsCount[1]++;
                }
                right++;
                if (right < fruits.Length)
                {
                    currFruit = fruits[right];
                }
            }
            result = twoNumsCount.Sum() > result ? twoNumsCount.Sum() : result;
            twoNums[1] = -1;
            twoNumsCount = [0, 0];
        }
        return result;
    }
}