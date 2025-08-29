//UGGGGGGGGGGGGGGGGGGGGGGGGGGHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH

foreach (int i in new Solution().FindOriginalArray([1, 3, 4, 2, 6, 8])) Console.WriteLine(i + " ");

public class Solution
{
    public int[] FindOriginalArray(int[] changed)
    {
        if (changed.Length <= 1) return [];
        Dictionary<int, int> counts = new Dictionary<int, int>();
        int n = changed.Length;
        int[] result = new int[n / 2];
        int resultIdx = 0;
        for (int i = 0; i < n; i++)
        {
            if (!counts.ContainsKey(changed[i]))
            {
                counts[changed[i]] = 0;
            }
            counts[changed[i]]++;
            if (changed[i] % 2 == 1)
            {
                result[resultIdx++] = changed[i];
                changed[i] = -1;
            }
        }
        int doubles = 0;
        //foreach (var pair in counts) { Console.WriteLine(pair.Key + ": " + pair.Value); }
        foreach (var pair in counts)
        {
            if (pair.Key != 0)
            {
                if (counts.ContainsKey(pair.Key * 2))
                {
                    if (counts[pair.Key * 2] >= pair.Value)
                        doubles++;
                }
            }
            else
            {
                if (pair.Value > 1)
                {
                    doubles += pair.Value / 2;
                }
            }
            if (doubles == n / 2) break;
        }
        if (doubles < n / 2) return [];
        for (int i = 0; i < n; i++)
        {
            if (changed[i] != -1)
            {
                if (!counts.ContainsKey(changed[i] / 2))
                {
                    result[resultIdx++] = changed[i];
                }
                else if (counts[changed[i]] > counts[changed[i] / 2])
                {
                    counts[changed[i]]--;
                    result[resultIdx++] = changed[i];
                }
            }
            if (resultIdx == result.Length) break;
        }
        return result;
    }
}