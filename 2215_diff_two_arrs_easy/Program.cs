new Solution().FindDifference([-68, -80, -19, -94, 82, 21, -43], [-63]);

public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        IList<IList<int>> result = [[], []];
        int n1 = nums1.Length, n2 = nums2.Length;
        int n = Math.Max(n1, n2);
        Dictionary<int, int> occurs = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            if (i < n1 && occurs.ContainsKey(nums1[i]))
            {
                if (occurs[nums1[i]] == 2)
                {
                    occurs[nums1[i]] = 3;
                }
            }
            else if (i < n1)
            {
                occurs[nums1[i]] = 1;
            }
            if (i < n2 && occurs.ContainsKey(nums2[i]))
            {
                if (occurs[nums2[i]] == 1)
                {
                    occurs[nums2[i]] = 3;
                }
            }
            else if (i < n2)
            {
                occurs[nums2[i]] = 2;
            }
        }
        foreach (var pair in occurs)
        {
            if (pair.Value == 1)
            {
                result[0].Add(pair.Key);
            }
            else if (pair.Value == 2)
            {
                result[1].Add(pair.Key);
            }
        }
        return result;
    }
}