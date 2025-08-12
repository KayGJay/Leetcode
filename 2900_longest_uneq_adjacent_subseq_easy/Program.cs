public class Solution
{
    public IList<string> GetLongestSubsequence(string[] words, int[] groups)
    {
        List<string> result = new List<string>();
        result.Add(words[0]);
        int lastNum = groups[0];
        for (int i = 1; i < groups.Length; i++)
        {
            if (groups[i] != lastNum)
            {
                lastNum = groups[i];
                result.Add(words[i]);
            }
        }
        return result;
    }
}