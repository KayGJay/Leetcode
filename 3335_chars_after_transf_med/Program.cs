Console.WriteLine(new Solution().LengthAfterTransformations("abcyy", 2));

public class Solution
{
    private const int MOD = 1000000007;
    public int LengthAfterTransformations(string s, int t)
    {
        int[] chars = new int[26];
        foreach (char c in s)
        {
            chars[c - 'a']++;
        }
        //foreach (var pair in chars) { Console.WriteLine(pair.Key + ": " + pair.Value); }
        //Console.WriteLine();
        int changes = 0;
        while (changes < t)
        {
            int[] newArr = new int[26];
            newArr[0] = chars[25];
            newArr[1] = (chars[0] + chars[25]) % MOD;
            for (int i = 2; i < 26; i++)
            {
                newArr[i] = chars[i - 1];
            }
            //foreach (var pair in chars) { if (pair.Value != 0) Console.WriteLine(pair.Key + ": " + pair.Value); }
            chars = newArr;
            changes++;
        }
        int result = 0;
        foreach (int i in chars)
        {
            result = (result + i) % MOD;
        }
        return result;
    }
}