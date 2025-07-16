Console.WriteLine(new Solution().FindDifferentBinaryString(["01", "10"]));

//"Cantor's diagonal argument"
public class Solution
{
    public string FindDifferentBinaryString(string[] nums)
    {
        string result = "";
        for (int i = 0; i <  nums.Length; i++)
        {
            result += nums[i][i] == 0 ? 1 : 0;
        }
        return result;
    }
}

//O(nlogn), not mentioned in editorial. Suboptimal, other solution is O(n)
//public class Solution
//{
//    public string FindDifferentBinaryString(string[] nums)
//    {
//        Array.Sort(nums);
//        for (int i = 1; i < nums.Length; i++)
//        {
//            if (Convert.ToInt32(nums[i], 2) - Convert.ToInt32(nums[i - 1], 2) != 1)
//            {
//                string binary = Convert.ToString(Convert.ToInt32(nums[i - 1]) + 1, 2);
//                return binary.PadLeft(nums[0].Length, '0');
//            }
//        }
//        if (nums[nums.Length - 1].Any(x => x == '0'))
//        {
//            string binary = "";
//            for (int i = 0; i < nums[0].Length; i++)
//            {
//                binary += "1";
//            }
//            return binary;
//        }
//        else
//        {
//            string binary = "";
//            for (int i = 0; i < nums[0].Length; i++)
//            {
//                binary += "0";
//            }
//            return binary;
//        }
//    }
//}