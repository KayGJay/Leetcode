public class Solution
{
    public int[] FindEvenNumbers(int[] digits)
    {
        Dictionary<int, int> digitFreq = new Dictionary<int,int>
                                         {
                                          {1, 0}, {2, 0}, {3, 0},
                                          {4, 0}, {5, 0}, {6, 0},
                                          {7, 0}, {8, 0}, {9, 0},
                                          {0, 0}
                                         };
        int[] validNums = new int[450];
        List<int> result = new List<int>();
        for (int i = 0; i < validNums.Length; i++)
        {
            validNums[i] = 100 + 2 * i;
        }
        foreach (int i in digits)
        {
            digitFreq[i]++;
        }
        foreach (int i in validNums)
        {
            string strNum = i.ToString();
            bool found = true;
            foreach (char c in strNum)
            {
                if (!(strNum.Count(x => x == c) <= digitFreq[int.Parse(c.ToString())]))
                {
                    found = false;
                }
            }
            if (found)
                result.Add(i);
        }
        return result.ToArray();
    }
}