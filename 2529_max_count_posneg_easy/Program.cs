using System;

Console.WriteLine(new Solution().MaximumCount([-2, -1, -1, 0, 0, 0]));

//Not quiet, the above test case fails. Seems like I might need to implement my own binary search for this
public class Solution
{
    public int MaximumCount(int[] nums)
    {
        if (nums[0] == 0 && nums[nums.Length - 1] == 0) { return 0; }
        int negs = Array.BinarySearch(nums, 0);
        if (negs < 0)
        {
            negs++;
            negs *= -1;
        }
        int pos = negs;
        while (pos < nums.Length && nums[pos] < 1)
        {
            pos++;
        }
        Console.WriteLine(negs + " " + (nums.Length - pos));
        return Math.Max(negs, (nums.Length - pos));
    }
}

//public class Solution
//{
//    public int MaximumCount(int[] nums)
//    {
//        int negs = nums.BinarySearch(0);
//        int pos = 0;
//        for (int i = 0; i < nums.Length; i++)
//        {
//            if (nums[i] < 0)
//            {
//                negs++;
//            }
//            else if (nums[i] == 0)
//            {
//                pos--;
//            }
//            else
//            {
//                break;
//            }
//        }
//        return Math.Max(negs, pos + (nums.Length - negs));
//    }
//}