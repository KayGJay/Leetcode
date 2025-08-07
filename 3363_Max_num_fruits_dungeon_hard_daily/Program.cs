Console.WriteLine(new Solution().MaxCollectedFruits([[1, 2, 3, 4], [5, 6, 8, 7], [9, 10, 11, 12], [13, 14, 15, 16]]));

public class Solution
{
    public int MaxCollectedFruits(int[][] fruits)
    {
        int result = 0;
        int len = fruits.Length;
        int i = 0, j = 0, i2 = len - 1, j2 = 0;
        for (; i < fruits.Length && j < fruits.Length; i++, j++)
        {
            result += fruits[i][j];
            fruits[i][j] = 0;
        }
        i = 0;
        j = len - 1;
        while (i < fruits.Length - 1)
        {
            if (i == i2 && j == j2 && i != len - 1 && j != len - 1)
            {
                if (fruits[i][j + 1] > fruits[i2 - 1][j])
                {
                    j++;
                }
                else
                {
                    i2--;
                }
            }

            result += fruits[i][j] + fruits[i2][j2];
            fruits[i][j] = 0;
            fruits[i2][j2] = 0;

            //update child 2
            if (i == len - 2)
            {
                i = len - 1;
                j = len - 1;
            }
            else if (j == len - 1)
            {
                if (fruits[i + 1][j] >= fruits[i + 1][j - 1])
                {
                    i++;
                }
                else
                {
                    i++;
                    j--;
                }
            }
            else
            {
                if (fruits[i + 1][j + 1] > fruits[i + 1][j])
                {
                    i++;
                    j++;
                }
                else
                {
                    i++;
                }
            }

            //update child 3
            if (j2 == len - 1)
            {
                i2 = len - 1;
                j2 = len - 1;
            }
            else if (i2 == len - 1)
            {
                if (fruits[i2][j2 + 1] > fruits[i2 - 1][j2 + 1])
                {
                    j2++;
                }
                else
                {
                    i2--;
                    j2++;
                }
            }
            else
            {
                if (fruits[i2 + 1][j2 + 1] > fruits[i2][j2 + 1])
                {
                    i2++;
                    j2++;
                }
                else
                {
                    j2++;
                }
            }
        }
        return result;
    }
}