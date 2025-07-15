public class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        HashSet<int> needOps = new HashSet<int>();
        foreach (int i in nums)
        {
            if (i < k)
            {
                return -1;
            }
            else if (i > k)
            {
                needOps.Add(i);
            }
        }
        return needOps.Count;
    }
}