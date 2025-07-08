// NOT FINISHED, SUPER HARD, STUDY

int[][] arr = [[1, 1, 1], [2, 2, 2], [3, 3, 3], [4, 4, 4]];

Solution sol = new Solution();

Console.WriteLine(sol.MaxValue(arr, 2));
public class Solution
{
    public Dictionary<int, int> idxValues = new Dictionary<int, int>();
    public int MaxValue(int[][] events, int k)
    {
        events = events.OrderBy(x => x[0]).ToArray();
        foreach (var arr in events) foreach (int i in arr) { Console.WriteLine(i); }
        for (int i = 0; i < events.Length; i++)
        {
            idxValues[i] = IdxValue(events, k, i);
        }
        foreach (var pair in idxValues) { Console.WriteLine(pair.Key + ": " + pair.Value); }
        return idxValues.Values.Max();
    }

    public int IdxValue(int[][] events, int k, int idx)
    {   
        if (idxValues.ContainsKey(idx))
        {
            return idxValues[idx];
        }
        if (k == 0) return 0;
        if (k == 1)
        {
            idxValues[idx] = events[idx][2];
            return idxValues[idx];
        }
        
        int nextIdx = Array.FindIndex(events, x => x[0] == events[idx][1] + 1);
        int bestValue = 0;
        if (nextIdx == -1)
        {
            nextIdx = events.Length;
        }
        if (nextIdx < 0)
        {
            nextIdx = nextIdx * -1 - 1;
        }
        int bestChoice = nextIdx;
        while (nextIdx < events.Length)
        {
            if (bestChoice == nextIdx)
            {
                bestValue = IdxValue(events, k, bestChoice);
            }
            else if (IdxValue(events, k - 1, nextIdx) > IdxValue(events, k - 1, bestChoice))
            {
                bestChoice = nextIdx;
                bestValue = IdxValue(events, k - 1, bestChoice);
            }
            nextIdx++;
        }

        idxValues[idx] = events[idx][2] + bestValue;
        return idxValues[idx];
    }
}