//PHEW, optimal!!!

Solution sol = new Solution();

int[] arr = [135745088, 609245787, 16, 2048, 2097152];
foreach (int i in arr) { Console.WriteLine(Convert.ToString(i, 2).PadLeft(30) + " " + i); }

Console.WriteLine();

for (int i = 0; i < arr.Length - 1; i++)
{
    Console.WriteLine($"{arr[i]} & {arr[i + 1]} = {arr[i] & arr[i + 1]}");
}

Console.WriteLine(sol.LongestNiceSubarray(arr));

public class Solution
{
    public int LongestNiceSubarray(int[] nums)
    {
        int i = 0, j = 1;
        int result = 1;
        while (i < nums.Length - 1 && j < nums.Length)
        {
            j = i + 1;
            int curr = i;
            while (i < j && j < nums.Length)
            {
                if ((nums[curr] & nums[j]) == 0)
                {
                    curr++;
                }
                else
                {
                    break;
                }
                if (curr == j)
                {
                    j++;
                    curr = i;
                }
            }
            if (j - i > result)
            {
                result = j - i;
            }
            i++;
        }
        if (j - i > result)
            result = j - --i;
        return result;
    }
}