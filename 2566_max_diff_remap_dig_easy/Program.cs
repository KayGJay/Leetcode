using static System.Runtime.InteropServices.JavaScript.JSType;

string numStr = "90";
int changeForMax = 0;
Console.WriteLine("90".Replace('0', '9'));
Console.WriteLine(numStr.Replace(Convert.ToChar(changeForMax), '9'));
Console.WriteLine((char)(0 + '0'));


Console.WriteLine(new Solution().MinMaxDifference(90));

public class Solution
{
    public int MinMaxDifference(int num)
    {
        string numStr = num.ToString();
        int changeForMax = -1, changeForMin = -1;
        for (int i = 0; i < numStr.Length; i++)
        {
            // char 1 --- int '1' - '0' = 1
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
        //(char)(int + '0') = char representation of int
        int max = int.Parse(numStr.Replace((char)(changeForMax + '0'), '9'));
        int min = int.Parse(numStr.Replace((char)(changeForMin + '0'), '0'));
        return max - min;
    }
}