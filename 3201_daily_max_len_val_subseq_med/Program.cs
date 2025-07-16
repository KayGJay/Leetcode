Console.WriteLine(new Solution().MaximumLength([1, 2, 1, 1, 2, 1, 2]));

public class Solution
{
    public int MaximumLength(int[] nums)
    {
        int odds = 0, evens = 0, alters = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 1)
            {
                odds++;
            }
            if (nums[i] % 2 == 0)
            {
                evens++;
            }
            if (i != 0 && nums[i] % 2 != nums[i - 1] % 2)
            {
                alters++;
            }
        }
        return Math.Max(Math.Max(odds, evens), alters);
    }
}

//First solution, O(n^2)
//public class Solution
//{
//    public int MaximumLength(int[] nums)
//    {
//        bool foundOdd = false, foundEven = false;
//        int result = 1;
//        for (int i = 0; i < nums.Length; i++)
//        {
//            if (nums[i] % 2 == 1 && !foundOdd)
//            {
//                foundOdd = true;
//                int j = i + 1;
//                int subSeqLength = 1;
//                while (j < nums.Length)
//                {
//                    if (nums[j] % 2 == 1)
//                    {
//                        subSeqLength++;
//                    }
//                    j++;
//                }
//                if (subSeqLength > result)
//                {
//                    result = subSeqLength;
//                }
//                j = i + 1;
//                subSeqLength = 1;
//                while (j < nums.Length)
//                {
//                    if (nums[j - 1] % 2 != nums[j] % 2)
//                    {
//                        subSeqLength++;
//                    }
//                    j++;
//                }
//                if (subSeqLength > result)
//                {
//                    result = subSeqLength;
//                }
//            }
//            else if (nums[i] % 2 == 0 && !foundEven)
//            {
//                foundEven = true;
//                int j = i + 1;
//                int subSeqLength = 1;
//                while (j < nums.Length)
//                {
//                    if (nums[j] % 2 == 0)
//                    {
//                        subSeqLength++;
//                    }
//                    j++;
//                }
//                if (subSeqLength > result)
//                {
//                    result = subSeqLength;
//                }
//                j = i + 1;
//                subSeqLength = 1;
//                while (j < nums.Length)
//                {
//                    if (nums[j - 1] % 2 != nums[j] % 2)
//                    {
//                        subSeqLength++;
//                    }
//                    j++;
//                }
//                if (subSeqLength > result)
//                {
//                    result = subSeqLength;
//                }
//            }
//            if (foundOdd && foundEven)
//            {
//                break;
//            }
//        }
//        return result;
//    }
//}