Console.WriteLine(new Solution().CountFairPairs([0, 1, 7, 4, 4, 5], 3, 6));
//0, 1, 4, 4, 5, 7

//TLE
//public class Solution
//{
//    public long CountFairPairs(int[] nums, int lower, int upper)
//    {
//        Array.Sort(nums);
//        int i = 0;
//        int j = nums.Length - 1;
//        int result = 0;
//        while (i < nums.Length - 1)
//        {
//            while (i != j)
//            {
//                if (nums[i] + nums[j] <= upper && nums[i] + nums[j] >= lower)
//                    result++;
//                j--;
//            }
//            i++;
//            j = nums.Length - 1;
//        }
//        return result;
//    }
//}

//Finish later, didn't realize initially that index i must be < index j
public class Solution
{
    public long CountFairPairs(int[] nums, int lower, int upper)
    {
        
    }
}