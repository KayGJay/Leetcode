//Started and going ok but I'm braindead atm

public class Solution
{
    public int MinDominoRotations(int[] tops, int[] bottoms)
    {
        int minSwaps = Int32.MaxValue;
        for (int i = 0; i <= 6; i++)
        {
            bool poss = true;
            int currSwaps = 0;
            for (int j = 0; j < tops.Length; j++)
            {
                if (tops[j] != i)
                {
                    if (bottoms[j] == i)
                    {
                        currSwaps++;
                    }
                    else
                    {
                        poss = false;
                        break;
                    }
                }
                if (poss)
                {
                    minSwaps = Math.Min(minSwaps, currSwaps);
                }
            }
        }
        return minSwaps == Int32.MaxValue ? -1 : minSwaps;
    }
}