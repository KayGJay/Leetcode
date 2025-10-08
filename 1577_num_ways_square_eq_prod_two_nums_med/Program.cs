new Solution().StringMatching(["blue", "green", "bu"]);

public class Solution
{
    public IList<string> StringMatching(string[] words)
    {
        List<string> result = new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            for (int j = 0; j < words.Length; j++)
            {
                if (j != i && words[j].Contains(word))
                {
                    result.Add(word);
                    break;
                }
            }
        }
        return result;
    }
}