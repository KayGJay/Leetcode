//foreach (int num in new Solution().SuccessfulPairs([5, 1, 3], [1, 2, 3, 4, 5], 7)) Console.WriteLine(num);

//Console.WriteLine(new Solution().BinarySearch([1, 2, 3, 4, 6], 0, 1));

using System.Globalization;

int[] test = [25, 19, 30, 37, 14, 30, 38, 22, 38, 38, 26, 33, 34, 23, 40, 28, 15, 29, 36, 39, 39, 37, 32, 38, 8, 17, 39, 20, 4, 39, 39, 7, 30, 35, 29, 23];
Array.Sort(test);
for(int i = 0; i < test.Length; i++)
{
    Console.WriteLine(i + ": " + test[i]);
}
Console.WriteLine(new Solution().BinarySearch(test, 0, 2));
class Solution
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions);
        List<int> result = new List<int>();
        int j = 0;
        for (int i = 0; i < spells.Length; i++)
        {
            decimal neededVal = Math.Ceiling((decimal)success / spells[i]);
            j = BinarySearch(potions, 0, (int)neededVal);
            if (j != -1)
            {
                result.Add(potions.Length - j);
            }
            else
            {
                result.Add(0);
            }
        }
        return result.ToArray();
    }
    public int BinarySearch(int[] nums, int start, int find)
    {
        int end = nums.Length - 1;
        int mid = (start + end) / 2;
        while (end - start > 1)
        {
            if (nums[mid] < find)
            {
                start = mid;
                mid = (start + end) / 2;
            }
            else if (nums[mid] > find)
            {
                end = mid;
                mid = (start + end) / 2;
            }
            else
            {
                end = mid;
                mid = (start + end) / 2;
            }
        }
        return nums[end] >= find ? end : -1;
    }
}