public class Solution
{
    public int MinMaxDifference(int num)
    {
        string numStr = num.ToString();
        int changeForMax = -1, changeForMin = -1;
        for (int i = 0; i < numStr.Length; i++)
        {
            Console.WriteLine($"numStr[i] = {numStr[i]}, numStr[i] - '0' = {numStr[i] - '0'}");
            if (numStr[i] - '0' != 9 && changeForMax == -1)
            {
                changeForMax = numStr[i] - '0';
            }
            if (numStr[i] - '0' != 0 && changeForMin == -1)
            {
                changeForMin = numStr[i] - '0';
            }
            if (changeForMax != -1 && changeForMin != -1) break;
        }
        int max = int.Parse(numStr.Replace((char)(changeForMax + '0'), '9'));
        int min = int.Parse(numStr.Replace((char)(changeForMin + '0'), '0'));
        return max - min;
    }
}