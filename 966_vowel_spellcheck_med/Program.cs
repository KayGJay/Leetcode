foreach (var s in new Solution().Spellchecker(["KiTe", "kite", "hare", "Hare"], ["kite", "Kite", "KiTe", "Hare", "HARE", "Hear", "hear", "keti", "keet", "keto"])) Console.WriteLine(s);

public class Solution
{
    public bool MatchExceptVowels(string key, string word)
    {
        if (key.Length != word.Length) return false;
        string vowels = "AEIOUaeiou";
        for (int i = 0; i < word.Length; i++)
        {
            if (!vowels.Contains(word[i]) && !vowels.Contains(key[i]))
            {
                if (word[i].ToString().ToLower() != key[i].ToString().ToLower())
                {
                    return false;
                }
            }
        }
        return true;
    }
    public string[] Spellchecker(string[] wordlist, string[] queries)
    {
        HashSet<string> words = new HashSet<string>(wordlist);
        List<string> result = new List<string>();
        foreach (string s in queries)
        {
            bool added = false;
            foreach (var key in words)
            {
                if (s == key)
                {
                    result.Add(key);
                    added = true;
                    break;
                }
            }
            if (!added)
            {
                foreach (var key in words)
                {
                    if (s.ToLower() == key)
                    {
                        result.Add(key);
                        added = true;
                        break;
                    }
                }
            }
            if (!added)
            {
                foreach (var key in words)
                {
                    if (MatchExceptVowels(key, s))
                    {
                        result.Add(key);
                        added = true;
                        break;
                    }
                }
            }
            if (!added)
            {
                result.Add("");
            }
        }
        return result.ToArray();
    }
}