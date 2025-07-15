public class Solution
{
    public bool IsValid(string word)
    {
        string vowels = "aeiouAEIOU";
        bool vowel = false, consonant = false;
        if (word.Length < 3)
        {
            return false;
        }
        else if (!word.All(x => char.IsLetterOrDigit(x)))
        {
            return false;
        }
        else
        {
            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    if (vowels.Contains(c))
                    {
                        vowel = true;
                    }
                    else
                    {
                        consonant = true;
                    }
                }
                if (vowel && consonant)
                {
                    break;
                }
            }
        }
        return vowel && consonant;
    }
}