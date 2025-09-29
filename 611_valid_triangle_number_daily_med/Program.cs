Solution sol = new Solution();

Console.WriteLine(sol.TriangleNumber([4, 2, 3, 4]));

//Console.WriteLine(sol.BinarySearch([2, 3, 4, 4, 4, 4, 4, 4, 4, 4], 0, 6));

public class Solution
{
    public int TriangleNumber(int[] nums)
    {
        Array.Sort(nums);
        int result = 0;
        int i = 0, j = 0, k = 2;
        while (i < nums.Length - 2)
        {
            j = i + 1;
            while (j < nums.Length - 1)
            {
                while (k < nums.Length && nums[i] + nums[j] > nums[k])
                {
                    k++;
                }
                result += k - j - 1;
                j++;
            }
            i++;
        }
        return result;
    }
    //public int TriangleNumber(int[] nums)
    //{
    //    Array.Sort(nums);
    //    int result = 0;
    //    int i = 0, j = 0, k = 0;
    //    while (i < nums.Length - 2)
    //    {
    //        j = i + 1;
    //        while (j < nums.Length - 1)
    //        {
    //            k = j + 1;
    //            while (k < nums.Length && nums[i] + nums[j] > nums[k])
    //            {
    //                result++;
    //                k++;
    //            }
    //            j++;
    //        }
    //        i++;
    //    }
    //    return result;
    //}
    //public int TriangleNumber(int[] nums)
    //{
    //    Array.Sort(nums);
    //    int result = 0;
    //    int i = 0, j = 0, k = 0;
    //    while (i < nums.Length - 2)
    //    {
    //        j = i + 1;
    //        while (j < nums.Length - 1)
    //        {
    //            k = BinarySearch(nums, j, nums[i] + nums[j] - 1);
    //            if (nums[k] < nums[i] + nums[j])
    //                result += k - j;
    //            j++;
    //        }
    //        i++;
    //    }
    //    return result;
    //}
    public int BinarySearch(int[] nums, int start, int find)
    {
        int end = nums.Length - 1;
        int mid = (start + end) / 2;
        //int result = -1;
        while (start != mid)
        {
            if (nums[mid] < find)
            {
                start = mid;
            }
            else if (nums[mid] > find)
            {
                end = mid;
            }
            else
            {
                start = mid;
            }
            mid = (start + end) / 2;
        }
        return nums[mid + 1] <= find ? mid + 1 : mid;
    }
}