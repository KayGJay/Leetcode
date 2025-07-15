//Matrix mult, create transformation matrix
// [1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0]
new Solution().LengthAfterTransformations("abcyy", 2, [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2]);

public class Solution
{
    public int LengthAfterTransformations(string s, int t, IList<int> nums)
    {
        int[] chars = new int[26];
        foreach (char c in s)
        {
            chars[c - 'a']++;
        }
        Console.Write("[");
        foreach (int i in chars) { Console.Write(i + ", "); }
        Console.WriteLine();
        return 0;
    }
}