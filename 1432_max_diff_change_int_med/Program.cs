//Not done yet, have to handle most sig dig being 9

Console.WriteLine(new Solution().MaxDiff(9288));

public class Solution
{
    public int MaxDiff(int num)
    {
        string numStr = num.ToString();
        char minChar = numStr[0];
        if (numStr.Length == 1)
            return 8;
        if (numStr[0] == '1')
        {
            int i = 0;
            while (i < numStr.Length - 1 && numStr[i] == '1')
            {
                i++;
            }
            minChar = numStr[i];
        }
        int max = int.Parse(numStr.Replace(numStr[0], '9'));
        int min = minChar == '1' && minChar == numStr[0] ? int.Parse(numStr) : minChar != numStr[0] ? int.Parse(numStr.Replace(minChar, '0')) : int.Parse(numStr.Replace(minChar, '1'));
        return max - min;
    }
}