//Looooots of help with this one, the two numSubsets calls go through the array and add
//A value for including and a value for skipping

Console.WriteLine(new Solution().CountMaxOrSubsets([3, 2, 1, 5]));

public class Solution
{
    public int count = 0;
    public int CountMaxOrSubsets(int[] nums)
    {
        int maxVal = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            maxVal = maxVal | nums[i];
        }
        numSubSets(0, 0, maxVal, nums);
        return count;
    }

    public void numSubSets(int index, int currValue, int maxValue, int[] nums)
    {
        if (currValue == maxValue)
        {
            count += (int)Math.Pow(2, nums.Length - index);
            return;
        }
        if (index == nums.Length)
        {
            return;
        }
        numSubSets(index + 1, currValue | nums[index], maxValue, nums);
        numSubSets(index + 1, currValue, maxValue, nums);
    }
}