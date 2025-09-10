//Think I get the idea but the implementation and indexing etc is a complete nightmare and this doesn't work yet

public class Solution
{
    public int MinimumTeachings(int n, int[][] languages, int[][] friendships)
    {
        Dictionary<int, int> numTaught = new Dictionary<int, int>();
        Dictionary<int, int> numKnow = new Dictionary<int, int>();
        HashSet<int>[] knownBy = new HashSet<int>[languages.Length + 1];

        for (int i = 1; i <= languages.Length; i++)
        {
            knownBy[i] = new HashSet<int>();
        }

        for (int i = 1; i <= n; i++)
        {
            numTaught[i] = 0;
            numKnow[i] = 0;
        }

        foreach (var arr in friendships)
        {
            foreach (int user in arr)
            {
                if (knownBy[user].Count() == 0)
                {
                    foreach (int lang in languages[user - 1])
                    {
                        knownBy[user].Add(lang);
                        numKnow[lang]++;
                    }
                }
            }
            foreach (var key in numTaught.Keys)
            {
                if (knownBy[arr[0]].Contains(key) != knownBy[arr[1]].Contains(key))
                {
                    numTaught[key]++;
                    knownBy[arr[0]].Add(key);
                    knownBy[arr[1]].Add(key);
                }
            }
        }

        foreach (var key in numKnow.Keys) Console.WriteLine($"Known: {numKnow[key]}, Taught: {numTaught[key]}");

        int result = Int32.MaxValue;
        for (int i = 1; i <= n; i++)
        {
            if (numKnow[i] + numTaught[i] == languages.Length)
            {
                result = Math.Min(result, numTaught[i]);
            }
        }
        return result == Int32.MaxValue ? 0 : result;
    }
}